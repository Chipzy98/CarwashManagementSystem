namespace CarWashManagementSystem
{
    partial class FrmAppointment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Cusnametxt = new System.Windows.Forms.TextBox();
            this.Email1txt = new System.Windows.Forms.TextBox();
            this.Mnum1txt = new System.Windows.Forms.TextBox();
            this.Nic1txt = new System.Windows.Forms.TextBox();
            this.Appointtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.domainUpDown1);
            this.panel1.Controls.Add(this.Addbtn);
            this.panel1.Controls.Add(this.Clearbtn);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Cusnametxt);
            this.panel1.Controls.Add(this.Email1txt);
            this.panel1.Controls.Add(this.Mnum1txt);
            this.panel1.Controls.Add(this.Nic1txt);
            this.panel1.Controls.Add(this.Appointtxt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 450);
            this.panel1.TabIndex = 0;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.AccessibleName = "dropDownServiceType";
            this.domainUpDown1.Items.Add("Full Service");
            this.domainUpDown1.Items.Add("Body Wash");
            this.domainUpDown1.Location = new System.Drawing.Point(258, 315);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 23;
            this.domainUpDown1.Text = "Select";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // Addbtn
            // 
            this.Addbtn.AccessibleName = "btnAdd";
            this.Addbtn.BackColor = System.Drawing.Color.Lime;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(679, 396);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(94, 41);
            this.Addbtn.TabIndex = 22;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            // 
            // Clearbtn
            // 
            this.Clearbtn.AccessibleName = "btnClear";
            this.Clearbtn.BackColor = System.Drawing.Color.Red;
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clearbtn.Location = new System.Drawing.Point(553, 396);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(94, 41);
            this.Clearbtn.TabIndex = 21;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleName = "dateTimepic";
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // Cusnametxt
            // 
            this.Cusnametxt.AccessibleName = "txtName";
            this.Cusnametxt.Location = new System.Drawing.Point(256, 113);
            this.Cusnametxt.Multiline = true;
            this.Cusnametxt.Name = "Cusnametxt";
            this.Cusnametxt.Size = new System.Drawing.Size(176, 31);
            this.Cusnametxt.TabIndex = 17;
            // 
            // Email1txt
            // 
            this.Email1txt.AccessibleName = "txtEmail";
            this.Email1txt.Location = new System.Drawing.Point(519, 177);
            this.Email1txt.Multiline = true;
            this.Email1txt.Name = "Email1txt";
            this.Email1txt.Size = new System.Drawing.Size(176, 31);
            this.Email1txt.TabIndex = 16;
            // 
            // Mnum1txt
            // 
            this.Mnum1txt.AccessibleName = "txtMobile";
            this.Mnum1txt.Location = new System.Drawing.Point(256, 177);
            this.Mnum1txt.Multiline = true;
            this.Mnum1txt.Name = "Mnum1txt";
            this.Mnum1txt.Size = new System.Drawing.Size(176, 31);
            this.Mnum1txt.TabIndex = 15;
            // 
            // Nic1txt
            // 
            this.Nic1txt.AccessibleName = "txtNic";
            this.Nic1txt.Location = new System.Drawing.Point(519, 51);
            this.Nic1txt.Multiline = true;
            this.Nic1txt.Name = "Nic1txt";
            this.Nic1txt.Size = new System.Drawing.Size(176, 31);
            this.Nic1txt.TabIndex = 14;
            // 
            // Appointtxt
            // 
            this.Appointtxt.AccessibleName = "txtAppointmentID";
            this.Appointtxt.Location = new System.Drawing.Point(256, 51);
            this.Appointtxt.Multiline = true;
            this.Appointtxt.Name = "Appointtxt";
            this.Appointtxt.Size = new System.Drawing.Size(176, 31);
            this.Appointtxt.TabIndex = 13;
            this.Appointtxt.TextChanged += new System.EventHandler(this.Appointtxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AccessibleName = "lblServiceType";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Service Type :";
            // 
            // label8
            // 
            this.label8.AccessibleName = "lblDateTime";
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(253, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date / Time :";
            // 
            // label7
            // 
            this.label7.AccessibleName = "lblAppointmentID";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Appointment ID :";
            // 
            // label5
            // 
            this.label5.AccessibleName = "lblEmail";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AccessibleName = "lblMobile";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mobile :";
            // 
            // label3
            // 
            this.label3.AccessibleName = "lblNic";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "NIC :";
            // 
            // label2
            // 
            this.label2.AccessibleName = "lblName";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Backbtn);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 447);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblAppointment";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Appointment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Backbtn
            // 
            this.Backbtn.AccessibleName = "btnBack";
            this.Backbtn.BackColor = System.Drawing.Color.Red;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backbtn.Location = new System.Drawing.Point(5, 5);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(104, 40);
            this.Backbtn.TabIndex = 1;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Cusnametxt;
        private System.Windows.Forms.TextBox Email1txt;
        private System.Windows.Forms.TextBox Mnum1txt;
        private System.Windows.Forms.TextBox Nic1txt;
        private System.Windows.Forms.TextBox Appointtxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}