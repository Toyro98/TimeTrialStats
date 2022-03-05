
using System;

namespace TimeTrialStats
{
    partial class StatsViewerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RunStatsViewer = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Map = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveRun = new System.Windows.Forms.Button();
            this.Border = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.RunStatsViewer)).BeginInit();
            this.Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunStatsViewer
            // 
            this.RunStatsViewer.AllowUserToAddRows = false;
            this.RunStatsViewer.AllowUserToDeleteRows = false;
            this.RunStatsViewer.AllowUserToResizeColumns = false;
            this.RunStatsViewer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunStatsViewer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RunStatsViewer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RunStatsViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RunStatsViewer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RunStatsViewer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.RunStatsViewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RunStatsViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RunStatsViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RunStatsViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Map,
            this.Time,
            this.AvgSpeed,
            this.Distance});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RunStatsViewer.DefaultCellStyle = dataGridViewCellStyle3;
            this.RunStatsViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RunStatsViewer.Location = new System.Drawing.Point(-1, -1);
            this.RunStatsViewer.Name = "RunStatsViewer";
            this.RunStatsViewer.ReadOnly = true;
            this.RunStatsViewer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RunStatsViewer.RowHeadersVisible = false;
            this.RunStatsViewer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RunStatsViewer.RowTemplate.Height = 25;
            this.RunStatsViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RunStatsViewer.ShowEditingIcon = false;
            this.RunStatsViewer.Size = new System.Drawing.Size(520, 325);
            this.RunStatsViewer.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DividerWidth = 1;
            this.Id.FillWeight = 48F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 48;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 48;
            // 
            // Map
            // 
            this.Map.DividerWidth = 1;
            this.Map.FillWeight = 172F;
            this.Map.HeaderText = "Map";
            this.Map.MinimumWidth = 172;
            this.Map.Name = "Map";
            this.Map.ReadOnly = true;
            this.Map.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Map.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Map.Width = 172;
            // 
            // Time
            // 
            this.Time.DividerWidth = 1;
            this.Time.FillWeight = 92F;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 92;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Time.Width = 92;
            // 
            // AvgSpeed
            // 
            this.AvgSpeed.DividerWidth = 1;
            this.AvgSpeed.HeaderText = "Avg Speed";
            this.AvgSpeed.MinimumWidth = 100;
            this.AvgSpeed.Name = "AvgSpeed";
            this.AvgSpeed.ReadOnly = true;
            this.AvgSpeed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AvgSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Distance
            // 
            this.Distance.DividerWidth = 1;
            this.Distance.FillWeight = 92F;
            this.Distance.HeaderText = "Distance";
            this.Distance.MinimumWidth = 92;
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            this.Distance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Distance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Distance.Width = 108;
            // 
            // SaveRun
            // 
            this.SaveRun.Enabled = false;
            this.SaveRun.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveRun.Location = new System.Drawing.Point(458, 349);
            this.SaveRun.Name = "SaveRun";
            this.SaveRun.Size = new System.Drawing.Size(75, 26);
            this.SaveRun.TabIndex = 1;
            this.SaveRun.Text = "Save";
            this.SaveRun.UseVisualStyleBackColor = true;
            this.SaveRun.Click += new System.EventHandler(this.SaveRun_Click);
            // 
            // Border
            // 
            this.Border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Border.Controls.Add(this.RunStatsViewer);
            this.Border.Location = new System.Drawing.Point(13, 13);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(520, 324);
            this.Border.TabIndex = 6;
            // 
            // StatsViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 387);
            this.Controls.Add(this.SaveRun);
            this.Controls.Add(this.Border);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(562, 426);
            this.MinimumSize = new System.Drawing.Size(562, 426);
            this.Name = "StatsViewerForm";
            this.Text = "Stats Viewer";
            this.Load += new System.EventHandler(this.StatsViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RunStatsViewer)).EndInit();
            this.Border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ClearAllRuns_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView RunStatsViewer;
        private System.Windows.Forms.Button SaveRun;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Map;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
    }
}