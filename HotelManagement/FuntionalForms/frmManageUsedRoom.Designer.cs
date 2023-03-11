namespace HotelManagement.FuntionalForms
{
    partial class frmManageUsedRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.lblService = new System.Windows.Forms.Label();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.dataGridViewOrderedServices = new System.Windows.Forms.DataGridView();
            this.dataGridViewStayInRoom = new System.Windows.Forms.DataGridView();
            this.lblCustomerStayIn = new System.Windows.Forms.Label();
            this.lblOrderedService = new System.Windows.Forms.Label();
            this.lblCheckinTime = new System.Windows.Forms.Label();
            this.dateTimePickerCheckOutTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckoutTime = new System.Windows.Forms.Label();
            this.dTPCheckinDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblServicesCostValue = new System.Windows.Forms.Label();
            this.lblRoomFee = new System.Windows.Forms.Label();
            this.lblRoomFeeValue = new System.Windows.Forms.Label();
            this.lblTotalCostValue = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblExtraFeeValue = new System.Windows.Forms.Label();
            this.lblExtraFee = new System.Windows.Forms.Label();
            this.lblServicesCost = new System.Windows.Forms.Label();
            this.rTBBookingNote = new System.Windows.Forms.RichTextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnReleaseRoom = new System.Windows.Forms.Button();
            this.dTPCheckinTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderedServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStayInRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.29565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoomNumber.Location = new System.Drawing.Point(601, 9);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(92, 48);
            this.lblRoomNumber.TabIndex = 100;
            this.lblRoomNumber.Text = "###";
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AllowUserToAddRows = false;
            this.dataGridViewServices.AllowUserToResizeRows = false;
            this.dataGridViewServices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dataGridViewServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewServices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewServices.EnableHeadersVisualStyles = false;
            this.dataGridViewServices.GridColor = System.Drawing.Color.Cyan;
            this.dataGridViewServices.Location = new System.Drawing.Point(38, 477);
            this.dataGridViewServices.MultiSelect = false;
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewServices.RowHeadersVisible = false;
            this.dataGridViewServices.RowHeadersWidth = 49;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServices.Size = new System.Drawing.Size(600, 285);
            this.dataGridViewServices.TabIndex = 94;
            this.dataGridViewServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServices_CellClick);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblService.Location = new System.Drawing.Point(35, 458);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(113, 16);
            this.lblService.TabIndex = 92;
            this.lblService.Text = "Hotel Services:";
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BackColor = System.Drawing.Color.Lime;
            this.btnCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBill.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreateBill.Location = new System.Drawing.Point(939, 802);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(143, 41);
            this.btnCreateBill.TabIndex = 91;
            this.btnCreateBill.Text = "🧾 Create Bill";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // dataGridViewOrderedServices
            // 
            this.dataGridViewOrderedServices.AllowUserToAddRows = false;
            this.dataGridViewOrderedServices.AllowUserToResizeRows = false;
            this.dataGridViewOrderedServices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewOrderedServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderedServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dataGridViewOrderedServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderedServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrderedServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrderedServices.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOrderedServices.EnableHeadersVisualStyles = false;
            this.dataGridViewOrderedServices.GridColor = System.Drawing.Color.Cyan;
            this.dataGridViewOrderedServices.Location = new System.Drawing.Point(688, 477);
            this.dataGridViewOrderedServices.MultiSelect = false;
            this.dataGridViewOrderedServices.Name = "dataGridViewOrderedServices";
            this.dataGridViewOrderedServices.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderedServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewOrderedServices.RowHeadersVisible = false;
            this.dataGridViewOrderedServices.RowHeadersWidth = 49;
            this.dataGridViewOrderedServices.RowTemplate.Height = 24;
            this.dataGridViewOrderedServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderedServices.Size = new System.Drawing.Size(568, 285);
            this.dataGridViewOrderedServices.TabIndex = 88;
            this.dataGridViewOrderedServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderedServices_CellClick);
            // 
            // dataGridViewStayInRoom
            // 
            this.dataGridViewStayInRoom.AllowUserToAddRows = false;
            this.dataGridViewStayInRoom.AllowUserToResizeRows = false;
            this.dataGridViewStayInRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewStayInRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStayInRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dataGridViewStayInRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStayInRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewStayInRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStayInRoom.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewStayInRoom.EnableHeadersVisualStyles = false;
            this.dataGridViewStayInRoom.GridColor = System.Drawing.Color.Cyan;
            this.dataGridViewStayInRoom.Location = new System.Drawing.Point(38, 275);
            this.dataGridViewStayInRoom.MultiSelect = false;
            this.dataGridViewStayInRoom.Name = "dataGridViewStayInRoom";
            this.dataGridViewStayInRoom.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStayInRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewStayInRoom.RowHeadersVisible = false;
            this.dataGridViewStayInRoom.RowHeadersWidth = 49;
            this.dataGridViewStayInRoom.RowTemplate.Height = 24;
            this.dataGridViewStayInRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewStayInRoom.Size = new System.Drawing.Size(1218, 140);
            this.dataGridViewStayInRoom.TabIndex = 81;
            this.dataGridViewStayInRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStayInRoom_CellClick);
            // 
            // lblCustomerStayIn
            // 
            this.lblCustomerStayIn.AutoSize = true;
            this.lblCustomerStayIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCustomerStayIn.Location = new System.Drawing.Point(593, 256);
            this.lblCustomerStayIn.Name = "lblCustomerStayIn";
            this.lblCustomerStayIn.Size = new System.Drawing.Size(130, 16);
            this.lblCustomerStayIn.TabIndex = 80;
            this.lblCustomerStayIn.Text = "Stay-In customers";
            // 
            // lblOrderedService
            // 
            this.lblOrderedService.AutoSize = true;
            this.lblOrderedService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOrderedService.Location = new System.Drawing.Point(685, 458);
            this.lblOrderedService.Name = "lblOrderedService";
            this.lblOrderedService.Size = new System.Drawing.Size(133, 16);
            this.lblOrderedService.TabIndex = 78;
            this.lblOrderedService.Text = "Ordered Services:";
            // 
            // lblCheckinTime
            // 
            this.lblCheckinTime.AutoSize = true;
            this.lblCheckinTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCheckinTime.Location = new System.Drawing.Point(35, 58);
            this.lblCheckinTime.Name = "lblCheckinTime";
            this.lblCheckinTime.Size = new System.Drawing.Size(104, 16);
            this.lblCheckinTime.TabIndex = 97;
            this.lblCheckinTime.Text = "Check-in time:";
            // 
            // dateTimePickerCheckOutTime
            // 
            this.dateTimePickerCheckOutTime.Enabled = false;
            this.dateTimePickerCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerCheckOutTime.Location = new System.Drawing.Point(384, 84);
            this.dateTimePickerCheckOutTime.Name = "dateTimePickerCheckOutTime";
            this.dateTimePickerCheckOutTime.ShowUpDown = true;
            this.dateTimePickerCheckOutTime.Size = new System.Drawing.Size(118, 22);
            this.dateTimePickerCheckOutTime.TabIndex = 99;
            this.dateTimePickerCheckOutTime.ValueChanged += new System.EventHandler(this.dateTimePickerCheckOutTime_ValueChanged);
            // 
            // dateTimePickerCheckOutDate
            // 
            this.dateTimePickerCheckOutDate.Enabled = false;
            this.dateTimePickerCheckOutDate.Location = new System.Drawing.Point(155, 84);
            this.dateTimePickerCheckOutDate.Name = "dateTimePickerCheckOutDate";
            this.dateTimePickerCheckOutDate.Size = new System.Drawing.Size(223, 22);
            this.dateTimePickerCheckOutDate.TabIndex = 96;
            this.dateTimePickerCheckOutDate.ValueChanged += new System.EventHandler(this.dateTimePickerCheckOutDate_ValueChanged);
            // 
            // lblCheckoutTime
            // 
            this.lblCheckoutTime.AutoSize = true;
            this.lblCheckoutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCheckoutTime.Location = new System.Drawing.Point(35, 89);
            this.lblCheckoutTime.Name = "lblCheckoutTime";
            this.lblCheckoutTime.Size = new System.Drawing.Size(113, 16);
            this.lblCheckoutTime.TabIndex = 98;
            this.lblCheckoutTime.Text = "Check-out time:";
            // 
            // dTPCheckinDateTime
            // 
            this.dTPCheckinDateTime.Enabled = false;
            this.dTPCheckinDateTime.Location = new System.Drawing.Point(155, 58);
            this.dTPCheckinDateTime.Name = "dTPCheckinDateTime";
            this.dTPCheckinDateTime.Size = new System.Drawing.Size(223, 22);
            this.dTPCheckinDateTime.TabIndex = 95;
            // 
            // lblServicesCostValue
            // 
            this.lblServicesCostValue.AutoSize = true;
            this.lblServicesCostValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblServicesCostValue.Location = new System.Drawing.Point(1211, 107);
            this.lblServicesCostValue.Name = "lblServicesCostValue";
            this.lblServicesCostValue.Size = new System.Drawing.Size(45, 25);
            this.lblServicesCostValue.TabIndex = 101;
            this.lblServicesCostValue.Text = "###";
            // 
            // lblRoomFee
            // 
            this.lblRoomFee.AutoSize = true;
            this.lblRoomFee.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoomFee.Location = new System.Drawing.Point(1108, 58);
            this.lblRoomFee.Name = "lblRoomFee";
            this.lblRoomFee.Size = new System.Drawing.Size(97, 25);
            this.lblRoomFee.TabIndex = 102;
            this.lblRoomFee.Text = "Room Fee";
            // 
            // lblRoomFeeValue
            // 
            this.lblRoomFeeValue.AutoSize = true;
            this.lblRoomFeeValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoomFeeValue.Location = new System.Drawing.Point(1211, 58);
            this.lblRoomFeeValue.Name = "lblRoomFeeValue";
            this.lblRoomFeeValue.Size = new System.Drawing.Size(45, 25);
            this.lblRoomFeeValue.TabIndex = 103;
            this.lblRoomFeeValue.Text = "###";
            // 
            // lblTotalCostValue
            // 
            this.lblTotalCostValue.AutoSize = true;
            this.lblTotalCostValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalCostValue.Location = new System.Drawing.Point(1211, 132);
            this.lblTotalCostValue.Name = "lblTotalCostValue";
            this.lblTotalCostValue.Size = new System.Drawing.Size(45, 25);
            this.lblTotalCostValue.TabIndex = 105;
            this.lblTotalCostValue.Text = "###";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalCost.Location = new System.Drawing.Point(1108, 132);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(53, 25);
            this.lblTotalCost.TabIndex = 104;
            this.lblTotalCost.Text = "Total";
            // 
            // lblExtraFeeValue
            // 
            this.lblExtraFeeValue.AutoSize = true;
            this.lblExtraFeeValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblExtraFeeValue.Location = new System.Drawing.Point(1211, 81);
            this.lblExtraFeeValue.Name = "lblExtraFeeValue";
            this.lblExtraFeeValue.Size = new System.Drawing.Size(45, 25);
            this.lblExtraFeeValue.TabIndex = 107;
            this.lblExtraFeeValue.Text = "###";
            // 
            // lblExtraFee
            // 
            this.lblExtraFee.AutoSize = true;
            this.lblExtraFee.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblExtraFee.Location = new System.Drawing.Point(1108, 81);
            this.lblExtraFee.Name = "lblExtraFee";
            this.lblExtraFee.Size = new System.Drawing.Size(91, 25);
            this.lblExtraFee.TabIndex = 106;
            this.lblExtraFee.Text = "Extra Fee";
            // 
            // lblServicesCost
            // 
            this.lblServicesCost.AutoSize = true;
            this.lblServicesCost.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblServicesCost.Location = new System.Drawing.Point(1108, 107);
            this.lblServicesCost.Name = "lblServicesCost";
            this.lblServicesCost.Size = new System.Drawing.Size(82, 25);
            this.lblServicesCost.TabIndex = 108;
            this.lblServicesCost.Text = "Services";
            // 
            // rTBBookingNote
            // 
            this.rTBBookingNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.rTBBookingNote.Location = new System.Drawing.Point(1113, 208);
            this.rTBBookingNote.Name = "rTBBookingNote";
            this.rTBBookingNote.Size = new System.Drawing.Size(143, 61);
            this.rTBBookingNote.TabIndex = 109;
            this.rTBBookingNote.Text = "";
            this.rTBBookingNote.TextChanged += new System.EventHandler(this.rTBBookingNote_TextChanged);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNote.Location = new System.Drawing.Point(1108, 180);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(55, 25);
            this.lblNote.TabIndex = 110;
            this.lblNote.Text = "Note";
            // 
            // btnReleaseRoom
            // 
            this.btnReleaseRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReleaseRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseRoom.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReleaseRoom.Location = new System.Drawing.Point(1113, 802);
            this.btnReleaseRoom.Name = "btnReleaseRoom";
            this.btnReleaseRoom.Size = new System.Drawing.Size(143, 41);
            this.btnReleaseRoom.TabIndex = 111;
            this.btnReleaseRoom.Text = "🚪 Release Room";
            this.btnReleaseRoom.UseVisualStyleBackColor = false;
            this.btnReleaseRoom.Click += new System.EventHandler(this.btnReleaseRoom_Click);
            // 
            // dTPCheckinTime
            // 
            this.dTPCheckinTime.Enabled = false;
            this.dTPCheckinTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPCheckinTime.Location = new System.Drawing.Point(384, 58);
            this.dTPCheckinTime.Name = "dTPCheckinTime";
            this.dTPCheckinTime.ShowUpDown = true;
            this.dTPCheckinTime.Size = new System.Drawing.Size(118, 22);
            this.dTPCheckinTime.TabIndex = 112;
            // 
            // frmManageUsedRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 855);
            this.Controls.Add(this.dTPCheckinTime);
            this.Controls.Add(this.btnReleaseRoom);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.rTBBookingNote);
            this.Controls.Add(this.lblServicesCost);
            this.Controls.Add(this.lblExtraFeeValue);
            this.Controls.Add(this.lblExtraFee);
            this.Controls.Add(this.lblTotalCostValue);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblRoomFeeValue);
            this.Controls.Add(this.lblRoomFee);
            this.Controls.Add(this.lblServicesCostValue);
            this.Controls.Add(this.dataGridViewOrderedServices);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.dateTimePickerCheckOutTime);
            this.Controls.Add(this.lblOrderedService);
            this.Controls.Add(this.lblCustomerStayIn);
            this.Controls.Add(this.dataGridViewStayInRoom);
            this.Controls.Add(this.lblCheckoutTime);
            this.Controls.Add(this.dateTimePickerCheckOutDate);
            this.Controls.Add(this.dTPCheckinDateTime);
            this.Controls.Add(this.lblCheckinTime);
            this.Controls.Add(this.dataGridViewServices);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.btnCreateBill);
            this.MaximumSize = new System.Drawing.Size(1318, 900);
            this.MinimumSize = new System.Drawing.Size(1318, 900);
            this.Name = "frmManageUsedRoom";
            this.Text = "frmManageUsedRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManageUsedRoom_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.frmManageUsedRoom_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderedServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStayInRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.DataGridView dataGridViewOrderedServices;
        private System.Windows.Forms.DataGridView dataGridViewStayInRoom;
        private System.Windows.Forms.Label lblCustomerStayIn;
        private System.Windows.Forms.Label lblOrderedService;
        private System.Windows.Forms.Label lblCheckinTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOutTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOutDate;
        private System.Windows.Forms.Label lblCheckoutTime;
        private System.Windows.Forms.DateTimePicker dTPCheckinDateTime;
        private System.Windows.Forms.Label lblServicesCostValue;
        private System.Windows.Forms.Label lblRoomFee;
        private System.Windows.Forms.Label lblRoomFeeValue;
        private System.Windows.Forms.Label lblTotalCostValue;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblExtraFeeValue;
        private System.Windows.Forms.Label lblExtraFee;
        private System.Windows.Forms.Label lblServicesCost;
        private System.Windows.Forms.RichTextBox rTBBookingNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnReleaseRoom;
        private System.Windows.Forms.DateTimePicker dTPCheckinTime;
    }
}