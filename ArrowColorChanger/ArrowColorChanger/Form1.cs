using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowColorChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                panel1.BackColor = Color.Green;
            }
            if (e.KeyCode == Keys.Down)
            {
                panel1.BackColor = Color.Red;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                panel1.BackColor = Color.Transparent;
            }
            if (e.KeyCode == Keys.Down)
            {
                panel1.BackColor = Color.Transparent;
            }
        }
    }
}
