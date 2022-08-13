using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bang_bang
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int sure = 0;
        private void Form5_Load(object sender, EventArgs e)
        {

            //Formun Görülebilirliğini Opacity Özelliği ile set edebiliriz.
            //0-1 arasında bir deger alabilir
            //this.Opacity = 0.5;
            //yavas yavas görünürlük artsın
            this.Opacity = 0;
            //timer çalışmaya başlasın opacity azar azar artsın
            timer2.Start();

            timer1.Start();
            axWindowsMediaPlayer1.URL = "baslangıc1.mp4";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            if (sure==80)
            {
                Form2 sayfa = new Form2();
                this.Hide();
                sayfa.Show();
                
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                timer3.Stop();
                this.Close();
            }
            else
                this.Opacity -= 0.1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //opacity degeri artsın
            //opacity degeri 1 e ulaşınca artış dursun timer stop etsin
            if (this.Opacity == 1)
                timer2.Stop();
            else
                this.Opacity += 0.1;
        }
    }
}
