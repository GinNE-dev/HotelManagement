namespace HotelManagement.FuntionalForms
{
    partial class frmPlaceBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxBookingDetail = new System.Windows.Forms.GroupBox();
            this.dataGridViewOrderedServices = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dataGridViewStayInRoom = new System.Windows.Forms.DataGridView();
            this.lblCustomerStayIn = new System.Windows.Forms.Label();
            this.lblOrderedService = new System.Windows.Forms.Label();
            this.lblCheckinTime = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.dTPCheckinDateTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckoutTime = new System.Windows.Forms.Label();
            this.dateTimePickerCheckOutTime = new System.Windows.Forms.DateTimePicker();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.groupBoxBookingDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderedServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStayInRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBookingDetail
            // 
            this.groupBoxBookingDetail.Controls.Add(this.dataGridViewOrderedServices);
            this.groupBoxBookingDetail.Controls.Add(this.btnAddCustomer);
            this.groupBoxBookingDetail.Controls.Add(this.lblCustomer);
            this.groupBoxBookingDetail.Controls.Add(this.dataGridViewStayInRoom);
            this.groupBoxBookingDetail.Controls.Add(this.lblCustomerStayIn);
            this.groupBoxBookingDetail.Controls.Add(this.lblOrderedService);
            this.groupBoxBookingDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxBookingDetail.Location = new System.Drawing.Point(673, 29);
            this.groupBoxBookingDetail.Name = "groupBoxBookingDetail";
            this.groupBoxBookingDetail.Size = new System.Drawing.Size(600, 702);
            this.groupBoxBookingDetail.TabIndex = 4;
            this.groupBoxBookingDetail.TabStop = false;
            this.groupBoxBookingDetail.Text = "Info";
            // 
            // dataGridViewOrderedServices
            // 
            this.dataGridViewOrderedServices.AllowUserToAddRows = false;
            this.dataGridViewOrderedServices.AllowUserToResizeRows = false;
            this.dataGridViewOrderedServices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewOrderedServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderedServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dataGridViewOrderedServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderedServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewOrderedServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrderedServices.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewOrderedServices.EnableHeadersVisualStyles = false;
            this.dataGridViewOrderedServices.GridColor = System.Drawing.Color.Cyan;
            this.dataGridViewOrderedServices.Location = new System.Drawing.Point(0, 439);
            this.dataGridViewOrderedServices.MultiSelect = false;
            this.dataGridViewOrderedServices.Name = "dataGridViewOrderedServices";
            this.dataGridViewOrderedServices.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderedServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewOrderedServices.RowHeadersVisible = false;
            this.dataGridViewOrderedServices.RowHeadersWidth = 49;
            this.dataGridViewOrderedServices.RowTemplate.Height = 24;
            this.dataGridViewOrderedServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderedServices.Size = new System.Drawing.Size(600, 260);
            this.dataGridViewOrderedServices.TabIndex = 88;
            this.dataGridViewOrderedServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderedServices_CellClick);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Lime;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(536, 74);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(64, 31);
            this.btnAddCustomer.TabIndex = 78;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCustomer.Location = new System.Drawing.Point(3, 82);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(0, 16);
            this.lblCustomer.TabIndex = 84;
            // 
            // dataGridViewStayInRoom
            // 
            this.dataGridViewStayInRoom.AllowUserToAddRows = false;
            this.dataGridViewStayInRoom.AllowUserToResizeRows = false;
            this.dataGridViewStayInRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewStayInRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStayInRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dataGridViewStayInRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStayInRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewStayInRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStayInRoom.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewStayInRoom.EnableHeadersVisualStyles = false;
            this.dataGridViewStayInRoom.GridColor = System.Drawing.Color.Cyan;
            this.dataGridViewStayInRoom.Location = new System.Drawing.Point(6, 106);
            this.dataGridViewStayInRoom.MultiSelect = false;
            this.dataGridViewStayInRoom.Name = "dataGridViewStayInRoom";
            this.dataGridViewStayInRoom.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStayInRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewStayInRoom.RowHeadersVisible = false;
            this.dataGridViewStayInRoom.RowHeadersWidth = 49;
            this.dataGridViewStayInRoom.RowTemplate.Height = 24;
            this.dataGridViewStayInRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStayInRoom.Size = new System.Drawing.Size(594, 232);
            this.dataGridViewStayInRoom.TabIndex = 81;
            this.dataGridViewStayInRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStayInRoom_CellClick);
            // 
            // lblCustomerStayIn
            // 
            this.lblCustomerStayIn.AutoSize = true;
            this.lblCustomerStayIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCustomerStayIn.Location = new System.Drawing.Point(0, 87);
            this.lblCustomerStayIn.Name = "lblCustomerStayIn";
            this.lblCustomerStayIn.Size = new System.Drawing.Size(84, 16);
            this.lblCustomerStayIn.TabIndex = 80;
            this.lblCustomerStayIn.Text = "Customers:";
            // 
            // lblOrderedService
            // 
            this.lblOrderedService.AutoSize = true;
            this.lblOrderedService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOrderedService.Location = new System.Drawing.Point(-3, 420);
            this.lblOrderedService.Name = "lblOrderedService";
            this.lblOrderedService.Size = new System.Drawing.Size(133, 16);
            this.lblOrderedService.TabIndex = 78;
            this.lblOrderedService.Text = "Ordered Services:";
            // 
            // lblCheckinTime
            // 
            this.lblCheckinTime.AutoSize = true;
            this.lblCheckinTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCheckinTime.Location = new System.Drawing.Point(12, 118);
            this.lblCheckinTime.Name = "lblCheckinTime";
            this.lblCheckinTime.Size = new System.Drawing.Size(104, 16);
            this.lblCheckinTime.TabIndex = 85;
            this.lblCheckinTime.Text = "Check-in time:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(501, 776);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(129, 31);
            this.btnConfirm.TabIndex = 78;
            this.btnConfirm.Text = "Confirm ✔️";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(673, 776);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 31);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "Cancel 🗙";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblService.Location = new System.Drawing.Point(27, 449);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(113, 16);
            this.lblService.TabIndex = 79;
            this.lblService.Text = "Hotel Services:";
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AllowUserToAddRows = false;
            this.dataGridViewServices.AllowUserToResizeRows = false;
            this.dataGridViewServices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dataGridViewServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewServices.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewServices.EnableHeadersVisualStyles = false;
            this.dataGridViewServices.GridColor = System.Drawing.Color.Cyan;
            this.dataGridViewServices.Location = new System.Drawing.Point(30, 468);
            this.dataGridViewServices.MultiSelect = false;
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewServices.RowHeadersVisible = false;
            this.dataGridViewServices.RowHeadersWidth = 49;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServices.Size = new System.Drawing.Size(600, 260);
            this.dataGridViewServices.TabIndex = 80;
            this.dataGridViewServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServices_CellClick);
            // 
            // dTPCheckinDateTime
            // 
            this.dTPCheckinDateTime.Enabled = false;
            this.dTPCheckinDateTime.Location = new System.Drawing.Point(132, 118);
            this.dTPCheckinDateTime.Name = "dTPCheckinDateTime";
            this.dTPCheckinDateTime.Size = new System.Drawing.Size(230, 22);
            this.dTPCheckinDateTime.TabIndex = 81;
            // 
            // dateTimePickerCheckOutDate
            // 
            this.dateTimePickerCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCheckOutDate.Location = new System.Drawing.Point(132, 144);
            this.dateTimePickerCheckOutDate.Name = "dateTimePickerCheckOutDate";
            this.dateTimePickerCheckOutDate.Size = new System.Drawing.Size(106, 22);
            this.dateTimePickerCheckOutDate.TabIndex = 82;
            this.dateTimePickerCheckOutDate.Visible = false;
            this.dateTimePickerCheckOutDate.ValueChanged += new System.EventHandler(this.dateTimePickerCheckOutDate_ValueChanged);
            // 
            // lblCheckoutTime
            // 
            this.lblCheckoutTime.AutoSize = true;
            this.lblCheckoutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCheckoutTime.Location = new System.Drawing.Point(12, 149);
            this.lblCheckoutTime.Name = "lblCheckoutTime";
            this.lblCheckoutTime.Size = new System.Drawing.Size(113, 16);
            this.lblCheckoutTime.TabIndex = 86;
            this.lblCheckoutTime.Text = "Check-out time:";
            this.lblCheckoutTime.Visible = false;
            // 
            // dateTimePickerCheckOutTime
            // 
            this.dateTimePickerCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerCheckOutTime.Location = new System.Drawing.Point(244, 144);
            this.dateTimePickerCheckOutTime.Name = "dateTimePickerCheckOutTime";
            this.dateTimePickerCheckOutTime.ShowUpDown = true;
            this.dateTimePickerCheckOutTime.Size = new System.Drawing.Size(118, 22);
            this.dateTimePickerCheckOutTime.TabIndex = 87;
            this.dateTimePickerCheckOutTime.Visible = false;
            this.dateTimePickerCheckOutTime.ValueChanged += new System.EventHandler(this.dateTimePickerCheckOutTime_ValueChanged);
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.29565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoomNumber.Location = new System.Drawing.Point(236, 29);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(92, 48);
            this.lblRoomNumber.TabIndex = 89;
            this.lblRoomNumber.Text = "###";
            // 
            // frmPlaceBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 855);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.dateTimePickerCheckOutTime);
            this.Controls.Add(this.lblCheckoutTime);
            this.Controls.Add(this.dateTimePickerCheckOutDate);
            this.Controls.Add(this.dTPCheckinDateTime);
            this.Controls.Add(this.lblCheckinTime);
            this.Controls.Add(this.dataGridViewServices);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBoxBookingDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPlaceBooking";
            this.Text = "frmPlaceBooking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlaceBooking_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.frmPlaceBooking_VisibleChanged);
            this.groupBoxBookingDetail.ResumeLayout(false);
            this.groupBoxBookingDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderedServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStayInRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxBookingDetail;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOrderedService;
        private System.Windows.Forms.DataGridView dataGridViewStayInRoom;
        private System.Windows.Forms.Label lblCustomerStayIn;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Label lblCheckinTime;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DateTimePicker dTPCheckinDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOutDate;
        private System.Windows.Forms.Label lblCheckoutTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOutTime;
        private System.Windows.Forms.DataGridView dataGridViewOrderedServices;
        private System.Windows.Forms.Label lblRoomNumber;
    }
}