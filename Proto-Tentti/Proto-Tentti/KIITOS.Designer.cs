namespace Proto_Tentti
{
    partial class KIITOS
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
            this.heiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduBT.Location = new System.Drawing.Point(275, 281);
            this.KirjauduBT.Name = "KirjauduBT";
            this.KirjauduBT.Size = new System.Drawing.Size(216, 48);
            this.KirjauduBT.TabIndex = 22;
            this.KirjauduBT.Text = "Sulje";
            this.KirjauduBT.UseVisualStyleBackColor = true;
            this.KirjauduBT.Click += new System.EventHandler(this.KirjauduBT_Click);
            // 
            // heiLB
            // 
            this.heiLB.AutoSize = true;
            this.heiLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heiLB.Location = new System.Drawing.Point(17, 121);
            this.heiLB.Name = "heiLB";
            this.heiLB.Size = new System.Drawing.Size(766, 44);
            this.heiLB.TabIndex = 21;
            this.heiLB.Text = "Lomake on täytetty ja  tiedot päivitetty!";
            // 
            // KIITOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KirjauduBT);
            this.Controls.Add(this.heiLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KIITOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KIITOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KirjauduBT;
        private System.Windows.Forms.Label heiLB;
    }
}