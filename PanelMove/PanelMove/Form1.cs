using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                panel1.Top -= 10;
            }
            if (e.KeyCode == Keys.Down)
            {
                panel1.Top += 10;
            }
            if (e.KeyCode == Keys.Left)
            {
                panel1.Left -= 10;
            }
            if (e.KeyCode == Keys.Right)
            {
                panel1.Left += 10;
            }
        }
    }
}
