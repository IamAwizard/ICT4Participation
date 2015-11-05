namespace ICT4Participation.Forms
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
            this.lb_Questions = new System.Windows.Forms.ListBox();
            this.lb_Reviews = new System.Windows.Forms.ListBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.Vragen = new System.Windows.Forms.Label();
            this.lbl_Reviews = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Questions
            // 
            this.lb_Questions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Questions.FormattingEnabled = true;
            this.lb_Questions.ItemHeight = 18;
            this.lb_Questions.Location = new System.Drawing.Point(285, 37);
            this.lb_Questions.Name = "lb_Questions";
            this.lb_Questions.Size = new System.Drawing.Size(252, 238);
            this.lb_Questions.TabIndex = 0;
            // 
            // lb_Reviews
            // 
            this.lb_Reviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Reviews.FormattingEnabled = true;
            this.lb_Reviews.ItemHeight = 18;
            this.lb_Reviews.Location = new System.Drawing.Point(12, 37);
            this.lb_Reviews.Name = "lb_Reviews";
            this.lb_Reviews.Size = new System.Drawing.Size(248, 238);
            this.lb_Reviews.TabIndex = 1;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(285, 297);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(224, 38);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Verwijder geselecteerde item";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(432, 372);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(105, 38);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Terug";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // Vragen
            // 
            this.Vragen.AutoSize = true;
            this.Vragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vragen.Location = new System.Drawing.Point(296, 13);
            this.Vragen.Name = "Vragen";
            this.Vragen.Size = new System.Drawing.Size(54, 18);
            this.Vragen.TabIndex = 4;
            this.Vragen.Text = "Vragen";
            // 
            // lbl_Reviews
            // 
            this.lbl_Reviews.AutoSize = true;
            this.lbl_Reviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reviews.Location = new System.Drawing.Point(12, 13);
            this.lbl_Reviews.Name = "lbl_Reviews";
            this.lbl_Reviews.Size = new System.Drawing.Size(103, 18);
            this.lbl_Reviews.TabIndex = 5;
            this.lbl_Reviews.Text = "Beoordelingen";
            // 
            // Form_MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(571, 422);
            this.Controls.Add(this.lbl_Reviews);
            this.Controls.Add(this.Vragen);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lb_Reviews);
            this.Controls.Add(this.lb_Questions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_MainAdmin";
            this.Text = "Form_MainAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Questions;
        private System.Windows.Forms.ListBox lb_Reviews;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label Vragen;
        private System.Windows.Forms.Label lbl_Reviews;
    }
}