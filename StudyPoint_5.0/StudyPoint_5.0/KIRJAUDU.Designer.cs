namespace StudyPoint_5._0
{
    partial class KIRJAUDU
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KayttajatnsTB = new System.Windows.Forms.TextBox();
            this.KirjauduBT01 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.KayttajatnsTB);
            this.panel1.Controls.Add(this.KirjauduBT01);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SalasanaTB);
            this.panel1.Location = new System.Drawing.Point(379, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 462);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(220, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kirjaudu sisään";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(190, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // KayttajatnsTB
            // 
            this.KayttajatnsTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajatnsTB.Location = new System.Drawing.Point(173, 128);
            this.KayttajatnsTB.Name = "KayttajatnsTB";
            this.KayttajatnsTB.Size = new System.Drawing.Size(268, 31);
            this.KayttajatnsTB.TabIndex = 2;
            // 
            // KirjauduBT01
            // 
            this.KirjauduBT01.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduBT01.Location = new System.Drawing.Point(205, 264);
            this.KirjauduBT01.Name = "KirjauduBT01";
            this.KirjauduBT01.Size = new System.Drawing.Size(199, 53);
            this.KirjauduBT01.TabIndex = 4;
            this.KirjauduBT01.Text = "Kirjaudu sisään";
            this.KirjauduBT01.UseVisualStyleBackColor = true;
            this.KirjauduBT01.Click += new System.EventHandler(this.KirjauduBT01_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(190, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(173, 202);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.PasswordChar = '*';
            this.SalasanaTB.Size = new System.Drawing.Size(268, 31);
            this.SalasanaTB.TabIndex = 3;
            // 
            // KIRJAUDU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyPoint_5._0.Properties.Resources.technology;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "KIRJAUDU";
            this.Size = new System.Drawing.Size(1396, 756);
            this.Load += new System.EventHandler(this.KIRJAUDU_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KirjauduBT01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SalasanaTB;
        public System.Windows.Forms.TextBox KayttajatnsTB;
    }
}
