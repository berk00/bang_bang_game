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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string a;
        public static string b;
        Random rnd = new Random();
        int sure = 0, sayi;
        public static int puan = 0;
        public static int puan1 ;
        public static int puan2 ;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            sayi = rnd.Next(50, 100);

           // label2.Text = sayi.ToString();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FAFAFA");

            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            
           // label1.Text = sure.ToString();
            if (sure > 1)
            {
                button1.Visible = false;
            }
            if (sure > 5)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;

            }
            if (sure==sayi)
            {
                SoundPlayer ses = new SoundPlayer();
                string d = Application.StartupPath + "\\Sequence 02_2.wav";
                ses.SoundLocation = d;
                ses.Play();
            }
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {

                if (sure > sayi)
                {
                    SoundPlayer ses = new SoundPlayer();
                    string d = Application.StartupPath + "\\Sequence 02.wav";
                    ses.SoundLocation = d;
                    ses.Play();
                    puan++;
                     puan1 = puan;
                    
                    pictureBox8.Enabled = true;
                    pictureBox9.Enabled = true;
                    panel2.Visible = false;
                    panel1.Visible = false;
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                   
                    label9.Text = textBox1.Text;
                    
                    label8.Visible = true;
                    

                }

                
            }
            if (e.KeyCode == Keys.L)
            {
                if (sure > sayi)
                {

                    SoundPlayer ses = new SoundPlayer();
                    string d = Application.StartupPath + "\\Sequence 02.wav";
                    ses.SoundLocation = d;
                    ses.Play();
                    puan++;
                     puan2 = puan;

                   
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    panel2.Visible = false;
                    panel1.Visible = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                   
                    label9.Text = textBox2.Text;
                    label8.Visible = true;



                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[0] == this)//Uygulamanin main form'u
            {
                //uygulamanin ana formunu kapatirsaniz uygulama kapanir, ana formu yeniden baslatmak uygulamayi yeniden baslatmak demektir.
                Application.Restart();
            }
            else
            {
                Form2 f = new Form2();
                f.Show();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 sayfa = new Form2();
            this.Hide();
            sayfa.Show();
            
        }

       

        private void button5_Click_1(object sender, EventArgs e)
        {
            
            Form3 sayfa = new Form3();
            this.Hide();
            sayfa.Show();
            a = textBox1.Text;
            b = textBox2.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Beto")
            {
                Form6 sayfa = new Form6();
                this.Hide();
                sayfa.Show();
            }
            if (textBox2.Text=="Beto")
            {
                Form6 sayfa = new Form6();
            this.Hide();
            sayfa.Show();
            }
        }

        
    }
}
