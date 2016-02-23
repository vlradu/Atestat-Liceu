using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Atestat
{
    public partial class GameMain : Form
    {
        double width, height;

        int sz = 35;  //marimea picturebox-urilor
        int sttop = 100, stleft = 100;  //pozitiile de start relativ la stanga si sus

        int lo, co, prev = 7, moveok=1;
        int[] ok = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // 0-femeie 1-cheie 2-pivnita 3-usa roz 4-jurnal 5-seif 6-usa mov 7-CD 8-CD player 9-sot

        int[] x = { 0, -1,  0,  1,  0};
        int[] y = { 0,  0,  1,  0, -1};

        int[,] a = new int[19, 33];
        PictureBox[,] p = new PictureBox[20, 33];

        string file = "Level.txt";

        public GameMain()
        {
            InitializeComponent();
            Cursor.Hide();
            ReadLevel(file);
            GenerateLevel();
            ShowLevel();
            width = this.ClientRectangle.Width;
            height = this.ClientRectangle.Height;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("HeyYou.wav");
            sp.PlayLooping();
            if (ok[9] == 1) sp.Stop();
        }

        /*void CalculateSizePos()  // calculeaza pozitia de start si dimensiunile matricei
        {
            double x = 0.08  * width, 
                   y = 0.035 * height;
            width = width - 2 * x;
            sz = Convert.ToInt32(width/32);
            height = height - 2 * y;
            sttop = Convert.ToInt32(((height + 2 * y) - 18 * sz) / 2);
            stleft = Convert.ToInt32(x);
        }*/

        void ReadLevel(string fisier)
        {
            int i = 1, j;
            string linie;
            string[] s = new string[100];
            StreamReader sr = new StreamReader(fisier);

            while ((linie = sr.ReadLine()) != null)
            {
                j = 1;
                s = linie.Split(' ');
                foreach (string c in s)
                {
                    a[i, j] = Convert.ToInt32(c);
                    if (a[i, j] == 1)
                    {
                        lo = i;
                        co = j;
                    }
                    j++;
                }
                i++;
            }
        }

        void GenerateLevel()
        {
            //CalculateSizePos();
            int i, j;
            for (i = 0; i <= 18; i++)
                for (j = 0; j <= 32; j++)
                {
                    p[i, j] = new PictureBox();
                    p[i, j].Width = sz;
                    p[i, j].Height = sz;
                    p[i, j].Left = stleft + sz * j;
                    p[i, j].Top = sttop + sz * i;
                    this.Controls.Add(p[i, j]);
                    p[i, j].Visible = false;
                }
        }

        void ShowLevel()
        {
            int i, j;
            for (i = 1; i <= 18; i++)
                for (j = 1; j <= 32; j++)
                {
                    p[i, j].SizeMode = PictureBoxSizeMode.StretchImage;

                    if (i == 0 || i == 19 || j == 0 || j == 33)                        
                        p[i, j].Image = null;

                    else
                        switch (a[i, j])
                        {
                            case 1:  p[i, j].Image = Image.FromFile("7r.png"); break;
                            case 2:  p[i, j].Image = Image.FromFile("2.png");  break;
                            case 3:  p[i, j].Image = Image.FromFile("3.png");  break;
                            case 4:  p[i, j].Image = Image.FromFile("4.png");  break;
                            case 5:  p[i, j].Image = Image.FromFile("5.png");  break;
                            case 6:  p[i, j].Image = Image.FromFile("6.png");  break;
                            case 7:  p[i, j].Image = Image.FromFile("7.png");  break;
                            case 8:  p[i, j].Image = Image.FromFile("8.png");  break;
                            case 9:  p[i, j].Image = Image.FromFile("9.png");  break;
                            case 10: p[i, j].Image = Image.FromFile("10.png"); break;
                            case 11: p[i, j].Image = Image.FromFile("11.png"); break;
                            case 12: p[i, j].Image = Image.FromFile("12.png"); break;
                            case 13: p[i, j].Image = Image.FromFile("13.png"); break;
                            case 14: p[i, j].Image = Image.FromFile("14.png"); break;
                            case 15: p[i, j].Image = Image.FromFile("15.png"); break;
                            case 16: p[i, j].Image = Image.FromFile("16.png"); break;
                            case 17: p[i, j].Image = Image.FromFile("17.png"); break;
                            case 18: p[i, j].Image = Image.FromFile("18.png"); break;
                            case 19: p[i, j].Image = Image.FromFile("19.png"); break;
                            case 31: p[i, j].Image = Image.FromFile("31.png"); break;
                            case 32: p[i, j].Image = Image.FromFile("32.png"); break;
                            case 33: p[i, j].Image = Image.FromFile("33.png"); break;
                            case 34: p[i, j].Image = Image.FromFile("34.png"); break;
                            case 35: p[i, j].Image = Image.FromFile("35.png"); break;
                            case 36: p[i, j].Image = Image.FromFile("36.png"); break;
                            case 37: p[i, j].Image = Image.FromFile("37.png"); break;
                            case 38: p[i, j].Image = Image.FromFile("38.png"); break;
                            case 40: p[i, j].Image = Image.FromFile("40.png"); break;
                            case 41: p[i, j].Image = Image.FromFile("41.png"); break;
                            case 42: p[i, j].Image = Image.FromFile("42.png"); break;
                            case 60: p[i, j].Image = Image.FromFile("60.png"); break;
                            case 66: p[i, j].Image = Image.FromFile("66.png"); break;
                            case 67: p[i, j].Image = Image.FromFile("67.png"); break;
                            case 70: p[i, j].Image = Image.FromFile("70.png"); break;
                            case 71: p[i, j].Image = Image.FromFile("71.png"); break;
                            case 72: p[i, j].Image = Image.FromFile("72.png"); break;
                            case 73: p[i, j].Image = Image.FromFile("73.png"); break;
                            case 85: p[i, j].Image = Image.FromFile("85.png"); break;
                            case 86: p[i, j].Image = Image.FromFile("86.png"); break;          
                        }
                    p[i, j].Visible = true;
                }
        }

        private void GameMain_Load(object sender, EventArgs e)
        {

        }

        private void GameMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ExitPrompt exit = new ExitPrompt();
                DialogResult exit_ok = exit.ShowDialog();
                if (exit_ok == DialogResult.OK) this.Close();
            }

            if (moveok == 1)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    switch (a[lo - 1, co])
                    {
                        case 5:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 5;  lo--; p[lo, co].Image = Image.FromFile("5u.png");  break;
                        case 6:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 6;  lo--; p[lo, co].Image = Image.FromFile("6u.png");  break;
                        case 7:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 7;  lo--; p[lo, co].Image = Image.FromFile("7u.png");  break;
                        case 8:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 8;  lo--; p[lo, co].Image = Image.FromFile("8u.png");  break;
                        case 9:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 9;  lo--; p[lo, co].Image = Image.FromFile("9u.png");  break;
                        case 14: a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 14; lo--; p[lo, co].Image = Image.FromFile("20u.png"); break;
                        case 15: a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 15; lo--; p[lo, co].Image = Image.FromFile("20u.png"); break;
                        case 18: if (ok[3] == 1)
                            { a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 18; lo--; p[lo, co].Image = Image.FromFile("20u.png"); }  break;
                        case 19: if (ok[6] == 1)
                            { a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 19; lo--; p[lo, co].Image = Image.FromFile("20u.png"); }  break;
                        default: break;
                    }
                }

                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    switch (a[lo + 1, co])
                    {
                        case 5:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 5;  lo++; p[lo, co].Image = Image.FromFile("5d.png");  break;
                        case 6:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 6;  lo++; p[lo, co].Image = Image.FromFile("6d.png");  break;
                        case 7:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 7;  lo++; p[lo, co].Image = Image.FromFile("7d.png");  break;
                        case 8:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 8;  lo++; p[lo, co].Image = Image.FromFile("8d.png");  break;
                        case 9:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 9;  lo++; p[lo, co].Image = Image.FromFile("9d.png");  break;
                        case 14: a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 14; lo++; p[lo, co].Image = Image.FromFile("20d.png"); break;
                        case 15: a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 15; lo++; p[lo, co].Image = Image.FromFile("20d.png"); break;
                        case 18: if (ok[3] == 1)
                            { a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 18; lo++; p[lo, co].Image = Image.FromFile("20d.png"); }  break;
                        case 19: if (ok[6] == 1)
                            { a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 19; lo++; p[lo, co].Image = Image.FromFile("20d.png"); }  break;
                        default: break;
                    }
                }

                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    switch (a[lo, co - 1])
                    {
                        case 5:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 5;  co--; p[lo, co].Image = Image.FromFile("5l.png");  break;
                        case 6:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 6;  co--; p[lo, co].Image = Image.FromFile("6l.png");  break;
                        case 7:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 7;  co--; p[lo, co].Image = Image.FromFile("7l.png");  break;
                        case 8:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 8;  co--; p[lo, co].Image = Image.FromFile("8l.png");  break;
                        case 9:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 9;  co--; p[lo, co].Image = Image.FromFile("9l.png");  break;
                        case 14: a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 14; co--; p[lo, co].Image = Image.FromFile("20l.png"); break;
                        default: break;
                    }
                }

                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    switch (a[lo, co + 1])
                    {
                        case 5:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 5;  co++; p[lo, co].Image = Image.FromFile("5r.png");  break;
                        case 6:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 6;  co++; p[lo, co].Image = Image.FromFile("6r.png");  break;
                        case 7:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 7;  co++; p[lo, co].Image = Image.FromFile("7r.png");  break;
                        case 8:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 8;  co++; p[lo, co].Image = Image.FromFile("8r.png");  break;
                        case 9:  a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 9;  co++; p[lo, co].Image = Image.FromFile("9r.png");  break;
                        case 14: a[lo, co] = prev; p[lo, co].Image = Image.FromFile(prev.ToString() + ".png"); prev = 14; co++; p[lo, co].Image = Image.FromFile("20r.png"); break;
                        default: break;
                    }
                }
            }

                if (e.KeyCode == Keys.Space)
                {
                        if (ScrollMessage.Visible == true)
                        {
                            ScrollMessage.Visible = false;
                            moveok = 1;
                            if (ok[9] == 1)
                            {
                                this.Close();
                                GameOver GO = new GameOver();
                                GO.ShowDialog();
                            }
                        }
                        else
                            for (int pos = 1; pos <= 4; pos++)
                            {
                                switch (a[lo + x[pos], co + y[pos]])
                                {
                                    case 2:
                                        if (ok[0] == 0)
                                        {
                                            ScrollMessage.Image = Image.FromFile("CheckCheck.png"); ScrollMessage.Visible = true; moveok = 0;
                                        }
                                        else
                                        {
                                            ScrollMessage.Image = Image.FromFile("KeyFound.png"); a[lo + x[pos], co + y[pos]] = 9; p[lo + x[pos], co + y[pos]].Image = Image.FromFile("9.png"); ok[1] = 1; ScrollMessage.Visible = true; moveok = 0;
                                        } break;

                                    case 3: ScrollMessage.Image = Image.FromFile("DiaryFound.png"); a[lo + x[pos], co + y[pos]] = 7; p[lo + x[pos], co + y[pos]].Image = Image.FromFile("7.png"); ok[4] = 1; ScrollMessage.Visible = true; moveok = 0; break;
                                    case 4: ScrollMessage.Image = Image.FromFile("CDFound.png"); a[lo + x[pos], co + y[pos]] = 8; p[lo + x[pos], co + y[pos]].Image = Image.FromFile("8.png"); ok[7] = 1; ScrollMessage.Visible = true; moveok = 0; break;
                                    case 13: ScrollMessage.Image = Image.FromFile("DoorCheck.png"); ScrollMessage.Visible = true; moveok = 0; break;

                                    case 16:
                                        if (ok[1] == 0)
                                        {
                                            ScrollMessage.Image = Image.FromFile("CellarCheck.png"); ScrollMessage.Visible = true; moveok = 0;
                                        }
                                        else if (ok[2] == 0)
                                        {
                                            Puzzle2 puzzle2 = new Puzzle2();
                                            DialogResult puzzle2_ok = puzzle2.ShowDialog();
                                            if (puzzle2_ok == DialogResult.OK)
                                            {
                                                ok[2] = 1; 
                                                ScrollMessage.Image = Image.FromFile("CellarSuccess.png"); ScrollMessage.Visible = true; moveok = 0;
                                            }                                            
                                        } break;
                                        
                                    case 18: if (ok[2] == 1 && ok[3] == 0) { ScrollMessage.Image = Image.FromFile("PinkDoorSuccess.png"); ok[3] = 1; ScrollMessage.Visible = true; moveok = 0; } break;
                                    case 19: if (ok[5] == 1 && ok[6] == 0) { ScrollMessage.Image = Image.FromFile("PurpleDoorSuccess.png"); ok[6] = 1; ScrollMessage.Visible = true; moveok = 0; } break;
                                    case 31: ScrollMessage.Image = Image.FromFile("KitchenCheck.png"); ScrollMessage.Visible = true; moveok = 0; break;
                                    case 32: ScrollMessage.Image = Image.FromFile("KitchenCheck.png"); ScrollMessage.Visible = true; moveok = 0; break;
                                    case 70: ScrollMessage.Image = Image.FromFile("WomanCheck.png"); ScrollMessage.Visible = true; moveok = 0; ok[0] = 1; break;
                                    case 71: ScrollMessage.Image = Image.FromFile("WomanCheck.png"); ScrollMessage.Visible = true; moveok = 0; ok[0] = 1; break;
                                    case 72:
                                        if (ok[4] == 0 && ok[5] == 0)
                                        {
                                            ScrollMessage.Image = Image.FromFile("SafeCheck.png"); ScrollMessage.Visible = true; moveok = 0;
                                        }
                                        if (ok[4] == 1 && ok[5] == 0)
                                        {
                                            Puzzle1 puzzle1 = new Puzzle1();
                                            DialogResult puzzle1_ok = puzzle1.ShowDialog();
                                            if (puzzle1_ok == DialogResult.OK)
                                            {
                                                ok[5] = 1;
                                                ScrollMessage.Image = Image.FromFile("SafeSuccess.png"); ScrollMessage.Visible = true; moveok = 0;
                                                
                                            }
                                        } break;
                                    case 73:
                                        if (ok[7] == 0 && ok[8] == 0)
                                        {
                                            ScrollMessage.Image = Image.FromFile("CDPlayerCheck.png"); ScrollMessage.Visible = true; moveok = 0;
                                        }
                                        if (ok[7] == 1 && ok[8] == 0)
                                        {
                                            Puzzle3 puzzle3 = new Puzzle3();
                                            DialogResult puzzle3_ok = puzzle3.ShowDialog();
                                            if (puzzle3_ok == DialogResult.OK)
                                            {
                                                ok[8] = 1;
                                                ScrollMessage.Image = Image.FromFile("CDSuccess.png"); ScrollMessage.Visible = true; moveok = 0;
                                            }
                                        } break;
                                    case 85:
                                        if (ok[8] == 0)
                                        {
                                            ScrollMessage.Image = Image.FromFile("HusbandCheck.png"); ScrollMessage.Visible = true; moveok = 0;
                                        }
                                        else
                                        {
                                            ScrollMessage.Image = Image.FromFile("HusbandSuccess.png"); ScrollMessage.Visible = true; ok[9] = 1; moveok = 0;
                                        } break;
                                    case 86:
                                        if (ok[8] == 0)
                                        {
                                            ScrollMessage.Image = Image.FromFile("NeighborCheck.png"); ScrollMessage.Visible = true; moveok = 0;
                                        }
                                        else
                                        {
                                            ScrollMessage.Image = Image.FromFile("NeighborFail.png"); ScrollMessage.Visible = true; moveok = 0;
                                        } break;
                                    default: break;
                                }
                    }
                }
            }

        private void ScrollMessage_Click(object sender, EventArgs e)
        {
            ScrollMessage.Image = null;
            ScrollMessage.Visible = false;
            moveok = 1;
        }

        private void ScrollMessage_Click_1(object sender, EventArgs e)
        {

        }

        private void GameMain_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }
    }
}
