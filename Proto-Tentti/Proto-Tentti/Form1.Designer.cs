namespace Proto_Tentti
{
    partial class tervetuloaFM
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
            this.KirjauduBT = new System.Windows.Forms.Button();
            this.Rekisteröidy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduBT.Location = new System.Drawing.Point(48, 375);
            this.KirjauduBT.Name = "KirjauduBT";
            this.KirjauduBT.Size = new System.Drawing.Size(283, 80);
            this.KirjauduBT.TabIndex = 0;
            this.KirjauduBT.Text = "Kirjaudu sisään";
            this.KirjauduBT.UseVisualStyleBackColor = true;
            this.KirjauduBT.Click += new System.EventHandler(this.KirjauduBT_Click);
            // 
            // Rekisteröidy
            // 
            this.Rekisteröidy.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rekisteröidy.Location = new System.Drawing.Point(346, 375);
            this.Rekisteröidy.Name = "Rekisteröidy";
            this.Rekisteröidy.Size = new System.Drawing.Size(283, 80);
            this.Rekisteröidy.TabIndex = 1;
            this.Rekisteröidy.Text = "Rekisteröidy";
            this.Rekisteröidy.UseVisualStyleBackColor = true;
            this.Rekisteröidy.Click += new System.EventHandler(this.Rekisteröidy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tervetuloa sivuilleni! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jatkaaksesi eteenpäin, ole hyvä ja kirjaudu sisään \r\ntai rekisteröidy käyttäjäksi" +
    "!";
            // 
            // tervetuloaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rekisteröidy);
            this.Controls.Add(this.KirjauduBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tervetuloaFM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tervetuloa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KirjauduBT;
        private System.Windows.Forms.Button Rekisteröidy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

