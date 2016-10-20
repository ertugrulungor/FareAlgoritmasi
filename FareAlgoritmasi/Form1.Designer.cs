namespace FareAlgoritmasi
{
    partial class Form1
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnCiz = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.pnlIcerik = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBasla);
            this.panel1.Controls.Add(this.btnCiz);
            this.panel1.Controls.Add(this.txtY);
            this.panel1.Controls.Add(this.txtX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(789, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(132, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(132, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 557);
            this.panel1.TabIndex = 0;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(13, 67);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(106, 23);
            this.btnBasla.TabIndex = 7;
            this.btnBasla.Tag = "-1,-1";
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnCiz
            // 
            this.btnCiz.Location = new System.Drawing.Point(13, 38);
            this.btnCiz.Name = "btnCiz";
            this.btnCiz.Size = new System.Drawing.Size(106, 23);
            this.btnCiz.TabIndex = 6;
            this.btnCiz.Tag = "-1,-1";
            this.btnCiz.Text = "Çiz";
            this.btnCiz.UseVisualStyleBackColor = true;
            this.btnCiz.Click += new System.EventHandler(this.btnCiz_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(69, 12);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(50, 20);
            this.txtY.TabIndex = 5;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(13, 12);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(50, 20);
            this.txtX.TabIndex = 4;
            // 
            // pnlIcerik
            // 
            this.pnlIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIcerik.Location = new System.Drawing.Point(0, 0);
            this.pnlIcerik.Name = "pnlIcerik";
            this.pnlIcerik.Size = new System.Drawing.Size(789, 557);
            this.pnlIcerik.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 557);
            this.Controls.Add(this.pnlIcerik);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnCiz;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Panel pnlIcerik;
    }
}

