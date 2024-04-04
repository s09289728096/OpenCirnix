namespace Cirnix.Forms.ServerStatus
{
    partial class RoomListStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StatisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Label_Title = new System.Windows.Forms.Label();
            this.RB_Player = new System.Windows.Forms.RadioButton();
            this.RB_Map = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_DisplayAll = new System.Windows.Forms.CheckBox();
            this.CB_IgnoreVersion = new System.Windows.Forms.CheckBox();
            this.Label_Players = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_TotalRoom = new System.Windows.Forms.Label();
            this.Label_TotalPlayers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticsChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatisticsChart
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Name = "MainChartArea";
            this.StatisticsChart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "MainLegend";
            this.StatisticsChart.Legends.Add(legend1);
            this.StatisticsChart.Location = new System.Drawing.Point(9, 30);
            this.StatisticsChart.Name = "StatisticsChart";
            series1.ChartArea = "MainChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            series1.Legend = "MainLegend";
            series1.Name = "MainSeries";
            this.StatisticsChart.Series.Add(series1);
            this.StatisticsChart.Size = new System.Drawing.Size(540, 400);
            this.StatisticsChart.TabIndex = 0;
            // 
            // Label_Title
            // 
            this.Label_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Title.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.Label_Title.Location = new System.Drawing.Point(180, 10);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(160, 20);
            this.Label_Title.TabIndex = 10;
            this.Label_Title.Text = "M16 伺服器 - 玩家分佈圖";
            this.Label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RB_Player
            // 
            this.RB_Player.Appearance = System.Windows.Forms.Appearance.Button;
            this.RB_Player.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.RB_Player.Location = new System.Drawing.Point(3, 38);
            this.RB_Player.Margin = new System.Windows.Forms.Padding(0);
            this.RB_Player.Name = "RB_Player";
            this.RB_Player.Size = new System.Drawing.Size(54, 23);
            this.RB_Player.TabIndex = 95;
            this.RB_Player.Text = "玩家";
            this.RB_Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RB_Player.UseVisualStyleBackColor = true;
            // 
            // RB_Map
            // 
            this.RB_Map.Appearance = System.Windows.Forms.Appearance.Button;
            this.RB_Map.Checked = true;
            this.RB_Map.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.RB_Map.Location = new System.Drawing.Point(3, 15);
            this.RB_Map.Margin = new System.Windows.Forms.Padding(0);
            this.RB_Map.Name = "RB_Map";
            this.RB_Map.Size = new System.Drawing.Size(54, 23);
            this.RB_Map.TabIndex = 94;
            this.RB_Map.TabStop = true;
            this.RB_Map.Text = "地圖";
            this.RB_Map.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RB_Map.UseVisualStyleBackColor = true;
            this.RB_Map.CheckedChanged += new System.EventHandler(this.RoomStatisticsRefresh);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Map);
            this.groupBox1.Controls.Add(this.RB_Player);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.groupBox1.Location = new System.Drawing.Point(7, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(65, 64);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "統計標準";
            // 
            // CB_DisplayAll
            // 
            this.CB_DisplayAll.BackColor = System.Drawing.Color.Transparent;
            this.CB_DisplayAll.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.CB_DisplayAll.Location = new System.Drawing.Point(75, 413);
            this.CB_DisplayAll.Margin = new System.Windows.Forms.Padding(1);
            this.CB_DisplayAll.Name = "CB_DisplayAll";
            this.CB_DisplayAll.Size = new System.Drawing.Size(70, 16);
            this.CB_DisplayAll.TabIndex = 97;
            this.CB_DisplayAll.Text = "完整符號";
            this.CB_DisplayAll.UseVisualStyleBackColor = false;
            this.CB_DisplayAll.CheckedChanged += new System.EventHandler(this.RoomStatisticsRefresh);
            // 
            // CB_IgnoreVersion
            // 
            this.CB_IgnoreVersion.BackColor = System.Drawing.Color.Transparent;
            this.CB_IgnoreVersion.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.CB_IgnoreVersion.Location = new System.Drawing.Point(75, 398);
            this.CB_IgnoreVersion.Margin = new System.Windows.Forms.Padding(1);
            this.CB_IgnoreVersion.Name = "CB_IgnoreVersion";
            this.CB_IgnoreVersion.Size = new System.Drawing.Size(70, 16);
            this.CB_IgnoreVersion.TabIndex = 98;
            this.CB_IgnoreVersion.Text = "忽略版本";
            this.CB_IgnoreVersion.UseVisualStyleBackColor = false;
            this.CB_IgnoreVersion.CheckedChanged += new System.EventHandler(this.RoomStatisticsRefresh);
            // 
            // Label_Players
            // 
            this.Label_Players.BackColor = System.Drawing.Color.Transparent;
            this.Label_Players.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.Label_Players.Location = new System.Drawing.Point(69, 60);
            this.Label_Players.Name = "Label_Players";
            this.Label_Players.Size = new System.Drawing.Size(34, 15);
            this.Label_Players.TabIndex = 99;
            this.Label_Players.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 100;
            this.label1.Text = "開放房間數:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.label2.Location = new System.Drawing.Point(4, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 101;
            this.label2.Text = "玩家數:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_TotalRoom
            // 
            this.Label_TotalRoom.BackColor = System.Drawing.Color.Transparent;
            this.Label_TotalRoom.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.Label_TotalRoom.Location = new System.Drawing.Point(69, 45);
            this.Label_TotalRoom.Name = "Label_TotalRoom";
            this.Label_TotalRoom.Size = new System.Drawing.Size(34, 15);
            this.Label_TotalRoom.TabIndex = 102;
            this.Label_TotalRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_TotalPlayers
            // 
            this.Label_TotalPlayers.BackColor = System.Drawing.Color.Transparent;
            this.Label_TotalPlayers.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.Label_TotalPlayers.Location = new System.Drawing.Point(69, 75);
            this.Label_TotalPlayers.Name = "Label_TotalPlayers";
            this.Label_TotalPlayers.Size = new System.Drawing.Size(34, 15);
            this.Label_TotalPlayers.TabIndex = 103;
            this.Label_TotalPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.label4.Location = new System.Drawing.Point(4, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 104;
            this.label4.Text = "連線玩家數:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RoomListStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 440);
            this.Controls.Add(this.Label_TotalPlayers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label_TotalRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Players);
            this.Controls.Add(this.CB_IgnoreVersion);
            this.Controls.Add(this.CB_DisplayAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatisticsChart);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomListStatistics";
            this.Padding = new System.Windows.Forms.Padding(4, 30, 4, 5);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "M16 伺服器 - 玩家分佈圖";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomListStatistics_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StatisticsChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart StatisticsChart;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.RadioButton RB_Player;
        private System.Windows.Forms.RadioButton RB_Map;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CB_DisplayAll;
        private System.Windows.Forms.CheckBox CB_IgnoreVersion;
        private System.Windows.Forms.Label Label_Players;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_TotalRoom;
        private System.Windows.Forms.Label Label_TotalPlayers;
        private System.Windows.Forms.Label label4;
    }
}