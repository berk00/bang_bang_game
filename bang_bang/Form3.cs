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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int sure = 0, sayi;
        int puan=Form1.puan1 ;

        int pp = Form1.puan2;
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;

            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            sayi = rnd.Next(50, 100);

           // label2.Text = sayi.ToString();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FAFAFA");

            panel1.Visible = false;
            panel2.Visible = false;


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
            if (sure == sayi)
            {
                SoundPlayer ses = new SoundPlayer();
                string d = Application.StartupPath + "\\Sequence 02_2.wav";
                ses.SoundLocation = d;
                ses.Play();
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
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
                    pictureBox8.Enabled = true;
                    pictureBox9.Enabled = true;
                    panel2.Visible = false;
                    panel1.Visible = false;
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = true;
                    //label2.Text = puan.ToString();
                    panel3.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    switch (puan)
                    {
                        case 1:
                        
                        
                            label8.Text = "Berabere!";
                            SoundPlayer sss = new SoundPlayer();
                            string ss = Application.StartupPath + "\\ALKIŞ SESİ.wav";
                    sss.SoundLocation = ss;
                    sss.Play();
                    pictureBox11.Visible = true;
                            break;
                       case 2:
                        case 3:

                            SoundPlayer ses1 = new SoundPlayer();
                            string ss1 = Application.StartupPath + "\\winner.wav";
                    ses1.SoundLocation = ss1;
                    ses1.Play();
                    pictureBox11.Visible = true;
                            label3.Text = Form1.a;
                            break;
                    }
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
                    pp++;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    panel2.Visible = false;
                    panel1.Visible = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                   //label4.Text = pp.ToString();
                    panel3.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    
                    switch(pp)
                    {
                       
                        case 1:
                    
                            label8.Text="Berabere!";
                            
                            SoundPlayer sss = new SoundPlayer();
                            string ss = Application.StartupPath + "\\ALKIŞ SESİ.wav";
                    sss.SoundLocation = ss;
                    sss.Play();
                    pictureBox11.Visible = true;
                            break;
                        case 2:
                        case 3:

                            SoundPlayer ses1 = new SoundPlayer();
                            string ss1 = Application.StartupPath + "\\winner.wav";
                    ses1.SoundLocation = ss1;
                    ses1.Play();
                    pictureBox11.Visible = true;
                    label3.Text = Form1.b;
                            break;

                    }
                }
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 sayfa = new Form2();
            this.Hide();
            sayfa.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.puan = 0;
            Form1 sayfa = new Form1();
            this.Hide();
            sayfa.Show();
            
        }


    }
}

    

            
        
    

