namespace ICT4Participation
{
    partial class Form_MainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainAdmin));
            this.lbox_Questions = new System.Windows.Forms.ListBox();
            this.btn_DeleteQuestion = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.gbox_Reviews = new System.Windows.Forms.GroupBox();
            this.lbox_Reviews = new System.Windows.Forms.ListBox();
            this.btn_DeleteReview = new System.Windows.Forms.Button();
            this.gbox_Questions = new System.Windows.Forms.GroupBox();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.splitter_Prettify = new System.Windows.Forms.SplitContainer();
            this.cbox_NoWarning = new System.Windows.Forms.CheckBox();
            this.gbox_Reviews.SuspendLayout();
            this.gbox_Questions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter_Prettify)).BeginInit();
            this.splitter_Prettify.Panel1.SuspendLayout();
            this.splitter_Prettify.Panel2.SuspendLayout();
            this.splitter_Prettify.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbox_Questions
            // 
            this.lbox_Questions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_Questions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbox_Questions.FormattingEnabled = true;
            this.lbox_Questions.HorizontalScrollbar = true;
            this.lbox_Questions.IntegralHeight = false;
            this.lbox_Questions.Location = new System.Drawing.Point(3, 16);
            this.lbox_Questions.Name = "lbox_Questions";
            this.lbox_Questions.ScrollAlwaysVisible = true;
            this.lbox_Questions.Size = new System.Drawing.Size(399, 288);
            this.lbox_Questions.TabIndex = 0;
            // 
            // btn_DeleteQuestion
            // 
            this.btn_DeleteQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DeleteQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_DeleteQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteQuestion.Location = new System.Drawing.Point(3, 304);
            this.btn_DeleteQuestion.Name = "btn_DeleteQuestion";
            this.btn_DeleteQuestion.Size = new System.Drawing.Size(399, 38);
            this.btn_DeleteQuestion.TabIndex = 2;
            this.btn_DeleteQuestion.Text = "Verwijder geselecteerde item";
            this.btn_DeleteQuestion.UseVisualStyleBackColor = true;
            this.btn_DeleteQuestion.Click += new System.EventHandler(this.btn_DeleteQuestion_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(717, 391);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(105, 38);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Afsluiten";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // gbox_Reviews
            // 
            this.gbox_Reviews.Controls.Add(this.lbox_Reviews);
            this.gbox_Reviews.Controls.Add(this.btn_DeleteReview);
            this.gbox_Reviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_Reviews.Location = new System.Drawing.Point(0, 0);
            this.gbox_Reviews.Name = "gbox_Reviews";
            this.gbox_Reviews.Size = new System.Drawing.Size(401, 345);
            this.gbox_Reviews.TabIndex = 4;
            this.gbox_Reviews.TabStop = false;
            this.gbox_Reviews.Text = "Reviews";
            // 
            // lbox_Reviews
            // 
            this.lbox_Reviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_Reviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbox_Reviews.FormattingEnabled = true;
            this.lbox_Reviews.HorizontalScrollbar = true;
            this.lbox_Reviews.IntegralHeight = false;
            this.lbox_Reviews.Location = new System.Drawing.Point(3, 16);
            this.lbox_Reviews.Name = "lbox_Reviews";
            this.lbox_Reviews.ScrollAlwaysVisible = true;
            this.lbox_Reviews.Size = new System.Drawing.Size(395, 288);
            this.lbox_Reviews.TabIndex = 8;
            // 
            // btn_DeleteReview
            // 
            this.btn_DeleteReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DeleteReview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_DeleteReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteReview.Location = new System.Drawing.Point(3, 304);
            this.btn_DeleteReview.Name = "btn_DeleteReview";
            this.btn_DeleteReview.Size = new System.Drawing.Size(395, 38);
            this.btn_DeleteReview.TabIndex = 7;
            this.btn_DeleteReview.Text = "Verwijder geselecteerde item";
            this.btn_DeleteReview.UseVisualStyleBackColor = true;
            this.btn_DeleteReview.Click += new System.EventHandler(this.btn_DeleteReview_Click);
            // 
            // gbox_Questions
            // 
            this.gbox_Questions.Controls.Add(this.lbox_Questions);
            this.gbox_Questions.Controls.Add(this.btn_DeleteQuestion);
            this.gbox_Questions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_Questions.Location = new System.Drawing.Point(0, 0);
            this.gbox_Questions.Name = "gbox_Questions";
            this.gbox_Questions.Size = new System.Drawing.Size(405, 345);
            this.gbox_Questions.TabIndex = 5;
            this.gbox_Questions.TabStop = false;
            this.gbox_Questions.Text = "Vragen";
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Welcome.Location = new System.Drawing.Point(8, 13);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(178, 24);
            this.lbl_Welcome.TabIndex = 6;
            this.lbl_Welcome.Text = "Welkom, beheerder";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Name.Location = new System.Drawing.Point(181, 13);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(82, 24);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "<Naam>";
            // 
            // splitter_Prettify
            // 
            this.splitter_Prettify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitter_Prettify.IsSplitterFixed = true;
            this.splitter_Prettify.Location = new System.Drawing.Point(12, 40);
            this.splitter_Prettify.Name = "splitter_Prettify";
            // 
            // splitter_Prettify.Panel1
            // 
            this.splitter_Prettify.Panel1.Controls.Add(this.gbox_Reviews);
            // 
            // splitter_Prettify.Panel2
            // 
            this.splitter_Prettify.Panel2.Controls.Add(this.gbox_Questions);
            this.splitter_Prettify.Size = new System.Drawing.Size(810, 345);
            this.splitter_Prettify.SplitterDistance = 401;
            this.splitter_Prettify.TabIndex = 8;
            // 
            // cbox_NoWarning
            // 
            this.cbox_NoWarning.AutoSize = true;
            this.cbox_NoWarning.ForeColor = System.Drawing.Color.Red;
            this.cbox_NoWarning.Location = new System.Drawing.Point(12, 412);
            this.cbox_NoWarning.Name = "cbox_NoWarning";
            this.cbox_NoWarning.Size = new System.Drawing.Size(120, 17);
            this.cbox_NoWarning.TabIndex = 9;
            this.cbox_NoWarning.Text = "Schakel pop-ups uit";
            this.cbox_NoWarning.UseVisualStyleBackColor = true;
            this.cbox_NoWarning.CheckedChanged += new System.EventHandler(this.cbox_NoWarning_CheckedChanged);
            // 
            // Form_MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.cbox_NoWarning);
            this.Controls.Add(this.splitter_Prettify);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.btn_Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(850, 480);
            this.Name = "Form_MainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beheersysteem";
            this.gbox_Reviews.ResumeLayout(false);
            this.gbox_Questions.ResumeLayout(false);
            this.splitter_Prettify.Panel1.ResumeLayout(false);
            this.splitter_Prettify.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter_Prettify)).EndInit();
            this.splitter_Prettify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_Questions;
        private System.Windows.Forms.Button btn_DeleteQuestion;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.GroupBox gbox_Reviews;
        private System.Windows.Forms.GroupBox gbox_Questions;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.ListBox lbox_Reviews;
        private System.Windows.Forms.Button btn_DeleteReview;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.SplitContainer splitter_Prettify;
        private System.Windows.Forms.CheckBox cbox_NoWarning;
    }
}