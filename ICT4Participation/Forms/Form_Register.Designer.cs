namespace ICT4Participation
{
    partial class Form_Register
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
            this.lbl_Registration = new System.Windows.Forms.Label();
            this.gbox_SelectRole = new System.Windows.Forms.GroupBox();
            this.rbtn_Volunteer = new System.Windows.Forms.RadioButton();
            this.rbtn_Client = new System.Windows.Forms.RadioButton();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_DateOfBirth = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.pnl_VOGInfo = new System.Windows.Forms.Panel();
            this.lbl_VOGPath = new System.Windows.Forms.Label();
            this.tbox_VolunteerInfoDoNotUse = new System.Windows.Forms.TextBox();
            this.btn_VOGUpload = new System.Windows.Forms.Button();
            this.lbl_VOG = new System.Windows.Forms.Label();
            this.tbox_Email = new System.Windows.Forms.TextBox();
            this.tbox_Password = new System.Windows.Forms.TextBox();
            this.tbox_Name = new System.Windows.Forms.TextBox();
            this.tbox_City = new System.Windows.Forms.TextBox();
            this.tbox_Address = new System.Windows.Forms.TextBox();
            this.cbox_Gender = new System.Windows.Forms.ComboBox();
            this.dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbox_SelectRole.SuspendLayout();
            this.pnl_VOGInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Registration
            // 
            this.lbl_Registration.AutoSize = true;
            this.lbl_Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registration.ForeColor = System.Drawing.Color.White;
            this.lbl_Registration.Location = new System.Drawing.Point(62, 9);
            this.lbl_Registration.Name = "lbl_Registration";
            this.lbl_Registration.Size = new System.Drawing.Size(282, 24);
            this.lbl_Registration.TabIndex = 0;
            this.lbl_Registration.Text = "Welkom bij ICT4Participation!";
            // 
            // gbox_SelectRole
            // 
            this.gbox_SelectRole.Controls.Add(this.rbtn_Volunteer);
            this.gbox_SelectRole.Controls.Add(this.rbtn_Client);
            this.gbox_SelectRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_SelectRole.ForeColor = System.Drawing.Color.White;
            this.gbox_SelectRole.Location = new System.Drawing.Point(95, 262);
            this.gbox_SelectRole.Name = "gbox_SelectRole";
            this.gbox_SelectRole.Size = new System.Drawing.Size(230, 74);
            this.gbox_SelectRole.TabIndex = 8;
            this.gbox_SelectRole.TabStop = false;
            this.gbox_SelectRole.Text = "Ik ben een:";
            // 
            // rbtn_Volunteer
            // 
            this.rbtn_Volunteer.AutoSize = true;
            this.rbtn_Volunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Volunteer.ForeColor = System.Drawing.Color.White;
            this.rbtn_Volunteer.Location = new System.Drawing.Point(6, 46);
            this.rbtn_Volunteer.Name = "rbtn_Volunteer";
            this.rbtn_Volunteer.Size = new System.Drawing.Size(90, 22);
            this.rbtn_Volunteer.TabIndex = 1;
            this.rbtn_Volunteer.TabStop = true;
            this.rbtn_Volunteer.Text = "Vrijwilliger";
            this.rbtn_Volunteer.UseVisualStyleBackColor = true;
            this.rbtn_Volunteer.CheckedChanged += new System.EventHandler(this.rbtn_Volunteer_CheckedChanged);
            // 
            // rbtn_Client
            // 
            this.rbtn_Client.AutoSize = true;
            this.rbtn_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Client.ForeColor = System.Drawing.Color.White;
            this.rbtn_Client.Location = new System.Drawing.Point(6, 23);
            this.rbtn_Client.Name = "rbtn_Client";
            this.rbtn_Client.Size = new System.Drawing.Size(121, 22);
            this.rbtn_Client.TabIndex = 0;
            this.rbtn_Client.TabStop = true;
            this.rbtn_Client.Text = "Hulpzoekende";
            this.rbtn_Client.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_OK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(49, 458);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 35);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(278, 456);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 35);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Annuleer";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.White;
            this.lbl_Email.Location = new System.Drawing.Point(92, 46);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(50, 18);
            this.lbl_Email.TabIndex = 11;
            this.lbl_Email.Text = "E-Mail";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.White;
            this.lbl_Password.Location = new System.Drawing.Point(49, 76);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(93, 18);
            this.lbl_Password.TabIndex = 12;
            this.lbl_Password.Text = "Wachtwoord";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(31, 106);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(111, 18);
            this.lbl_Name.TabIndex = 13;
            this.lbl_Name.Text = "Volledige Naam";
            // 
            // lbl_DateOfBirth
            // 
            this.lbl_DateOfBirth.AutoSize = true;
            this.lbl_DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lbl_DateOfBirth.Location = new System.Drawing.Point(30, 136);
            this.lbl_DateOfBirth.Name = "lbl_DateOfBirth";
            this.lbl_DateOfBirth.Size = new System.Drawing.Size(112, 18);
            this.lbl_DateOfBirth.TabIndex = 14;
            this.lbl_DateOfBirth.Text = "Geboortedatum";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.White;
            this.lbl_Gender.Location = new System.Drawing.Point(75, 164);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(67, 18);
            this.lbl_Gender.TabIndex = 15;
            this.lbl_Gender.Text = "Geslacht";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.ForeColor = System.Drawing.Color.White;
            this.lbl_City.Location = new System.Drawing.Point(54, 196);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(88, 18);
            this.lbl_City.TabIndex = 16;
            this.lbl_City.Text = "Woonplaats";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.White;
            this.lbl_Address.Location = new System.Drawing.Point(96, 226);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(46, 18);
            this.lbl_Address.TabIndex = 17;
            this.lbl_Address.Text = "Adres";
            // 
            // pnl_VOGInfo
            // 
            this.pnl_VOGInfo.Controls.Add(this.lbl_VOGPath);
            this.pnl_VOGInfo.Controls.Add(this.tbox_VolunteerInfoDoNotUse);
            this.pnl_VOGInfo.Controls.Add(this.btn_VOGUpload);
            this.pnl_VOGInfo.Controls.Add(this.lbl_VOG);
            this.pnl_VOGInfo.Location = new System.Drawing.Point(66, 340);
            this.pnl_VOGInfo.Name = "pnl_VOGInfo";
            this.pnl_VOGInfo.Size = new System.Drawing.Size(288, 107);
            this.pnl_VOGInfo.TabIndex = 18;
            this.pnl_VOGInfo.Visible = false;
            // 
            // lbl_VOGPath
            // 
            this.lbl_VOGPath.AutoSize = true;
            this.lbl_VOGPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VOGPath.ForeColor = System.Drawing.Color.White;
            this.lbl_VOGPath.Location = new System.Drawing.Point(66, 11);
            this.lbl_VOGPath.MaximumSize = new System.Drawing.Size(78, 18);
            this.lbl_VOGPath.Name = "lbl_VOGPath";
            this.lbl_VOGPath.Size = new System.Drawing.Size(78, 18);
            this.lbl_VOGPath.TabIndex = 18;
            this.lbl_VOGPath.Text = "<bestand>";
            // 
            // tbox_VolunteerInfoDoNotUse
            // 
            this.tbox_VolunteerInfoDoNotUse.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbox_VolunteerInfoDoNotUse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_VolunteerInfoDoNotUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_VolunteerInfoDoNotUse.ForeColor = System.Drawing.Color.White;
            this.tbox_VolunteerInfoDoNotUse.Location = new System.Drawing.Point(35, 38);
            this.tbox_VolunteerInfoDoNotUse.Multiline = true;
            this.tbox_VolunteerInfoDoNotUse.Name = "tbox_VolunteerInfoDoNotUse";
            this.tbox_VolunteerInfoDoNotUse.ReadOnly = true;
            this.tbox_VolunteerInfoDoNotUse.Size = new System.Drawing.Size(238, 60);
            this.tbox_VolunteerInfoDoNotUse.TabIndex = 15;
            this.tbox_VolunteerInfoDoNotUse.Text = "*Als vrijwilliger is een verklaring omtrent gedrag benodigd. Deze kunt u aanvrage" +
    "n bij uw gemeente. ";
            // 
            // btn_VOGUpload
            // 
            this.btn_VOGUpload.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_VOGUpload.FlatAppearance.BorderSize = 0;
            this.btn_VOGUpload.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_VOGUpload.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_VOGUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VOGUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VOGUpload.Location = new System.Drawing.Point(147, 8);
            this.btn_VOGUpload.Name = "btn_VOGUpload";
            this.btn_VOGUpload.Size = new System.Drawing.Size(125, 24);
            this.btn_VOGUpload.TabIndex = 14;
            this.btn_VOGUpload.Text = "Upload...";
            this.btn_VOGUpload.UseVisualStyleBackColor = false;
            this.btn_VOGUpload.Click += new System.EventHandler(this.btn_VOGUpload_Click);
            // 
            // lbl_VOG
            // 
            this.lbl_VOG.AutoSize = true;
            this.lbl_VOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VOG.ForeColor = System.Drawing.Color.White;
            this.lbl_VOG.Location = new System.Drawing.Point(7, 11);
            this.lbl_VOG.Name = "lbl_VOG";
            this.lbl_VOG.Size = new System.Drawing.Size(53, 18);
            this.lbl_VOG.TabIndex = 12;
            this.lbl_VOG.Text = "V.O.G.";
            // 
            // tbox_Email
            // 
            this.tbox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Email.Location = new System.Drawing.Point(158, 43);
            this.tbox_Email.Name = "tbox_Email";
            this.tbox_Email.Size = new System.Drawing.Size(201, 24);
            this.tbox_Email.TabIndex = 19;
            // 
            // tbox_Password
            // 
            this.tbox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Password.Location = new System.Drawing.Point(158, 73);
            this.tbox_Password.Name = "tbox_Password";
            this.tbox_Password.PasswordChar = '■';
            this.tbox_Password.Size = new System.Drawing.Size(201, 24);
            this.tbox_Password.TabIndex = 20;
            // 
            // tbox_Name
            // 
            this.tbox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Name.Location = new System.Drawing.Point(158, 103);
            this.tbox_Name.Name = "tbox_Name";
            this.tbox_Name.Size = new System.Drawing.Size(201, 24);
            this.tbox_Name.TabIndex = 22;
            // 
            // tbox_City
            // 
            this.tbox_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_City.Location = new System.Drawing.Point(158, 193);
            this.tbox_City.Name = "tbox_City";
            this.tbox_City.Size = new System.Drawing.Size(201, 24);
            this.tbox_City.TabIndex = 24;
            // 
            // tbox_Address
            // 
            this.tbox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Address.Location = new System.Drawing.Point(158, 223);
            this.tbox_Address.Name = "tbox_Address";
            this.tbox_Address.Size = new System.Drawing.Size(201, 24);
            this.tbox_Address.TabIndex = 25;
            // 
            // cbox_Gender
            // 
            this.cbox_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Gender.FormattingEnabled = true;
            this.cbox_Gender.Items.AddRange(new object[] {
            "Man",
            "Vrouw"});
            this.cbox_Gender.Location = new System.Drawing.Point(158, 161);
            this.cbox_Gender.Name = "cbox_Gender";
            this.cbox_Gender.Size = new System.Drawing.Size(201, 26);
            this.cbox_Gender.TabIndex = 26;
            // 
            // dtp_DateOfBirth
            // 
            this.dtp_DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateOfBirth.Location = new System.Drawing.Point(158, 131);
            this.dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            this.dtp_DateOfBirth.Size = new System.Drawing.Size(201, 24);
            this.dtp_DateOfBirth.TabIndex = 27;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "VOG";
            this.OpenFileDialog.Filter = "\"PDF file|*.pdf|All Files|*.*\"";
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(416, 503);
            this.Controls.Add(this.dtp_DateOfBirth);
            this.Controls.Add(this.cbox_Gender);
            this.Controls.Add(this.tbox_Address);
            this.Controls.Add(this.tbox_City);
            this.Controls.Add(this.tbox_Name);
            this.Controls.Add(this.tbox_Password);
            this.Controls.Add(this.tbox_Email);
            this.Controls.Add(this.pnl_VOGInfo);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_DateOfBirth);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.gbox_SelectRole);
            this.Controls.Add(this.lbl_Registration);
            this.Name = "Form_Register";
            this.ShowIcon = false;
            this.Text = "Registratie";
            this.gbox_SelectRole.ResumeLayout(false);
            this.gbox_SelectRole.PerformLayout();
            this.pnl_VOGInfo.ResumeLayout(false);
            this.pnl_VOGInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Registration;
        private System.Windows.Forms.GroupBox gbox_SelectRole;
        private System.Windows.Forms.RadioButton rbtn_Volunteer;
        private System.Windows.Forms.RadioButton rbtn_Client;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_DateOfBirth;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Panel pnl_VOGInfo;
        private System.Windows.Forms.Button btn_VOGUpload;
        private System.Windows.Forms.Label lbl_VOG;
        private System.Windows.Forms.TextBox tbox_VolunteerInfoDoNotUse;
        private System.Windows.Forms.Label lbl_VOGPath;
        private System.Windows.Forms.TextBox tbox_Email;
        private System.Windows.Forms.TextBox tbox_Password;
        private System.Windows.Forms.TextBox tbox_Name;
        private System.Windows.Forms.TextBox tbox_City;
        private System.Windows.Forms.TextBox tbox_Address;
        private System.Windows.Forms.ComboBox cbox_Gender;
        private System.Windows.Forms.DateTimePicker dtp_DateOfBirth;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}