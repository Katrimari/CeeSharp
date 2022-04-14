namespace CryptausEncryptaus
{
    partial class CryptausFM
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
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.CryptattuLB = new System.Windows.Forms.Label();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.TiedotGB = new System.Windows.Forms.ComboBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.CryptaaBT = new System.Windows.Forms.Button();
            this.NaytaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.BackColor = System.Drawing.Color.Transparent;
            this.SalasanaLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalasanaLB.Location = new System.Drawing.Point(35, 72);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(85, 27);
            this.SalasanaLB.TabIndex = 0;
            this.SalasanaLB.Text = "Salasanasi";
            // 
            // CryptattuLB
            // 
            this.CryptattuLB.AutoSize = true;
            this.CryptattuLB.BackColor = System.Drawing.Color.Transparent;
            this.CryptattuLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CryptattuLB.Location = new System.Drawing.Point(33, 112);
            this.CryptattuLB.Name = "CryptattuLB";
            this.CryptattuLB.Size = new System.Drawing.Size(87, 27);
            this.CryptattuLB.TabIndex = 1;
            this.CryptattuLB.Text = "Cryptattu";
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(138, 69);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(248, 30);
            this.SalasanaTB.TabIndex = 2;
            // 
            // TiedotGB
            // 
            this.TiedotGB.FormattingEnabled = true;
            this.TiedotGB.Location = new System.Drawing.Point(138, 109);
            this.TiedotGB.Name = "TiedotGB";
            this.TiedotGB.Size = new System.Drawing.Size(248, 35);
            this.TiedotGB.TabIndex = 3;
            this.TiedotGB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.BackColor = System.Drawing.Color.Transparent;
            this.VastausLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VastausLB.Location = new System.Drawing.Point(33, 223);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(69, 27);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // CryptaaBT
            // 
            this.CryptaaBT.BackColor = System.Drawing.Color.Navy;
            this.CryptaaBT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CryptaaBT.Location = new System.Drawing.Point(436, 63);
            this.CryptaaBT.Name = "CryptaaBT";
            this.CryptaaBT.Size = new System.Drawing.Size(134, 36);
            this.CryptaaBT.TabIndex = 5;
            this.CryptaaBT.Text = "Cryptaa";
            this.CryptaaBT.UseVisualStyleBackColor = false;
            this.CryptaaBT.Click += new System.EventHandler(this.CryptaaBT_Click);
            // 
            // NaytaBT
            // 
            this.NaytaBT.BackColor = System.Drawing.Color.Navy;
            this.NaytaBT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NaytaBT.Location = new System.Drawing.Point(436, 109);
            this.NaytaBT.Name = "NaytaBT";
            this.NaytaBT.Size = new System.Drawing.Size(134, 36);
            this.NaytaBT.TabIndex = 6;
            this.NaytaBT.Text = "Näytä salasana";
            this.NaytaBT.UseVisualStyleBackColor = false;
            this.NaytaBT.Click += new System.EventHandler(this.NaytaBT_Click);
            // 
            // CryptausFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CryptausEncryptaus.Properties.Resources.technology_background_1632715;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(721, 323);
            this.Controls.Add(this.NaytaBT);
            this.Controls.Add(this.CryptaaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.TiedotGB);
            this.Controls.Add(this.SalasanaTB);
            this.Controls.Add(this.CryptattuLB);
            this.Controls.Add(this.SalasanaLB);
            this.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "CryptausFM";
            this.Text = "Cryptataan!";
            this.Load += new System.EventHandler(this.CryptausFM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.Label CryptattuLB;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.ComboBox TiedotGB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Button CryptaaBT;
        private System.Windows.Forms.Button NaytaBT;
    }
}

