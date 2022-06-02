namespace StudyPoint_5._0
{
    partial class PALAUTTEEN_HALLINTA
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
            this.viestiLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.SnimiLB = new System.Windows.Forms.Label();
            this.EnimiLB = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viestiTB = new System.Windows.Forms.TextBox();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.idLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.idLB);
            this.panel1.Controls.Add(this.PoistaBT);
            this.panel1.Controls.Add(this.viestiTB);
            this.panel1.Controls.Add(this.viestiLB);
            this.panel1.Controls.Add(this.emailLB);
            this.panel1.Controls.Add(this.SnimiLB);
            this.panel1.Controls.Add(this.EnimiLB);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(18, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1361, 721);
            this.panel1.TabIndex = 0;
            // 
            // viestiLB
            // 
            this.viestiLB.AutoSize = true;
            this.viestiLB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viestiLB.ForeColor = System.Drawing.SystemColors.Control;
            this.viestiLB.Location = new System.Drawing.Point(559, 39);
            this.viestiLB.Name = "viestiLB";
            this.viestiLB.Size = new System.Drawing.Size(53, 23);
            this.viestiLB.TabIndex = 16;
            this.viestiLB.Text = "Viesti";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLB.ForeColor = System.Drawing.SystemColors.Control;
            this.emailLB.Location = new System.Drawing.Point(48, 166);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(95, 23);
            this.emailLB.TabIndex = 15;
            this.emailLB.Text = "Sähköposti";
            // 
            // SnimiLB
            // 
            this.SnimiLB.AutoSize = true;
            this.SnimiLB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnimiLB.ForeColor = System.Drawing.SystemColors.Control;
            this.SnimiLB.Location = new System.Drawing.Point(48, 121);
            this.SnimiLB.Name = "SnimiLB";
            this.SnimiLB.Size = new System.Drawing.Size(81, 23);
            this.SnimiLB.TabIndex = 14;
            this.SnimiLB.Text = "Sukunimi";
            // 
            // EnimiLB
            // 
            this.EnimiLB.AutoSize = true;
            this.EnimiLB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnimiLB.ForeColor = System.Drawing.SystemColors.Control;
            this.EnimiLB.Location = new System.Drawing.Point(48, 76);
            this.EnimiLB.Name = "EnimiLB";
            this.EnimiLB.Size = new System.Drawing.Size(68, 23);
            this.EnimiLB.TabIndex = 13;
            this.EnimiLB.Text = "Etunimi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1355, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // viestiTB
            // 
            this.viestiTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viestiTB.Location = new System.Drawing.Point(618, 39);
            this.viestiTB.Multiline = true;
            this.viestiTB.Name = "viestiTB";
            this.viestiTB.Size = new System.Drawing.Size(720, 233);
            this.viestiTB.TabIndex = 17;
            // 
            // PoistaBT
            // 
            this.PoistaBT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaBT.Location = new System.Drawing.Point(1127, 278);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(211, 53);
            this.PoistaBT.TabIndex = 20;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLB.ForeColor = System.Drawing.SystemColors.Control;
            this.idLB.Location = new System.Drawing.Point(48, 36);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(28, 23);
            this.idLB.TabIndex = 21;
            this.idLB.Text = "ID";
            // 
            // PALAUTTEEN_HALLINTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PALAUTTEEN_HALLINTA";
            this.Size = new System.Drawing.Size(1396, 756);
            this.Load += new System.EventHandler(this.PALAUTTEEN_HALLINTA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label viestiLB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.Label SnimiLB;
        private System.Windows.Forms.Label EnimiLB;
        private System.Windows.Forms.TextBox viestiTB;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Label idLB;
    }
}
