namespace CarWashManagementSystem
{
    partial class FrmViewServiceHistory
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
            this.table3 = new System.Windows.Forms.TableLayoutPanel();
            this.Appoint2txt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.table3);
            this.panel1.Controls.Add(this.Appoint2txt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 452);
            this.panel1.TabIndex = 0;
            // 
            // table3
            // 
            this.table3.AccessibleName = "tableViewServiceHistory";
            this.table3.BackColor = System.Drawing.SystemColors.Control;
            this.table3.ColumnCount = 2;
            this.table3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table3.Location = new System.Drawing.Point(224, 88);
            this.table3.Name = "table3";
            this.table3.RowCount = 2;
            this.table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table3.Size = new System.Drawing.Size(380, 238);
            this.table3.TabIndex = 22;
            // 
            // Appoint2txt
            // 
            this.Appoint2txt.AccessibleName = "txtAppointmentId";
            this.Appoint2txt.Location = new System.Drawing.Point(224, 28);
            this.Appoint2txt.Multiline = true;
            this.Appoint2txt.Name = "Appoint2txt";
            this.Appoint2txt.Size = new System.Drawing.Size(176, 31);
            this.Appoint2txt.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Backbtn);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 447);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblViewServiceHistory";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 93);
            this.label1.TabIndex = 2;
            this.label1.Text = "View \r\nService\r\nHistory";
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
            // label7
            // 
            this.label7.AccessibleName = "lblAppointmentId";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Appointment ID :";
            // 
            // ViewServiceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ViewServiceHistory";
            this.Text = "ViewServiceHistory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.TextBox Appoint2txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel table3;
    }
}