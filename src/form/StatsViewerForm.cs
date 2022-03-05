using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TimeTrialStats
{
    public partial class StatsViewerForm : Form
    {
        public bool formatStats = true;

        List<Stats> stats = new List<Stats>();
        List<RunData> runs = new List<RunData>();

        public StatsViewerForm()
        {
            InitializeComponent();
        }

        private void StatsViewerForm_Load(object sender, EventArgs e)
        {
            RunStatsViewer.Rows.Clear();
            PopulateRunStatsViewer();
        }

        private void PopulateRunStatsViewer()
        {
            stats = Memory.sessionStats;

            // Check so the total runs is not 0
            if (stats.Count() == 0)
            {
                return;
            }

            // Remove data with values of all 0's
            for (int i = 0; i < stats.Count(); i++)
            {
                if (stats[i].Time == 0f && stats[i].AvgSpeed == 0f && stats[i].Distance == 0f)
                {
                    stats.RemoveAt(i);
                }
            }

            // Check again after removing data
            if (stats.Count() == 0)
            {
                return;
            }

            // Resize "Distance" 
            if (stats.Count() > 12)
            {
                RunStatsViewer.Columns[4].Width = 92;
            }

            string id;
            string map;
            string time;
            string avgSpeed;
            string distance;

            for (int i = 0; i < stats.Count(); i++)
            {
                id = (i + 1).ToString();
                map = Utils.GetTimeTrialNameById(stats[i].StretchId);

                if (formatStats == true)
                {
                    time = Utils.FormatTime(stats[i].Time);
                    avgSpeed = string.Format("{0:0.00} km/h", stats[i].AvgSpeed);
                    distance = string.Format("{0:0} m", stats[i].Distance);
                }
                else
                {
                    time = stats[i].Time.ToString();
                    avgSpeed = stats[i].AvgSpeed.ToString();
                    distance = stats[i].Distance.ToString();
                }

                runs.Add(new RunData()
                {
                    MapName = map,
                    Time = stats[i].Time,
                    AvgSpeed = stats[i].AvgSpeed,
                    Distance = stats[i].Distance
                });

                RunStatsViewer.Rows.Add(new string[] { id, map, time, avgSpeed, distance });
            }

            SaveRun.Enabled = true;
            RunStatsViewer.ClearSelection();
        }

        private void SaveRun_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Save Runs Data",
                Filter = "Json|*.json",
                CheckPathExists = true,
                FileName = "run"
            };

            saveFile.ShowDialog();

            if (saveFile.FileName != "")
            {
                // Serialize 
                string json = JsonConvert.SerializeObject(runs, Formatting.Indented);

                // Write to file
                File.WriteAllText(saveFile.FileName, json);
            }
        }
    }
}
