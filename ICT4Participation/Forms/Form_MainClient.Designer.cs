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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainClient));
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_Discrepancy = new System.Windows.Forms.Label();
            this.btn_AddQuestion = new System.Windows.Forms.Button();
            this.lbox_MyQuestions = new System.Windows.Forms.ListBox();
            this.tbox_Discrepancy = new System.Windows.Forms.TextBox();
            this.tbox_Question = new System.Windows.Forms.TextBox();
            this.tbox_Location = new System.Windows.Forms.TextBox();
            this.lbl_AskQuestion = new System.Windows.Forms.Label();
            this.lbl_LoggedinInfo = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.gbox_NewQuestion = new System.Windows.Forms.GroupBox();
            this.gbox_MyQuestions = new System.Windows.Forms.GroupBox();
            this.btn_QuestionDetails = new System.Windows.Forms.Button();
            this.sstrip_Bottom = new System.Windows.Forms.StatusStrip();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.gbox_NewQuestion.SuspendLayout();
            this.gbox_MyQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Location.ForeColor = System.Drawing.Color.White;
            this.lbl_Location.Location = new System.Drawing.Point(80, 176);
            this.lbl_Location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(65, 20);
            this.lbl_Location.TabIndex = 0;
            this.lbl_Location.Text = "Locatie:";
            // 
            // lbl_Discrepancy
            // 
            this.lbl_Discrepancy.AutoSize = true;
            this.lbl_Discrepancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Discrepancy.ForeColor = System.Drawing.Color.White;
            this.lbl_Discrepancy.Location = new System.Drawing.Point(36, 212);
            this.lbl_Discrepancy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Discrepancy.Name = "lbl_Discrepancy";
            this.lbl_Discrepancy.Size = new System.Drawing.Size(109, 20);
            this.lbl_Discrepancy.TabIndex = 1;
            this.lbl_Discrepancy.Text = "Bijzonderheid:";
            // 
            // btn_AddQuestion
            // 
            this.btn_AddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddQuestion.BackColor = System.Drawing.Color.White;
            this.btn_AddQuestion.FlatAppearance.BorderSize = 0;
            this.btn_AddQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AddQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddQuestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_AddQuestion.Location = new System.Drawing.Point(207, 248);
            this.btn_AddQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddQuestion.Name = "btn_AddQuestion";
            this.btn_AddQuestion.Size = new System.Drawing.Size(290, 35);
            this.btn_AddQuestion.TabIndex = 4;
            this.btn_AddQuestion.Text = "Vraag verzenden";
            this.btn_AddQuestion.UseVisualStyleBackColor = false;
            this.btn_AddQuestion.Click += new System.EventHandler(this.btn_AddQuestion_Click);
            // 
            // lbox_MyQuestions
            // 
            this.lbox_MyQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_MyQuestions.BackColor = System.Drawing.Color.White;
            this.lbox_MyQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbox_MyQuestions.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbox_MyQuestions.FormattingEnabled = true;
            this.lbox_MyQuestions.HorizontalScrollbar = true;
            this.lbox_MyQuestions.ItemHeight = 20;
            this.lbox_MyQuestions.Location = new System.Drawing.Point(11, 24);
            this.lbox_MyQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.lbox_MyQuestions.Name = "lbox_MyQuestions";
            this.lbox_MyQuestions.ScrollAlwaysVisible = true;
            this.lbox_MyQuestions.Size = new System.Drawing.Size(485, 104);
            this.lbox_MyQuestions.TabIndex = 5;
            // 
            // tbox_Discrepancy
            // 
            this.tbox_Discrepancy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Discrepancy.Location = new System.Drawing.Point(193, 209);
            this.tbox_Discrepancy.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Discrepancy.Multiline = true;
            this.tbox_Discrepancy.Name = "tbox_Discrepancy";
            this.tbox_Discrepancy.Size = new System.Drawing.Size(304, 32);
            this.tbox_Discrepancy.TabIndex = 6;
            // 
            // tbox_Question
            // 
            this.tbox_Question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Question.Location = new System.Drawing.Point(193, 28);
            this.tbox_Question.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Question.Multiline = true;
            this.tbox_Question.Name = "tbox_Question";
            this.tbox_Question.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_Question.Size = new System.Drawing.Size(304, 126);
            this.tbox_Question.TabIndex = 7;
            // 
            // tbox_Location
            // 
            this.tbox_Location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Location.Location = new System.Drawing.Point(193, 173);
            this.tbox_Location.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Location.Multiline = true;
            this.tbox_Location.Name = "tbox_Location";
            this.tbox_Location.Size = new System.Drawing.Size(304, 32);
            this.tbox_Location.TabIndex = 8;
            // 
            // lbl_AskQuestion
            // 
            this.lbl_AskQuestion.AutoSize = true;
            this.lbl_AskQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AskQuestion.ForeColor = System.Drawing.Color.White;
            this.lbl_AskQuestion.Location = new System.Drawing.Point(7, 31);
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
            this.gbox_NewQuestion.Controls.Add(this.lbl_Location);
            this.gbox_NewQuestion.Controls.Add(this.lbl_Discrepancy);
            this.gbox_NewQuestion.Controls.Add(this.btn_AddQuestion);
            this.gbox_NewQuestion.Controls.Add(this.lbl_AskQuestion);
            this.gbox_NewQuestion.Controls.Add(this.tbox_Discrepancy);
            this.gbox_NewQuestion.Controls.Add(this.tbox_Location);
            this.gbox_NewQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbox_NewQuestion.ForeColor = System.Drawing.Color.White;
            this.gbox_NewQuestion.Location = new System.Drawing.Point(15, 236);
            this.gbox_NewQuestion.Name = "gbox_NewQuestion";
            this.gbox_NewQuestion.Size = new System.Drawing.Size(511, 294);
            this.gbox_NewQuestion.TabIndex = 12;
            this.gbox_NewQuestion.TabStop = false;
            this.gbox_NewQuestion.Text = "Zoek hulp";
            // 
            // gbox_MyQuestions
            // 
            this.gbox_MyQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_MyQuestions.Controls.Add(this.btn_QuestionDetails);
            this.gbox_MyQuestions.Controls.Add(this.lbox_MyQuestions);
            this.gbox_MyQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbox_MyQuestions.ForeColor = System.Drawing.Color.White;
            this.gbox_MyQuestions.Location = new System.Drawing.Point(15, 44);
            this.gbox_MyQuestions.Name = "gbox_MyQuestions";
            this.gbox_MyQuestions.Size = new System.Drawing.Size(511, 186);
            this.gbox_MyQuestions.TabIndex = 13;
            this.gbox_MyQuestions.TabStop = false;
            this.gbox_MyQuestions.Text = "Mijn Vragen";
            // 
            // btn_QuestionDetails
            // 
            this.btn_QuestionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QuestionDetails.BackColor = System.Drawing.Color.White;
            this.btn_QuestionDetails.FlatAppearance.BorderSize = 0;
            this.btn_QuestionDetails.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_QuestionDetails.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_QuestionDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuestionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuestionDetails.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_QuestionDetails.Location = new System.Drawing.Point(207, 143);
            this.btn_QuestionDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QuestionDetails.Name = "btn_QuestionDetails";
            this.btn_QuestionDetails.Size = new System.Drawing.Size(290, 35);
            this.btn_QuestionDetails.TabIndex = 6;
            this.btn_QuestionDetails.Text = "Details van geselecteerde vraag";
            this.btn_QuestionDetails.UseVisualStyleBackColor = false;
            this.btn_QuestionDetails.Click += new System.EventHandler(this.btn_QuestionDetails_Click);
            // 
            // sstrip_Bottom
            // 
            this.sstrip_Bottom.Location = new System.Drawing.Point(0, 539);
            this.sstrip_Bottom.Name = "sstrip_Bottom";
            this.sstrip_Bottom.Size = new System.Drawing.Size(538, 22);
            this.sstrip_Bottom.TabIndex = 14;
            this.sstrip_Bottom.Text = "statusStrip1";
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
            this.btn_DeleteUser.Location = new System.Drawing.Point(350, 9);
            this.btn_DeleteUser.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(177, 35);
            this.btn_DeleteUser.TabIndex = 15;
            this.btn_DeleteUser.Text = "Account Verwijderen";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // Form_MainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(538, 561);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.sstrip_Bottom);
            this.Controls.Add(this.gbox_MyQuestions);
            this.Controls.Add(this.gbox_NewQuestion);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_LoggedinInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(540, 600);
            this.Name = "Form_MainClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hulpzoekendesysteem";
            this.gbox_NewQuestion.ResumeLayout(false);
            this.gbox_NewQuestion.PerformLayout();
            this.gbox_MyQuestions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_Discrepancy;
        private System.Windows.Forms.Button btn_AddQuestion;
        private System.Windows.Forms.ListBox lbox_MyQuestions;
        private System.Windows.Forms.TextBox tbox_Discrepancy;
        private System.Windows.Forms.TextBox tbox_Question;
        private System.Windows.Forms.TextBox tbox_Location;
        private System.Windows.Forms.Label lbl_AskQuestion;
        private System.Windows.Forms.Label lbl_LoggedinInfo;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.GroupBox gbox_NewQuestion;
        private System.Windows.Forms.GroupBox gbox_MyQuestions;
        private System.Windows.Forms.Button btn_QuestionDetails;
        private System.Windows.Forms.StatusStrip sstrip_Bottom;
        private System.Windows.Forms.Button btn_DeleteUser;
    }
}