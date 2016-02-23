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
    public partial class Puzzle2 : Form
    {
        bool[] ok = { false, false, true, false, true, false, false, false, false, true };

        public Puzzle2()
        {
            Cursor.Show();
            InitializeComponent();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("cellar.wav");
            sp.PlayLooping();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ok[1] = !ok[1]; if (pictureBox1.BackColor == Color.DarkRed) pictureBox1.BackColor = Color.LawnGreen; else pictureBox1.BackColor = Color.DarkRed;
            ok[2] = !ok[2]; if (pictureBox2.BackColor == Color.DarkRed) pictureBox2.BackColor = Color.LawnGreen; else pictureBox2.BackColor = Color.DarkRed;
            ok[4] = !ok[4]; if (pictureBox4.BackColor == Color.DarkRed) pictureBox4.BackColor = Color.LawnGreen; else pictureBox4.BackColor = Color.DarkRed;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ok[1] = !ok[1]; if (pictureBox1.BackColor == Color.DarkRed) pictureBox1.BackColor = Color.LawnGreen; else pictureBox1.BackColor = Color.DarkRed;
            ok[2] = !ok[2]; if (pictureBox2.BackColor == Color.DarkRed) pictureBox2.BackColor = Color.LawnGreen; else pictureBox2.BackColor = Color.DarkRed;
            ok[3] = !ok[3]; if (pictureBox3.BackColor == Color.DarkRed) pictureBox3.BackColor = Color.LawnGreen; else pictureBox3.BackColor = Color.DarkRed;
            ok[5] = !ok[5]; if (pictureBox5.BackColor == Color.DarkRed) pictureBox5.BackColor = Color.LawnGreen; else pictureBox5.BackColor = Color.DarkRed;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ok[2] = !ok[2]; if (pictureBox2.BackColor == Color.DarkRed) pictureBox2.BackColor = Color.LawnGreen; else pictureBox2.BackColor = Color.DarkRed;
            ok[3] = !ok[3]; if (pictureBox3.BackColor == Color.DarkRed) pictureBox3.BackColor = Color.LawnGreen; else pictureBox3.BackColor = Color.DarkRed;
            ok[6] = !ok[6]; if (pictureBox6.BackColor == Color.DarkRed) pictureBox6.BackColor = Color.LawnGreen; else pictureBox6.BackColor = Color.DarkRed;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ok[1] = !ok[1]; if (pictureBox1.BackColor == Color.DarkRed) pictureBox1.BackColor = Color.LawnGreen; else pictureBox1.BackColor = Color.DarkRed;
            ok[4] = !ok[4]; if (pictureBox4.BackColor == Color.DarkRed) pictureBox4.BackColor = Color.LawnGreen; else pictureBox4.BackColor = Color.DarkRed;
            ok[5] = !ok[5]; if (pictureBox5.BackColor == Color.DarkRed) pictureBox5.BackColor = Color.LawnGreen; else pictureBox5.BackColor = Color.DarkRed;
            ok[7] = !ok[7]; if (pictureBox7.BackColor == Color.DarkRed) pictureBox7.BackColor = Color.LawnGreen; else pictureBox7.BackColor = Color.DarkRed;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ok[2] = !ok[2]; if (pictureBox2.BackColor == Color.DarkRed) pictureBox2.BackColor = Color.LawnGreen; else pictureBox2.BackColor = Color.DarkRed;
            ok[4] = !ok[4]; if (pictureBox4.BackColor == Color.DarkRed) pictureBox4.BackColor = Color.LawnGreen; else pictureBox4.BackColor = Color.DarkRed;
            ok[5] = !ok[5]; if (pictureBox5.BackColor == Color.DarkRed) pictureBox5.BackColor = Color.LawnGreen; else pictureBox5.BackColor = Color.DarkRed;
            ok[6] = !ok[6]; if (pictureBox6.BackColor == Color.DarkRed) pictureBox6.BackColor = Color.LawnGreen; else pictureBox6.BackColor = Color.DarkRed;
            ok[8] = !ok[8]; if (pictureBox8.BackColor == Color.DarkRed) pictureBox8.BackColor = Color.LawnGreen; else pictureBox8.BackColor = Color.DarkRed;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ok[3] = !ok[3]; if (pictureBox3.BackColor == Color.DarkRed) pictureBox3.BackColor = Color.LawnGreen; else pictureBox3.BackColor = Color.DarkRed;
            ok[5] = !ok[5]; if (pictureBox5.BackColor == Color.DarkRed) pictureBox5.BackColor = Color.LawnGreen; else pictureBox5.BackColor = Color.DarkRed;
            ok[6] = !ok[6]; if (pictureBox6.BackColor == Color.DarkRed) pictureBox6.BackColor = Color.LawnGreen; else pictureBox6.BackColor = Color.DarkRed;
            ok[9] = !ok[9]; if (pictureBox9.BackColor == Color.DarkRed) pictureBox9.BackColor = Color.LawnGreen; else pictureBox9.BackColor = Color.DarkRed;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ok[4] = !ok[4]; if (pictureBox4.BackColor == Color.DarkRed) pictureBox4.BackColor = Color.LawnGreen; else pictureBox4.BackColor = Color.DarkRed;
            ok[7] = !ok[7]; if (pictureBox7.BackColor == Color.DarkRed) pictureBox7.BackColor = Color.LawnGreen; else pictureBox7.BackColor = Color.DarkRed;
            ok[8] = !ok[8]; if (pictureBox8.BackColor == Color.DarkRed) pictureBox8.BackColor = Color.LawnGreen; else pictureBox8.BackColor = Color.DarkRed;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ok[5] = !ok[5]; if (pictureBox5.BackColor == Color.DarkRed) pictureBox5.BackColor = Color.LawnGreen; else pictureBox5.BackColor = Color.DarkRed;
            ok[7] = !ok[7]; if (pictureBox7.BackColor == Color.DarkRed) pictureBox7.BackColor = Color.LawnGreen; else pictureBox7.BackColor = Color.DarkRed;
            ok[8] = !ok[8]; if (pictureBox8.BackColor == Color.DarkRed) pictureBox8.BackColor = Color.LawnGreen; else pictureBox8.BackColor = Color.DarkRed;
            ok[9] = !ok[9]; if (pictureBox9.BackColor == Color.DarkRed) pictureBox9.BackColor = Color.LawnGreen; else pictureBox9.BackColor = Color.DarkRed;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ok[6] = !ok[6]; if (pictureBox6.BackColor == Color.DarkRed) pictureBox6.BackColor = Color.LawnGreen; else pictureBox6.BackColor = Color.DarkRed;
            ok[8] = !ok[8]; if (pictureBox8.BackColor == Color.DarkRed) pictureBox8.BackColor = Color.LawnGreen; else pictureBox8.BackColor = Color.DarkRed;
            ok[9] = !ok[9]; if (pictureBox9.BackColor == Color.DarkRed) pictureBox9.BackColor = Color.LawnGreen; else pictureBox9.BackColor = Color.DarkRed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ok[0] = true;
            for (int i = 1; i <= 9; i++)
                if (!ok[i]) ok[0] = false;
            if (ok[0])
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
                MessageBox.Show("Toate pătrațele trebuie să fie verzi!");
        }

        private void Puzzle2_Load(object sender, EventArgs e)
        {

        }

        
    }
}
