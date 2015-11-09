namespace ICT4Participation
{
    partial class Form_Answer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Answer));
            this.tbox_Answer = new System.Windows.Forms.TextBox();
            this.btn_SendAnswer = new System.Windows.Forms.Button();
            this.lbl_AnswerTooLong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbox_Answer
            // 
            this.tbox_Answer.Location = new System.Drawing.Point(12, 12);
            this.tbox_Answer.Multiline = true;
            this.tbox_Answer.Name = "tbox_Answer";
            this.tbox_Answer.Size = new System.Drawing.Size(260, 202);
            this.tbox_Answer.TabIndex = 0;
            this.tbox_Answer.TextChanged += new System.EventHandler(this.tbox_Answer_TextChanged);
            // 
            // btn_SendAnswer
            // 
            this.btn_SendAnswer.BackColor = System.Drawing.Color.White;
            this.btn_SendAnswer.FlatAppearance.BorderSize = 0;
            this.btn_SendAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SendAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_SendAnswer.Location = new System.Drawing.Point(67, 219);
            this.btn_SendAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SendAnswer.Name = "btn_SendAnswer";
            this.btn_SendAnswer.Size = new System.Drawing.Size(148, 33);
            this.btn_SendAnswer.TabIndex = 18;
            this.btn_SendAnswer.Text = "Antwoord versturen";
            this.btn_SendAnswer.UseVisualStyleBackColor = false;
            this.btn_SendAnswer.Click += new System.EventHandler(this.btn_saveanswer_Click);
            // 
            // lbl_AnswerTooLong
            // 
            this.lbl_AnswerTooLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_AnswerTooLong.ForeColor = System.Drawing.Color.White;
            this.lbl_AnswerTooLong.Location = new System.Drawing.Point(35, 254);
            this.lbl_AnswerTooLong.Name = "lbl_AnswerTooLong";
            this.lbl_AnswerTooLong.Size = new System.Drawing.Size(218, 43);
            this.lbl_AnswerTooLong.TabIndex = 19;
            this.lbl_AnswerTooLong.Text = "* Antwoord mag niet langer dan 1024 tekens zijn!";
            this.lbl_AnswerTooLong.Visible = false;
            // 
            // Form_Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_AnswerTooLong);
            this.Controls.Add(this.btn_SendAnswer);
            this.Controls.Add(this.tbox_Answer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 330);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form_Answer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voer een antwoord in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_Answer;
        private System.Windows.Forms.Button btn_SendAnswer;
        private System.Windows.Forms.Label lbl_AnswerTooLong;
    }
}