namespace ICT4Participation
{
    partial class Form_AcceptQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AcceptQuestion));
            this.lbl_Question = new System.Windows.Forms.Label();
            this.lbl_Transport = new System.Windows.Forms.Label();
            this.lbl_Discrepancy = new System.Windows.Forms.Label();
            this.lbl_Distance = new System.Windows.Forms.Label();
            this.tbox_Discrepancy = new System.Windows.Forms.TextBox();
            this.tbox_Transport = new System.Windows.Forms.TextBox();
            this.tbox_Distance = new System.Windows.Forms.TextBox();
            this.btn_acceptassignment = new System.Windows.Forms.Button();
            this.tbox_Question = new System.Windows.Forms.TextBox();
            this.tbox_Location = new System.Windows.Forms.TextBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_ClientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Question.ForeColor = System.Drawing.Color.White;
            this.lbl_Question.Location = new System.Drawing.Point(11, 9);
            this.lbl_Question.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(95, 24);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Text = "Vraag van";
            // 
            // lbl_Transport
            // 
            this.lbl_Transport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Transport.AutoSize = true;
            this.lbl_Transport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Transport.ForeColor = System.Drawing.Color.White;
            this.lbl_Transport.Location = new System.Drawing.Point(9, 404);
            this.lbl_Transport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Transport.Name = "lbl_Transport";
            this.lbl_Transport.Size = new System.Drawing.Size(110, 18);
            this.lbl_Transport.TabIndex = 4;
            this.lbl_Transport.Text = "Vervoersmiddel";
            // 
            // lbl_Discrepancy
            // 
            this.lbl_Discrepancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Discrepancy.AutoSize = true;
            this.lbl_Discrepancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Discrepancy.ForeColor = System.Drawing.Color.White;
            this.lbl_Discrepancy.Location = new System.Drawing.Point(22, 332);
            this.lbl_Discrepancy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Discrepancy.Name = "lbl_Discrepancy";
            this.lbl_Discrepancy.Size = new System.Drawing.Size(97, 18);
            this.lbl_Discrepancy.TabIndex = 5;
            this.lbl_Discrepancy.Text = "Bijzonderheid";
            // 
            // lbl_Distance
            // 
            this.lbl_Distance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Distance.AutoSize = true;
            this.lbl_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Distance.ForeColor = System.Drawing.Color.White;
            this.lbl_Distance.Location = new System.Drawing.Point(62, 380);
            this.lbl_Distance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Distance.Name = "lbl_Distance";
            this.lbl_Distance.Size = new System.Drawing.Size(57, 18);
            this.lbl_Distance.TabIndex = 6;
            this.lbl_Distance.Text = "Afstand";
            // 
            // tbox_Discrepancy
            // 
            this.tbox_Discrepancy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Discrepancy.Location = new System.Drawing.Point(148, 330);
            this.tbox_Discrepancy.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Discrepancy.Name = "tbox_Discrepancy";
            this.tbox_Discrepancy.ReadOnly = true;
            this.tbox_Discrepancy.Size = new System.Drawing.Size(260, 20);
            this.tbox_Discrepancy.TabIndex = 7;
            // 
            // tbox_Transport
            // 
            this.tbox_Transport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Transport.Location = new System.Drawing.Point(148, 402);
            this.tbox_Transport.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Transport.Name = "tbox_Transport";
            this.tbox_Transport.ReadOnly = true;
            this.tbox_Transport.Size = new System.Drawing.Size(260, 20);
            this.tbox_Transport.TabIndex = 9;
            // 
            // tbox_Distance
            // 
            this.tbox_Distance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Distance.Location = new System.Drawing.Point(148, 378);
            this.tbox_Distance.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Distance.Name = "tbox_Distance";
            this.tbox_Distance.ReadOnly = true;
            this.tbox_Distance.Size = new System.Drawing.Size(260, 20);
            this.tbox_Distance.TabIndex = 10;
            // 
            // btn_acceptassignment
            // 
            this.btn_acceptassignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_acceptassignment.BackColor = System.Drawing.Color.White;
            this.btn_acceptassignment.FlatAppearance.BorderSize = 0;
            this.btn_acceptassignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acceptassignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_acceptassignment.Location = new System.Drawing.Point(132, 447);
            this.btn_acceptassignment.Margin = new System.Windows.Forms.Padding(2);
            this.btn_acceptassignment.Name = "btn_acceptassignment";
            this.btn_acceptassignment.Size = new System.Drawing.Size(148, 33);
            this.btn_acceptassignment.TabIndex = 17;
            this.btn_acceptassignment.Text = "Accepteer opdracht";
            this.btn_acceptassignment.UseVisualStyleBackColor = false;
            this.btn_acceptassignment.Click += new System.EventHandler(this.btn_acceptassignment_Click);
            // 
            // tbox_Question
            // 
            this.tbox_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Question.Location = new System.Drawing.Point(15, 42);
            this.tbox_Question.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Question.Multiline = true;
            this.tbox_Question.Name = "tbox_Question";
            this.tbox_Question.ReadOnly = true;
            this.tbox_Question.Size = new System.Drawing.Size(393, 274);
            this.tbox_Question.TabIndex = 18;
            // 
            // tbox_Location
            // 
            this.tbox_Location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Location.Location = new System.Drawing.Point(148, 354);
            this.tbox_Location.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Location.Name = "tbox_Location";
            this.tbox_Location.ReadOnly = true;
            this.tbox_Location.Size = new System.Drawing.Size(260, 20);
            this.tbox_Location.TabIndex = 21;
            // 
            // lbl_Location
            // 
            this.lbl_Location.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Location.ForeColor = System.Drawing.Color.White;
            this.lbl_Location.Location = new System.Drawing.Point(63, 356);
            this.lbl_Location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(56, 18);
            this.lbl_Location.TabIndex = 20;
            this.lbl_Location.Text = "Locatie";
            // 
            // lbl_ClientName
            // 
            this.lbl_ClientName.AutoSize = true;
            this.lbl_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_ClientName.ForeColor = System.Drawing.Color.White;
            this.lbl_ClientName.Location = new System.Drawing.Point(102, 9);
            this.lbl_ClientName.Name = "lbl_ClientName";
            this.lbl_ClientName.Size = new System.Drawing.Size(79, 24);
            this.lbl_ClientName.TabIndex = 22;
            this.lbl_ClientName.Text = "<Client>";
            // 
            // Form_AcceptQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(424, 491);
            this.Controls.Add(this.lbl_ClientName);
            this.Controls.Add(this.tbox_Location);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.tbox_Question);
            this.Controls.Add(this.btn_acceptassignment);
            this.Controls.Add(this.tbox_Distance);
            this.Controls.Add(this.tbox_Transport);
            this.Controls.Add(this.tbox_Discrepancy);
            this.Controls.Add(this.lbl_Distance);
            this.Controls.Add(this.lbl_Discrepancy);
            this.Controls.Add(this.lbl_Transport);
            this.Controls.Add(this.lbl_Question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(440, 530);
            this.Name = "Form_AcceptQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vraag Accepteren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Label lbl_Transport;
        private System.Windows.Forms.Label lbl_Discrepancy;
        private System.Windows.Forms.Label lbl_Distance;
        private System.Windows.Forms.TextBox tbox_Discrepancy;
        private System.Windows.Forms.TextBox tbox_Transport;
        private System.Windows.Forms.TextBox tbox_Distance;
        private System.Windows.Forms.Button btn_acceptassignment;
        private System.Windows.Forms.TextBox tbox_Question;
        private System.Windows.Forms.TextBox tbox_Location;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_ClientName;
    }
}