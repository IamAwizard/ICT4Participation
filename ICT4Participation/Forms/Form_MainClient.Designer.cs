namespace ICT4Participation.Forms
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
            this.lbl_locatie = new System.Windows.Forms.Label();
            this.lbl_bijzonderheid = new System.Windows.Forms.Label();
            this.lbl_zoekhulp = new System.Windows.Forms.Label();
            this.btn_stelvraag = new System.Windows.Forms.Button();
            this.lb_vragen = new System.Windows.Forms.ListBox();
            this.tb_bijzonderheid = new System.Windows.Forms.TextBox();
            this.tb_vraag = new System.Windows.Forms.TextBox();
            this.tb_locatie = new System.Windows.Forms.TextBox();
            this.lbl_stelvraag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_locatie
            // 
            this.lbl_locatie.AutoSize = true;
            this.lbl_locatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_locatie.ForeColor = System.Drawing.Color.White;
            this.lbl_locatie.Location = new System.Drawing.Point(34, 311);
            this.lbl_locatie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_locatie.Name = "lbl_locatie";
            this.lbl_locatie.Size = new System.Drawing.Size(56, 18);
            this.lbl_locatie.TabIndex = 0;
            this.lbl_locatie.Text = "Locatie";
            // 
            // lbl_bijzonderheid
            // 
            this.lbl_bijzonderheid.AutoSize = true;
            this.lbl_bijzonderheid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bijzonderheid.ForeColor = System.Drawing.Color.White;
            this.lbl_bijzonderheid.Location = new System.Drawing.Point(34, 361);
            this.lbl_bijzonderheid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bijzonderheid.Name = "lbl_bijzonderheid";
            this.lbl_bijzonderheid.Size = new System.Drawing.Size(97, 18);
            this.lbl_bijzonderheid.TabIndex = 1;
            this.lbl_bijzonderheid.Text = "Bijzonderheid";
            // 
            // lbl_zoekhulp
            // 
            this.lbl_zoekhulp.AutoSize = true;
            this.lbl_zoekhulp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zoekhulp.ForeColor = System.Drawing.Color.White;
            this.lbl_zoekhulp.Location = new System.Drawing.Point(34, 221);
            this.lbl_zoekhulp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_zoekhulp.Name = "lbl_zoekhulp";
            this.lbl_zoekhulp.Size = new System.Drawing.Size(73, 18);
            this.lbl_zoekhulp.TabIndex = 2;
            this.lbl_zoekhulp.Text = "Zoek hulp";
            // 
            // btn_stelvraag
            // 
            this.btn_stelvraag.BackColor = System.Drawing.Color.White;
            this.btn_stelvraag.FlatAppearance.BorderSize = 0;
            this.btn_stelvraag.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_stelvraag.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_stelvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stelvraag.Location = new System.Drawing.Point(442, 254);
            this.btn_stelvraag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_stelvraag.Name = "btn_stelvraag";
            this.btn_stelvraag.Size = new System.Drawing.Size(64, 130);
            this.btn_stelvraag.TabIndex = 4;
            this.btn_stelvraag.Text = "Stel Vraag";
            this.btn_stelvraag.UseVisualStyleBackColor = false;
            // 
            // lb_vragen
            // 
            this.lb_vragen.BackColor = System.Drawing.Color.White;
            this.lb_vragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vragen.FormattingEnabled = true;
            this.lb_vragen.ItemHeight = 17;
            this.lb_vragen.Location = new System.Drawing.Point(16, 10);
            this.lb_vragen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_vragen.Name = "lb_vragen";
            this.lb_vragen.Size = new System.Drawing.Size(484, 191);
            this.lb_vragen.TabIndex = 5;
            // 
            // tb_bijzonderheid
            // 
            this.tb_bijzonderheid.Location = new System.Drawing.Point(210, 353);
            this.tb_bijzonderheid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_bijzonderheid.Multiline = true;
            this.tb_bijzonderheid.Name = "tb_bijzonderheid";
            this.tb_bijzonderheid.Size = new System.Drawing.Size(212, 32);
            this.tb_bijzonderheid.TabIndex = 6;
            // 
            // tb_vraag
            // 
            this.tb_vraag.Location = new System.Drawing.Point(210, 254);
            this.tb_vraag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_vraag.Multiline = true;
            this.tb_vraag.Name = "tb_vraag";
            this.tb_vraag.Size = new System.Drawing.Size(212, 32);
            this.tb_vraag.TabIndex = 7;
            // 
            // tb_locatie
            // 
            this.tb_locatie.Location = new System.Drawing.Point(210, 303);
            this.tb_locatie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_locatie.Multiline = true;
            this.tb_locatie.Name = "tb_locatie";
            this.tb_locatie.Size = new System.Drawing.Size(212, 32);
            this.tb_locatie.TabIndex = 8;
            // 
            // lbl_stelvraag
            // 
            this.lbl_stelvraag.AutoSize = true;
            this.lbl_stelvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stelvraag.ForeColor = System.Drawing.Color.White;
            this.lbl_stelvraag.Location = new System.Drawing.Point(34, 266);
            this.lbl_stelvraag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_stelvraag.Name = "lbl_stelvraag";
            this.lbl_stelvraag.Size = new System.Drawing.Size(124, 18);
            this.lbl_stelvraag.TabIndex = 9;
            this.lbl_stelvraag.Text = "Stel hier uw vraag";
            // 
            // Form_MainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(517, 431);
            this.Controls.Add(this.lbl_stelvraag);
            this.Controls.Add(this.tb_locatie);
            this.Controls.Add(this.tb_vraag);
            this.Controls.Add(this.tb_bijzonderheid);
            this.Controls.Add(this.lb_vragen);
            this.Controls.Add(this.btn_stelvraag);
            this.Controls.Add(this.lbl_zoekhulp);
            this.Controls.Add(this.lbl_bijzonderheid);
            this.Controls.Add(this.lbl_locatie);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_MainClient";
            this.Text = "Form_MainClient";
            this.Load += new System.EventHandler(this.Form_MainClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_locatie;
        private System.Windows.Forms.Label lbl_bijzonderheid;
        private System.Windows.Forms.Label lbl_zoekhulp;
        private System.Windows.Forms.Button btn_stelvraag;
        private System.Windows.Forms.ListBox lb_vragen;
        private System.Windows.Forms.TextBox tb_bijzonderheid;
        private System.Windows.Forms.TextBox tb_vraag;
        private System.Windows.Forms.TextBox tb_locatie;
        private System.Windows.Forms.Label lbl_stelvraag;
    }
}