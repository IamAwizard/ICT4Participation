namespace ICT4Participation
{
    partial class Form_Review
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Review));
            this.gbox_Review = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_SendReview = new System.Windows.Forms.Button();
            this.tbox_ReviewContent = new System.Windows.Forms.TextBox();
            this.lbl_ReviewContent = new System.Windows.Forms.Label();
            this.cbox_Rating = new System.Windows.Forms.ComboBox();
            this.lbl_Rating = new System.Windows.Forms.Label();
            this.lbl_ReviewUserInfo = new System.Windows.Forms.Label();
            this.gbox_Review.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_Review
            // 
            this.gbox_Review.Controls.Add(this.lbl_ReviewUserInfo);
            this.gbox_Review.Controls.Add(this.btn_Cancel);
            this.gbox_Review.Controls.Add(this.btn_SendReview);
            this.gbox_Review.Controls.Add(this.tbox_ReviewContent);
            this.gbox_Review.Controls.Add(this.lbl_ReviewContent);
            this.gbox_Review.Controls.Add(this.cbox_Rating);
            this.gbox_Review.Controls.Add(this.lbl_Rating);
            this.gbox_Review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbox_Review.ForeColor = System.Drawing.Color.White;
            this.gbox_Review.Location = new System.Drawing.Point(12, 12);
            this.gbox_Review.Name = "gbox_Review";
            this.gbox_Review.Size = new System.Drawing.Size(534, 348);
            this.gbox_Review.TabIndex = 10;
            this.gbox_Review.TabStop = false;
            this.gbox_Review.Text = "Beoordeling";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cancel.Location = new System.Drawing.Point(299, 309);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(139, 29);
            this.btn_Cancel.TabIndex = 19;
            this.btn_Cancel.Text = "Terug";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SendReview
            // 
            this.btn_SendReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SendReview.BackColor = System.Drawing.Color.White;
            this.btn_SendReview.FlatAppearance.BorderSize = 0;
            this.btn_SendReview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_SendReview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_SendReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SendReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendReview.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_SendReview.Location = new System.Drawing.Point(106, 309);
            this.btn_SendReview.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SendReview.Name = "btn_SendReview";
            this.btn_SendReview.Size = new System.Drawing.Size(139, 29);
            this.btn_SendReview.TabIndex = 18;
            this.btn_SendReview.Text = "Versturen";
            this.btn_SendReview.UseVisualStyleBackColor = false;
            this.btn_SendReview.Click += new System.EventHandler(this.btn_SendReview_Click);
            // 
            // tbox_ReviewContent
            // 
            this.tbox_ReviewContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbox_ReviewContent.Location = new System.Drawing.Point(6, 127);
            this.tbox_ReviewContent.Multiline = true;
            this.tbox_ReviewContent.Name = "tbox_ReviewContent";
            this.tbox_ReviewContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbox_ReviewContent.Size = new System.Drawing.Size(522, 172);
            this.tbox_ReviewContent.TabIndex = 17;
            // 
            // lbl_ReviewContent
            // 
            this.lbl_ReviewContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ReviewContent.Location = new System.Drawing.Point(6, 106);
            this.lbl_ReviewContent.Name = "lbl_ReviewContent";
            this.lbl_ReviewContent.Size = new System.Drawing.Size(124, 18);
            this.lbl_ReviewContent.TabIndex = 16;
            this.lbl_ReviewContent.Text = "Toelichting:";
            // 
            // cbox_Rating
            // 
            this.cbox_Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbox_Rating.FormattingEnabled = true;
            this.cbox_Rating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbox_Rating.Location = new System.Drawing.Point(136, 51);
            this.cbox_Rating.Name = "cbox_Rating";
            this.cbox_Rating.Size = new System.Drawing.Size(43, 28);
            this.cbox_Rating.TabIndex = 15;
            // 
            // lbl_Rating
            // 
            this.lbl_Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Rating.Location = new System.Drawing.Point(6, 43);
            this.lbl_Rating.Name = "lbl_Rating";
            this.lbl_Rating.Size = new System.Drawing.Size(124, 44);
            this.lbl_Rating.TabIndex = 6;
            this.lbl_Rating.Text = "Hoe beoordeelt u dit antwoord?";
            // 
            // lbl_ReviewUserInfo
            // 
            this.lbl_ReviewUserInfo.AutoSize = true;
            this.lbl_ReviewUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ReviewUserInfo.Location = new System.Drawing.Point(6, 22);
            this.lbl_ReviewUserInfo.Name = "lbl_ReviewUserInfo";
            this.lbl_ReviewUserInfo.Size = new System.Drawing.Size(155, 20);
            this.lbl_ReviewUserInfo.TabIndex = 20;
            this.lbl_ReviewUserInfo.Text = "Review van <> op <>";
            this.lbl_ReviewUserInfo.Visible = false;
            // 
            // Form_Review
            // 
            this.AcceptButton = this.btn_SendReview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(559, 366);
            this.Controls.Add(this.gbox_Review);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Review";
            this.Text = "Review Schrijven";
            this.gbox_Review.ResumeLayout(false);
            this.gbox_Review.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_Review;
        private System.Windows.Forms.Button btn_SendReview;
        private System.Windows.Forms.TextBox tbox_ReviewContent;
        private System.Windows.Forms.Label lbl_ReviewContent;
        private System.Windows.Forms.ComboBox cbox_Rating;
        private System.Windows.Forms.Label lbl_Rating;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_ReviewUserInfo;
    }
}