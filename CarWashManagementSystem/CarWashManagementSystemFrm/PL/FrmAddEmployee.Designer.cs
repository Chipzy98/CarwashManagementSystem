namespace CarWashManagementSystem
{
    partial class FrmAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewPaybtn = new System.Windows.Forms.Button();
            this.addEmpbtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 452);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AccessibleName = "imgAddEmployee";
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(305, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 411);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.viewPaybtn);
            this.panel2.Controls.Add(this.addEmpbtn);
            this.panel2.Controls.Add(this.Backbtn);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 447);
            this.panel2.TabIndex = 2;
            // 
            // viewPaybtn
            // 
            this.viewPaybtn.AccessibleName = "btnViewPayments";
            this.viewPaybtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.viewPaybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPaybtn.Location = new System.Drawing.Point(18, 258);
            this.viewPaybtn.Name = "viewPaybtn";
            this.viewPaybtn.Size = new System.Drawing.Size(249, 57);
            this.viewPaybtn.TabIndex = 8;
            this.viewPaybtn.Text = "View Payments";
            this.viewPaybtn.UseVisualStyleBackColor = false;
            this.viewPaybtn.Click += new System.EventHandler(this.viewPaybtn_Click);
            // 
            // addEmpbtn
            // 
            this.addEmpbtn.AccessibleName = "btnAddEmployee";
            this.addEmpbtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.addEmpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpbtn.Location = new System.Drawing.Point(18, 146);
            this.addEmpbtn.Name = "addEmpbtn";
            this.addEmpbtn.Size = new System.Drawing.Size(249, 57);
            this.addEmpbtn.TabIndex = 7;
            this.addEmpbtn.Text = "Add Employee";
            this.addEmpbtn.UseVisualStyleBackColor = false;
            this.addEmpbtn.Click += new System.EventHandler(this.addEmpbtn_Click);
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
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAddEmployee";
            this.Text = "AddEmployee";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button viewPaybtn;
        private System.Windows.Forms.Button addEmpbtn;
        private System.Windows.Forms.Panel panel3;
    }
}