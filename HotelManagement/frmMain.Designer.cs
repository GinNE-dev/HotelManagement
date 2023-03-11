namespace HotelManagement
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRoom = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuButtton = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBookingManagement = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButtton)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMain.Controls.Add(this.panel5);
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.MaximumSize = new System.Drawing.Size(200, 855);
            this.panelMain.MinimumSize = new System.Drawing.Size(70, 855);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(200, 855);
            this.panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButtton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 112);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(0, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(194, 44);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 1;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRoom);
            this.panel3.Location = new System.Drawing.Point(0, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 50);
            this.panel3.TabIndex = 4;
            // 
            // btnRoom
            // 
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Location = new System.Drawing.Point(3, 3);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(194, 44);
            this.btnRoom.TabIndex = 3;
            this.btnRoom.Text = "Room";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Location = new System.Drawing.Point(0, 286);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 50);
            this.panel4.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuButtton
            // 
            this.menuButtton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButtton.Location = new System.Drawing.Point(12, 26);
            this.menuButtton.Name = "menuButtton";
            this.menuButtton.Size = new System.Drawing.Size(50, 49);
            this.menuButtton.TabIndex = 1;
            this.menuButtton.TabStop = false;
            this.menuButtton.Click += new System.EventHandler(this.menuButtton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnBookingManagement);
            this.panel5.Location = new System.Drawing.Point(0, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 50);
            this.panel5.TabIndex = 6;
            // 
            // btnBookingManagement
            // 
            this.btnBookingManagement.FlatAppearance.BorderSize = 0;
            this.btnBookingManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBookingManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingManagement.ForeColor = System.Drawing.Color.White;
            this.btnBookingManagement.Location = new System.Drawing.Point(3, 3);
            this.btnBookingManagement.Name = "btnBookingManagement";
            this.btnBookingManagement.Size = new System.Drawing.Size(194, 44);
            this.btnBookingManagement.TabIndex = 3;
            this.btnBookingManagement.Text = "Booking";
            this.btnBookingManagement.UseVisualStyleBackColor = true;
            this.btnBookingManagement.Click += new System.EventHandler(this.btnBookingManagement_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1582, 855);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Hotel Maneger";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButtton)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox menuButtton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBookingManagement;
    }
}