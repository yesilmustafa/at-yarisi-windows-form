using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Win_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            kellikinaye.Left += rnd.Next(1, 3);
            delibey.Left += rnd.Next(1, 3);
            akkacan.Left += rnd.Next(1, 3);
            midas.Left += rnd.Next(1, 3);
            karasimsek.Left += rnd.Next(1, 3);


            atkontrol(kellikinaye);
            atkontrol(delibey);
            atkontrol(akkacan);
            atkontrol(midas);
            atkontrol(karasimsek);


        }

        void atkontrol(PictureBox at)
        {

            if (at.Right > label1.Left) //atlardan kazanının belli alduğu yer
            {


                timer1.Stop();
                AtDurumDegistir(false, at);
                sesci.Stop();
                MessageBox.Show(at.Name + " Kazandı!");
            }

        }

        SoundPlayer sesci = new SoundPlayer();


        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();

            sesci.SoundLocation = "hm.wav";
            sesci.Play();

            AtDurumDegistir(true, kellikinaye);

        }


        void AtDurumDegistir(bool durum, PictureBox kazanan)
        {


            kellikinaye.Enabled = delibey.Enabled = akkacan.Enabled = midas.Enabled = karasimsek.Enabled = durum;

            kazanan.Enabled = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            this.Hide();
            f.Show();

        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkimizda hayirlisi = new Hakkimizda();
            hayirlisi.Show();


        }

    
    
    }

}
