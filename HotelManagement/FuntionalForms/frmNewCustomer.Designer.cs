namespace HotelManagement.FuntionalForms
{
    partial class frmNewCustomer
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.blbAge = new System.Windows.Forms.Label();
            this.nUDAge = new System.Windows.Forms.NumericUpDown();
            this.lblGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.lblCitizenID = new System.Windows.Forms.Label();
            this.mtxtCitizenID = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(91, 227);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(99, 31);
            this.btnConfirm.TabIndex = 57;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 22);
            this.txtEmail.TabIndex = 56;
            this.txtEmail.Text = "@gmail.com";
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(108, 128);
            this.mtxtPhone.Mask = "0000-000-000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(143, 22);
            this.mtxtPhone.TabIndex = 55;
            this.mtxtPhone.Leave += new System.EventHandler(this.mtxtPhone_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(30, 161);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 52;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(30, 131);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 16);
            this.lblPhone.TabIndex = 51;
            this.lblPhone.Text = "Phone";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.Location = new System.Drawing.Point(30, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 50;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 22);
            this.txtName.TabIndex = 49;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // blbAge
            // 
            this.blbAge.AutoSize = true;
            this.blbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.blbAge.Location = new System.Drawing.Point(30, 67);
            this.blbAge.Name = "blbAge";
            this.blbAge.Size = new System.Drawing.Size(35, 16);
            this.blbAge.TabIndex = 59;
            this.blbAge.Text = "Age";
            // 
            // nUDAge
            // 
            this.nUDAge.Location = new System.Drawing.Point(108, 65);
            this.nUDAge.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nUDAge.Name = "nUDAge";
            this.nUDAge.Size = new System.Drawing.Size(143, 22);
            this.nUDAge.TabIndex = 60;
            this.nUDAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGender.Location = new System.Drawing.Point(30, 102);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(58, 16);
            this.lblGender.TabIndex = 61;
            this.lblGender.Text = "Gender";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(108, 93);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(143, 24);
            this.comboBoxGender.TabIndex = 62;
            this.comboBoxGender.Text = "Male";
            this.comboBoxGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxGender_KeyPress);
            // 
            // lblCitizenID
            // 
            this.lblCitizenID.AutoSize = true;
            this.lblCitizenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold);
            this.lblCitizenID.Location = new System.Drawing.Point(30, 189);
            this.lblCitizenID.Name = "lblCitizenID";
            this.lblCitizenID.Size = new System.Drawing.Size(72, 16);
            this.lblCitizenID.TabIndex = 53;
            this.lblCitizenID.Text = "Citizen ID";
            // 
            // mtxtCitizenID
            // 
            this.mtxtCitizenID.Location = new System.Drawing.Point(108, 183);
            this.mtxtCitizenID.Mask = "000000000000";
            this.mtxtCitizenID.Name = "mtxtCitizenID";
            this.mtxtCitizenID.Size = new System.Drawing.Size(143, 22);
            this.mtxtCitizenID.TabIndex = 63;
            this.mtxtCitizenID.Leave += new System.EventHandler(this.mtxtCitizenID_Leave);
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(304, 275);
            this.Controls.Add(this.mtxtCitizenID);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.nUDAge);
            this.Controls.Add(this.blbAge);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.lblCitizenID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewCustomer";
            this.Text = "frmNewCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.nUDAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label blbAge;
        private System.Windows.Forms.NumericUpDown nUDAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label lblCitizenID;
        private System.Windows.Forms.MaskedTextBox mtxtCitizenID;
    }
}