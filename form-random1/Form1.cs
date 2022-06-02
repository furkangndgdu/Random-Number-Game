using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_random1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();   
            int sayı1 = rnd.Next(1,49);
            int sayı2 = rnd.Next(1, 49);
            int sayı3 = rnd.Next(1, 49);
            int sayı4 = rnd.Next(1, 49);
            int sayı5 = rnd.Next(1, 49);
            int sayı6 = rnd.Next(1, 49);
            label1.Text = Convert.ToString(sayı1);
            label2.Text = Convert.ToString(sayı2);
            label3.Text = Convert.ToString(sayı3);
            label4.Text = Convert.ToString(sayı4);
            label5.Text = Convert.ToString(sayı5);
            label6.Text = Convert.ToString(sayı6);
        }
    }
}
