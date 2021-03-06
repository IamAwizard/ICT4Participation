﻿namespace ICT4Participation
{
    partial class Form_QuestionDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuestionDetails));
            this.pbox_Client = new System.Windows.Forms.PictureBox();
            this.tbox_Question = new System.Windows.Forms.TextBox();
            this.lbl_ClientName = new System.Windows.Forms.Label();
            this.gbox_Question = new System.Windows.Forms.GroupBox();
            this.tbox_Distance = new System.Windows.Forms.TextBox();
            this.lbl_Distance = new System.Windows.Forms.Label();
            this.tbox_Transport = new System.Windows.Forms.TextBox();
            this.lbl_Transport = new System.Windows.Forms.Label();
            this.tbox_Discrepancy = new System.Windows.Forms.TextBox();
            this.tbox_Location = new System.Windows.Forms.TextBox();
            this.lbl_Info4 = new System.Windows.Forms.Label();
            this.lbl_Info3 = new System.Windows.Forms.Label();
            this.lbl_Info2 = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Info1 = new System.Windows.Forms.Label();
            this.gbox_Answer = new System.Windows.Forms.GroupBox();
            this.btn_AddReview = new System.Windows.Forms.Button();
            this.btn_AddMeeting = new System.Windows.Forms.Button();
            this.lbl_Info6 = new System.Windows.Forms.Label();
            this.lbl_AnswerAuthorName = new System.Windows.Forms.Label();
            this.tbox_Answer = new System.Windows.Forms.TextBox();
            this.gbox_NoAnswer = new System.Windows.Forms.GroupBox();
            this.lbl_NoAnswer = new System.Windows.Forms.Label();
            this.pbox_Volunteer = new System.Windows.Forms.PictureBox();
            this.lbl_Info7 = new System.Windows.Forms.Label();
            this.lbl_QuestionAnswered = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Client)).BeginInit();
            this.gbox_Question.SuspendLayout();
            this.gbox_Answer.SuspendLayout();
            this.gbox_NoAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Volunteer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_Client
            // 
            this.pbox_Client.Image = global::ICT4Participation.Properties.Resources.IMG_Questionblack;
            this.pbox_Client.Location = new System.Drawing.Point(209, 2);
            this.pbox_Client.Name = "pbox_Client";
            this.pbox_Client.Size = new System.Drawing.Size(118, 116);
            this.pbox_Client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Client.TabIndex = 0;
            this.pbox_Client.TabStop = false;
            // 
            // tbox_Question
            // 
            this.tbox_Question.Location = new System.Drawing.Point(31, 89);
            this.tbox_Question.Multiline = true;
            this.tbox_Question.Name = "tbox_Question";
            this.tbox_Question.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbox_Question.Size = new System.Drawing.Size(465, 171);
            this.tbox_Question.TabIndex = 5;
            this.tbox_Question.TextChanged += new System.EventHandler(this.tbox_Question_TextChanged);
            // 
            // lbl_ClientName
            // 
            this.lbl_ClientName.AutoSize = true;
            this.lbl_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ClientName.ForeColor = System.Drawing.Color.White;
            this.lbl_ClientName.Location = new System.Drawing.Point(86, 57);
            this.lbl_ClientName.Name = "lbl_ClientName";
            this.lbl_ClientName.Size = new System.Drawing.Size(69, 20);
            this.lbl_ClientName.TabIndex = 2;
            this.lbl_ClientName.Text = "<Naam>";
            // 
            // gbox_Question
            // 
            this.gbox_Question.Controls.Add(this.tbox_Distance);
            this.gbox_Question.Controls.Add(this.lbl_Distance);
            this.gbox_Question.Controls.Add(this.tbox_Transport);
            this.gbox_Question.Controls.Add(this.lbl_Transport);
            this.gbox_Question.Controls.Add(this.tbox_Discrepancy);
            this.gbox_Question.Controls.Add(this.tbox_Location);
            this.gbox_Question.Controls.Add(this.lbl_Info4);
            this.gbox_Question.Controls.Add(this.lbl_Info3);
            this.gbox_Question.Controls.Add(this.lbl_Info2);
            this.gbox_Question.Controls.Add(this.lbl_Date);
            this.gbox_Question.Controls.Add(this.lbl_Info1);
            this.gbox_Question.Controls.Add(this.lbl_ClientName);
            this.gbox_Question.Controls.Add(this.tbox_Question);
            this.gbox_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbox_Question.ForeColor = System.Drawing.Color.White;
            this.gbox_Question.Location = new System.Drawing.Point(12, 124);
            this.gbox_Question.Name = "gbox_Question";
            this.gbox_Question.Size = new System.Drawing.Size(511, 407);
            this.gbox_Question.TabIndex = 3;
            this.gbox_Question.TabStop = false;
            this.gbox_Question.Text = "Vraag";
            // 
            // tbox_Distance
            // 
            this.tbox_Distance.Location = new System.Drawing.Point(143, 365);
            this.tbox_Distance.Name = "tbox_Distance";
            this.tbox_Distance.Size = new System.Drawing.Size(353, 26);
            this.tbox_Distance.TabIndex = 12;
            this.tbox_Distance.TextChanged += new System.EventHandler(this.tbox_Question_TextChanged);
            // 
            // lbl_Distance
            // 
            this.lbl_Distance.AutoSize = true;
            this.lbl_Distance.Location = new System.Drawing.Point(27, 368);
            this.lbl_Distance.Name = "lbl_Distance";
            this.lbl_Distance.Size = new System.Drawing.Size(69, 20);
            this.lbl_Distance.TabIndex = 11;
            this.lbl_Distance.Text = "Afstand:";
            // 
            // tbox_Transport
            // 
            this.tbox_Transport.Location = new System.Drawing.Point(143, 333);
            this.tbox_Transport.Name = "tbox_Transport";
            this.tbox_Transport.Size = new System.Drawing.Size(353, 26);
            this.tbox_Transport.TabIndex = 10;
            this.tbox_Transport.TextChanged += new System.EventHandler(this.tbox_Question_TextChanged);
            // 
            // lbl_Transport
            // 
            this.lbl_Transport.AutoSize = true;
            this.lbl_Transport.Location = new System.Drawing.Point(27, 336);
            this.lbl_Transport.Name = "lbl_Transport";
            this.lbl_Transport.Size = new System.Drawing.Size(114, 20);
            this.lbl_Transport.TabIndex = 9;
            this.lbl_Transport.Text = "Vervoermiddel:";
            // 
            // tbox_Discrepancy
            // 
            this.tbox_Discrepancy.Location = new System.Drawing.Point(143, 301);
            this.tbox_Discrepancy.Name = "tbox_Discrepancy";
            this.tbox_Discrepancy.Size = new System.Drawing.Size(353, 26);
            this.tbox_Discrepancy.TabIndex = 8;
            this.tbox_Discrepancy.TextChanged += new System.EventHandler(this.tbox_Question_TextChanged);
            // 
            // tbox_Location
            // 
            this.tbox_Location.Location = new System.Drawing.Point(143, 269);
            this.tbox_Location.Name = "tbox_Location";
            this.tbox_Location.Size = new System.Drawing.Size(353, 26);
            this.tbox_Location.TabIndex = 4;
            this.tbox_Location.TextChanged += new System.EventHandler(this.tbox_Question_TextChanged);
            // 
            // lbl_Info4
            // 
            this.lbl_Info4.AutoSize = true;
            this.lbl_Info4.Location = new System.Drawing.Point(27, 304);
            this.lbl_Info4.Name = "lbl_Info4";
            this.lbl_Info4.Size = new System.Drawing.Size(109, 20);
            this.lbl_Info4.TabIndex = 7;
            this.lbl_Info4.Text = "Bijzonderheid:";
            // 
            // lbl_Info3
            // 
            this.lbl_Info3.AutoSize = true;
            this.lbl_Info3.Location = new System.Drawing.Point(28, 272);
            this.lbl_Info3.Name = "lbl_Info3";
            this.lbl_Info3.Size = new System.Drawing.Size(65, 20);
            this.lbl_Info3.TabIndex = 6;
            this.lbl_Info3.Text = "Locatie:";
            // 
            // lbl_Info2
            // 
            this.lbl_Info2.AutoSize = true;
            this.lbl_Info2.Location = new System.Drawing.Point(28, 57);
            this.lbl_Info2.Name = "lbl_Info2";
            this.lbl_Info2.Size = new System.Drawing.Size(52, 20);
            this.lbl_Info2.TabIndex = 5;
            this.lbl_Info2.Text = "Vroeg";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(86, 37);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(72, 20);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "<datum>";
            // 
            // lbl_Info1
            // 
            this.lbl_Info1.AutoSize = true;
            this.lbl_Info1.Location = new System.Drawing.Point(28, 37);
            this.lbl_Info1.Name = "lbl_Info1";
            this.lbl_Info1.Size = new System.Drawing.Size(30, 20);
            this.lbl_Info1.TabIndex = 3;
            this.lbl_Info1.Text = "Op";
            // 
            // gbox_Answer
            // 
            this.gbox_Answer.Controls.Add(this.btn_AddReview);
            this.gbox_Answer.Controls.Add(this.btn_AddMeeting);
            this.gbox_Answer.Controls.Add(this.lbl_Info6);
            this.gbox_Answer.Controls.Add(this.lbl_AnswerAuthorName);
            this.gbox_Answer.Controls.Add(this.tbox_Answer);
            this.gbox_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbox_Answer.ForeColor = System.Drawing.Color.White;
            this.gbox_Answer.Location = new System.Drawing.Point(541, 124);
            this.gbox_Answer.Name = "gbox_Answer";
            this.gbox_Answer.Size = new System.Drawing.Size(511, 407);
            this.gbox_Answer.TabIndex = 4;
            this.gbox_Answer.TabStop = false;
            this.gbox_Answer.Text = "Antwoord";
            // 
            // btn_AddReview
            // 
            this.btn_AddReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddReview.BackColor = System.Drawing.Color.White;
            this.btn_AddReview.FlatAppearance.BorderSize = 0;
            this.btn_AddReview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AddReview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AddReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddReview.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_AddReview.Location = new System.Drawing.Point(267, 361);
            this.btn_AddReview.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddReview.Name = "btn_AddReview";
            this.btn_AddReview.Size = new System.Drawing.Size(210, 35);
            this.btn_AddReview.TabIndex = 7;
            this.btn_AddReview.Text = "Schrijf Review";
            this.btn_AddReview.UseVisualStyleBackColor = false;
            this.btn_AddReview.Click += new System.EventHandler(this.btn_AddReview_Click);
            // 
            // btn_AddMeeting
            // 
            this.btn_AddMeeting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddMeeting.BackColor = System.Drawing.Color.White;
            this.btn_AddMeeting.FlatAppearance.BorderSize = 0;
            this.btn_AddMeeting.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AddMeeting.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AddMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMeeting.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_AddMeeting.Location = new System.Drawing.Point(31, 361);
            this.btn_AddMeeting.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddMeeting.Name = "btn_AddMeeting";
            this.btn_AddMeeting.Size = new System.Drawing.Size(210, 35);
            this.btn_AddMeeting.TabIndex = 6;
            this.btn_AddMeeting.Text = "Afspraak plannen!";
            this.btn_AddMeeting.UseVisualStyleBackColor = false;
            this.btn_AddMeeting.Click += new System.EventHandler(this.btn_AddMeeting_Click);
            // 
            // lbl_Info6
            // 
            this.lbl_Info6.AutoSize = true;
            this.lbl_Info6.Location = new System.Drawing.Point(27, 57);
            this.lbl_Info6.Name = "lbl_Info6";
            this.lbl_Info6.Size = new System.Drawing.Size(136, 20);
            this.lbl_Info6.TabIndex = 5;
            this.lbl_Info6.Text = "heeft gereageerd:";
            // 
            // lbl_AnswerAuthorName
            // 
            this.lbl_AnswerAuthorName.AutoSize = true;
            this.lbl_AnswerAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AnswerAuthorName.ForeColor = System.Drawing.Color.White;
            this.lbl_AnswerAuthorName.Location = new System.Drawing.Point(27, 37);
            this.lbl_AnswerAuthorName.Name = "lbl_AnswerAuthorName";
            this.lbl_AnswerAuthorName.Size = new System.Drawing.Size(69, 20);
            this.lbl_AnswerAuthorName.TabIndex = 2;
            this.lbl_AnswerAuthorName.Text = "<Naam>";
            // 
            // tbox_Answer
            // 
            this.tbox_Answer.Location = new System.Drawing.Point(31, 89);
            this.tbox_Answer.Multiline = true;
            this.tbox_Answer.Name = "tbox_Answer";
            this.tbox_Answer.ReadOnly = true;
            this.tbox_Answer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbox_Answer.Size = new System.Drawing.Size(446, 267);
            this.tbox_Answer.TabIndex = 1;
            // 
            // gbox_NoAnswer
            // 
            this.gbox_NoAnswer.Controls.Add(this.lbl_NoAnswer);
            this.gbox_NoAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbox_NoAnswer.ForeColor = System.Drawing.Color.White;
            this.gbox_NoAnswer.Location = new System.Drawing.Point(541, 124);
            this.gbox_NoAnswer.Name = "gbox_NoAnswer";
            this.gbox_NoAnswer.Size = new System.Drawing.Size(511, 407);
            this.gbox_NoAnswer.TabIndex = 8;
            this.gbox_NoAnswer.TabStop = false;
            this.gbox_NoAnswer.Text = "Antwoord";
            // 
            // lbl_NoAnswer
            // 
            this.lbl_NoAnswer.AutoSize = true;
            this.lbl_NoAnswer.Location = new System.Drawing.Point(102, 194);
            this.lbl_NoAnswer.Name = "lbl_NoAnswer";
            this.lbl_NoAnswer.Size = new System.Drawing.Size(311, 20);
            this.lbl_NoAnswer.TabIndex = 5;
            this.lbl_NoAnswer.Text = "Nog niemand heeft gereageerd op je vraag";
            // 
            // pbox_Volunteer
            // 
            this.pbox_Volunteer.Image = global::ICT4Participation.Properties.Resources.IMG_Volunteerblack;
            this.pbox_Volunteer.Location = new System.Drawing.Point(736, 2);
            this.pbox_Volunteer.Name = "pbox_Volunteer";
            this.pbox_Volunteer.Size = new System.Drawing.Size(118, 116);
            this.pbox_Volunteer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Volunteer.TabIndex = 5;
            this.pbox_Volunteer.TabStop = false;
            // 
            // lbl_Info7
            // 
            this.lbl_Info7.AutoSize = true;
            this.lbl_Info7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info7.ForeColor = System.Drawing.Color.White;
            this.lbl_Info7.Location = new System.Drawing.Point(351, 18);
            this.lbl_Info7.Name = "lbl_Info7";
            this.lbl_Info7.Size = new System.Drawing.Size(117, 24);
            this.lbl_Info7.TabIndex = 6;
            this.lbl_Info7.Text = "Vraag status:";
            // 
            // lbl_QuestionAnswered
            // 
            this.lbl_QuestionAnswered.AutoSize = true;
            this.lbl_QuestionAnswered.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuestionAnswered.ForeColor = System.Drawing.Color.White;
            this.lbl_QuestionAnswered.Location = new System.Drawing.Point(428, 68);
            this.lbl_QuestionAnswered.Name = "lbl_QuestionAnswered";
            this.lbl_QuestionAnswered.Size = new System.Drawing.Size(164, 25);
            this.lbl_QuestionAnswered.TabIndex = 7;
            this.lbl_QuestionAnswered.Text = "Onbeantwoord";
            // 
            // Form_QuestionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1066, 544);
            this.Controls.Add(this.gbox_Answer);
            this.Controls.Add(this.gbox_NoAnswer);
            this.Controls.Add(this.lbl_QuestionAnswered);
            this.Controls.Add(this.lbl_Info7);
            this.Controls.Add(this.pbox_Volunteer);
            this.Controls.Add(this.gbox_Question);
            this.Controls.Add(this.pbox_Client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1080, 580);
            this.Name = "Form_QuestionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vraagdetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_QuestionDetails_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Client)).EndInit();
            this.gbox_Question.ResumeLayout(false);
            this.gbox_Question.PerformLayout();
            this.gbox_Answer.ResumeLayout(false);
            this.gbox_Answer.PerformLayout();
            this.gbox_NoAnswer.ResumeLayout(false);
            this.gbox_NoAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Volunteer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_Client;
        private System.Windows.Forms.TextBox tbox_Question;
        private System.Windows.Forms.Label lbl_ClientName;
        private System.Windows.Forms.GroupBox gbox_Question;
        private System.Windows.Forms.Label lbl_Info4;
        private System.Windows.Forms.Label lbl_Info3;
        private System.Windows.Forms.Label lbl_Info2;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Info1;
        private System.Windows.Forms.TextBox tbox_Discrepancy;
        private System.Windows.Forms.TextBox tbox_Location;
        private System.Windows.Forms.TextBox tbox_Distance;
        private System.Windows.Forms.Label lbl_Distance;
        private System.Windows.Forms.TextBox tbox_Transport;
        private System.Windows.Forms.Label lbl_Transport;
        private System.Windows.Forms.GroupBox gbox_Answer;
        private System.Windows.Forms.Label lbl_AnswerAuthorName;
        private System.Windows.Forms.TextBox tbox_Answer;
        private System.Windows.Forms.PictureBox pbox_Volunteer;
        private System.Windows.Forms.Label lbl_Info7;
        private System.Windows.Forms.Label lbl_QuestionAnswered;
        private System.Windows.Forms.Button btn_AddMeeting;
        private System.Windows.Forms.GroupBox gbox_NoAnswer;
        private System.Windows.Forms.Label lbl_NoAnswer;
        private System.Windows.Forms.Label lbl_Info6;
        private System.Windows.Forms.Button btn_AddReview;
    }
}