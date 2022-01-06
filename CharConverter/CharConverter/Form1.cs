using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox2.Text = "nasrat";
            }
            else
            {
                textBox2.Text = Encoding.ASCII.GetBytes(textBox1.Text)[0].ToString();
            }
        }
    }
}
