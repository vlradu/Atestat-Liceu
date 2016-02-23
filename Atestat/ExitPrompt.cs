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
    public partial class ExitPrompt : Form
    {
        public ExitPrompt()
        {
            InitializeComponent();
            Cursor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Hide();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //GameMain.
            Cursor.Hide();
            this.Close();
        }



        private void ExitPrompt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Cursor.Hide();
                this.Close();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Cursor.Hide();
                this.Close();
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Cursor.Hide();
                this.Close();
            }
        }

        private void ExitPrompt_Load(object sender, EventArgs e)
        {
            button3.DialogResult = DialogResult.OK;
            button1.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help hlp = new Help();
            hlp.ShowDialog();
            this.Close();
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Cursor.Hide();
                this.Close();
            }
        }
    }
}
