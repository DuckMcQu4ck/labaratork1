using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
                Width += 10;
            else if (e.KeyChar == '-')
                Width -= 10;
        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Text = $"{e.X}x{e.Y}";
            else
                Text = $"{Width}x{Height}";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("ЗДАРОВА","ПРИВЕТСТВИЕ");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("ПРОЩАЙ","ПРОЩАНИЕ");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !e.Shift)
                Left += 10;
            else if (e.KeyCode == Keys.Space && e.Shift)
                Left -= 10;
        }


    }
}
