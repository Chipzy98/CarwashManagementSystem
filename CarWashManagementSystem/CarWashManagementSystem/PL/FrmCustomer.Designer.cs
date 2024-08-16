namespace CarWashManagementSystem
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addchome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Appointbtn = new System.Windows.Forms.Button();
            this.vhisbtn = new System.Windows.Forms.Button();
            this.Paybtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AccessibleName = "imgCustomer";
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(321, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 445);
            this.panel3.TabIndex = 0;
            // 
            // addchome
            // 
            this.addchome.AccessibleName = "btnBack";
            this.addchome.BackColor = System.Drawing.Color.Red;
            this.addchome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addchome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addchome.Location = new System.Drawing.Point(5, 5);
            this.addchome.Name = "addchome";
            this.addchome.Size = new System.Drawing.Size(109, 41);
            this.addchome.TabIndex = 0;
            this.addchome.Text = "Back";
            this.addchome.UseVisualStyleBackColor = false;
            this.addchome.Click += new System.EventHandler(this.addchome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.Appointbtn);
            this.panel2.Controls.Add(this.vhisbtn);
            this.panel2.Controls.Add(this.Paybtn);
            this.panel2.Controls.Add(this.addchome);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 446);
            this.panel2.TabIndex = 7;
            // 
            // Appointbtn
            // 
            this.Appointbtn.AccessibleName = "btnAppointment";
            this.Appointbtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Appointbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointbtn.Location = new System.Drawing.Point(26, 128);
            this.Appointbtn.Name = "Appointbtn";
            this.Appointbtn.Size = new System.Drawing.Size(249, 57);
            this.Appointbtn.TabIndex = 4;
            this.Appointbtn.Text = "Appointment";
            this.Appointbtn.UseVisualStyleBackColor = false;
            this.Appointbtn.Click += new System.EventHandler(this.Appointbtn_Click);
            // 
            // vhisbtn
            // 
            this.vhisbtn.AccessibleName = "btnViewServiceHostory";
            this.vhisbtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.vhisbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vhisbtn.Location = new System.Drawing.Point(26, 314);
            this.vhisbtn.Name = "vhisbtn";
            this.vhisbtn.Size = new System.Drawing.Size(249, 57);
            this.vhisbtn.TabIndex = 6;
            this.vhisbtn.Text = "View Service History";
            this.vhisbtn.UseVisualStyleBackColor = false;
            this.vhisbtn.Click += new System.EventHandler(this.vhisbtn_Click);
            // 
            // Paybtn
            // 
            this.Paybtn.AccessibleName = "btnPayment";
            this.Paybtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Paybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paybtn.Location = new System.Drawing.Point(26, 224);
            this.Paybtn.Name = "Paybtn";
            this.Paybtn.Size = new System.Drawing.Size(249, 57);
            this.Paybtn.TabIndex = 5;
            this.Paybtn.Text = "Payment";
            this.Paybtn.UseVisualStyleBackColor = false;
            this.Paybtn.Click += new System.EventHandler(this.Paybtn_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addchome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button vhisbtn;
        private System.Windows.Forms.Button Paybtn;
        private System.Windows.Forms.Button Appointbtn;
        private System.Windows.Forms.Panel panel3;
    }
}