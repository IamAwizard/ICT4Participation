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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Chat));
            this.gbox_Chathistory = new System.Windows.Forms.GroupBox();
            this.lbox_Chat = new System.Windows.Forms.ListBox();
            this.lbl_ChatInfo = new System.Windows.Forms.Label();
            this.lbl_User1 = new System.Windows.Forms.Label();
            this.lbl_User2 = new System.Windows.Forms.Label();
            this.gbox_AddMessage = new System.Windows.Forms.GroupBox();
            this.tbox_Message = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.Timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.gbox_Chathistory.SuspendLayout();
            this.gbox_AddMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_Chathistory
            // 
            this.gbox_Chathistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_Chathistory.Controls.Add(this.lbox_Chat);
            this.gbox_Chathistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbox_Chathistory.ForeColor = System.Drawing.Color.White;
            this.gbox_Chathistory.Location = new System.Drawing.Point(12, 78);
            this.gbox_Chathistory.Name = "gbox_Chathistory";
            this.gbox_Chathistory.Size = new System.Drawing.Size(460, 224);
            this.gbox_Chathistory.TabIndex = 3;
            this.gbox_Chathistory.TabStop = false;
            this.gbox_Chathistory.Text = "Berichten:";
            // 
            // lbox_Chat
            // 
            this.lbox_Chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbox_Chat.FormattingEnabled = true;
            this.lbox_Chat.HorizontalScrollbar = true;
            this.lbox_Chat.IntegralHeight = false;
            this.lbox_Chat.ItemHeight = 20;
            this.lbox_Chat.Location = new System.Drawing.Point(3, 22);
            this.lbox_Chat.Name = "lbox_Chat";
            this.lbox_Chat.ScrollAlwaysVisible = true;
            this.lbox_Chat.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbox_Chat.Size = new System.Drawing.Size(454, 199);
            this.lbox_Chat.TabIndex = 0;
            // 
            // lbl_ChatInfo
            // 
            this.lbl_ChatInfo.AutoSize = true;
            this.lbl_ChatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ChatInfo.ForeColor = System.Drawing.Color.White;
            this.lbl_ChatInfo.Location = new System.Drawing.Point(13, 13);
            this.lbl_ChatInfo.Name = "lbl_ChatInfo";
            this.lbl_ChatInfo.Size = new System.Drawing.Size(99, 20);
            this.lbl_ChatInfo.TabIndex = 4;
            this.lbl_ChatInfo.Text = "Chat tussen:";
            // 
            // lbl_User1
            // 
            this.lbl_User1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_User1.AutoSize = true;
            this.lbl_User1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_User1.ForeColor = System.Drawing.Color.White;
            this.lbl_User1.Location = new System.Drawing.Point(60, 35);
            this.lbl_User1.Name = "lbl_User1";
            this.lbl_User1.Size = new System.Drawing.Size(82, 20);
            this.lbl_User1.TabIndex = 6;
            this.lbl_User1.Text = "<Naam 1>";
            // 
            // lbl_User2
            // 
            this.lbl_User2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_User2.AutoSize = true;
            this.lbl_User2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_User2.ForeColor = System.Drawing.Color.White;
            this.lbl_User2.Location = new System.Drawing.Point(60, 55);
            this.lbl_User2.Name = "lbl_User2";
            this.lbl_User2.Size = new System.Drawing.Size(82, 20);
            this.lbl_User2.TabIndex = 7;
            this.lbl_User2.Text = "<Naam 2>";
            // 
            // gbox_AddMessage
            // 
            this.gbox_AddMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_AddMessage.Controls.Add(this.tbox_Message);
            this.gbox_AddMessage.Controls.Add(this.btn_Send);
            this.gbox_AddMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbox_AddMessage.ForeColor = System.Drawing.Color.White;
            this.gbox_AddMessage.Location = new System.Drawing.Point(12, 302);
            this.gbox_AddMessage.Name = "gbox_AddMessage";
            this.gbox_AddMessage.Size = new System.Drawing.Size(460, 52);
            this.gbox_AddMessage.TabIndex = 8;
            this.gbox_AddMessage.TabStop = false;
            this.gbox_AddMessage.Text = "Bericht sturen:";
            // 
            // tbox_Message
            // 
            this.tbox_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_Message.Location = new System.Drawing.Point(3, 22);
            this.tbox_Message.Name = "tbox_Message";
            this.tbox_Message.Size = new System.Drawing.Size(306, 26);
            this.tbox_Message.TabIndex = 16;
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.White;
            this.btn_Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Send.FlatAppearance.BorderSize = 0;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Send.ForeColor = System.Drawing.Color.Black;
            this.btn_Send.Location = new System.Drawing.Point(309, 22);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(148, 27);
            this.btn_Send.TabIndex = 15;
            this.btn_Send.Text = "Versturen";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Timer_Refresh
            // 
            this.Timer_Refresh.Interval = 5000;
            this.Timer_Refresh.Tick += new System.EventHandler(this.Timer_Refresh_Tick);
            // 
            // Form_Chat
            // 
            this.AcceptButton = this.btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.gbox_AddMessage);
            this.Controls.Add(this.lbl_User2);
            this.Controls.Add(this.lbl_User1);
            this.Controls.Add(this.lbl_ChatInfo);
            this.Controls.Add(this.gbox_Chathistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form_Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Chat_FormClosing);
            this.gbox_Chathistory.ResumeLayout(false);
            this.gbox_AddMessage.ResumeLayout(false);
            this.gbox_AddMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbox_Chathistory;
        private System.Windows.Forms.ListBox lbox_Chat;
        private System.Windows.Forms.Label lbl_ChatInfo;
        private System.Windows.Forms.Label lbl_User1;
        private System.Windows.Forms.Label lbl_User2;
        private System.Windows.Forms.GroupBox gbox_AddMessage;
        private System.Windows.Forms.TextBox tbox_Message;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Timer Timer_Refresh;
    }
}