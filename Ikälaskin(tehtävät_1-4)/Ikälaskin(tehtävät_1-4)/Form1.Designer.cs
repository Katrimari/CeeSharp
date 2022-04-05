namespace Ikälaskin_tehtävät_1_4_
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
            this.SynttaritDT = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.VuottaLB = new System.Windows.Forms.Label();
            this.KuukauttaLB = new System.Windows.Forms.Label();
            this.PaivaaLB = new System.Windows.Forms.Label();
            this.TuntiaLB = new System.Windows.Forms.Label();
            this.MinuuttiaLB = new System.Windows.Forms.Label();
            this.SekuntiaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SynttaritDT
            // 
            this.SynttaritDT.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SynttaritDT.Location = new System.Drawing.Point(12, 21);
            this.SynttaritDT.Name = "SynttaritDT";
            this.SynttaritDT.Size = new System.Drawing.Size(219, 20);
            this.SynttaritDT.TabIndex = 0;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskeBT.Location = new System.Drawing.Point(253, 12);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(75, 39);
            this.LaskeBT.TabIndex = 1;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // VuottaLB
            // 
            this.VuottaLB.AutoSize = true;
            this.VuottaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VuottaLB.Location = new System.Drawing.Point(77, 82);
            this.VuottaLB.Name = "VuottaLB";
            this.VuottaLB.Size = new System.Drawing.Size(74, 25);
            this.VuottaLB.TabIndex = 2;
            this.VuottaLB.Text = "Vuotta";
            this.VuottaLB.Visible = false;
            this.VuottaLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // KuukauttaLB
            // 
            this.KuukauttaLB.AutoSize = true;
            this.KuukauttaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KuukauttaLB.Location = new System.Drawing.Point(77, 116);
            this.KuukauttaLB.Name = "KuukauttaLB";
            this.KuukauttaLB.Size = new System.Drawing.Size(106, 25);
            this.KuukauttaLB.TabIndex = 3;
            this.KuukauttaLB.Text = "kuukautta";
            this.KuukauttaLB.Visible = false;
            // 
            // PaivaaLB
            // 
            this.PaivaaLB.AutoSize = true;
            this.PaivaaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaivaaLB.Location = new System.Drawing.Point(77, 150);
            this.PaivaaLB.Name = "PaivaaLB";
            this.PaivaaLB.Size = new System.Drawing.Size(76, 25);
            this.PaivaaLB.TabIndex = 4;
            this.PaivaaLB.Text = "päivää";
            this.PaivaaLB.Visible = false;
            // 
            // TuntiaLB
            // 
            this.TuntiaLB.AutoSize = true;
            this.TuntiaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuntiaLB.Location = new System.Drawing.Point(411, 82);
            this.TuntiaLB.Name = "TuntiaLB";
            this.TuntiaLB.Size = new System.Drawing.Size(65, 25);
            this.TuntiaLB.TabIndex = 5;
            this.TuntiaLB.Text = "tuntia";
            this.TuntiaLB.Visible = false;
            // 
            // MinuuttiaLB
            // 
            this.MinuuttiaLB.AutoSize = true;
            this.MinuuttiaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuuttiaLB.Location = new System.Drawing.Point(411, 116);
            this.MinuuttiaLB.Name = "MinuuttiaLB";
            this.MinuuttiaLB.Size = new System.Drawing.Size(99, 25);
            this.MinuuttiaLB.TabIndex = 6;
            this.MinuuttiaLB.Text = "minuuttia";
            this.MinuuttiaLB.Visible = false;
            this.MinuuttiaLB.Click += new System.EventHandler(this.MinuuttiaLB_Click);
            // 
            // SekuntiaLB
            // 
            this.SekuntiaLB.AutoSize = true;
            this.SekuntiaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SekuntiaLB.Location = new System.Drawing.Point(411, 150);
            this.SekuntiaLB.Name = "SekuntiaLB";
            this.SekuntiaLB.Size = new System.Drawing.Size(93, 25);
            this.SekuntiaLB.TabIndex = 7;
            this.SekuntiaLB.Text = "sekuntia";
            this.SekuntiaLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 202);
            this.Controls.Add(this.SekuntiaLB);
            this.Controls.Add(this.MinuuttiaLB);
            this.Controls.Add(this.TuntiaLB);
            this.Controls.Add(this.PaivaaLB);
            this.Controls.Add(this.KuukauttaLB);
            this.Controls.Add(this.VuottaLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.SynttaritDT);
            this.Name = "Form1";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SynttaritDT;
        private System.Windows.Forms.Button LaskeBT;
        private System.Windows.Forms.Label VuottaLB;
        private System.Windows.Forms.Label KuukauttaLB;
        private System.Windows.Forms.Label PaivaaLB;
        private System.Windows.Forms.Label TuntiaLB;
        private System.Windows.Forms.Label MinuuttiaLB;
        private System.Windows.Forms.Label SekuntiaLB;
    }
}

