using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(button1, "Закрыть окно");
            toolTip1.SetToolTip(button2, "Устанавливает цвет формы на зеленый");
            toolTip1.SetToolTip(button3, "Устанавливает цвет формы на серый");
            toolTip1.SetToolTip(comboBox1,"Устанавливает курсор");
            toolTip1.SetToolTip(comboBox2,"Устанавливает цвет формы");
            toolTip1.SetToolTip(checkBox1,"Отключение возможности закрытия приложения");
            toolTip1.SetToolTip(checkBox2, "Скрыть кнопку \"закрыть\"");
            toolTip1.SetToolTip(checkBox3, "Отключает кнопку \"закрыть\"");
            toolTip1.SetToolTip(checkBox4, "Убрать границы");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X && e.Alt)
                Close();
            if (e.KeyCode == Keys.Up)
                Top += -10;
            else if (e.KeyCode == Keys.Down)
                Top -= -10;
            else if (e.KeyCode == Keys.Right)
                Left -= -10;
            else if (e.KeyCode == Keys.Left)
                Left += -10;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '+')
            {
                Width  += 10;
                Height += 10;
            }
            else if(e.KeyChar == '-')
            {
                Width  -= 10;
                Height -= 10;
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
        private void checkBox3_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = !checkBox3.Checked;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    Cursor = Cursors.Default;
                    break;
                case 1:
                    Cursor = Cursors.Hand;
                    break;
                case 2:
                    Cursor = Cursors.AppStarting;
                    break;
                case 3:
                    Cursor = Cursors.WaitCursor;
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = checkBox1.Checked;
        }


        private void checkBox2_Click(object sender, EventArgs e)
        {
            button1.Visible = !checkBox2.Checked;
        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox2.SelectedIndex)
            {
                case 0:
                    BackColor = Color.White;
                    break;
                case 1:
                    BackColor = Color.Red;
                    break;
                case 2:
                    BackColor = Color.Green;
                    break;
                case 3:
                    BackColor = Color.Blue;
                    break;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
            FormBorderStyle = checkBox4.Checked ? FormBorderStyle.Sizable : FormBorderStyle.None;
        }

    }
}
