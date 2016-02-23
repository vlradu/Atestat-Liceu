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
    public partial class ManaCriminala : Form
    {
        public ManaCriminala()
        {
            InitializeComponent();
            Cursor.Hide();
        }

        private void ManaCriminala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                GameMain game = new GameMain();
                game.ShowDialog();
                this.Close();
            }
        }

        private void ManaCriminala_Load(object sender, EventArgs e)
        {

        }
    }
}
