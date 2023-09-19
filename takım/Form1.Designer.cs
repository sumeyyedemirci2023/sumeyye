namespace takım
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
            this.btnTrabzonsp = new System.Windows.Forms.Button();
            this.btnGsaray = new System.Windows.Forms.Button();
            this.btnBesiktas = new System.Windows.Forms.Button();
            this.btnFenerbahce = new System.Windows.Forms.Button();
            this.lblTakim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrabzonsp
            // 
            this.btnTrabzonsp.Location = new System.Drawing.Point(127, 12);
            this.btnTrabzonsp.Name = "btnTrabzonsp";
            this.btnTrabzonsp.Size = new System.Drawing.Size(109, 38);
            this.btnTrabzonsp.TabIndex = 0;
            this.btnTrabzonsp.Text = "Trabzon spor";
            this.btnTrabzonsp.UseVisualStyleBackColor = true;
            this.btnTrabzonsp.Click += new System.EventHandler(this.btnTrabzonsp_Click);
            // 
            // btnGsaray
            // 
            this.btnGsaray.Location = new System.Drawing.Point(242, 12);
            this.btnGsaray.Name = "btnGsaray";
            this.btnGsaray.Size = new System.Drawing.Size(109, 38);
            this.btnGsaray.TabIndex = 1;
            this.btnGsaray.Text = "Galatasaray";
            this.btnGsaray.UseVisualStyleBackColor = true;
            this.btnGsaray.Click += new System.EventHandler(this.btnGsaray_Click);
            // 
            // btnBesiktas
            // 
            this.btnBesiktas.Location = new System.Drawing.Point(357, 12);
            this.btnBesiktas.Name = "btnBesiktas";
            this.btnBesiktas.Size = new System.Drawing.Size(109, 38);
            this.btnBesiktas.TabIndex = 2;
            this.btnBesiktas.Text = "Beşiktaş";
            this.btnBesiktas.UseVisualStyleBackColor = true;
            this.btnBesiktas.Click += new System.EventHandler(this.btnBesiktas_Click);
            // 
            // btnFenerbahce
            // 
            this.btnFenerbahce.Location = new System.Drawing.Point(12, 12);
            this.btnFenerbahce.Name = "btnFenerbahce";
            this.btnFenerbahce.Size = new System.Drawing.Size(109, 38);
            this.btnFenerbahce.TabIndex = 3;
            this.btnFenerbahce.Text = "Fenerbahçe";
            this.btnFenerbahce.UseVisualStyleBackColor = true;
            this.btnFenerbahce.Click += new System.EventHandler(this.btnFenerbahce_Click);
            // 
            // lblTakim
            // 
            this.lblTakim.AutoSize = true;
            this.lblTakim.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTakim.Location = new System.Drawing.Point(169, 67);
            this.lblTakim.Name = "lblTakim";
            this.lblTakim.Size = new System.Drawing.Size(143, 55);
            this.lblTakim.TabIndex = 4;
            this.lblTakim.Text = "takim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 138);
            this.Controls.Add(this.lblTakim);
            this.Controls.Add(this.btnFenerbahce);
            this.Controls.Add(this.btnBesiktas);
            this.Controls.Add(this.btnGsaray);
            this.Controls.Add(this.btnTrabzonsp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrabzonsp;
        private System.Windows.Forms.Button btnGsaray;
        private System.Windows.Forms.Button btnBesiktas;
        private System.Windows.Forms.Button btnFenerbahce;
        private System.Windows.Forms.Label lblTakim;
    }
}

