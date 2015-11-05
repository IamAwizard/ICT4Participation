namespace ICT4Participation
{
    partial class Form_Question
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_assignment = new System.Windows.Forms.TextBox();
            this.tb_specialty = new System.Windows.Forms.TextBox();
            this.btn_chat = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "De opdracht";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bijzonderheid";
            // 
            // tb_assignment
            // 
            this.tb_assignment.Location = new System.Drawing.Point(134, 12);
            this.tb_assignment.Multiline = true;
            this.tb_assignment.Name = "tb_assignment";
            this.tb_assignment.Size = new System.Drawing.Size(481, 229);
            this.tb_assignment.TabIndex = 4;
            // 
            // tb_specialty
            // 
            this.tb_specialty.Location = new System.Drawing.Point(16, 292);
            this.tb_specialty.Multiline = true;
            this.tb_specialty.Name = "tb_specialty";
            this.tb_specialty.Size = new System.Drawing.Size(305, 159);
            this.tb_specialty.TabIndex = 5;
            // 
            // btn_chat
            // 
            this.btn_chat.BackColor = System.Drawing.Color.White;
            this.btn_chat.FlatAppearance.BorderSize = 0;
            this.btn_chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_chat.Location = new System.Drawing.Point(412, 292);
            this.btn_chat.Name = "btn_chat";
            this.btn_chat.Size = new System.Drawing.Size(175, 50);
            this.btn_chat.TabIndex = 6;
            this.btn_chat.Text = "Chat";
            this.btn_chat.UseVisualStyleBackColor = false;
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.White;
            this.btn_accept.FlatAppearance.BorderSize = 0;
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_accept.Location = new System.Drawing.Point(412, 377);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(175, 50);
            this.btn_accept.TabIndex = 7;
            this.btn_accept.Text = "Accepteren";
            this.btn_accept.UseVisualStyleBackColor = false;
            // 
            // Form_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(645, 510);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.btn_chat);
            this.Controls.Add(this.tb_specialty);
            this.Controls.Add(this.tb_assignment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Question";
            this.Text = "Form_Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_assignment;
        private System.Windows.Forms.TextBox tb_specialty;
        private System.Windows.Forms.Button btn_chat;
        private System.Windows.Forms.Button btn_accept;
    }
}