using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kazanilanScore = 0;
        int yolHizi = 30;
        int arabaHizi = 50; //benim arabanın hızı

        bool solYon = false;
        bool sagYon = false;

        int digerArabaHizi = 50;

        Random random = new Random();

        public void oyunuBaslat()
        {
            btn_oyunuBaslat.Enabled = false;
            carpma.Visible = false; //patlamayı false yapıyoruz patlama anında çıkacak.

            arabaHizi = 50;
            digerArabaHizi = 50;
            kazanilanScore = 0;

            //arabaların başlangıçtaki koordinatları
            myCar.Left = 160;
            myCar.Top = 270;

            car1.Left = 30;
            car1.Top = 30;

            car2.Left = 320;
            car2.Top = 50;

            solYon = false;
            sagYon = false;
            timer1.Start();

            carpma.Left = 165;
            carpma.Top = 294;





        }
        private void sesAc()
        {
            string sesYol = Path.Combine(Application.StartupPath, "araba.wav");

            if (File.Exists(sesYol))
            {
                SoundPlayer ses = new SoundPlayer(sesYol);
                ses.Play();
            }
            else
            {
                MessageBox.Show("Ses dosyası bulunamadı!\n" + sesYol, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            oyunuBaslat();
            sesAc();        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kazanilanScore++;
            label_score.Text = kazanilanScore.ToString();
            yol.Top += yolHizi;

            if (yol.Top > 400)
            {
                yol.Top = -100;
            }
            if (solYon)
            {
                myCar.Left -= arabaHizi;
            }
            if (sagYon)
            {
                myCar.Left += arabaHizi;
            }

            if (myCar.Left < 1)
            {
                solYon = false;
            }
            else if ((myCar.Left + myCar.Width) > 510)
            {
                sagYon = false;
            }

            car1.Top += arabaHizi;
            car2.Top += arabaHizi;

            if (car1.Top > yol.Height)
            {
                araba1Degistir();
                car1.Left = random.Next(20, 50);
                car1.Top = random.Next(40, 140) * -1;


            }
            if (car1.Top > yol.Height)
            {
                araba2Degistir();
                car2.Left = random.Next(20, 50);
                car2.Top = random.Next(40, 140) * -1;


            }
            if (myCar.Bounds.IntersectsWith(car1.Bounds) || myCar.Bounds.IntersectsWith(car2.Bounds))
            {
                gameOver();
            }
        }
        private void araba1Degistir()
        {
            int sira = random.Next(1, 7);
            switch (sira)
            {
                case 1:
                    car1.Image = Properties.Resources.araba1;
                    break;
                case 2:
                    car1.Image = Properties.Resources.araba8;
                    break;
                case 3:
                    car1.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    car1.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    car1.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    car1.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    car1.Image = Properties.Resources.araba7;
                    break;
            }
        }
        private void araba2Degistir()
        {
            int sira = random.Next(1, 7);
            switch (sira)
            {
                case 1:
                    car2.Image = Properties.Resources.araba1;
                    break;
                case 2:
                    car2.Image = Properties.Resources.araba8;
                    break;
                case 3:
                    car2.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    car2.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    car2.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    car2.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    car2.Image = Properties.Resources.araba7;
                    break;
            }
        }
        private void gameOver()
        {
            timer1.Stop();
            btn_oyunuBaslat.Enabled = true;
            carpma.Visible = true;
            myCar.Controls.Add(carpma);
            carpma.Location = new Point(7, -5);
            carpma.BringToFront();
            carpma.BackColor = Color.White;
            MessageBox.Show("Tebrikler kazandınız puanınız: " + label_score.Text, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && myCar.Left > 0)
            {
                solYon = true;
            }
            if (e.KeyCode == Keys.Right && myCar.Left + myCar.Width < yol.Width)
            {
                sagYon = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                solYon = false;
            }
            if(e.KeyCode == Keys.Right)
            {
                sagYon = false; 
            }
        }

        private void puan_Click(object sender, EventArgs e)
        {

        }

        private void btn_oyunuBaslat_Click(object sender, EventArgs e)
        {
            oyunuBaslat();
        }
    }
}
