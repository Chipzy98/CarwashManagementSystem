namespace CarWashManagementSystem
{
    partial class FrmCardPayment
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
            this.Cardpaypan = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Cnumtxt = new System.Windows.Forms.TextBox();
            this.Chnametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Paybtn = new System.Windows.Forms.Button();
            this.table2 = new System.Windows.Forms.TableLayoutPanel();
            this.Appoint1txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Cardpaypan.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cardpaypan
            // 
            this.Cardpaypan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cardpaypan.Controls.Add(this.dateTimePicker1);
            this.Cardpaypan.Controls.Add(this.Cnumtxt);
            this.Cardpaypan.Controls.Add(this.Chnametxt);
            this.Cardpaypan.Controls.Add(this.label4);
            this.Cardpaypan.Controls.Add(this.label3);
            this.Cardpaypan.Controls.Add(this.label2);
            this.Cardpaypan.Controls.Add(this.Paybtn);
            this.Cardpaypan.Controls.Add(this.table2);
            this.Cardpaypan.Controls.Add(this.Appoint1txt);
            this.Cardpaypan.Controls.Add(this.label7);
            this.Cardpaypan.Controls.Add(this.panel2);
            this.Cardpaypan.Location = new System.Drawing.Point(0, 0);
            this.Cardpaypan.Name = "Cardpaypan";
            this.Cardpaypan.Size = new System.Drawing.Size(694, 449);
            this.Cardpaypan.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleName = "datetimepic";
            this.dateTimePicker1.Location = new System.Drawing.Point(464, 331);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // Cnumtxt
            // 
            this.Cnumtxt.AccessibleName = "txtCardNumber";
            this.Cnumtxt.Location = new System.Drawing.Point(270, 326);
            this.Cnumtxt.Multiline = true;
            this.Cnumtxt.Name = "Cnumtxt";
            this.Cnumtxt.Size = new System.Drawing.Size(176, 31);
            this.Cnumtxt.TabIndex = 26;
            // 
            // Chnametxt
            // 
            this.Chnametxt.AccessibleName = "txtCardHolderName";
            this.Chnametxt.Location = new System.Drawing.Point(270, 261);
            this.Chnametxt.Multiline = true;
            this.Chnametxt.Name = "Chnametxt";
            this.Chnametxt.Size = new System.Drawing.Size(247, 31);
            this.Chnametxt.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AccessibleName = "lblExpireDate";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Expire Date :";
            // 
            // label3
            // 
            this.label3.AccessibleName = "lblCardNumber";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Card Number :";
            // 
            // label2
            // 
            this.label2.AccessibleName = "lblCardHolderName";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Card Holder Name :";
            // 
            // Paybtn
            // 
            this.Paybtn.AccessibleName = "btnPay";
            this.Paybtn.BackColor = System.Drawing.Color.Lime;
            this.Paybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paybtn.Location = new System.Drawing.Point(540, 391);
            this.Paybtn.Name = "Paybtn";
            this.Paybtn.Size = new System.Drawing.Size(113, 47);
            this.Paybtn.TabIndex = 21;
            this.Paybtn.Text = "Pay";
            this.Paybtn.UseVisualStyleBackColor = false;
            // 
            // table2
            // 
            this.table2.AccessibleName = "tableCardPayment";
            this.table2.BackColor = System.Drawing.SystemColors.Control;
            this.table2.ColumnCount = 2;
            this.table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table2.Location = new System.Drawing.Point(270, 89);
            this.table2.Name = "table2";
            this.table2.RowCount = 2;
            this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table2.Size = new System.Drawing.Size(380, 127);
            this.table2.TabIndex = 20;
            // 
            // Appoint1txt
            // 
            this.Appoint1txt.AccessibleName = "txtAppointmentId";
            this.Appoint1txt.Location = new System.Drawing.Point(270, 38);
            this.Appoint1txt.Multiline = true;
            this.Appoint1txt.Name = "Appoint1txt";
            this.Appoint1txt.Size = new System.Drawing.Size(176, 31);
            this.Appoint1txt.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AccessibleName = "lblAppointmentId";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Appointment ID :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Backbtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 447);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblCarPayment";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // CardPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.Cardpaypan);
            this.Name = "CardPayment";
            this.Text = "CardPayment";
            this.Cardpaypan.ResumeLayout(false);
            this.Cardpaypan.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Cardpaypan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button Paybtn;
        private System.Windows.Forms.TableLayoutPanel table2;
        private System.Windows.Forms.TextBox Appoint1txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Cnumtxt;
        private System.Windows.Forms.TextBox Chnametxt;
        private System.Windows.Forms.Label label4;
    }
}