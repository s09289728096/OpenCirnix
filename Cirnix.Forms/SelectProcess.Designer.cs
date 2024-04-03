namespace Cirnix.Forms
{
    partial class SelectProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProcess));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SelectButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ProcessList = new System.Windows.Forms.ListView();
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.War3Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(10, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(219, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "可以手動選擇程式";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.UseStyleColors = true;
            // 
            // SelectButton
            // 
            this.SelectButton.Highlight = true;
            this.SelectButton.Location = new System.Drawing.Point(69, 341);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(86, 35);
            this.SelectButton.TabIndex = 4;
            this.SelectButton.Text = "選擇";
            this.SelectButton.UseSelectable = true;
            this.SelectButton.Click += new System.EventHandler(this.Select_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(9, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(219, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 73;
            this.metroLabel1.Text = "如果你找不到War3";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseStyleColors = true;
            // 
            // ProcessList
            // 
            this.ProcessList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PID,
            this.War3Name});
            this.ProcessList.FullRowSelect = true;
            this.ProcessList.GridLines = true;
            this.ProcessList.HideSelection = false;
            this.ProcessList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProcessList.Location = new System.Drawing.Point(9, 135);
            this.ProcessList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(218, 191);
            this.ProcessList.TabIndex = 76;
            this.ProcessList.UseCompatibleStateImageBehavior = false;
            this.ProcessList.View = System.Windows.Forms.View.Details;
            // 
            // PID
            // 
            this.PID.Text = "PID";
            this.PID.Width = 30;
            // 
            // War3Name
            // 
            this.War3Name.Text = "War3Name";
            this.War3Name.Width = 220;
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(9, 106);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(219, 20);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 77;
            this.metroLabel3.Text = "點擊PID並按下選擇按鈕";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.UseStyleColors = true;
            // 
            // SelectProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 387);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.metroLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectProcess";
            this.Padding = new System.Windows.Forms.Padding(9, 60, 9, 10);
            this.Resizable = false;
            this.Text = "War3 選擇";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectProcess_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroButton SelectButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListView ProcessList;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader War3Name;
    }
}