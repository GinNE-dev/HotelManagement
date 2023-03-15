namespace HotelManagement.FuntionalForms
{
    partial class frmStatistic
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
            this.eHostBarChartRevenue = new System.Windows.Forms.Integration.ElementHost();
            this.dateTimePickerRange = new System.Windows.Forms.DateTimePicker();
            this.cbbPeriod = new System.Windows.Forms.ComboBox();
            this.eHostPieChart = new System.Windows.Forms.Integration.ElementHost();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblRevenueChartTitle = new System.Windows.Forms.Label();
            this.lblRoomTypeChartTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnECount = new System.Windows.Forms.Button();
            this.elementHostOrderRate = new System.Windows.Forms.Integration.ElementHost();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSCount = new System.Windows.Forms.Button();
            this.elementHostCustomerAge = new System.Windows.Forms.Integration.ElementHost();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // eHostBarChartRevenue
            // 
            this.eHostBarChartRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eHostBarChartRevenue.Location = new System.Drawing.Point(12, 151);
            this.eHostBarChartRevenue.Name = "eHostBarChartRevenue";
            this.eHostBarChartRevenue.Size = new System.Drawing.Size(856, 247);
            this.eHostBarChartRevenue.TabIndex = 1;
            this.eHostBarChartRevenue.Text = "Revenue";
            this.eHostBarChartRevenue.Child = null;
            // 
            // dateTimePickerRange
            // 
            this.dateTimePickerRange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerRange.Location = new System.Drawing.Point(149, 87);
            this.dateTimePickerRange.Name = "dateTimePickerRange";
            this.dateTimePickerRange.Size = new System.Drawing.Size(229, 22);
            this.dateTimePickerRange.TabIndex = 2;
            this.dateTimePickerRange.ValueChanged += new System.EventHandler(this.dateTimePickerRange_ValueChanged);
            // 
            // cbbPeriod
            // 
            this.cbbPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPeriod.FormattingEnabled = true;
            this.cbbPeriod.Items.AddRange(new object[] {
            "Week",
            "Month",
            "Year"});
            this.cbbPeriod.Location = new System.Drawing.Point(12, 87);
            this.cbbPeriod.Name = "cbbPeriod";
            this.cbbPeriod.Size = new System.Drawing.Size(121, 24);
            this.cbbPeriod.TabIndex = 3;
            this.cbbPeriod.SelectedIndexChanged += new System.EventHandler(this.cbbPeriod_SelectedIndexChanged);
            // 
            // eHostPieChart
            // 
            this.eHostPieChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eHostPieChart.Location = new System.Drawing.Point(12, 471);
            this.eHostPieChart.Name = "eHostPieChart";
            this.eHostPieChart.Size = new System.Drawing.Size(283, 237);
            this.eHostPieChart.TabIndex = 4;
            this.eHostPieChart.Text = "elementHost1";
            this.eHostPieChart.Child = null;
            // 
            // lblPeriod
            // 
            this.lblPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(384, 90);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(10, 16);
            this.lblPeriod.TabIndex = 5;
            this.lblPeriod.Text = " ";
            // 
            // lblRevenueChartTitle
            // 
            this.lblRevenueChartTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRevenueChartTitle.AutoSize = true;
            this.lblRevenueChartTitle.Location = new System.Drawing.Point(384, 128);
            this.lblRevenueChartTitle.Name = "lblRevenueChartTitle";
            this.lblRevenueChartTitle.Size = new System.Drawing.Size(10, 16);
            this.lblRevenueChartTitle.TabIndex = 6;
            this.lblRevenueChartTitle.Text = " ";
            // 
            // lblRoomTypeChartTitle
            // 
            this.lblRoomTypeChartTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoomTypeChartTitle.AutoSize = true;
            this.lblRoomTypeChartTitle.Location = new System.Drawing.Point(9, 452);
            this.lblRoomTypeChartTitle.Name = "lblRoomTypeChartTitle";
            this.lblRoomTypeChartTitle.Size = new System.Drawing.Size(222, 16);
            this.lblRoomTypeChartTitle.TabIndex = 7;
            this.lblRoomTypeChartTitle.Text = " RENTED ROOM TYPE STATISTIC";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnECount);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 38);
            this.panel1.TabIndex = 8;
            // 
            // btnECount
            // 
            this.btnECount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnECount.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnECount.Location = new System.Drawing.Point(-33, -21);
            this.btnECount.Name = "btnECount";
            this.btnECount.Size = new System.Drawing.Size(190, 78);
            this.btnECount.TabIndex = 9;
            this.btnECount.Text = "Employees: #";
            this.btnECount.UseVisualStyleBackColor = false;
            // 
            // elementHostOrderRate
            // 
            this.elementHostOrderRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementHostOrderRate.Location = new System.Drawing.Point(333, 502);
            this.elementHostOrderRate.Name = "elementHostOrderRate";
            this.elementHostOrderRate.Size = new System.Drawing.Size(212, 159);
            this.elementHostOrderRate.TabIndex = 9;
            this.elementHostOrderRate.Text = "elementHost1";
            this.elementHostOrderRate.Child = null;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "SERVICES ORDER RATE";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnSCount);
            this.panel2.Location = new System.Drawing.Point(149, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 38);
            this.panel2.TabIndex = 10;
            // 
            // btnSCount
            // 
            this.btnSCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnSCount.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSCount.Location = new System.Drawing.Point(-33, -21);
            this.btnSCount.Name = "btnSCount";
            this.btnSCount.Size = new System.Drawing.Size(190, 78);
            this.btnSCount.TabIndex = 9;
            this.btnSCount.Text = "Services: #";
            this.btnSCount.UseVisualStyleBackColor = false;
            // 
            // elementHostCustomerAge
            // 
            this.elementHostCustomerAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementHostCustomerAge.Location = new System.Drawing.Point(574, 471);
            this.elementHostCustomerAge.Name = "elementHostCustomerAge";
            this.elementHostCustomerAge.Size = new System.Drawing.Size(294, 237);
            this.elementHostCustomerAge.TabIndex = 11;
            this.elementHostCustomerAge.Text = "elementHost1";
            this.elementHostCustomerAge.Child = null;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "CLIENT AGE CLASSIFY";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(727, 127);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(64, 17);
            this.lblTotalRevenue.TabIndex = 13;
            this.lblTotalRevenue.Text = "TOTAL: #";
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(880, 720);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.elementHostCustomerAge);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elementHostOrderRate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRoomTypeChartTitle);
            this.Controls.Add(this.lblRevenueChartTitle);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.eHostPieChart);
            this.Controls.Add(this.cbbPeriod);
            this.Controls.Add(this.dateTimePickerRange);
            this.Controls.Add(this.eHostBarChartRevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStatistic";
            this.Text = "frmStatistic";
            this.Load += new System.EventHandler(this.frmStatistic_Load);
            this.VisibleChanged += new System.EventHandler(this.frmStatistic_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost eHostBarChartRevenue;
        private System.Windows.Forms.DateTimePicker dateTimePickerRange;
        private System.Windows.Forms.ComboBox cbbPeriod;
        private System.Windows.Forms.Integration.ElementHost eHostPieChart;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblRevenueChartTitle;
        private System.Windows.Forms.Label lblRoomTypeChartTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnECount;
        private System.Windows.Forms.Integration.ElementHost elementHostOrderRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSCount;
        private System.Windows.Forms.Integration.ElementHost elementHostCustomerAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalRevenue;
    }
}