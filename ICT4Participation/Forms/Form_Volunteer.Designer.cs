namespace ICT4Participation.Forms
{
    partial class Form_Volunteer
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
            this.lb_metquestions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_naamgebruiker = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Reageer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_metquestions
            // 
            this.lb_metquestions.FormattingEnabled = true;
            this.lb_metquestions.ItemHeight = 16;
            this.lb_metquestions.Location = new System.Drawing.Point(12, 12);
            this.lb_metquestions.Name = "lb_metquestions";
            this.lb_metquestions.Size = new System.Drawing.Size(363, 420);
            this.lb_metquestions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(379, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingelogd als:";
            // 
            // lbl_naamgebruiker
            // 
            this.lbl_naamgebruiker.AutoSize = true;
            this.lbl_naamgebruiker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_naamgebruiker.ForeColor = System.Drawing.Color.White;
            this.lbl_naamgebruiker.Location = new System.Drawing.Point(496, 30);
            this.lbl_naamgebruiker.Name = "lbl_naamgebruiker";
            this.lbl_naamgebruiker.Size = new System.Drawing.Size(0, 24);
            this.lbl_naamgebruiker.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(392, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Profiel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Reageer
            // 
            this.btn_Reageer.BackColor = System.Drawing.Color.White;
            this.btn_Reageer.FlatAppearance.BorderSize = 0;
            this.btn_Reageer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reageer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Reageer.ForeColor = System.Drawing.Color.Black;
            this.btn_Reageer.Location = new System.Drawing.Point(392, 199);
            this.btn_Reageer.Name = "btn_Reageer";
            this.btn_Reageer.Size = new System.Drawing.Size(171, 58);
            this.btn_Reageer.TabIndex = 4;
            this.btn_Reageer.Text = "Reageer";
            this.btn_Reageer.UseVisualStyleBackColor = false;
            // 
            // Form_Volunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(664, 444);
            this.Controls.Add(this.btn_Reageer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_naamgebruiker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_metquestions);
            this.Name = "Form_Volunteer";
            this.Text = "Form_Volunteer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_metquestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_naamgebruiker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Reageer;
    }
}