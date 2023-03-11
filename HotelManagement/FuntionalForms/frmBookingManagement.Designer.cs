namespace HotelManagement.FuntionalForms
{
    partial class frmBookingManagement
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
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToResizeRows = false;
            this.dgvBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dgvBooking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooking.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBooking.EnableHeadersVisualStyles = false;
            this.dgvBooking.GridColor = System.Drawing.Color.Cyan;
            this.dgvBooking.Location = new System.Drawing.Point(55, 220);
            this.dgvBooking.MultiSelect = false;
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooking.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBooking.RowHeadersVisible = false;
            this.dgvBooking.RowHeadersWidth = 49;
            this.dgvBooking.RowTemplate.Height = 24;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBooking.Size = new System.Drawing.Size(1193, 584);
            this.dgvBooking.TabIndex = 82;
            this.dgvBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellClick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 30.20869F, System.Drawing.FontStyle.Bold);
            this.lbl.Location = new System.Drawing.Point(381, 29);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(525, 66);
            this.lbl.TabIndex = 83;
            this.lbl.Text = "Booking Management";
            // 
            // frmBookingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 855);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dgvBooking);
            this.MaximumSize = new System.Drawing.Size(1318, 900);
            this.MinimumSize = new System.Drawing.Size(1318, 900);
            this.Name = "frmBookingManagement";
            this.Text = "frmBookingManagement";
            this.VisibleChanged += new System.EventHandler(this.frmBookingManagement_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label lbl;
    }
}