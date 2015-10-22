namespace ICT4Participation.Forms
{
    partial class Form_MainVolunteer
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
            this.pnl_opdrachtaanvaard = new System.Windows.Forms.Panel();
            this.pnl_profiel = new System.Windows.Forms.Panel();
            this.lbl_opdracht = new System.Windows.Forms.Label();
            this.lbl_reistijd = new System.Windows.Forms.Label();
            this.lbl_bijzonder = new System.Windows.Forms.Label();
            this.lbl_vervoersmiddel = new System.Windows.Forms.Label();
            this.lbl_afstand = new System.Windows.Forms.Label();
            this.tb_reistijd = new System.Windows.Forms.TextBox();
            this.tb_bijzonder = new System.Windows.Forms.TextBox();
            this.tb_afstand = new System.Windows.Forms.TextBox();
            this.tb_vervoersmiddel = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_accepteer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_VOG = new System.Windows.Forms.Label();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_naamdonotuse = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_opdrachtaanvaard.SuspendLayout();
            this.pnl_profiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_opdrachtaanvaard
            // 
            this.pnl_opdrachtaanvaard.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl_opdrachtaanvaard.Controls.Add(this.btn_accepteer);
            this.pnl_opdrachtaanvaard.Controls.Add(this.btn_back);
            this.pnl_opdrachtaanvaard.Controls.Add(this.tb_vervoersmiddel);
            this.pnl_opdrachtaanvaard.Controls.Add(this.tb_afstand);
            this.pnl_opdrachtaanvaard.Controls.Add(this.tb_bijzonder);
            this.pnl_opdrachtaanvaard.Controls.Add(this.tb_reistijd);
            this.pnl_opdrachtaanvaard.Controls.Add(this.lbl_afstand);
            this.pnl_opdrachtaanvaard.Controls.Add(this.lbl_vervoersmiddel);
            this.pnl_opdrachtaanvaard.Controls.Add(this.lbl_bijzonder);
            this.pnl_opdrachtaanvaard.Controls.Add(this.lbl_reistijd);
            this.pnl_opdrachtaanvaard.Controls.Add(this.lbl_opdracht);
            this.pnl_opdrachtaanvaard.Location = new System.Drawing.Point(1, 2);
            this.pnl_opdrachtaanvaard.Name = "pnl_opdrachtaanvaard";
            this.pnl_opdrachtaanvaard.Size = new System.Drawing.Size(561, 522);
            this.pnl_opdrachtaanvaard.TabIndex = 0;
            // 
            // pnl_profiel
            // 
            this.pnl_profiel.Controls.Add(this.label4);
            this.pnl_profiel.Controls.Add(this.lbl_naamdonotuse);
            this.pnl_profiel.Controls.Add(this.label2);
            this.pnl_profiel.Controls.Add(this.label1);
            this.pnl_profiel.Controls.Add(this.lbl_score);
            this.pnl_profiel.Controls.Add(this.lbl_rating);
            this.pnl_profiel.Controls.Add(this.lbl_VOG);
            this.pnl_profiel.Controls.Add(this.pictureBox1);
            this.pnl_profiel.Location = new System.Drawing.Point(1, 2);
            this.pnl_profiel.Name = "pnl_profiel";
            this.pnl_profiel.Size = new System.Drawing.Size(561, 519);
            this.pnl_profiel.TabIndex = 0;
            this.pnl_profiel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_profiel_Paint);
            // 
            // lbl_opdracht
            // 
            this.lbl_opdracht.AutoSize = true;
            this.lbl_opdracht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_opdracht.Location = new System.Drawing.Point(206, 42);
            this.lbl_opdracht.Name = "lbl_opdracht";
            this.lbl_opdracht.Size = new System.Drawing.Size(112, 29);
            this.lbl_opdracht.TabIndex = 0;
            this.lbl_opdracht.Text = "Opdracht";
            // 
            // lbl_reistijd
            // 
            this.lbl_reistijd.AutoSize = true;
            this.lbl_reistijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reistijd.ForeColor = System.Drawing.Color.White;
            this.lbl_reistijd.Location = new System.Drawing.Point(44, 133);
            this.lbl_reistijd.Name = "lbl_reistijd";
            this.lbl_reistijd.Size = new System.Drawing.Size(70, 24);
            this.lbl_reistijd.TabIndex = 1;
            this.lbl_reistijd.Text = "Reistijd";
            // 
            // lbl_bijzonder
            // 
            this.lbl_bijzonder.AutoSize = true;
            this.lbl_bijzonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bijzonder.ForeColor = System.Drawing.Color.White;
            this.lbl_bijzonder.Location = new System.Drawing.Point(44, 198);
            this.lbl_bijzonder.Name = "lbl_bijzonder";
            this.lbl_bijzonder.Size = new System.Drawing.Size(126, 24);
            this.lbl_bijzonder.TabIndex = 2;
            this.lbl_bijzonder.Text = "Bijzonderheid";
            // 
            // lbl_vervoersmiddel
            // 
            this.lbl_vervoersmiddel.AutoSize = true;
            this.lbl_vervoersmiddel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vervoersmiddel.ForeColor = System.Drawing.Color.White;
            this.lbl_vervoersmiddel.Location = new System.Drawing.Point(44, 330);
            this.lbl_vervoersmiddel.Name = "lbl_vervoersmiddel";
            this.lbl_vervoersmiddel.Size = new System.Drawing.Size(143, 24);
            this.lbl_vervoersmiddel.TabIndex = 3;
            this.lbl_vervoersmiddel.Text = "Vervoersmiddel";
            // 
            // lbl_afstand
            // 
            this.lbl_afstand.AutoSize = true;
            this.lbl_afstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_afstand.ForeColor = System.Drawing.Color.White;
            this.lbl_afstand.Location = new System.Drawing.Point(44, 262);
            this.lbl_afstand.Name = "lbl_afstand";
            this.lbl_afstand.Size = new System.Drawing.Size(72, 24);
            this.lbl_afstand.TabIndex = 4;
            this.lbl_afstand.Text = "Afstand";
            // 
            // tb_reistijd
            // 
            this.tb_reistijd.Location = new System.Drawing.Point(217, 124);
            this.tb_reistijd.Multiline = true;
            this.tb_reistijd.Name = "tb_reistijd";
            this.tb_reistijd.Size = new System.Drawing.Size(250, 42);
            this.tb_reistijd.TabIndex = 5;
            // 
            // tb_bijzonder
            // 
            this.tb_bijzonder.Location = new System.Drawing.Point(217, 198);
            this.tb_bijzonder.Multiline = true;
            this.tb_bijzonder.Name = "tb_bijzonder";
            this.tb_bijzonder.Size = new System.Drawing.Size(250, 42);
            this.tb_bijzonder.TabIndex = 6;
            // 
            // tb_afstand
            // 
            this.tb_afstand.Location = new System.Drawing.Point(217, 262);
            this.tb_afstand.Multiline = true;
            this.tb_afstand.Name = "tb_afstand";
            this.tb_afstand.Size = new System.Drawing.Size(250, 42);
            this.tb_afstand.TabIndex = 7;
            // 
            // tb_vervoersmiddel
            // 
            this.tb_vervoersmiddel.Location = new System.Drawing.Point(217, 330);
            this.tb_vervoersmiddel.Multiline = true;
            this.tb_vervoersmiddel.Name = "tb_vervoersmiddel";
            this.tb_vervoersmiddel.Size = new System.Drawing.Size(250, 42);
            this.tb_vervoersmiddel.TabIndex = 8;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(338, 396);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(189, 43);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_accepteer
            // 
            this.btn_accepteer.BackColor = System.Drawing.Color.White;
            this.btn_accepteer.FlatAppearance.BorderSize = 0;
            this.btn_accepteer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_accepteer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_accepteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accepteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accepteer.Location = new System.Drawing.Point(338, 453);
            this.btn_accepteer.Name = "btn_accepteer";
            this.btn_accepteer.Size = new System.Drawing.Size(189, 43);
            this.btn_accepteer.TabIndex = 10;
            this.btn_accepteer.Text = "Accepteer opdracht";
            this.btn_accepteer.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 197);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_VOG
            // 
            this.lbl_VOG.AutoSize = true;
            this.lbl_VOG.Location = new System.Drawing.Point(428, 42);
            this.lbl_VOG.Name = "lbl_VOG";
            this.lbl_VOG.Size = new System.Drawing.Size(39, 17);
            this.lbl_VOG.TabIndex = 1;
            this.lbl_VOG.Text = "VOG";
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.Location = new System.Drawing.Point(217, 42);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(49, 17);
            this.lbl_rating.TabIndex = 2;
            this.lbl_rating.Text = "Rating";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Location = new System.Drawing.Point(217, 71);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(16, 17);
            this.lbl_score.TabIndex = 3;
            this.lbl_score.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // lbl_naamdonotuse
            // 
            this.lbl_naamdonotuse.AutoSize = true;
            this.lbl_naamdonotuse.Location = new System.Drawing.Point(11, 234);
            this.lbl_naamdonotuse.Name = "lbl_naamdonotuse";
            this.lbl_naamdonotuse.Size = new System.Drawing.Size(49, 17);
            this.lbl_naamdonotuse.TabIndex = 6;
            this.lbl_naamdonotuse.Text = "Naam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // Form_MainVolunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(567, 520);
            this.Controls.Add(this.pnl_profiel);
            this.Controls.Add(this.pnl_opdrachtaanvaard);
            this.Name = "Form_MainVolunteer";
            this.Text = "Form_MainVolunteer";
            this.pnl_opdrachtaanvaard.ResumeLayout(false);
            this.pnl_opdrachtaanvaard.PerformLayout();
            this.pnl_profiel.ResumeLayout(false);
            this.pnl_profiel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_opdrachtaanvaard;
        private System.Windows.Forms.Button btn_accepteer;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tb_vervoersmiddel;
        private System.Windows.Forms.TextBox tb_afstand;
        private System.Windows.Forms.TextBox tb_bijzonder;
        private System.Windows.Forms.TextBox tb_reistijd;
        private System.Windows.Forms.Label lbl_afstand;
        private System.Windows.Forms.Label lbl_vervoersmiddel;
        private System.Windows.Forms.Label lbl_bijzonder;
        private System.Windows.Forms.Label lbl_reistijd;
        private System.Windows.Forms.Label lbl_opdracht;
        private System.Windows.Forms.Panel pnl_profiel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_naamdonotuse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.Label lbl_VOG;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}