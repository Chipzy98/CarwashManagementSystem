namespace CarWashManagementSystem
{
    partial class FrmAddNewEmplyoyee
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.empIdlbl = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.Label();
            this.rolelbl = new System.Windows.Forms.Label();
            this.contactNumlbl = new System.Windows.Forms.Label();
            this.empIdtxt = new System.Windows.Forms.TextBox();
            this.empNametxt = new System.Windows.Forms.TextBox();
            this.roletxt = new System.Windows.Forms.TextBox();
            this.contactNumtxt = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Addbtn);
            this.panel1.Controls.Add(this.Clearbtn);
            this.panel1.Controls.Add(this.contactNumtxt);
            this.panel1.Controls.Add(this.roletxt);
            this.panel1.Controls.Add(this.empNametxt);
            this.panel1.Controls.Add(this.empIdtxt);
            this.panel1.Controls.Add(this.contactNumlbl);
            this.panel1.Controls.Add(this.rolelbl);
            this.panel1.Controls.Add(this.empName);
            this.panel1.Controls.Add(this.empIdlbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 452);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Backbtn);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 447);
            this.panel2.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 93);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add \r\nNew \r\nEmployee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // empIdlbl
            // 
            this.empIdlbl.AccessibleName = "lblEID";
            this.empIdlbl.AutoSize = true;
            this.empIdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdlbl.Location = new System.Drawing.Point(230, 34);
            this.empIdlbl.Name = "empIdlbl";
            this.empIdlbl.Size = new System.Drawing.Size(95, 16);
            this.empIdlbl.TabIndex = 3;
            this.empIdlbl.Text = "Employe ID :";
            // 
            // empName
            // 
            this.empName.AccessibleName = "lblEmpName";
            this.empName.AutoSize = true;
            this.empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.Location = new System.Drawing.Point(230, 107);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(130, 16);
            this.empName.TabIndex = 4;
            this.empName.Text = "Employee Name :";
            // 
            // rolelbl
            // 
            this.rolelbl.AccessibleName = "lblRole";
            this.rolelbl.AutoSize = true;
            this.rolelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolelbl.Location = new System.Drawing.Point(230, 172);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Size = new System.Drawing.Size(48, 16);
            this.rolelbl.TabIndex = 5;
            this.rolelbl.Text = "Role :";
            // 
            // contactNumlbl
            // 
            this.contactNumlbl.AccessibleName = "lblContactNum";
            this.contactNumlbl.AutoSize = true;
            this.contactNumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumlbl.Location = new System.Drawing.Point(230, 235);
            this.contactNumlbl.Name = "contactNumlbl";
            this.contactNumlbl.Size = new System.Drawing.Size(125, 16);
            this.contactNumlbl.TabIndex = 6;
            this.contactNumlbl.Text = "Contact Number :";
            // 
            // empIdtxt
            // 
            this.empIdtxt.AccessibleName = "txtEmpId";
            this.empIdtxt.Location = new System.Drawing.Point(236, 64);
            this.empIdtxt.Multiline = true;
            this.empIdtxt.Name = "empIdtxt";
            this.empIdtxt.Size = new System.Drawing.Size(163, 24);
            this.empIdtxt.TabIndex = 7;
            // 
            // empNametxt
            // 
            this.empNametxt.AccessibleName = "txtEmpName";
            this.empNametxt.Location = new System.Drawing.Point(236, 135);
            this.empNametxt.Multiline = true;
            this.empNametxt.Name = "empNametxt";
            this.empNametxt.Size = new System.Drawing.Size(227, 24);
            this.empNametxt.TabIndex = 8;
            // 
            // roletxt
            // 
            this.roletxt.AccessibleName = "txtRole";
            this.roletxt.Location = new System.Drawing.Point(236, 196);
            this.roletxt.Multiline = true;
            this.roletxt.Name = "roletxt";
            this.roletxt.Size = new System.Drawing.Size(227, 24);
            this.roletxt.TabIndex = 9;
            // 
            // contactNumtxt
            // 
            this.contactNumtxt.AccessibleName = "txtContactNumber";
            this.contactNumtxt.Location = new System.Drawing.Point(236, 263);
            this.contactNumtxt.Multiline = true;
            this.contactNumtxt.Name = "contactNumtxt";
            this.contactNumtxt.Size = new System.Drawing.Size(227, 24);
            this.contactNumtxt.TabIndex = 10;
            // 
            // Addbtn
            // 
            this.Addbtn.AccessibleName = "btnAdd";
            this.Addbtn.BackColor = System.Drawing.Color.Lime;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(490, 333);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(94, 41);
            this.Addbtn.TabIndex = 13;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            // 
            // Clearbtn
            // 
            this.Clearbtn.AccessibleName = "btnClear";
            this.Clearbtn.BackColor = System.Drawing.Color.Red;
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clearbtn.Location = new System.Drawing.Point(364, 333);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(94, 41);
            this.Clearbtn.TabIndex = 12;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            // 
            // AddNewEmplyoyee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 385);
            this.Controls.Add(this.panel1);
            this.Name = "AddNewEmplyoyee";
            this.Text = "AddNewEmplyoyee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label contactNumlbl;
        private System.Windows.Forms.Label rolelbl;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.Label empIdlbl;
        private System.Windows.Forms.TextBox empIdtxt;
        private System.Windows.Forms.TextBox contactNumtxt;
        private System.Windows.Forms.TextBox roletxt;
        private System.Windows.Forms.TextBox empNametxt;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Clearbtn;
    }
}