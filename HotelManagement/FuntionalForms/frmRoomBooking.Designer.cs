namespace HotelManagement.FuntionalForms
{
    partial class frmRoomBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.checkBoxReady = new System.Windows.Forms.CheckBox();
            this.panelRoomInfo = new System.Windows.Forms.Panel();
            this.richTextBoxDecription = new System.Windows.Forms.RichTextBox();
            this.lblDecription = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblVIP2 = new System.Windows.Forms.Label();
            this.lblHourCost2 = new System.Windows.Forms.Label();
            this.lblRoomType2 = new System.Windows.Forms.Label();
            this.lblROOMNUMBER2 = new System.Windows.Forms.Label();
            this.lblVIP = new System.Windows.Forms.Label();
            this.lblHourCost = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.panelRoomInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToResizeRows = false;
            this.dataGridViewRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dataGridViewRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoom.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewRoom.EnableHeadersVisualStyles = false;
            this.dataGridViewRoom.GridColor = System.Drawing.Color.Cyan;
            this.dataGridViewRoom.Location = new System.Drawing.Point(7, 261);
            this.dataGridViewRoom.MultiSelect = false;
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewRoom.RowHeadersVisible = false;
            this.dataGridViewRoom.RowHeadersWidth = 49;
            this.dataGridViewRoom.RowTemplate.Height = 24;
            this.dataGridViewRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewRoom.Size = new System.Drawing.Size(644, 394);
            this.dataGridViewRoom.TabIndex = 81;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            this.dataGridViewRoom.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellEnter);
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRoomType.AutoCompleteCustomSource.AddRange(new string[] {
            "All",
            "Single",
            "Double"});
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "All",
            "Single",
            "Double",
            "King",
            "Queen"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(7, 230);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(74, 25);
            this.comboBoxRoomType.TabIndex = 82;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // checkBoxReady
            // 
            this.checkBoxReady.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxReady.AutoSize = true;
            this.checkBoxReady.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBoxReady.Location = new System.Drawing.Point(95, 232);
            this.checkBoxReady.Name = "checkBoxReady";
            this.checkBoxReady.Size = new System.Drawing.Size(94, 21);
            this.checkBoxReady.TabIndex = 84;
            this.checkBoxReady.Text = "Ready only";
            this.checkBoxReady.UseVisualStyleBackColor = true;
            this.checkBoxReady.CheckedChanged += new System.EventHandler(this.checkBoxReady_CheckedChanged);
            // 
            // panelRoomInfo
            // 
            this.panelRoomInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRoomInfo.Controls.Add(this.richTextBoxDecription);
            this.panelRoomInfo.Controls.Add(this.lblDecription);
            this.panelRoomInfo.Controls.Add(this.lblStatus2);
            this.panelRoomInfo.Controls.Add(this.lblStatus);
            this.panelRoomInfo.Controls.Add(this.lblVIP2);
            this.panelRoomInfo.Controls.Add(this.lblHourCost2);
            this.panelRoomInfo.Controls.Add(this.lblRoomType2);
            this.panelRoomInfo.Controls.Add(this.lblROOMNUMBER2);
            this.panelRoomInfo.Controls.Add(this.lblVIP);
            this.panelRoomInfo.Controls.Add(this.lblHourCost);
            this.panelRoomInfo.Controls.Add(this.lblRoomType);
            this.panelRoomInfo.Location = new System.Drawing.Point(657, 226);
            this.panelRoomInfo.Name = "panelRoomInfo";
            this.panelRoomInfo.Size = new System.Drawing.Size(221, 429);
            this.panelRoomInfo.TabIndex = 88;
            // 
            // richTextBoxDecription
            // 
            this.richTextBoxDecription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxDecription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.richTextBoxDecription.Location = new System.Drawing.Point(7, 313);
            this.richTextBoxDecription.Name = "richTextBoxDecription";
            this.richTextBoxDecription.ReadOnly = true;
            this.richTextBoxDecription.Size = new System.Drawing.Size(203, 100);
            this.richTextBoxDecription.TabIndex = 11;
            this.richTextBoxDecription.Text = "";
            // 
            // lblDecription
            // 
            this.lblDecription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDecription.AutoSize = true;
            this.lblDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDecription.Location = new System.Drawing.Point(3, 262);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(157, 26);
            this.lblDecription.TabIndex = 10;
            this.lblDecription.Text = "DECRIPTION";
            // 
            // lblStatus2
            // 
            this.lblStatus2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblStatus2.Location = new System.Drawing.Point(122, 171);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(39, 20);
            this.lblStatus2.TabIndex = 9;
            this.lblStatus2.Text = "###";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblStatus.Location = new System.Drawing.Point(3, 171);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "STATUS";
            // 
            // lblVIP2
            // 
            this.lblVIP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVIP2.AutoSize = true;
            this.lblVIP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblVIP2.Location = new System.Drawing.Point(122, 210);
            this.lblVIP2.Name = "lblVIP2";
            this.lblVIP2.Size = new System.Drawing.Size(39, 20);
            this.lblVIP2.TabIndex = 7;
            this.lblVIP2.Text = "###";
            // 
            // lblHourCost2
            // 
            this.lblHourCost2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHourCost2.AutoSize = true;
            this.lblHourCost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHourCost2.Location = new System.Drawing.Point(122, 132);
            this.lblHourCost2.Name = "lblHourCost2";
            this.lblHourCost2.Size = new System.Drawing.Size(39, 20);
            this.lblHourCost2.TabIndex = 6;
            this.lblHourCost2.Text = "###";
            // 
            // lblRoomType2
            // 
            this.lblRoomType2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoomType2.AutoSize = true;
            this.lblRoomType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblRoomType2.Location = new System.Drawing.Point(121, 85);
            this.lblRoomType2.Name = "lblRoomType2";
            this.lblRoomType2.Size = new System.Drawing.Size(39, 20);
            this.lblRoomType2.TabIndex = 5;
            this.lblRoomType2.Text = "###";
            // 
            // lblROOMNUMBER2
            // 
            this.lblROOMNUMBER2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblROOMNUMBER2.AutoSize = true;
            this.lblROOMNUMBER2.Font = new System.Drawing.Font("Segoe UI", 20.03478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblROOMNUMBER2.Location = new System.Drawing.Point(67, 0);
            this.lblROOMNUMBER2.Name = "lblROOMNUMBER2";
            this.lblROOMNUMBER2.Size = new System.Drawing.Size(77, 45);
            this.lblROOMNUMBER2.TabIndex = 4;
            this.lblROOMNUMBER2.Text = "###";
            // 
            // lblVIP
            // 
            this.lblVIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVIP.AutoSize = true;
            this.lblVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblVIP.Location = new System.Drawing.Point(3, 210);
            this.lblVIP.Name = "lblVIP";
            this.lblVIP.Size = new System.Drawing.Size(38, 20);
            this.lblVIP.TabIndex = 3;
            this.lblVIP.Text = "VIP";
            // 
            // lblHourCost
            // 
            this.lblHourCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHourCost.AutoSize = true;
            this.lblHourCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHourCost.Location = new System.Drawing.Point(3, 132);
            this.lblHourCost.Name = "lblHourCost";
            this.lblHourCost.Size = new System.Drawing.Size(113, 20);
            this.lblHourCost.TabIndex = 2;
            this.lblHourCost.Text = "HOUR COST";
            // 
            // lblRoomType
            // 
            this.lblRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblRoomType.Location = new System.Drawing.Point(3, 85);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(112, 20);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "ROOM TYPE";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(194, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 85);
            this.panel1.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30.20869F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Management";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(232)))), ((int)(((byte)(90)))));
            this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(7, 661);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 16);
            this.panel2.TabIndex = 90;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.panel3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(100, 661);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 16);
            this.panel3.TabIndex = 91;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(232)))), ((int)(((byte)(90)))));
            this.panel4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel4.Location = new System.Drawing.Point(228, 661);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(36, 16);
            this.panel4.TabIndex = 92;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(137)))), ((int)(((byte)(73)))));
            this.panel5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel5.Location = new System.Drawing.Point(343, 662);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(36, 16);
            this.panel5.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(40, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Ready";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(142, 661);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 95;
            this.label3.Text = "Being used";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(270, 661);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 96;
            this.label4.Text = "Cleaning";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(385, 662);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 97;
            this.label5.Text = "Fixing";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClearSearch.Location = new System.Drawing.Point(492, 226);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(66, 29);
            this.btnClearSearch.TabIndex = 100;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 8.260869F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(564, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 29);
            this.btnSearch.TabIndex = 99;
            this.btnSearch.Text = "Search 🔍";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(301, 226);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 29);
            this.txtSearch.TabIndex = 98;
            // 
            // frmRoomBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(880, 720);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRoomInfo);
            this.Controls.Add(this.checkBoxReady);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.dataGridViewRoom);
            this.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRoomBooking";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "frmRoomBooking";
            this.VisibleChanged += new System.EventHandler(this.frmRoomBooking_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.panelRoomInfo.ResumeLayout(false);
            this.panelRoomInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.CheckBox checkBoxReady;
        private System.Windows.Forms.Panel panelRoomInfo;
        private System.Windows.Forms.RichTextBox richTextBoxDecription;
        private System.Windows.Forms.Label lblDecription;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblVIP2;
        private System.Windows.Forms.Label lblHourCost2;
        private System.Windows.Forms.Label lblRoomType2;
        private System.Windows.Forms.Label lblROOMNUMBER2;
        private System.Windows.Forms.Label lblVIP;
        private System.Windows.Forms.Label lblHourCost;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}