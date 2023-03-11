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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.checkBoxVIP = new System.Windows.Forms.CheckBox();
            this.checkBoxReady = new System.Windows.Forms.CheckBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRoom.EnableHeadersVisualStyles = false;
            this.dataGridViewRoom.GridColor = System.Drawing.Color.Cyan;
            this.dataGridViewRoom.Location = new System.Drawing.Point(38, 351);
            this.dataGridViewRoom.MultiSelect = false;
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRoom.RowHeadersVisible = false;
            this.dataGridViewRoom.RowHeadersWidth = 49;
            this.dataGridViewRoom.RowTemplate.Height = 24;
            this.dataGridViewRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewRoom.Size = new System.Drawing.Size(850, 477);
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
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(38, 300);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(74, 25);
            this.comboBoxRoomType.TabIndex = 82;
            this.comboBoxRoomType.Text = "All Type";
            // 
            // checkBoxVIP
            // 
            this.checkBoxVIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxVIP.AutoSize = true;
            this.checkBoxVIP.Location = new System.Drawing.Point(118, 302);
            this.checkBoxVIP.Name = "checkBoxVIP";
            this.checkBoxVIP.Size = new System.Drawing.Size(75, 21);
            this.checkBoxVIP.TabIndex = 83;
            this.checkBoxVIP.Text = "VIP Only";
            this.checkBoxVIP.UseVisualStyleBackColor = true;
            // 
            // checkBoxReady
            // 
            this.checkBoxReady.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxReady.AutoSize = true;
            this.checkBoxReady.Location = new System.Drawing.Point(225, 302);
            this.checkBoxReady.Name = "checkBoxReady";
            this.checkBoxReady.Size = new System.Drawing.Size(63, 21);
            this.checkBoxReady.TabIndex = 84;
            this.checkBoxReady.Text = "Ready";
            this.checkBoxReady.UseVisualStyleBackColor = true;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClearSearch.Location = new System.Drawing.Point(731, 290);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(66, 33);
            this.btnClearSearch.TabIndex = 87;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSearch.Location = new System.Drawing.Point(801, 290);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 33);
            this.btnSearch.TabIndex = 86;
            this.btnSearch.Text = "Search 🔍";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(555, 295);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 25);
            this.txtSearch.TabIndex = 85;
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
            this.panelRoomInfo.Location = new System.Drawing.Point(953, 247);
            this.panelRoomInfo.Name = "panelRoomInfo";
            this.panelRoomInfo.Size = new System.Drawing.Size(295, 581);
            this.panelRoomInfo.TabIndex = 88;
            // 
            // richTextBoxDecription
            // 
            this.richTextBoxDecription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxDecription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.richTextBoxDecription.Location = new System.Drawing.Point(24, 305);
            this.richTextBoxDecription.Name = "richTextBoxDecription";
            this.richTextBoxDecription.ReadOnly = true;
            this.richTextBoxDecription.Size = new System.Drawing.Size(248, 218);
            this.richTextBoxDecription.TabIndex = 11;
            this.richTextBoxDecription.Text = "";
            // 
            // lblDecription
            // 
            this.lblDecription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDecription.AutoSize = true;
            this.lblDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDecription.Location = new System.Drawing.Point(19, 255);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(157, 26);
            this.lblDecription.TabIndex = 10;
            this.lblDecription.Text = "DECRIPTION";
            // 
            // lblStatus2
            // 
            this.lblStatus2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus2.Location = new System.Drawing.Point(199, 164);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(51, 26);
            this.lblStatus2.TabIndex = 9;
            this.lblStatus2.Text = "###";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.Location = new System.Drawing.Point(19, 164);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(103, 26);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "STATUS";
            // 
            // lblVIP2
            // 
            this.lblVIP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVIP2.AutoSize = true;
            this.lblVIP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVIP2.Location = new System.Drawing.Point(199, 203);
            this.lblVIP2.Name = "lblVIP2";
            this.lblVIP2.Size = new System.Drawing.Size(51, 26);
            this.lblVIP2.TabIndex = 7;
            this.lblVIP2.Text = "###";
            // 
            // lblHourCost2
            // 
            this.lblHourCost2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHourCost2.AutoSize = true;
            this.lblHourCost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHourCost2.Location = new System.Drawing.Point(199, 125);
            this.lblHourCost2.Name = "lblHourCost2";
            this.lblHourCost2.Size = new System.Drawing.Size(51, 26);
            this.lblHourCost2.TabIndex = 6;
            this.lblHourCost2.Text = "###";
            // 
            // lblRoomType2
            // 
            this.lblRoomType2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoomType2.AutoSize = true;
            this.lblRoomType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoomType2.Location = new System.Drawing.Point(199, 78);
            this.lblRoomType2.Name = "lblRoomType2";
            this.lblRoomType2.Size = new System.Drawing.Size(51, 26);
            this.lblRoomType2.TabIndex = 5;
            this.lblRoomType2.Text = "###";
            // 
            // lblROOMNUMBER2
            // 
            this.lblROOMNUMBER2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblROOMNUMBER2.AutoSize = true;
            this.lblROOMNUMBER2.Font = new System.Drawing.Font("Segoe UI", 20.03478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblROOMNUMBER2.Location = new System.Drawing.Point(110, 12);
            this.lblROOMNUMBER2.Name = "lblROOMNUMBER2";
            this.lblROOMNUMBER2.Size = new System.Drawing.Size(77, 45);
            this.lblROOMNUMBER2.TabIndex = 4;
            this.lblROOMNUMBER2.Text = "###";
            // 
            // lblVIP
            // 
            this.lblVIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVIP.AutoSize = true;
            this.lblVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVIP.Location = new System.Drawing.Point(19, 203);
            this.lblVIP.Name = "lblVIP";
            this.lblVIP.Size = new System.Drawing.Size(51, 26);
            this.lblVIP.TabIndex = 3;
            this.lblVIP.Text = "VIP";
            // 
            // lblHourCost
            // 
            this.lblHourCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHourCost.AutoSize = true;
            this.lblHourCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHourCost.Location = new System.Drawing.Point(19, 125);
            this.lblHourCost.Name = "lblHourCost";
            this.lblHourCost.Size = new System.Drawing.Size(152, 26);
            this.lblHourCost.TabIndex = 2;
            this.lblHourCost.Text = "HOUR COST";
            // 
            // lblRoomType
            // 
            this.lblRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoomType.Location = new System.Drawing.Point(19, 78);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(153, 26);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "ROOM TYPE";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(361, 91);
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
            // frmRoomBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1318, 900);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRoomInfo);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.checkBoxReady);
            this.Controls.Add(this.checkBoxVIP);
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
        private System.Windows.Forms.CheckBox checkBoxVIP;
        private System.Windows.Forms.CheckBox checkBoxReady;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
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
    }
}