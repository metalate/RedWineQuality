namespace Red_Wine_Quality
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
            this.baslık = new System.Windows.Forms.Label();
            this.alcohol_lbl = new System.Windows.Forms.Label();
            this.sugar_lbl = new System.Windows.Forms.Label();
            this.ph_lbl = new System.Windows.Forms.Label();
            this.alcohol_txt = new System.Windows.Forms.TextBox();
            this.sugar_txt = new System.Windows.Forms.TextBox();
            this.ph_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.quality_ratio_lbl = new System.Windows.Forms.Label();
            this.result_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baslık
            // 
            this.baslık.AutoSize = true;
            this.baslık.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslık.ForeColor = System.Drawing.Color.Maroon;
            this.baslık.Location = new System.Drawing.Point(12, 29);
            this.baslık.Name = "baslık";
            this.baslık.Size = new System.Drawing.Size(541, 71);
            this.baslık.TabIndex = 0;
            this.baslık.Text = "Quality of Red Wine";
            // 
            // alcohol_lbl
            // 
            this.alcohol_lbl.AutoSize = true;
            this.alcohol_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alcohol_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.alcohol_lbl.Location = new System.Drawing.Point(23, 169);
            this.alcohol_lbl.Name = "alcohol_lbl";
            this.alcohol_lbl.Size = new System.Drawing.Size(79, 20);
            this.alcohol_lbl.TabIndex = 1;
            this.alcohol_lbl.Text = "Alcohol : ";
            // 
            // sugar_lbl
            // 
            this.sugar_lbl.AutoSize = true;
            this.sugar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sugar_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sugar_lbl.Location = new System.Drawing.Point(23, 208);
            this.sugar_lbl.Name = "sugar_lbl";
            this.sugar_lbl.Size = new System.Drawing.Size(78, 20);
            this.sugar_lbl.TabIndex = 2;
            this.sugar_lbl.Text = "Sugar   : ";
            // 
            // ph_lbl
            // 
            this.ph_lbl.AutoSize = true;
            this.ph_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ph_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ph_lbl.Location = new System.Drawing.Point(23, 247);
            this.ph_lbl.Name = "ph_lbl";
            this.ph_lbl.Size = new System.Drawing.Size(76, 20);
            this.ph_lbl.TabIndex = 3;
            this.ph_lbl.Text = "pH       : ";
            // 
            // alcohol_txt
            // 
            this.alcohol_txt.BackColor = System.Drawing.Color.Silver;
            this.alcohol_txt.Location = new System.Drawing.Point(109, 166);
            this.alcohol_txt.Name = "alcohol_txt";
            this.alcohol_txt.Size = new System.Drawing.Size(173, 22);
            this.alcohol_txt.TabIndex = 4;
            // 
            // sugar_txt
            // 
            this.sugar_txt.BackColor = System.Drawing.Color.Silver;
            this.sugar_txt.Location = new System.Drawing.Point(109, 208);
            this.sugar_txt.Name = "sugar_txt";
            this.sugar_txt.Size = new System.Drawing.Size(173, 22);
            this.sugar_txt.TabIndex = 5;
            // 
            // ph_txt
            // 
            this.ph_txt.BackColor = System.Drawing.Color.Silver;
            this.ph_txt.Location = new System.Drawing.Point(109, 247);
            this.ph_txt.Name = "ph_txt";
            this.ph_txt.Size = new System.Drawing.Size(173, 22);
            this.ph_txt.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(109, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quality_ratio_lbl
            // 
            this.quality_ratio_lbl.AutoSize = true;
            this.quality_ratio_lbl.BackColor = System.Drawing.Color.Black;
            this.quality_ratio_lbl.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quality_ratio_lbl.ForeColor = System.Drawing.Color.Maroon;
            this.quality_ratio_lbl.Location = new System.Drawing.Point(375, 151);
            this.quality_ratio_lbl.Name = "quality_ratio_lbl";
            this.quality_ratio_lbl.Size = new System.Drawing.Size(109, 71);
            this.quality_ratio_lbl.TabIndex = 8;
            this.quality_ratio_lbl.Text = "9,6";
            this.quality_ratio_lbl.Visible = false;
            // 
            // result_lbl
            // 
            this.result_lbl.AutoSize = true;
            this.result_lbl.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_lbl.ForeColor = System.Drawing.Color.Maroon;
            this.result_lbl.Location = new System.Drawing.Point(361, 259);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(136, 48);
            this.result_lbl.TabIndex = 9;
            this.result_lbl.Text = "Perfect";
            this.result_lbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 552);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.quality_ratio_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ph_txt);
            this.Controls.Add(this.sugar_txt);
            this.Controls.Add(this.alcohol_txt);
            this.Controls.Add(this.ph_lbl);
            this.Controls.Add(this.sugar_lbl);
            this.Controls.Add(this.alcohol_lbl);
            this.Controls.Add(this.baslık);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Quality of Red Wine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baslık;
        private System.Windows.Forms.Label alcohol_lbl;
        private System.Windows.Forms.Label sugar_lbl;
        private System.Windows.Forms.Label ph_lbl;
        private System.Windows.Forms.TextBox alcohol_txt;
        private System.Windows.Forms.TextBox sugar_txt;
        private System.Windows.Forms.TextBox ph_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label quality_ratio_lbl;
        private System.Windows.Forms.Label result_lbl;
    }
}

