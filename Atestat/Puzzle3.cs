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
    public partial class Puzzle3 : Form
    {

        bool[] ok1 = { false, false, false, false }, //plugs,  in ordine: 2 - 1 ; 3 - 2; 1 - 3;  (plug - poza)
               ok2 = { false, false, false, false }, //chords, in ordine: 3 - 4 ; 1 - 5; 2 - 6; (chord - poza)
             final = { false, false, false, false }, // ok: 1 - 6; 2 - 4; 3 - 5  (if (poza))
               bar = { false, false, false, false };
        public Puzzle3()
        {
            Cursor.Show();
            InitializeComponent();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("static.wav");
            sp.PlayLooping();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ok1[2] = true; 
            ok1[1] = ok1[3] = false; 
            if (ok1[2] && ok2[2]) { final[2] = true; pictureBox1.BackColor = pictureBox6.BackColor = Color.LawnGreen; }
            if (!final[2]) pictureBox1.BackColor = Color.Goldenrod;
            if (!final[1]) pictureBox3.BackColor = Color.DarkRed;
            if (!final[3]) pictureBox2.BackColor = Color.DarkRed;
            if (!bar[2] && final[2]) { bar[2] = !bar[2]; progressBar1.Value++; }        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ok1[3] = true;
            ok1[1] = ok1[2] = false;
            if (ok1[3] && ok2[3]) { final[3] = true; pictureBox2.BackColor = pictureBox4.BackColor = Color.LawnGreen; }
            if (!final[3]) pictureBox2.BackColor = Color.Goldenrod;
            if (!final[1]) pictureBox3.BackColor = Color.DarkRed;
            if (!final[2]) pictureBox1.BackColor = Color.DarkRed;
            if (!bar[3] && final[3]) { bar[3] = !bar[3]; progressBar1.Value++; }   
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ok1[1] = true;
            ok1[2] = ok1[3] = false;
            if (ok1[1] && ok2[1]) { final[1] = true; pictureBox3.BackColor = pictureBox5.BackColor = Color.LawnGreen; }
            if (!final[1]) pictureBox3.BackColor = Color.Goldenrod;
            if (!final[2]) pictureBox1.BackColor = Color.DarkRed;
            if (!final[3]) pictureBox2.BackColor = Color.DarkRed;
            if (!bar[1] && final[1]) { bar[1] = !bar[1]; progressBar1.Value++; }   
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ok2[3] = true;
            ok2[1] = ok2[2] = false;
            if (ok1[3] && ok2[3]) { final[3] = true; pictureBox2.BackColor = pictureBox4.BackColor = Color.LawnGreen; }
            if (!final[3]) pictureBox4.BackColor = Color.Goldenrod;
            if (!final[1]) pictureBox5.BackColor = Color.DarkRed;
            if (!final[2]) pictureBox6.BackColor = Color.DarkRed;
            if (!bar[3] && final[3]) { bar[3] = !bar[3]; progressBar1.Value++; }   
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ok2[1] = true;
            ok2[2] = ok2[3] = false;
            if (ok1[1] && ok2[1]) { final[1] = true; pictureBox3.BackColor = pictureBox5.BackColor = Color.LawnGreen; }
            if (!final[1]) pictureBox5.BackColor = Color.Goldenrod;
            if (!final[3]) pictureBox4.BackColor = Color.DarkRed;
            if (!final[2]) pictureBox6.BackColor = Color.DarkRed;
            if (!bar[1] && final[1]) { bar[1] = !bar[1]; progressBar1.Value++; }   
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ok2[2] = true;
            ok2[1] = ok2[3] = false;
            if (ok1[2] && ok2[2]) { final[2] = true; pictureBox1.BackColor = pictureBox6.BackColor = Color.LawnGreen; }
            if (!final[2]) pictureBox6.BackColor = Color.Goldenrod;
            if (!final[3]) pictureBox4.BackColor = Color.DarkRed;
            if (!final[1]) pictureBox5.BackColor = Color.DarkRed;
            if (!bar[2] && final[2]) { bar[2] = !bar[2]; progressBar1.Value++; }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value==3)
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
                MessageBox.Show("Nu sunt conectate toate cablurile!");
        }
    }
}
