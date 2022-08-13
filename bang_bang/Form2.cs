using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace bang_bang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
           
        
            
SoundPlayer ses = new SoundPlayer();
        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FAFAFA");
            
            string ss = Application.StartupPath + "\\The good the bad and the ugly - The best theme tune ever.wav";
            ses.SoundLocation = ss;
            ses.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ses.Stop();
            Form1 sayfa = new Form1();
            this.Hide();
            sayfa.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 sayfa = new Form4();
            this.Hide();
            sayfa.Show();
           

            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ses.Stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ses.Play();
        }
    }
}
