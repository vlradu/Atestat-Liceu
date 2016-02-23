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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            Cursor.Hide();
            InitializeComponent();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("Mother.wav");
            sp.Play();
        }

        private void GameOver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void GameOver_Load(object sender, EventArgs e)
        {

        }
    }
}
