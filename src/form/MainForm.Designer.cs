
namespace TimeTrialStats
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.current_distance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.current_avgSpeed = new System.Windows.Forms.Label();
            this.current_time = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.current_totalCheckpoints = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.current_timedCheckpoint = new System.Windows.Forms.Label();
            this.current_checkpoint = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.total_distance = new System.Windows.Forms.Label();
            this.average_speed = new System.Windows.Forms.Label();
            this.total_time = new System.Windows.Forms.Label();
            this.total_checkpoints = new System.Windows.Forms.Label();
            this.average_time = new System.Windows.Forms.Label();
            this.average_distance = new System.Windows.Forms.Label();
            this.total_runs = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.total_timedCheckpoints = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.discordStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.formatStats = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StatsViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.best_time = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.best_avgSpeed = new System.Windows.Forms.Label();
            this.best_distance = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.current_distance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.current_avgSpeed);
            this.groupBox1.Controls.Add(this.current_time);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.current_totalCheckpoints);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.current_timedCheckpoint);
            this.groupBox1.Controls.Add(this.current_checkpoint);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current";
            // 
            // current_distance
            // 
            this.current_distance.AutoSize = true;
            this.current_distance.Location = new System.Drawing.Point(135, 132);
            this.current_distance.Name = "current_distance";
            this.current_distance.Size = new System.Drawing.Size(30, 17);
            this.current_distance.TabIndex = 14;
            this.current_distance.Text = "0 m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Distance";
            // 
            // current_avgSpeed
            // 
            this.current_avgSpeed.AutoSize = true;
            this.current_avgSpeed.Location = new System.Drawing.Point(135, 111);
            this.current_avgSpeed.Name = "current_avgSpeed";
            this.current_avgSpeed.Size = new System.Drawing.Size(65, 17);
            this.current_avgSpeed.TabIndex = 12;
            this.current_avgSpeed.Text = "0.00 km/h";
            // 
            // current_time
            // 
            this.current_time.AutoSize = true;
            this.current_time.Location = new System.Drawing.Point(135, 90);
            this.current_time.Name = "current_time";
            this.current_time.Size = new System.Drawing.Size(56, 17);
            this.current_time.TabIndex = 11;
            this.current_time.Text = "00:00.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Time";
            // 
            // current_totalCheckpoints
            // 
            this.current_totalCheckpoints.AutoSize = true;
            this.current_totalCheckpoints.Location = new System.Drawing.Point(135, 63);
            this.current_totalCheckpoints.Name = "current_totalCheckpoints";
            this.current_totalCheckpoints.Size = new System.Drawing.Size(15, 17);
            this.current_totalCheckpoints.TabIndex = 9;
            this.current_totalCheckpoints.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total Checkpoints";
            // 
            // current_timedCheckpoint
            // 
            this.current_timedCheckpoint.AutoSize = true;
            this.current_timedCheckpoint.Location = new System.Drawing.Point(135, 42);
            this.current_timedCheckpoint.Name = "current_timedCheckpoint";
            this.current_timedCheckpoint.Size = new System.Drawing.Size(15, 17);
            this.current_timedCheckpoint.TabIndex = 7;
            this.current_timedCheckpoint.Text = "0";
            // 
            // current_checkpoint
            // 
            this.current_checkpoint.AutoSize = true;
            this.current_checkpoint.Location = new System.Drawing.Point(135, 21);
            this.current_checkpoint.Name = "current_checkpoint";
            this.current_checkpoint.Size = new System.Drawing.Size(15, 17);
            this.current_checkpoint.TabIndex = 6;
            this.current_checkpoint.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Avg Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Timed Checkpoint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Checkpoint";
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // total_distance
            // 
            this.total_distance.AutoSize = true;
            this.total_distance.Location = new System.Drawing.Point(135, 111);
            this.total_distance.Name = "total_distance";
            this.total_distance.Size = new System.Drawing.Size(30, 17);
            this.total_distance.TabIndex = 17;
            this.total_distance.Text = "0 m";
            // 
            // average_speed
            // 
            this.average_speed.AutoSize = true;
            this.average_speed.Location = new System.Drawing.Point(135, 42);
            this.average_speed.Name = "average_speed";
            this.average_speed.Size = new System.Drawing.Size(65, 17);
            this.average_speed.TabIndex = 16;
            this.average_speed.Text = "0.00 km/h";
            // 
            // total_time
            // 
            this.total_time.AutoSize = true;
            this.total_time.Location = new System.Drawing.Point(135, 90);
            this.total_time.Name = "total_time";
            this.total_time.Size = new System.Drawing.Size(56, 17);
            this.total_time.TabIndex = 15;
            this.total_time.Text = "00:00.00";
            // 
            // total_checkpoints
            // 
            this.total_checkpoints.AutoSize = true;
            this.total_checkpoints.Location = new System.Drawing.Point(135, 42);
            this.total_checkpoints.Name = "total_checkpoints";
            this.total_checkpoints.Size = new System.Drawing.Size(15, 17);
            this.total_checkpoints.TabIndex = 15;
            this.total_checkpoints.Text = "0";
            // 
            // average_time
            // 
            this.average_time.AutoSize = true;
            this.average_time.Location = new System.Drawing.Point(135, 21);
            this.average_time.Name = "average_time";
            this.average_time.Size = new System.Drawing.Size(56, 17);
            this.average_time.TabIndex = 18;
            this.average_time.Text = "00:00.00";
            // 
            // average_distance
            // 
            this.average_distance.AutoSize = true;
            this.average_distance.Location = new System.Drawing.Point(135, 63);
            this.average_distance.Name = "average_distance";
            this.average_distance.Size = new System.Drawing.Size(30, 17);
            this.average_distance.TabIndex = 19;
            this.average_distance.Text = "0 m";
            // 
            // total_runs
            // 
            this.total_runs.AutoSize = true;
            this.total_runs.Location = new System.Drawing.Point(135, 21);
            this.total_runs.Name = "total_runs";
            this.total_runs.Size = new System.Drawing.Size(15, 17);
            this.total_runs.TabIndex = 20;
            this.total_runs.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.average_time);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.average_speed);
            this.groupBox2.Controls.Add(this.average_distance);
            this.groupBox2.Location = new System.Drawing.Point(283, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 90);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Average";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Distance";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Avg Speed";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.total_timedCheckpoints);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.total_distance);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.total_time);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.total_runs);
            this.groupBox3.Controls.Add(this.total_checkpoints);
            this.groupBox3.Location = new System.Drawing.Point(283, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 138);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "Timed Checkpoints";
            // 
            // total_timedCheckpoints
            // 
            this.total_timedCheckpoints.AutoSize = true;
            this.total_timedCheckpoints.Location = new System.Drawing.Point(135, 63);
            this.total_timedCheckpoints.Name = "total_timedCheckpoints";
            this.total_timedCheckpoints.Size = new System.Drawing.Size(15, 17);
            this.total_timedCheckpoints.TabIndex = 22;
            this.total_timedCheckpoints.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Distance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Runs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Checkpoints";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discordStatus,
            this.formatStats,
            this.toolStripSeparator1,
            this.StatsViewer,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 104);
            // 
            // discordStatus
            // 
            this.discordStatus.CheckOnClick = true;
            this.discordStatus.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordStatus.Name = "discordStatus";
            this.discordStatus.Size = new System.Drawing.Size(159, 22);
            this.discordStatus.Text = "Discord Status";
            this.discordStatus.CheckedChanged += new System.EventHandler(this.DiscordStatus_CheckedChanged);
            // 
            // formatStats
            // 
            this.formatStats.Checked = true;
            this.formatStats.CheckOnClick = true;
            this.formatStats.CheckState = System.Windows.Forms.CheckState.Checked;
            this.formatStats.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatStats.Name = "formatStats";
            this.formatStats.Size = new System.Drawing.Size(159, 22);
            this.formatStats.Text = "Format Stats";
            this.formatStats.CheckedChanged += new System.EventHandler(this.FormatStats_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // StatsViewer
            // 
            this.StatsViewer.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsViewer.Name = "StatsViewer";
            this.StatsViewer.Size = new System.Drawing.Size(159, 22);
            this.StatsViewer.Text = "View All Runs";
            this.StatsViewer.Click += new System.EventHandler(this.StatsViewerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.best_time);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.best_avgSpeed);
            this.groupBox4.Controls.Add(this.best_distance);
            this.groupBox4.Location = new System.Drawing.Point(12, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 90);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Best";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Distance";
            // 
            // best_time
            // 
            this.best_time.AutoSize = true;
            this.best_time.Location = new System.Drawing.Point(135, 21);
            this.best_time.Name = "best_time";
            this.best_time.Size = new System.Drawing.Size(56, 17);
            this.best_time.TabIndex = 18;
            this.best_time.Text = "00:00.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "Time";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "Avg Speed";
            // 
            // best_avgSpeed
            // 
            this.best_avgSpeed.AutoSize = true;
            this.best_avgSpeed.Location = new System.Drawing.Point(135, 42);
            this.best_avgSpeed.Name = "best_avgSpeed";
            this.best_avgSpeed.Size = new System.Drawing.Size(65, 17);
            this.best_avgSpeed.TabIndex = 16;
            this.best_avgSpeed.Text = "0.00 km/h";
            // 
            // best_distance
            // 
            this.best_distance.AutoSize = true;
            this.best_distance.Location = new System.Drawing.Point(135, 63);
            this.best_distance.Name = "best_distance";
            this.best_distance.Size = new System.Drawing.Size(30, 17);
            this.best_distance.TabIndex = 19;
            this.best_distance.Text = "0 m";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 278);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(567, 317);
            this.MinimumSize = new System.Drawing.Size(567, 317);
            this.Name = "MainForm";
            this.Text = "Time Trial Stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label current_avgSpeed;
        private System.Windows.Forms.Label current_time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label current_totalCheckpoints;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label current_timedCheckpoint;
        private System.Windows.Forms.Label current_checkpoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label current_distance;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label total_distance;
        private System.Windows.Forms.Label average_speed;
        private System.Windows.Forms.Label total_time;
        private System.Windows.Forms.Label total_checkpoints;
        private System.Windows.Forms.Label average_time;
        private System.Windows.Forms.Label average_distance;
        private System.Windows.Forms.Label total_runs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem discordStatus;
        private System.Windows.Forms.ToolStripMenuItem formatStats;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem StatsViewer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label best_time;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label best_avgSpeed;
        private System.Windows.Forms.Label best_distance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label total_timedCheckpoints;
    }
}

