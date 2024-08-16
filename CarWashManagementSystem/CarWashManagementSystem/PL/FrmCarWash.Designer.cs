namespace CarWashManagementSystem
{
    partial class FrmCarWash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarWash));
            this.Dashpan1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Staffbtn = new System.Windows.Forms.Button();
            this.Custumerbtn = new System.Windows.Forms.Button();
            this.Addcusbtn = new System.Windows.Forms.Button();
            this.Dashpan1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dashpan1
            // 
            this.Dashpan1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dashpan1.Controls.Add(this.panel2);
            this.Dashpan1.Controls.Add(this.panel1);
            this.Dashpan1.Location = new System.Drawing.Point(0, 0);
            this.Dashpan1.Name = "Dashpan1";
            this.Dashpan1.Size = new System.Drawing.Size(803, 450);
            this.Dashpan1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "imgCarWash";
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(218, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 443);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.Staffbtn);
            this.panel1.Controls.Add(this.Custumerbtn);
            this.panel1.Controls.Add(this.Addcusbtn);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 448);
            this.panel1.TabIndex = 0;
            // 
            // Staffbtn
            // 
            this.Staffbtn.AccessibleName = "btnStaff";
            this.Staffbtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Staffbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staffbtn.Location = new System.Drawing.Point(38, 288);
            this.Staffbtn.Name = "Staffbtn";
            this.Staffbtn.Size = new System.Drawing.Size(133, 49);
            this.Staffbtn.TabIndex = 2;
            this.Staffbtn.Text = "Staff";
            this.Staffbtn.UseVisualStyleBackColor = false;
            this.Staffbtn.Click += new System.EventHandler(this.Staffbtn_Click);
            // 
            // Custumerbtn
            // 
            this.Custumerbtn.AccessibleName = "btnCustomer";
            this.Custumerbtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Custumerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Custumerbtn.Location = new System.Drawing.Point(38, 199);
            this.Custumerbtn.Name = "Custumerbtn";
            this.Custumerbtn.Size = new System.Drawing.Size(133, 49);
            this.Custumerbtn.TabIndex = 1;
            this.Custumerbtn.Text = "Customer";
            this.Custumerbtn.UseVisualStyleBackColor = false;
            this.Custumerbtn.Click += new System.EventHandler(this.Custumerbtn_Click);
            // 
            // Addcusbtn
            // 
            this.Addcusbtn.AccessibleName = "btnAddCustomer";
            this.Addcusbtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Addcusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addcusbtn.Location = new System.Drawing.Point(38, 109);
            this.Addcusbtn.Name = "Addcusbtn";
            this.Addcusbtn.Size = new System.Drawing.Size(133, 49);
            this.Addcusbtn.TabIndex = 0;
            this.Addcusbtn.Text = "Add Customer";
            this.Addcusbtn.UseVisualStyleBackColor = false;
            this.Addcusbtn.Click += new System.EventHandler(this.Addcusbtn_Click);
            // 
            // FrmCarWash
            // 
            this.AccessibleName = "FrmCarWash";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dashpan1);
            this.Name = "FrmCarWash";
            this.Text = "FrmCarWash";
            this.Load += new System.EventHandler(this.CarWash_Load);
            this.Dashpan1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Dashpan1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Staffbtn;
        private System.Windows.Forms.Button Custumerbtn;
        private System.Windows.Forms.Button Addcusbtn;
        private System.Windows.Forms.Panel panel2;
    }
}

