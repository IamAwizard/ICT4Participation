namespace ICT4Participation
{
    partial class Form_Meeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Meeting));
            this.btn_AddMeeting = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tbox_Location = new System.Windows.Forms.TextBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_VolunName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AddMeeting
            // 
            this.btn_AddMeeting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddMeeting.BackColor = System.Drawing.Color.White;
            this.btn_AddMeeting.FlatAppearance.BorderSize = 0;
            this.btn_AddMeeting.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AddMeeting.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AddMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMeeting.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_AddMeeting.Location = new System.Drawing.Point(50, 162);
            this.btn_AddMeeting.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddMeeting.Name = "btn_AddMeeting";
            this.btn_AddMeeting.Size = new System.Drawing.Size(210, 35);
            this.btn_AddMeeting.TabIndex = 7;
            this.btn_AddMeeting.Text = "Bevestigen";
            this.btn_AddMeeting.UseVisualStyleBackColor = false;
            this.btn_AddMeeting.Click += new System.EventHandler(this.btn_AddMeeting_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "dd-MMM-yyy HH:mm";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(13, 125);
            this.dtp_Date.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(277, 24);
            this.dtp_Date.TabIndex = 8;
            // 
            // tbox_Location
            // 
            this.tbox_Location.Location = new System.Drawing.Point(13, 77);
            this.tbox_Location.Name = "tbox_Location";
            this.tbox_Location.Size = new System.Drawing.Size(277, 24);
            this.tbox_Location.TabIndex = 9;
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(10, 56);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(60, 18);
            this.lbl_Location.TabIndex = 10;
            this.lbl_Location.Text = "Locatie:";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(10, 104);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(56, 18);
            this.lbl_Date.TabIndex = 11;
            this.lbl_Date.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Afspraak plannen met:";
            // 
            // lbl_VolunName
            // 
            this.lbl_VolunName.AutoSize = true;
            this.lbl_VolunName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VolunName.Location = new System.Drawing.Point(12, 27);
            this.lbl_VolunName.Name = "lbl_VolunName";
            this.lbl_VolunName.Size = new System.Drawing.Size(69, 18);
            this.lbl_VolunName.TabIndex = 13;
            this.lbl_VolunName.Text = "<naam>";
            // 
            // Form_Meeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(306, 208);
            this.Controls.Add(this.lbl_VolunName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.tbox_Location);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.btn_AddMeeting);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Meeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afspraak Plannen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddMeeting;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tbox_Location;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_VolunName;
    }
}