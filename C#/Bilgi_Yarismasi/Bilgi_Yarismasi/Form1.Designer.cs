﻿namespace Bilgi_Yarismasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lblsoruno = new System.Windows.Forms.Label();
            this.Lbldogru = new System.Windows.Forms.Label();
            this.Lblyanlis = new System.Windows.Forms.Label();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(480, 220);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnA
            // 
            this.BtnA.Location = new System.Drawing.Point(23, 251);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(237, 36);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Location = new System.Drawing.Point(266, 251);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(237, 36);
            this.BtnB.TabIndex = 2;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            // 
            // BtnD
            // 
            this.BtnD.Location = new System.Drawing.Point(266, 293);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(237, 36);
            this.BtnD.TabIndex = 3;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(23, 293);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(237, 36);
            this.BtnC.TabIndex = 4;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış Sayısı:";
            // 
            // Lblsoruno
            // 
            this.Lblsoruno.AutoSize = true;
            this.Lblsoruno.Location = new System.Drawing.Point(698, 60);
            this.Lblsoruno.Name = "Lblsoruno";
            this.Lblsoruno.Size = new System.Drawing.Size(29, 35);
            this.Lblsoruno.TabIndex = 8;
            this.Lblsoruno.Text = "0";
            // 
            // Lbldogru
            // 
            this.Lbldogru.AutoSize = true;
            this.Lbldogru.Location = new System.Drawing.Point(747, 114);
            this.Lbldogru.Name = "Lbldogru";
            this.Lbldogru.Size = new System.Drawing.Size(29, 35);
            this.Lbldogru.TabIndex = 9;
            this.Lbldogru.Text = "0";
            // 
            // Lblyanlis
            // 
            this.Lblyanlis.AutoSize = true;
            this.Lblyanlis.Location = new System.Drawing.Point(744, 180);
            this.Lblyanlis.Name = "Lblyanlis";
            this.Lblyanlis.Size = new System.Drawing.Size(29, 35);
            this.Lblyanlis.TabIndex = 10;
            this.Lblyanlis.Text = "0";
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(555, 234);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(237, 36);
            this.BtnSonraki.TabIndex = 11;
            this.BtnSonraki.Text = "Sonraki";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(555, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(692, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 35);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 35);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 425);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.Lblyanlis);
            this.Controls.Add(this.Lbldogru);
            this.Controls.Add(this.Lblsoruno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lblsoruno;
        private System.Windows.Forms.Label Lbldogru;
        private System.Windows.Forms.Label Lblyanlis;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

