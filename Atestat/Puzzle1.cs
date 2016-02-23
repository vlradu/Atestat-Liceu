using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Puzzle1 : Form
    {
        public Puzzle1()
        {
            Cursor.Show();
            InitializeComponent();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("morse.wav");
            sp.PlayLooping();
        }

        private void Puzzle1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "42")
            {

                System.Media.SoundPlayer spi = new System.Media.SoundPlayer("HeyYou.wav");
                spi.PlayLooping();
                this.DialogResult = DialogResult.OK;
                if (this.DialogResult == DialogResult.OK)
                {
                    Cursor.Hide();
                    this.Close();
                }
            }
            else
            {
                textBox1.Text = null;
                MessageBox.Show("Cifrul nu este cel corect!");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.PerformClick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
