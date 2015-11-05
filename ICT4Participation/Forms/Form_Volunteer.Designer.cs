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
            this.lb_withquestions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nameuser = new System.Windows.Forms.Label();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_Respond = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_withquestions
            // 
            this.lb_withquestions.FormattingEnabled = true;
            this.lb_withquestions.ItemHeight = 16;
            this.lb_withquestions.Location = new System.Drawing.Point(12, 12);
            this.lb_withquestions.Name = "lb_withquestions";
            this.lb_withquestions.Size = new System.Drawing.Size(363, 420);
            this.lb_withquestions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(381, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingelogd als:";
            // 
            // lbl_nameuser
            // 
            this.lbl_nameuser.AutoSize = true;
            this.lbl_nameuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_nameuser.ForeColor = System.Drawing.Color.White;
            this.lbl_nameuser.Location = new System.Drawing.Point(496, 30);
            this.lbl_nameuser.Name = "lbl_nameuser";
            this.lbl_nameuser.Size = new System.Drawing.Size(0, 24);
            this.lbl_nameuser.TabIndex = 2;
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.White;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_profile.ForeColor = System.Drawing.Color.Black;
            this.btn_profile.Location = new System.Drawing.Point(392, 104);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(171, 58);
            this.btn_profile.TabIndex = 3;
            this.btn_profile.Text = "Profiel";
            this.btn_profile.UseVisualStyleBackColor = false;
            // 
            // btn_Respond
            // 
            this.btn_Respond.BackColor = System.Drawing.Color.White;
            this.btn_Respond.FlatAppearance.BorderSize = 0;
            this.btn_Respond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Respond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Respond.ForeColor = System.Drawing.Color.Black;
            this.btn_Respond.Location = new System.Drawing.Point(392, 199);
            this.btn_Respond.Name = "btn_Respond";
            this.btn_Respond.Size = new System.Drawing.Size(171, 58);
            this.btn_Respond.TabIndex = 4;
            this.btn_Respond.Text = "Reageer";
            this.btn_Respond.UseVisualStyleBackColor = false;
            // 
            // Form_Volunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(664, 444);
            this.Controls.Add(this.btn_Respond);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.lbl_nameuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_withquestions);
            this.Name = "Form_Volunteer";
            this.Text = "Form_Volunteer";
            this.Load += new System.EventHandler(this.Form_Volunteer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_withquestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nameuser;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_Respond;
    }
}