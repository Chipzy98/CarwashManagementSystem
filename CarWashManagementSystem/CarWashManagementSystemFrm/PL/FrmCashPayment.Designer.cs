namespace CarWashManagementSystem
{
    partial class FrmCashPayment
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
            this.Cashpaypan = new System.Windows.Forms.Panel();
            this.cashPaymenttbl = new System.Windows.Forms.DataGridView();
            this.Paybtn = new System.Windows.Forms.Button();
            this.Appointtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.Cashpaypan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashPaymenttbl)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cashpaypan
            // 
            this.Cashpaypan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cashpaypan.Controls.Add(this.searchbtn);
            this.Cashpaypan.Controls.Add(this.cashPaymenttbl);
            this.Cashpaypan.Controls.Add(this.Paybtn);
            this.Cashpaypan.Controls.Add(this.Appointtxt);
            this.Cashpaypan.Controls.Add(this.label7);
            this.Cashpaypan.Controls.Add(this.panel2);
            this.Cashpaypan.Location = new System.Drawing.Point(0, 0);
            this.Cashpaypan.Name = "Cashpaypan";
            this.Cashpaypan.Size = new System.Drawing.Size(694, 380);
            this.Cashpaypan.TabIndex = 0;
            // 
            // cashPaymenttbl
            // 
            this.cashPaymenttbl.AccessibleName = "tblCashPayment";
            this.cashPaymenttbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashPaymenttbl.Location = new System.Drawing.Point(295, 154);
            this.cashPaymenttbl.Name = "cashPaymenttbl";
            this.cashPaymenttbl.Size = new System.Drawing.Size(342, 107);
            this.cashPaymenttbl.TabIndex = 18;
            // 
            // Paybtn
            // 
            this.Paybtn.AccessibleName = "btnPay";
            this.Paybtn.BackColor = System.Drawing.Color.Lime;
            this.Paybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paybtn.Location = new System.Drawing.Point(524, 299);
            this.Paybtn.Name = "Paybtn";
            this.Paybtn.Size = new System.Drawing.Size(113, 47);
            this.Paybtn.TabIndex = 17;
            this.Paybtn.Text = "Pay";
            this.Paybtn.UseVisualStyleBackColor = false;
            this.Paybtn.Click += new System.EventHandler(this.Paybtn_Click);
            // 
            // Appointtxt
            // 
            this.Appointtxt.AccessibleName = "txtAppointmentId";
            this.Appointtxt.Location = new System.Drawing.Point(276, 50);
            this.Appointtxt.Multiline = true;
            this.Appointtxt.Name = "Appointtxt";
            this.Appointtxt.Size = new System.Drawing.Size(176, 31);
            this.Appointtxt.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AccessibleName = "lblAppointmentId";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Appointment ID :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Backbtn);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 447);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblCashPayment";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cash Payment";
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
            // searchbtn
            // 
            this.searchbtn.AccessibleName = "btnSearch";
            this.searchbtn.BackColor = System.Drawing.Color.LawnGreen;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(492, 44);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(109, 40);
            this.searchbtn.TabIndex = 24;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // FrmCashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 365);
            this.Controls.Add(this.Cashpaypan);
            this.Name = "FrmCashPayment";
            this.Text = "CashPayment";
            this.Load += new System.EventHandler(this.FrmCashPayment_Load);
            this.Cashpaypan.ResumeLayout(false);
            this.Cashpaypan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashPaymenttbl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Cashpaypan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.TextBox Appointtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Paybtn;
        private System.Windows.Forms.DataGridView cashPaymenttbl;
        private System.Windows.Forms.Button searchbtn;
    }
}