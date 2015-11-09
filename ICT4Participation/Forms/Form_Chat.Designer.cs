namespace ICT4Participation
{
    partial class Form_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Chat));
            this.gbox_Client = new System.Windows.Forms.GroupBox();
            this.gbox_Volunteer = new System.Windows.Forms.GroupBox();
            this.lbox_Chat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // gbox_Client
            // 
            this.gbox_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbox_Client.ForeColor = System.Drawing.Color.White;
            this.gbox_Client.Location = new System.Drawing.Point(12, 12);
            this.gbox_Client.Name = "gbox_Client";
            this.gbox_Client.Size = new System.Drawing.Size(340, 90);
            this.gbox_Client.TabIndex = 2;
            this.gbox_Client.TabStop = false;
            this.gbox_Client.Text = "<Naam Client>";
            // 
            // gbox_Volunteer
            // 
            this.gbox_Volunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbox_Volunteer.ForeColor = System.Drawing.Color.White;
            this.gbox_Volunteer.Location = new System.Drawing.Point(358, 12);
            this.gbox_Volunteer.Name = "gbox_Volunteer";
            this.gbox_Volunteer.Size = new System.Drawing.Size(314, 90);
            this.gbox_Volunteer.TabIndex = 3;
            this.gbox_Volunteer.TabStop = false;
            this.gbox_Volunteer.Text = "<Naam Volunteer>";
            // 
            // lbox_Chat
            // 
            this.lbox_Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbox_Chat.FormattingEnabled = true;
            this.lbox_Chat.ItemHeight = 20;
            this.lbox_Chat.Location = new System.Drawing.Point(145, 117);
            this.lbox_Chat.Name = "lbox_Chat";
            this.lbox_Chat.Size = new System.Drawing.Size(432, 284);
            this.lbox_Chat.TabIndex = 0;
            // 
            // Form_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(689, 427);
            this.Controls.Add(this.lbox_Chat);
            this.Controls.Add(this.gbox_Volunteer);
            this.Controls.Add(this.gbox_Client);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Chat";
            this.Text = "Chat";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbox_Client;
        private System.Windows.Forms.GroupBox gbox_Volunteer;
        private System.Windows.Forms.ListBox lbox_Chat;
    }
}