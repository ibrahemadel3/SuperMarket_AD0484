
namespace SuperMarket_AD0484
{
    partial class frmlogin
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
            this.lblwel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncoffee = new System.Windows.Forms.Button();
            this.btnJuices = new System.Windows.Forms.Button();
            this.btnlegumes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblwel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 76);
            this.panel1.TabIndex = 0;
            // 
            // lblwel
            // 
            this.lblwel.AutoSize = true;
            this.lblwel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblwel.Location = new System.Drawing.Point(28, 34);
            this.lblwel.Name = "lblwel";
            this.lblwel.Size = new System.Drawing.Size(52, 21);
            this.lblwel.TabIndex = 0;
            this.lblwel.Text = "label1";
            this.lblwel.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btncoffee);
            this.panel2.Controls.Add(this.btnJuices);
            this.panel2.Controls.Add(this.btnlegumes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 238);
            this.panel2.TabIndex = 1;
            // 
            // btncoffee
            // 
            this.btncoffee.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btncoffee.Location = new System.Drawing.Point(20, 140);
            this.btncoffee.Name = "btncoffee";
            this.btncoffee.Size = new System.Drawing.Size(89, 29);
            this.btncoffee.TabIndex = 2;
            this.btncoffee.Text = "Coffee";
            this.btncoffee.UseVisualStyleBackColor = true;
            this.btncoffee.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // btnJuices
            // 
            this.btnJuices.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnJuices.Location = new System.Drawing.Point(20, 84);
            this.btnJuices.Name = "btnJuices";
            this.btnJuices.Size = new System.Drawing.Size(89, 29);
            this.btnJuices.TabIndex = 1;
            this.btnJuices.Text = "Juices";
            this.btnJuices.UseVisualStyleBackColor = true;
            this.btnJuices.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnlegumes
            // 
            this.btnlegumes.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnlegumes.Location = new System.Drawing.Point(20, 23);
            this.btnlegumes.Name = "btnlegumes";
            this.btnlegumes.Size = new System.Drawing.Size(89, 28);
            this.btnlegumes.TabIndex = 0;
            this.btnlegumes.Text = "Legumes";
            this.btnlegumes.UseVisualStyleBackColor = true;
            this.btnlegumes.Click += new System.EventHandler(this.btnForm1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(124)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(129, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 238);
            this.panel3.TabIndex = 2;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 314);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmlogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncoffee;
        private System.Windows.Forms.Button btnJuices;
        private System.Windows.Forms.Button btnlegumes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblwel;
    }
}