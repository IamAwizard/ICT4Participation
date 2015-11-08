namespace ICT4Participation.Forms
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
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.btn_saveanswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_answer
            // 
            this.tb_answer.Location = new System.Drawing.Point(12, 12);
            this.tb_answer.Multiline = true;
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(260, 202);
            this.tb_answer.TabIndex = 0;
            // 
            // btn_saveanswer
            // 
            this.btn_saveanswer.BackColor = System.Drawing.Color.White;
            this.btn_saveanswer.FlatAppearance.BorderSize = 0;
            this.btn_saveanswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_saveanswer.Location = new System.Drawing.Point(67, 219);
            this.btn_saveanswer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveanswer.Name = "btn_saveanswer";
            this.btn_saveanswer.Size = new System.Drawing.Size(148, 33);
            this.btn_saveanswer.TabIndex = 18;
            this.btn_saveanswer.Text = "Bevestig Antwoord";
            this.btn_saveanswer.UseVisualStyleBackColor = false;
            this.btn_saveanswer.Click += new System.EventHandler(this.btn_saveanswer_Click);
            // 
            // Form_Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_saveanswer);
            this.Controls.Add(this.tb_answer);
            this.Name = "Form_Answer";
            this.Text = "Answer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Button btn_saveanswer;
    }
}