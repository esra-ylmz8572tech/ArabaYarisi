namespace ArabaYarisi
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.carpma = new System.Windows.Forms.PictureBox();
            this.myCar = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.yol = new System.Windows.Forms.PictureBox();
            this.yüksekSkor = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.btn_oyunuBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.score_deger = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.carpma);
            this.panel1.Controls.Add(this.myCar);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.car1);
            this.panel1.Controls.Add(this.yol);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // carpma
            // 
            this.carpma.Image = global::ArabaYarisi.Properties.Resources.explosion;
            this.carpma.Location = new System.Drawing.Point(267, 272);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(84, 72);
            this.carpma.TabIndex = 5;
            this.carpma.TabStop = false;
            // 
            // myCar
            // 
            this.myCar.Image = global::ArabaYarisi.Properties.Resources.araba9;
            this.myCar.Location = new System.Drawing.Point(221, 350);
            this.myCar.Name = "myCar";
            this.myCar.Size = new System.Drawing.Size(88, 180);
            this.myCar.TabIndex = 4;
            this.myCar.TabStop = false;
            // 
            // car2
            // 
            this.car2.Image = global::ArabaYarisi.Properties.Resources.araba5;
            this.car2.Location = new System.Drawing.Point(333, 69);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(70, 142);
            this.car2.TabIndex = 4;
            this.car2.TabStop = false;
            // 
            // car1
            // 
            this.car1.Image = global::ArabaYarisi.Properties.Resources.araba6;
            this.car1.Location = new System.Drawing.Point(83, 53);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(105, 220);
            this.car1.TabIndex = 4;
            this.car1.TabStop = false;
            // 
            // yol
            // 
            this.yol.Image = global::ArabaYarisi.Properties.Resources.yol;
            this.yol.Location = new System.Drawing.Point(0, 3);
            this.yol.Name = "yol";
            this.yol.Size = new System.Drawing.Size(505, 523);
            this.yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol.TabIndex = 0;
            this.yol.TabStop = false;
            // 
            // yüksekSkor
            // 
            this.yüksekSkor.AutoSize = true;
            this.yüksekSkor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yüksekSkor.Location = new System.Drawing.Point(32, 581);
            this.yüksekSkor.Name = "yüksekSkor";
            this.yüksekSkor.Size = new System.Drawing.Size(118, 21);
            this.yüksekSkor.TabIndex = 1;
            this.yüksekSkor.Text = "High Score: ";
            this.yüksekSkor.Click += new System.EventHandler(this.puan_Click);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_score.Location = new System.Drawing.Point(140, 581);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(20, 21);
            this.label_score.TabIndex = 1;
            this.label_score.Text = "0";
            // 
            // btn_oyunuBaslat
            // 
            this.btn_oyunuBaslat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_oyunuBaslat.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyunuBaslat.Location = new System.Drawing.Point(1, 615);
            this.btn_oyunuBaslat.Name = "btn_oyunuBaslat";
            this.btn_oyunuBaslat.Size = new System.Drawing.Size(538, 32);
            this.btn_oyunuBaslat.TabIndex = 2;
            this.btn_oyunuBaslat.Text = "Oyunu Başlat";
            this.btn_oyunuBaslat.UseVisualStyleBackColor = false;
            this.btn_oyunuBaslat.Click += new System.EventHandler(this.btn_oyunuBaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score.Location = new System.Drawing.Point(371, 581);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(73, 21);
            this.score.TabIndex = 1;
            this.score.Text = "Score: ";
            // 
            // score_deger
            // 
            this.score_deger.AutoSize = true;
            this.score_deger.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_deger.Location = new System.Drawing.Point(438, 581);
            this.score_deger.Name = "score_deger";
            this.score_deger.Size = new System.Drawing.Size(20, 21);
            this.score_deger.TabIndex = 1;
            this.score_deger.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 677);
            this.Controls.Add(this.btn_oyunuBaslat);
            this.Controls.Add(this.score_deger);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.score);
            this.Controls.Add(this.yüksekSkor);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox yol;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox myCar;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.Label yüksekSkor;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button btn_oyunuBaslat;
        private System.Windows.Forms.PictureBox carpma;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label score_deger;
    }
}

