namespace Proto_Tentti
{
    partial class REKISTEROITYMISLOMAKE
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
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kirjauduLNK = new System.Windows.Forms.LinkLabel();
            this.KirjauduBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.salisTB = new System.Windows.Forms.TextBox();
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.ssLB = new System.Windows.Forms.Label();
            this.ktLB = new System.Windows.Forms.Label();
            this.salisAgnTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.naytasalisCB = new System.Windows.Forms.CheckBox();
            this.snimiTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.syntymaDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaBT.Location = new System.Drawing.Point(85, 621);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(216, 48);
            this.tyhjennaBT.TabIndex = 21;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 695);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Onko sinulla jo käyttäjätunnus?";
            // 
            // kirjauduLNK
            // 
            this.kirjauduLNK.AutoSize = true;
            this.kirjauduLNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjauduLNK.Location = new System.Drawing.Point(122, 732);
            this.kirjauduLNK.Name = "kirjauduLNK";
            this.kirjauduLNK.Size = new System.Drawing.Size(121, 16);
            this.kirjauduLNK.TabIndex = 19;
            this.kirjauduLNK.TabStop = true;
            this.kirjauduLNK.Text = "Kirjaudu sisään nyt!";
            this.kirjauduLNK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kirjauduLNK_LinkClicked);
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduBT.Location = new System.Drawing.Point(85, 567);
            this.KirjauduBT.Name = "KirjauduBT";
            this.KirjauduBT.Size = new System.Drawing.Size(216, 48);
            this.KirjauduBT.TabIndex = 18;
            this.KirjauduBT.Text = "Rekisteröidy";
            this.KirjauduBT.UseVisualStyleBackColor = true;
            this.KirjauduBT.Click += new System.EventHandler(this.KirjauduBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rekisteröidy";
            // 
            // salisTB
            // 
            this.salisTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salisTB.Location = new System.Drawing.Point(54, 402);
            this.salisTB.Name = "salisTB";
            this.salisTB.PasswordChar = '*';
            this.salisTB.Size = new System.Drawing.Size(301, 27);
            this.salisTB.TabIndex = 16;
            // 
            // enimiTB
            // 
            this.enimiTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enimiTB.Location = new System.Drawing.Point(54, 119);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(301, 27);
            this.enimiTB.TabIndex = 15;
            // 
            // ssLB
            // 
            this.ssLB.AutoSize = true;
            this.ssLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssLB.Location = new System.Drawing.Point(50, 379);
            this.ssLB.Name = "ssLB";
            this.ssLB.Size = new System.Drawing.Size(137, 20);
            this.ssLB.TabIndex = 14;
            this.ssLB.Text = "Anna Salasana:";
            // 
            // ktLB
            // 
            this.ktLB.AutoSize = true;
            this.ktLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktLB.Location = new System.Drawing.Point(50, 96);
            this.ktLB.Name = "ktLB";
            this.ktLB.Size = new System.Drawing.Size(78, 20);
            this.ktLB.TabIndex = 13;
            this.ktLB.Text = "Etunimi:";
            // 
            // salisAgnTB
            // 
            this.salisAgnTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salisAgnTB.Location = new System.Drawing.Point(54, 480);
            this.salisAgnTB.Name = "salisAgnTB";
            this.salisAgnTB.PasswordChar = '*';
            this.salisAgnTB.Size = new System.Drawing.Size(301, 27);
            this.salisAgnTB.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Salasana uudelleen:";
            // 
            // naytasalisCB
            // 
            this.naytasalisCB.AutoSize = true;
            this.naytasalisCB.Location = new System.Drawing.Point(256, 513);
            this.naytasalisCB.Name = "naytasalisCB";
            this.naytasalisCB.Size = new System.Drawing.Size(99, 17);
            this.naytasalisCB.TabIndex = 24;
            this.naytasalisCB.Text = "Näytä salasana";
            this.naytasalisCB.UseVisualStyleBackColor = true;
            this.naytasalisCB.CheckedChanged += new System.EventHandler(this.naytasalisCB_CheckedChanged);
            // 
            // snimiTB
            // 
            this.snimiTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snimiTB.Location = new System.Drawing.Point(54, 192);
            this.snimiTB.Name = "snimiTB";
            this.snimiTB.Size = new System.Drawing.Size(301, 27);
            this.snimiTB.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sukunimi:";
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(54, 260);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(301, 27);
            this.emailTB.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sähköposti:";
            // 
            // syntymaDTP
            // 
            this.syntymaDTP.Location = new System.Drawing.Point(54, 331);
            this.syntymaDTP.Name = "syntymaDTP";
            this.syntymaDTP.Size = new System.Drawing.Size(200, 20);
            this.syntymaDTP.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Syntymäpäivä:";
            // 
            // REKISTEROITYMISLOMAKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 807);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.syntymaDTP);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.snimiTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.naytasalisCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salisAgnTB);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kirjauduLNK);
            this.Controls.Add(this.KirjauduBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salisTB);
            this.Controls.Add(this.enimiTB);
            this.Controls.Add(this.ssLB);
            this.Controls.Add(this.ktLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "REKISTEROITYMISLOMAKE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rekisteröidy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel kirjauduLNK;
        private System.Windows.Forms.Button KirjauduBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salisTB;
        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.Label ssLB;
        private System.Windows.Forms.Label ktLB;
        private System.Windows.Forms.TextBox salisAgnTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox naytasalisCB;
        private System.Windows.Forms.TextBox snimiTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker syntymaDTP;
        private System.Windows.Forms.Label label6;
    }
}