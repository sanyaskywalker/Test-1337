using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
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
            int pervoe = Convert.ToInt32(textBox1.Text);
            int vtoroe = Convert.ToInt32(textBox2.Text);
            otvet.Text = Convert.ToString(pervoe + vtoroe);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pervoe = Convert.ToInt32(textBox1.Text);
            int vtoroe = Convert.ToInt32(textBox2.Text);
            otvet.Text = Convert.ToString(pervoe - vtoroe);
        }
    }
}
