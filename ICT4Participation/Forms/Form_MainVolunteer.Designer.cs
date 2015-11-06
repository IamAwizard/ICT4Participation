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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainVolunteer));
            this.lbox_Questions = new System.Windows.Forms.ListBox();
            this.lbl_LoggedinInfo = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_Respond = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox_Questions
            // 
            this.lbox_Questions.FormattingEnabled = true;
            this.lbox_Questions.ItemHeight = 16;
            this.lbox_Questions.Location = new System.Drawing.Point(12, 12);
            this.lbox_Questions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbox_Questions.Name = "lbox_Questions";
            this.lbox_Questions.Size = new System.Drawing.Size(363, 420);
            this.lbox_Questions.TabIndex = 0;
            // 
            // lbl_LoggedinInfo
            // 
            this.lbl_LoggedinInfo.AutoSize = true;
            this.lbl_LoggedinInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_LoggedinInfo.ForeColor = System.Drawing.Color.White;
            this.lbl_LoggedinInfo.Location = new System.Drawing.Point(381, 30);
            this.lbl_LoggedinInfo.Name = "lbl_LoggedinInfo";
            this.lbl_LoggedinInfo.Size = new System.Drawing.Size(117, 24);
            this.lbl_LoggedinInfo.TabIndex = 1;
            this.lbl_LoggedinInfo.Text = "Ingelogd als:";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_UserName.ForeColor = System.Drawing.Color.White;
            this.lbl_UserName.Location = new System.Drawing.Point(496, 30);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(0, 24);
            this.lbl_UserName.TabIndex = 2;
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.White;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_profile.ForeColor = System.Drawing.Color.Black;
            this.btn_profile.Location = new System.Drawing.Point(392, 103);
            this.btn_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(171, 58);
            this.btn_profile.TabIndex = 3;
            this.btn_profile.Text = "Profiel";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_Respond
            // 
            this.btn_Respond.BackColor = System.Drawing.Color.White;
            this.btn_Respond.FlatAppearance.BorderSize = 0;
            this.btn_Respond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Respond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Respond.ForeColor = System.Drawing.Color.Black;
            this.btn_Respond.Location = new System.Drawing.Point(392, 199);
            this.btn_Respond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Respond.Name = "btn_Respond";
            this.btn_Respond.Size = new System.Drawing.Size(171, 58);
            this.btn_Respond.TabIndex = 4;
            this.btn_Respond.Text = "Reageer";
            this.btn_Respond.UseVisualStyleBackColor = false;
            // 
            // Form_MainVolunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(664, 444);
            this.Controls.Add(this.btn_Respond);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_LoggedinInfo);
            this.Controls.Add(this.lbox_Questions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_MainVolunteer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vrijwilligerssysteem";
            this.Load += new System.EventHandler(this.Form_Volunteer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_Questions;
        private System.Windows.Forms.Label lbl_LoggedinInfo;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_Respond;
    }
}