using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace TimeTrialStats
{
    public partial class MainForm : Form
    {
        Discord discord;
        Memory memory;
        GameVersion version = new GameVersion();

        StatsViewerForm statsViewerForm = new StatsViewerForm();

        Stats sessionStats = new Stats();
        Stats bestStats = new Stats();
        Stats averageStats = new Stats();
        Stats totalStats = new Stats();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Title
            System.Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Text = $"Time Trial Stats {version.Major}.{version.Minor}.{version.Build}";

            // Loop to see if the game isn't running
            // User has to manually click on Retry once game has started
            while (Utils.IsMirrorsEdgeRunning() == false)
            {
                DialogResult dialog = MessageBox.Show("I had problems finding the Mirror's Edge proccess...", "MirrorsEdge.exe not found!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Cancel)
                {
                    Environment.Exit(0);
                }
            }

            GetGameVersion();

            // Add offsets to database
            Offset offset = new Offset();
            offset.Add();

            // Initilize memory and discord
            memory = new Memory();
            discord = new Discord();

            // Start memory function. It's there just incase user opens this program when finished a run
            memory.Startup();
            BGWorker.RunWorkerAsync();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Clear discord status
            discord.Cleanup();
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Sleep for 0.1 seconds
            Thread.Sleep(100);

            // Check if Mirror's Edge is running
            if (Utils.IsMirrorsEdgeRunning() == true)
            { 
                // If Mirror's Edge is still running, continue
                BGWorker.ReportProgress(0);
            }
            else
            {
                // Clear discord status
                discord.Cleanup();

                while (true)
                {
                    // Ask user if they want to save their stats
                    DialogResult dialog = MessageBox.Show("It seems that you have closed Mirror's Edge or the game crashed. Would you like to save your stats?", "Save run data?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialog == DialogResult.Yes)
                    {
                        statsViewerForm.ShowDialog();
                    }
                    else
                    {
                        break;
                    }
                }
                
                Environment.Exit(0);
            }
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Updates addresses, reads memory, and checks the checkpoint and if we finished
            // More details in Memory.cs
            memory.UpdateMemory();
            memory.ReadMemory();
            memory.CheckMemory();

            // Clears the text if StretchId is 0
            if (memory.StretchId == 0)
            {
                ClearAllText();
            }

            // Checks if we have stats for current map, if so, get stats and update texts
            if (memory.StatsExistsForStretchId())
            {
                sessionStats = memory.GetCurrentStats();
                bestStats = memory.GetBestStats();
                averageStats = memory.GetAverageStats();
                totalStats = memory.GetTotalStats();

                UpdateAllText();
            }

            // Discord stuff
            if (discordStatus.Checked == true)
            {
                discord.Update(memory.StretchId != 0 ? totalStats.Runs : 0);
            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void DiscordStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (discordStatus.Checked == true)
            {
                discord.Update(memory.StretchId != 0 ? totalStats.Runs : 0);
            }
            else
            {
                discord.Clear();
            }
        }

        private void FormatStats_CheckedChanged(object sender, EventArgs e)
        {
            statsViewerForm.formatStats = formatStats.Checked;
        }

        private void StatsViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statsViewerForm.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void UpdateAllText()
        {
            // Gets the current map from the StretchId
            discord.mapName = Utils.GetTimeTrialNameById(memory.StretchId);

            // Update checkpoint text for current and total
            current_checkpoint.Text = sessionStats.CheckpointsPassed.ToString();
            current_timedCheckpoint.Text = sessionStats.TimerCheckpointsPassed.ToString();
            current_totalCheckpoints.Text = sessionStats.TotalCheckpoints.ToString();

            total_runs.Text = totalStats.Runs.ToString();
            total_checkpoints.Text = totalStats.CheckpointsPassed.ToString();
            total_timedCheckpoints.Text = totalStats.TimerCheckpointsPassed.ToString();

            // Check if user wants it formatted or not
            if (formatStats.Checked == true)
            {
                current_time.Text = Utils.FormatTime(sessionStats.Time);
                current_avgSpeed.Text = string.Format("{0:0.00} km/h", sessionStats.AvgSpeed);
                current_distance.Text = string.Format("{0:0} m", sessionStats.Distance);

                best_time.Text = Utils.FormatTime(bestStats.Time);
                best_avgSpeed.Text = string.Format("{0:0.00} km/h", bestStats.AvgSpeed);
                best_distance.Text = string.Format("{0:0} m", bestStats.Distance);

                average_time.Text = Utils.FormatTime(averageStats.Time);
                average_speed.Text = string.Format("{0:0.00} km/h", float.IsNaN(averageStats.AvgSpeed) == true ? 0 : averageStats.AvgSpeed);
                average_distance.Text = string.Format("{0:0} m", float.IsNaN(averageStats.Distance) == true ? 0 : averageStats.Distance);

                total_time.Text = Utils.FormatTime(totalStats.Time);
                total_distance.Text = string.Format("{0:0} m", totalStats.Distance);
            }
            else
            {
                current_time.Text = sessionStats.Time.ToString();
                current_avgSpeed.Text = sessionStats.AvgSpeed.ToString();
                current_distance.Text = sessionStats.Distance.ToString();

                best_time.Text = bestStats.Time.ToString();
                best_avgSpeed.Text = bestStats.AvgSpeed.ToString();
                best_distance.Text = bestStats.Distance.ToString();

                average_time.Text = float.IsNaN(averageStats.Time) == true ? "0" : averageStats.Time.ToString();
                average_speed.Text = float.IsNaN(averageStats.AvgSpeed) == true ? "0" : averageStats.AvgSpeed.ToString();
                average_distance.Text = float.IsNaN(averageStats.Distance) == true ? "0" : averageStats.Distance.ToString();

                total_time.Text = totalStats.Time.ToString();
                total_distance.Text = totalStats.Distance.ToString();
            }
        }

        private void ClearAllText()
        {
            discord.mapName = "n/a";

            current_checkpoint.Text = "0";
            current_timedCheckpoint.Text = "0";
            current_totalCheckpoints.Text = "0";

            total_runs.Text = "0";
            total_checkpoints.Text = "0";
            total_timedCheckpoints.Text = "0";

            if (formatStats.Checked == true)
            {
                current_time.Text = "00:00.000";
                current_avgSpeed.Text = "0.00 km/h";
                current_distance.Text = "0 m";

                best_time.Text = "00:00.000";
                best_avgSpeed.Text = "0.00 km/h";
                best_distance.Text = "0 m";

                average_time.Text = "00:00.000";
                average_speed.Text = "0.00 km/h";
                average_distance.Text = "0 m";

                total_time.Text = "00:00.000";
                total_distance.Text = "0 m";
            }
            else
            {
                current_time.Text = "0";
                current_avgSpeed.Text = "0";
                current_distance.Text = "0";

                best_time.Text = "0";
                best_avgSpeed.Text = "0";
                best_distance.Text = "0";

                average_time.Text = "0";
                average_speed.Text = "0";
                average_distance.Text = "0";

                total_time.Text = "0";
                total_distance.Text = "0";
            }
        }

        private void GetGameVersion()
        {
            bool supportedVersion = false;

            List<Version> supportedVersions = new List<Version>
            {
                Version.Steam,
                Version.GoG,
                Version.Origin,
                Version.Reloaded,
                Version.Dvd
            };

            while (true)
            {
                version.DetectGameVersion();

                // Loop through all supported versions and see if they use one of it
                for (int i = 0; i < supportedVersions.Count(); i++)
                {
                    if (GameVersion.Current == supportedVersions[i])
                    {
                        // User uses a supported version :D
                        supportedVersion = true;
                    }
                }

                if (supportedVersion == false)
                {
                    // Display a message box telling user that it doesn't support their game version
                    string message = $"This program doesn't support your game version. It only supports Steam, GoG, Origin, Reloaded, and Dvd version.\n\nVersion: {GameVersion.Current}\nMemorySize: {GameVersion.MemorySize}";
                    DialogResult dialogResult = MessageBox.Show(message, "Unsupported Version Detected!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                    // Exit the program
                    if (dialogResult == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
