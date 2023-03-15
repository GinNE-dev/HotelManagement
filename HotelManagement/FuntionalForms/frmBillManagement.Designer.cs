namespace HotelManagement.FuntionalForms
{
    partial class frmBillManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillManagement));
            this.lbl = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBillTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBillNumber = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.lblRoomFee = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblServiceCost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblExtraFee = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 30.20869F, System.Drawing.FontStyle.Bold);
            this.lbl.Location = new System.Drawing.Point(232, 38);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(408, 66);
            this.lbl.TabIndex = 85;
            this.lbl.Text = "Bill Management";
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBill.EnableHeadersVisualStyles = false;
            this.dgvBill.GridColor = System.Drawing.Color.Cyan;
            this.dgvBill.Location = new System.Drawing.Point(12, 211);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 49;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(619, 448);
            this.dgvBill.TabIndex = 84;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            this.dgvBill.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellEnter);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblExtraFee);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblServiceCost);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblRoomFee);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTotalCost);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblStaff);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblBillTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(637, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 483);
            this.panel1.TabIndex = 86;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI Semibold", 10.77391F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.Location = new System.Drawing.Point(90, 238);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(78, 25);
            this.lblTotalCost.TabIndex = 96;
            this.lblTotalCost.Text = "######";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.773913F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 95;
            this.label5.Text = "TOTAL";
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 8.773913F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.Location = new System.Drawing.Point(87, 80);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(63, 20);
            this.lblCustomer.TabIndex = 92;
            this.lblCustomer.Text = "######";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(0, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 91;
            this.label3.Text = "CUSTOMER";
            // 
            // lblStaff
            // 
            this.lblStaff.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 8.773913F, System.Drawing.FontStyle.Bold);
            this.lblStaff.Location = new System.Drawing.Point(87, 109);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(63, 20);
            this.lblStaff.TabIndex = 90;
            this.lblStaff.Text = "######";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 89;
            this.label2.Text = "STAFF";
            // 
            // lblBillTime
            // 
            this.lblBillTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBillTime.AutoSize = true;
            this.lblBillTime.Font = new System.Drawing.Font("Segoe UI Semibold", 8.773913F, System.Drawing.FontStyle.Bold);
            this.lblBillTime.Location = new System.Drawing.Point(87, 49);
            this.lblBillTime.Name = "lblBillTime";
            this.lblBillTime.Size = new System.Drawing.Size(63, 20);
            this.lblBillTime.TabIndex = 88;
            this.lblBillTime.Text = "######";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "BILL TIME";
            // 
            // lblBillNumber
            // 
            this.lblBillNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBillNumber.AutoSize = true;
            this.lblBillNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 8.773913F, System.Drawing.FontStyle.Bold);
            this.lblBillNumber.Location = new System.Drawing.Point(276, 104);
            this.lblBillNumber.Name = "lblBillNumber";
            this.lblBillNumber.Size = new System.Drawing.Size(63, 20);
            this.lblBillNumber.TabIndex = 94;
            this.lblBillNumber.Text = "######";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClearSearch.Location = new System.Drawing.Point(471, 176);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(66, 29);
            this.btnClearSearch.TabIndex = 106;
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
            this.btnSearch.Location = new System.Drawing.Point(543, 176);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 29);
            this.btnSearch.TabIndex = 105;
            this.btnSearch.Text = "Search 🔍";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(280, 176);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 29);
            this.txtSearch.TabIndex = 104;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // lblRoomFee
            // 
            this.lblRoomFee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRoomFee.AutoSize = true;
            this.lblRoomFee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.77391F, System.Drawing.FontStyle.Bold);
            this.lblRoomFee.Location = new System.Drawing.Point(90, 168);
            this.lblRoomFee.Name = "lblRoomFee";
            this.lblRoomFee.Size = new System.Drawing.Size(78, 25);
            this.lblRoomFee.TabIndex = 98;
            this.lblRoomFee.Text = "######";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.773913F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "ROOM FEE";
            // 
            // lblServiceCost
            // 
            this.lblServiceCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblServiceCost.AutoSize = true;
            this.lblServiceCost.Font = new System.Drawing.Font("Segoe UI Semibold", 10.77391F, System.Drawing.FontStyle.Bold);
            this.lblServiceCost.Location = new System.Drawing.Point(90, 210);
            this.lblServiceCost.Name = "lblServiceCost";
            this.lblServiceCost.Size = new System.Drawing.Size(78, 25);
            this.lblServiceCost.TabIndex = 100;
            this.lblServiceCost.Text = "######";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8.773913F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 99;
            this.label8.Text = "SERVICES";
            // 
            // lblExtraFee
            // 
            this.lblExtraFee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExtraFee.AutoSize = true;
            this.lblExtraFee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.77391F, System.Drawing.FontStyle.Bold);
            this.lblExtraFee.Location = new System.Drawing.Point(90, 188);
            this.lblExtraFee.Name = "lblExtraFee";
            this.lblExtraFee.Size = new System.Drawing.Size(78, 25);
            this.lblExtraFee.TabIndex = 102;
            this.lblExtraFee.Text = "######";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.773913F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 101;
            this.label7.Text = "EXTRA FEE";
            // 
            // frmBillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(880, 700);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblBillNumber);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dgvBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBillManagement";
            this.Text = "frmBillManagement";
            this.VisibleChanged += new System.EventHandler(this.frmBillManagement_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBillNumber;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBillTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Label lblServiceCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRoomFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExtraFee;
        private System.Windows.Forms.Label label7;
    }
}