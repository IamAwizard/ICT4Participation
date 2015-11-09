namespace ICT4Participation
{
    partial class Form_MainClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainClient));
            this.btn_AddQuestion = new System.Windows.Forms.Button();
            this.tbox_Question = new System.Windows.Forms.TextBox();
            this.lbl_AskQuestion = new System.Windows.Forms.Label();
            this.lbl_LoggedinInfo = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.gbox_NewQuestion = new System.Windows.Forms.GroupBox();
            this.gbox_MyQuestions = new System.Windows.Forms.GroupBox();
            this.lbox_MyQuestions = new System.Windows.Forms.ListBox();
            this.btn_QuestionDetails = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.gbox_Chat = new System.Windows.Forms.GroupBox();
            this.lbox_Volunteers = new System.Windows.Forms.ListBox();
            this.btn_Chat = new System.Windows.Forms.Button();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.gbox_NewQuestion.SuspendLayout();
            this.gbox_MyQuestions.SuspendLayout();
            this.gbox_Chat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddQuestion
            // 
            this.btn_AddQuestion.BackColor = System.Drawing.Color.White;
            this.btn_AddQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_AddQuestion.FlatAppearance.BorderSize = 0;
            this.btn_AddQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AddQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddQuestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_AddQuestion.Location = new System.Drawing.Point(3, 242);
            this.btn_AddQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddQuestion.Name = "btn_AddQuestion";
            this.btn_AddQuestion.Size = new System.Drawing.Size(555, 35);
            this.btn_AddQuestion.TabIndex = 4;
            this.btn_AddQuestion.Text = "Vraag verzenden";
            this.btn_AddQuestion.UseVisualStyleBackColor = false;
            this.btn_AddQuestion.Click += new System.EventHandler(this.btn_AddQuestion_Click);
            // 
            // tbox_Question
            // 
            this.tbox_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_Question.Location = new System.Drawing.Point(3, 42);
            this.tbox_Question.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Question.Multiline = true;
            this.tbox_Question.Name = "tbox_Question";
            this.tbox_Question.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_Question.Size = new System.Drawing.Size(555, 200);
            this.tbox_Question.TabIndex = 7;
            // 
            // lbl_AskQuestion
            // 
            this.lbl_AskQuestion.AutoSize = true;
            this.lbl_AskQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_AskQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AskQuestion.ForeColor = System.Drawing.Color.White;
            this.lbl_AskQuestion.Location = new System.Drawing.Point(3, 22);
            this.lbl_AskQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AskQuestion.Name = "lbl_AskQuestion";
            this.lbl_AskQuestion.Size = new System.Drawing.Size(138, 20);
            this.lbl_AskQuestion.TabIndex = 9;
            this.lbl_AskQuestion.Text = "Stel hier uw vraag:";
            // 
            // lbl_LoggedinInfo
            // 
            this.lbl_LoggedinInfo.AutoSize = true;
            this.lbl_LoggedinInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_LoggedinInfo.ForeColor = System.Drawing.Color.White;
            this.lbl_LoggedinInfo.Location = new System.Drawing.Point(11, 9);
            this.lbl_LoggedinInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LoggedinInfo.Name = "lbl_LoggedinInfo";
            this.lbl_LoggedinInfo.Size = new System.Drawing.Size(70, 20);
            this.lbl_LoggedinInfo.TabIndex = 10;
            this.lbl_LoggedinInfo.Text = "Welkom,";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_UserName.ForeColor = System.Drawing.Color.White;
            this.lbl_UserName.Location = new System.Drawing.Point(85, 9);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(27, 20);
            this.lbl_UserName.TabIndex = 10;
            this.lbl_UserName.Text = "<>";
            // 
            // gbox_NewQuestion
            // 
            this.gbox_NewQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_NewQuestion.Controls.Add(this.tbox_Question);
            this.gbox_NewQuestion.Controls.Add(this.btn_AddQuestion);
            this.gbox_NewQuestion.Controls.Add(this.lbl_AskQuestion);
            this.gbox_NewQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbox_NewQuestion.ForeColor = System.Drawing.Color.White;
            this.gbox_NewQuestion.Location = new System.Drawing.Point(15, 269);
            this.gbox_NewQuestion.Name = "gbox_NewQuestion";
            this.gbox_NewQuestion.Size = new System.Drawing.Size(561, 280);
            this.gbox_NewQuestion.TabIndex = 12;
            this.gbox_NewQuestion.TabStop = false;
            this.gbox_NewQuestion.Text = "Zoek hulp";
            // 
            // gbox_MyQuestions
            // 
            this.gbox_MyQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_MyQuestions.Controls.Add(this.lbox_MyQuestions);
            this.gbox_MyQuestions.Controls.Add(this.btn_QuestionDetails);
            this.gbox_MyQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbox_MyQuestions.ForeColor = System.Drawing.Color.White;
            this.gbox_MyQuestions.Location = new System.Drawing.Point(15, 44);
            this.gbox_MyQuestions.Name = "gbox_MyQuestions";
            this.gbox_MyQuestions.Size = new System.Drawing.Size(561, 219);
            this.gbox_MyQuestions.TabIndex = 13;
            this.gbox_MyQuestions.TabStop = false;
            this.gbox_MyQuestions.Text = "Mijn Vragen";
            // 
            // lbox_MyQuestions
            // 
            this.lbox_MyQuestions.BackColor = System.Drawing.Color.White;
            this.lbox_MyQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_MyQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbox_MyQuestions.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbox_MyQuestions.FormattingEnabled = true;
            this.lbox_MyQuestions.HorizontalScrollbar = true;
            this.lbox_MyQuestions.IntegralHeight = false;
            this.lbox_MyQuestions.ItemHeight = 20;
            this.lbox_MyQuestions.Location = new System.Drawing.Point(3, 22);
            this.lbox_MyQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.lbox_MyQuestions.Name = "lbox_MyQuestions";
            this.lbox_MyQuestions.ScrollAlwaysVisible = true;
            this.lbox_MyQuestions.Size = new System.Drawing.Size(555, 164);
            this.lbox_MyQuestions.TabIndex = 7;
            // 
            // btn_QuestionDetails
            // 
            this.btn_QuestionDetails.AutoSize = true;
            this.btn_QuestionDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_QuestionDetails.BackColor = System.Drawing.Color.White;
            this.btn_QuestionDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_QuestionDetails.FlatAppearance.BorderSize = 0;
            this.btn_QuestionDetails.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_QuestionDetails.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_QuestionDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuestionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuestionDetails.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_QuestionDetails.Location = new System.Drawing.Point(3, 186);
            this.btn_QuestionDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QuestionDetails.Name = "btn_QuestionDetails";
            this.btn_QuestionDetails.Size = new System.Drawing.Size(555, 30);
            this.btn_QuestionDetails.TabIndex = 6;
            this.btn_QuestionDetails.Text = "Details van geselecteerde vraag";
            this.btn_QuestionDetails.UseVisualStyleBackColor = false;
            this.btn_QuestionDetails.Click += new System.EventHandler(this.btn_QuestionDetails_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteUser.BackColor = System.Drawing.Color.IndianRed;
            this.btn_DeleteUser.FlatAppearance.BorderSize = 0;
            this.btn_DeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_DeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_DeleteUser.Location = new System.Drawing.Point(604, 9);
            this.btn_DeleteUser.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(165, 30);
            this.btn_DeleteUser.TabIndex = 15;
            this.btn_DeleteUser.Text = "Account Verwijderen";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // gbox_Chat
            // 
            this.gbox_Chat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_Chat.Controls.Add(this.lbox_Volunteers);
            this.gbox_Chat.Controls.Add(this.btn_Chat);
            this.gbox_Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gbox_Chat.ForeColor = System.Drawing.Color.White;
            this.gbox_Chat.Location = new System.Drawing.Point(587, 44);
            this.gbox_Chat.Name = "gbox_Chat";
            this.gbox_Chat.Size = new System.Drawing.Size(200, 505);
            this.gbox_Chat.TabIndex = 16;
            this.gbox_Chat.TabStop = false;
            this.gbox_Chat.Text = "Chatten";
            // 
            // lbox_Volunteers
            // 
            this.lbox_Volunteers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_Volunteers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbox_Volunteers.FormattingEnabled = true;
            this.lbox_Volunteers.IntegralHeight = false;
            this.lbox_Volunteers.ItemHeight = 20;
            this.lbox_Volunteers.Location = new System.Drawing.Point(3, 20);
            this.lbox_Volunteers.Name = "lbox_Volunteers";
            this.lbox_Volunteers.ScrollAlwaysVisible = true;
            this.lbox_Volunteers.Size = new System.Drawing.Size(194, 452);
            this.lbox_Volunteers.TabIndex = 8;
            // 
            // btn_Chat
            // 
            this.btn_Chat.BackColor = System.Drawing.Color.White;
            this.btn_Chat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Chat.FlatAppearance.BorderSize = 0;
            this.btn_Chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Chat.ForeColor = System.Drawing.Color.Black;
            this.btn_Chat.Location = new System.Drawing.Point(3, 472);
            this.btn_Chat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Chat.Name = "btn_Chat";
            this.btn_Chat.Size = new System.Drawing.Size(194, 30);
            this.btn_Chat.TabIndex = 9;
            this.btn_Chat.Text = "Chatten";
            this.btn_Chat.UseVisualStyleBackColor = false;
            // 
            // timer_Refresh
            // 
            this.timer_Refresh.Interval = 30000;
            this.timer_Refresh.Tick += new System.EventHandler(this.timer_Refresh_Tick);
            // 
            // Form_MainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(799, 561);
            this.Controls.Add(this.gbox_Chat);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.gbox_MyQuestions);
            this.Controls.Add(this.gbox_NewQuestion);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_LoggedinInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form_MainClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hulpzoekendesysteem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MainClient_FormClosing);
            this.gbox_NewQuestion.ResumeLayout(false);
            this.gbox_NewQuestion.PerformLayout();
            this.gbox_MyQuestions.ResumeLayout(false);
            this.gbox_MyQuestions.PerformLayout();
            this.gbox_Chat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AddQuestion;
        private System.Windows.Forms.TextBox tbox_Question;
        private System.Windows.Forms.Label lbl_AskQuestion;
        private System.Windows.Forms.Label lbl_LoggedinInfo;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.GroupBox gbox_NewQuestion;
        private System.Windows.Forms.GroupBox gbox_MyQuestions;
        private System.Windows.Forms.Button btn_QuestionDetails;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.ListBox lbox_MyQuestions;
        private System.Windows.Forms.GroupBox gbox_Chat;
        private System.Windows.Forms.ListBox lbox_Volunteers;
        private System.Windows.Forms.Button btn_Chat;
        private System.Windows.Forms.Timer timer_Refresh;
    }
}