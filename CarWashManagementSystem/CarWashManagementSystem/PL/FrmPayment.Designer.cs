namespace CarWashManagementSystem
{
    partial class FrmPayment
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
            this.cardPaymentbtn = new System.Windows.Forms.Button();
            this.cashPaymentbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.cardPaymentbtn);
            this.panel1.Controls.Add(this.cashPaymentbtn);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 370);
            this.panel1.TabIndex = 0;
            // 
            // cardPaymentbtn
            // 
            this.cardPaymentbtn.AccessibleName = "btnCardPayment";
            this.cardPaymentbtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.cardPaymentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardPaymentbtn.Location = new System.Drawing.Point(59, 206);
            this.cardPaymentbtn.Name = "cardPaymentbtn";
            this.cardPaymentbtn.Size = new System.Drawing.Size(197, 49);
            this.cardPaymentbtn.TabIndex = 3;
            this.cardPaymentbtn.Text = "Card Payment";
            this.cardPaymentbtn.UseVisualStyleBackColor = false;
            this.cardPaymentbtn.Click += new System.EventHandler(this.cardPaymentbtn_Click);
            // 
            // cashPaymentbtn
            // 
            this.cashPaymentbtn.AccessibleName = "btnCashPayment";
            this.cashPaymentbtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.cashPaymentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashPaymentbtn.Location = new System.Drawing.Point(59, 126);
            this.cashPaymentbtn.Name = "cashPaymentbtn";
            this.cashPaymentbtn.Size = new System.Drawing.Size(197, 49);
            this.cashPaymentbtn.TabIndex = 2;
            this.cashPaymentbtn.Text = "Cash Payment";
            this.cashPaymentbtn.UseVisualStyleBackColor = false;
            this.cashPaymentbtn.Click += new System.EventHandler(this.cashPaymentbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.AccessibleName = "btnBack";
            this.backbtn.BackColor = System.Drawing.Color.Red;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backbtn.Location = new System.Drawing.Point(3, 3);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(109, 41);
            this.backbtn.TabIndex = 1;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 370);
            this.Controls.Add(this.panel1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button cardPaymentbtn;
        private System.Windows.Forms.Button cashPaymentbtn;
    }
}