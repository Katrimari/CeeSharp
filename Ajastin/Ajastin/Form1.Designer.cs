﻿namespace Ajastin
{
    partial class AjastinFM
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
            this.components = new System.ComponentModel.Container();
            this.MinuutitCB = new System.Windows.Forms.ComboBox();
            this.SekunnitCB = new System.Windows.Forms.ComboBox();
            this.MinuutitLB = new System.Windows.Forms.Label();
            this.SekunnitLB = new System.Windows.Forms.Label();
            this.AikaLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MinuutitCB
            // 
            this.MinuutitCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuutitCB.FormattingEnabled = true;
            this.MinuutitCB.Location = new System.Drawing.Point(47, 74);
            this.MinuutitCB.Name = "MinuutitCB";
            this.MinuutitCB.Size = new System.Drawing.Size(121, 33);
            this.MinuutitCB.TabIndex = 0;
            // 
            // SekunnitCB
            // 
            this.SekunnitCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SekunnitCB.FormattingEnabled = true;
            this.SekunnitCB.Location = new System.Drawing.Point(209, 74);
            this.SekunnitCB.Name = "SekunnitCB";
            this.SekunnitCB.Size = new System.Drawing.Size(121, 33);
            this.SekunnitCB.TabIndex = 1;
            // 
            // MinuutitLB
            // 
            this.MinuutitLB.AutoSize = true;
            this.MinuutitLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuutitLB.Location = new System.Drawing.Point(41, 27);
            this.MinuutitLB.Name = "MinuutitLB";
            this.MinuutitLB.Size = new System.Drawing.Size(109, 31);
            this.MinuutitLB.TabIndex = 2;
            this.MinuutitLB.Text = "Minuutit";
            // 
            // SekunnitLB
            // 
            this.SekunnitLB.AutoSize = true;
            this.SekunnitLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SekunnitLB.Location = new System.Drawing.Point(203, 27);
            this.SekunnitLB.Name = "SekunnitLB";
            this.SekunnitLB.Size = new System.Drawing.Size(120, 31);
            this.SekunnitLB.TabIndex = 3;
            this.SekunnitLB.Text = "Sekunnit";
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AikaLB.Location = new System.Drawing.Point(41, 124);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(289, 108);
            this.AikaLB.TabIndex = 4;
            this.AikaLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBT.Location = new System.Drawing.Point(70, 267);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(80, 43);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBT.Location = new System.Drawing.Point(209, 267);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(80, 43);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AjastinTM
            // 
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // AjastinFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 355);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.AikaLB);
            this.Controls.Add(this.SekunnitLB);
            this.Controls.Add(this.MinuutitLB);
            this.Controls.Add(this.SekunnitCB);
            this.Controls.Add(this.MinuutitCB);
            this.Name = "AjastinFM";
            this.Text = "Ajastin";
            this.Load += new System.EventHandler(this.AjastinFM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MinuutitCB;
        private System.Windows.Forms.ComboBox SekunnitCB;
        private System.Windows.Forms.Label MinuutitLB;
        private System.Windows.Forms.Label SekunnitLB;
        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}

