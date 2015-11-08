namespace ICT4Participation
{
    partial class Form_MainVolunteer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainVolunteer));
            this.lbox_Questions = new System.Windows.Forms.ListBox();
            this.lbl_LoggedinInfo = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_Respond = new System.Windows.Forms.Button();
            this.gbox_Questions = new System.Windows.Forms.GroupBox();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.gbox_Questions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbox_Questions
            // 
            this.lbox_Questions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_Questions.FormattingEnabled = true;
            this.lbox_Questions.ItemHeight = 18;
            this.lbox_Questions.Location = new System.Drawing.Point(11, 22);
            this.lbox_Questions.Margin = new System.Windows.Forms.Padding(2);
            this.lbox_Questions.Name = "lbox_Questions";
            this.lbox_Questions.Size = new System.Drawing.Size(333, 202);
            this.lbox_Questions.TabIndex = 0;
            // 
            // lbl_LoggedinInfo
            // 
            this.lbl_LoggedinInfo.AutoSize = true;
            this.lbl_LoggedinInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_LoggedinInfo.ForeColor = System.Drawing.Color.White;
            this.lbl_LoggedinInfo.Location = new System.Drawing.Point(11, 10);
            this.lbl_LoggedinInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LoggedinInfo.Name = "lbl_LoggedinInfo";
            this.lbl_LoggedinInfo.Size = new System.Drawing.Size(90, 18);
            this.lbl_LoggedinInfo.TabIndex = 1;
            this.lbl_LoggedinInfo.Text = "Ingelogd als:";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_UserName.ForeColor = System.Drawing.Color.White;
            this.lbl_UserName.Location = new System.Drawing.Point(105, 10);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(103, 18);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "< User name>";
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.White;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_profile.ForeColor = System.Drawing.Color.Black;
            this.btn_profile.Location = new System.Drawing.Point(14, 39);
            this.btn_profile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(146, 30);
            this.btn_profile.TabIndex = 3;
            this.btn_profile.Text = "Mijn Profiel";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_Respond
            // 
            this.btn_Respond.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Respond.BackColor = System.Drawing.Color.White;
            this.btn_Respond.FlatAppearance.BorderSize = 0;
            this.btn_Respond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Respond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Respond.ForeColor = System.Drawing.Color.Black;
            this.btn_Respond.Location = new System.Drawing.Point(84, 238);
            this.btn_Respond.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Respond.Name = "btn_Respond";
            this.btn_Respond.Size = new System.Drawing.Size(195, 30);
            this.btn_Respond.TabIndex = 4;
            this.btn_Respond.Text = "Reageer";
            this.btn_Respond.UseVisualStyleBackColor = false;
            this.btn_Respond.Click += new System.EventHandler(this.btn_Respond_Click);
            // 
            // gbox_Questions
            // 
            this.gbox_Questions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_Questions.Controls.Add(this.lbox_Questions);
            this.gbox_Questions.Controls.Add(this.btn_Respond);
            this.gbox_Questions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gbox_Questions.ForeColor = System.Drawing.Color.White;
            this.gbox_Questions.Location = new System.Drawing.Point(14, 74);
            this.gbox_Questions.Name = "gbox_Questions";
            this.gbox_Questions.Size = new System.Drawing.Size(355, 273);
            this.gbox_Questions.TabIndex = 6;
            this.gbox_Questions.TabStop = false;
            this.gbox_Questions.Text = "Vragen";
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteUser.BackColor = System.Drawing.Color.IndianRed;
            this.btn_DeleteUser.FlatAppearance.BorderSize = 0;
            this.btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.Black;
            this.btn_DeleteUser.Location = new System.Drawing.Point(223, 39);
            this.btn_DeleteUser.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(146, 30);
            this.btn_DeleteUser.TabIndex = 7;
            this.btn_DeleteUser.Text = "Account Verwijderen";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // timer_Refresh
            // 
            this.timer_Refresh.Interval = 30000;
            this.timer_Refresh.Tick += new System.EventHandler(this.timer_Refresh_Tick);
            // 
            // Form_MainVolunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.gbox_Questions);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_LoggedinInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form_MainVolunteer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vrijwilligerssysteem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MainVolunteer_FormClosing);
            this.gbox_Questions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_Questions;
        private System.Windows.Forms.Label lbl_LoggedinInfo;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_Respond;
        private System.Windows.Forms.GroupBox gbox_Questions;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Timer timer_Refresh;
    }
}