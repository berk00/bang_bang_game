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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FAFAFA");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 sayfa = new Form2();
            sayfa.Hide();
            sayfa.Show();
            this.Visible = false;
        }
    }
}
