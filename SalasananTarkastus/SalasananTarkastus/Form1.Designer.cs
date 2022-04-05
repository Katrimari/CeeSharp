namespace SalasananTarkastus
{
    partial class SalasanaForm
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
            this.SalasanaPL = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.VirheviestiLB = new System.Windows.Forms.Label();
            this.SalasanaOikeinPL = new System.Windows.Forms.Panel();
            this.tervetuloaLB = new System.Windows.Forms.Label();
            this.SalasanaPL.SuspendLayout();
            this.SalasanaOikeinPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPL
            // 
            this.SalasanaPL.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPL.Controls.Add(this.VirheviestiLB);
            this.SalasanaPL.Controls.Add(this.TarkistaBT);
            this.SalasanaPL.Controls.Add(this.SalasanaTB);
            this.SalasanaPL.Controls.Add(this.KayttajaTB);
            this.SalasanaPL.Controls.Add(this.label2);
            this.SalasanaPL.Controls.Add(this.label1);
            this.SalasanaPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaPL.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPL.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPL.Name = "SalasanaPL";
            this.SalasanaPL.Size = new System.Drawing.Size(673, 310);
            this.SalasanaPL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(245, 63);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(225, 35);
            this.KayttajaTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(245, 104);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(225, 35);
            this.SalasanaTB.TabIndex = 3;
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.ForeColor = System.Drawing.Color.Black;
            this.TarkistaBT.Location = new System.Drawing.Point(322, 165);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(148, 48);
            this.TarkistaBT.TabIndex = 4;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = true;
            this.TarkistaBT.Click += new System.EventHandler(this.TarkistaBT_Click);
            // 
            // VirheviestiLB
            // 
            this.VirheviestiLB.AutoSize = true;
            this.VirheviestiLB.Location = new System.Drawing.Point(38, 239);
            this.VirheviestiLB.Name = "VirheviestiLB";
            this.VirheviestiLB.Size = new System.Drawing.Size(120, 29);
            this.VirheviestiLB.TabIndex = 5;
            this.VirheviestiLB.Text = "virheviesti";
            this.VirheviestiLB.Visible = false;
            // 
            // SalasanaOikeinPL
            // 
            this.SalasanaOikeinPL.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPL.Controls.Add(this.tervetuloaLB);
            this.SalasanaOikeinPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPL.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaOikeinPL.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPL.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPL.Name = "SalasanaOikeinPL";
            this.SalasanaOikeinPL.Size = new System.Drawing.Size(673, 310);
            this.SalasanaOikeinPL.TabIndex = 6;
            this.SalasanaOikeinPL.Visible = false;
            // 
            // tervetuloaLB
            // 
            this.tervetuloaLB.AutoSize = true;
            this.tervetuloaLB.Location = new System.Drawing.Point(50, 113);
            this.tervetuloaLB.Name = "tervetuloaLB";
            this.tervetuloaLB.Size = new System.Drawing.Size(574, 80);
            this.tervetuloaLB.TabIndex = 0;
            this.tervetuloaLB.Text = "Tervetuloa sivuilleni";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 310);
            this.Controls.Add(this.SalasanaPL);
            this.Controls.Add(this.SalasanaOikeinPL);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan tarkastus";
            this.SalasanaPL.ResumeLayout(false);
            this.SalasanaPL.PerformLayout();
            this.SalasanaOikeinPL.ResumeLayout(false);
            this.SalasanaOikeinPL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SalasanaPL;
        private System.Windows.Forms.Label VirheviestiLB;
        private System.Windows.Forms.Button TarkistaBT;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SalasanaOikeinPL;
        private System.Windows.Forms.Label tervetuloaLB;
    }
}

