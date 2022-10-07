using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTop_games
{
    public partial class Chess : Form
    {
        public Chess()
        {
            InitializeComponent();
        }

        //Variable below here
        string Move1 = "A7";
        string Unit;
        //Variable abowe here

        private void Chess_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        //Button to take you to main lobby
        private void MainLobby_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main frm2 = new Main();
            frm2.ShowDialog();
        }

        //Button to return to table top games lobby
        private void TableTop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Table_Top frm2 = new Table_Top();
            frm2.ShowDialog();
        }

        //Makes the form resize itself if someone´s changes the size
        private Size oldSize;
        private void Form1_Load(object sender, EventArgs e) => oldSize = base.Size;

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in this.Controls)
                ResizeAll(cnt, base.Size);

            oldSize = base.Size;
        }
        private void ResizeAll(Control control, Size newSize)
        {
            int width = newSize.Width - oldSize.Width;
            control.Left += (control.Left * width) / oldSize.Width;
            control.Width += (control.Width * width) / oldSize.Width;

            int height = newSize.Height - oldSize.Height;
            control.Top += (control.Top * height) / oldSize.Height;
            control.Height += (control.Height * height) / oldSize.Height;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        //Making picture boxes do stuff
        private void A7_Click(object sender, EventArgs e)
        {
            //Checking if the tile has a piece on it
            //If it doesnt
            if (A7.Image == null)
            {
                //Checking if a piece containing tile has been clicked
                if (Move1 == null)
                {

                }
                else
                {
                    A7.Image = PCache.Image;
                    Move1 = null;
                    PCache.Image = null;

                    A1.BackColor = Color.White;
                    A2.BackColor = Color.Black;
                    A3.BackColor = Color.White;
                    A4.BackColor = Color.Black;
                    A5.BackColor = Color.White;
                    A6.BackColor = Color.Black;
                    A7.BackColor = Color.White;
                    A8.BackColor = Color.Black;

                    B1.BackColor = Color.Black;
                    B2.BackColor = Color.White;
                    B3.BackColor = Color.Black;
                    B4.BackColor = Color.White;
                    B5.BackColor = Color.Black;
                    B6.BackColor = Color.White;
                    B7.BackColor = Color.Black;
                    B8.BackColor = Color.White;

                    C1.BackColor = Color.White;
                    C2.BackColor = Color.Black;
                    C3.BackColor = Color.White;
                    C4.BackColor = Color.Black;
                    C5.BackColor = Color.White;
                    C6.BackColor = Color.Black;
                    C7.BackColor = Color.White;
                    C8.BackColor = Color.Black;

                    D1.BackColor = Color.Black;
                    D2.BackColor = Color.White;
                    D3.BackColor = Color.Black;
                    D4.BackColor = Color.White;
                    D5.BackColor = Color.Black;
                    D6.BackColor = Color.White;
                    D7.BackColor = Color.Black;
                    D8.BackColor = Color.White;

                    E1.BackColor = Color.White;
                    E2.BackColor = Color.Black;
                    E3.BackColor = Color.White;
                    E4.BackColor = Color.Black;
                    E5.BackColor = Color.White;
                    E6.BackColor = Color.Black;
                    E7.BackColor = Color.White;
                    E8.BackColor = Color.Black;

                    F1.BackColor = Color.Black;
                    F2.BackColor = Color.White;
                    F3.BackColor = Color.Black;
                    F4.BackColor = Color.White;
                    F5.BackColor = Color.Black;
                    F6.BackColor = Color.White;
                    F7.BackColor = Color.Black;
                    F8.BackColor = Color.White;

                    G1.BackColor = Color.White;
                    G2.BackColor = Color.Black;
                    G3.BackColor = Color.White;
                    G4.BackColor = Color.Black;
                    G5.BackColor = Color.White;
                    G6.BackColor = Color.Black;
                    G7.BackColor = Color.White;
                    G8.BackColor = Color.Black;

                    H1.BackColor = Color.Black;
                    H2.BackColor = Color.White;
                    H3.BackColor = Color.Black;
                    H4.BackColor = Color.White;
                    H5.BackColor = Color.Black;
                    H6.BackColor = Color.White;
                    H7.BackColor = Color.Black;
                    H8.BackColor = Color.White;
                }
            }
            //If it has a picture
            else if (A7.Image != null)
            {
                A7.BackColor = Color.Green;
                Move1 = "A7";
                PCache.Image = A7.Image;
                Selected.Text = "Selected slot: " + Move1;
                A7.Image = null;
                Test1.Text = PCache.Image.ToString();
                Test2.Text = WRook.Image.ToString();

                if (PCache.Image == WRook.Image || PCache.Image == BRook.Image)
                {
                    if ((Move1 == "A7") || (Move1 == "B7") || (Move1 == "C7") || (Move1 == "D7") || (Move1 == "E7") || (Move1 == "F7") || (Move1 == "G7") || (Move1 == "H7"))
                    {
                        Unit = "rook";
                        A6.BackColor = Color.LightGreen;
                        A5.BackColor = Color.LightGreen;
                        if (B6.Image != null)
                        {
                            B6.BackColor = Color.LightGreen;
                        }
                    }
                    else if ((Move1 == "A4") || (Move1 == "B4") || (Move1 == "C4") || (Move1 == "D4") || (Move1 == "E4") || (Move1 == "F4") || (Move1 == "G4") || (Move1 == "H4"))
                    {
                        if (B4.Image != null)
                        {
                            if(B4.Image == Properties.Resources.White_rook || B4.Image == Properties.Resources.Black_rook1)
                            {
                                B3.BackColor = Color.LightGreen;
                            }
                        }
                    }
                    else
                    {
                        A6.BackColor = Color.LightGreen;
                        if (B6 != null)
                        {
                            B6.BackColor = Color.LightGreen;
                        }
                    }
                }
                else if (PCache.Image == Properties.Resources.White_knight || PCache.Image == Properties.Resources.Black_knight1)
                {

                }
                else if (PCache.Image == Properties.Resources.White_tower || PCache.Image == Properties.Resources.Black_tower1)
                {

                }
                else if (PCache.Image == Properties.Resources.White_bishop || PCache.Image == Properties.Resources.Black_bishop1)
                {

                }
                else if (PCache.Image == Properties.Resources.White_King || PCache.Image == Properties.Resources.Black_King1)
                {

                }
                else if (PCache.Image == Properties.Resources.White_queen || PCache.Image == Properties.Resources.Black_queen1)
                {

                }
                Selected.Text = "Selected slot: " + Move1 + " Selected unit" + Unit;
            }
        }

        private void A6_Click(object sender, EventArgs e)
        {

            //Checking if the tile has a piece on it
            //If it doesnt
            if (A6.Image == null)
            {
                //Checking if a piece containing tile has been clicked
                if (Move1 == null)
                {

                }
                else
                {
                    A6.Image = PCache.Image;
                    Move1 = null;
                    PCache.Image = null;

                    A1.BackColor = Color.White;
                    A2.BackColor = Color.Black;
                    A3.BackColor = Color.White;
                    A4.BackColor = Color.Black;
                    A5.BackColor = Color.White;
                    A6.BackColor = Color.Black;
                    A7.BackColor = Color.White;
                    A8.BackColor = Color.Black;

                    B1.BackColor = Color.Black;
                    B2.BackColor = Color.White;
                    B3.BackColor = Color.Black;
                    B4.BackColor = Color.White;
                    B5.BackColor = Color.Black;
                    B6.BackColor = Color.White;
                    B7.BackColor = Color.Black;
                    B8.BackColor = Color.White;

                    C1.BackColor = Color.White;
                    C2.BackColor = Color.Black;
                    C3.BackColor = Color.White;
                    C4.BackColor = Color.Black;
                    C5.BackColor = Color.White;
                    C6.BackColor = Color.Black;
                    C7.BackColor = Color.White;
                    C8.BackColor = Color.Black;

                    D1.BackColor = Color.Black;
                    D2.BackColor = Color.White;
                    D3.BackColor = Color.Black;
                    D4.BackColor = Color.White;
                    D5.BackColor = Color.Black;
                    D6.BackColor = Color.White;
                    D7.BackColor = Color.Black;
                    D8.BackColor = Color.White;

                    E1.BackColor = Color.White;
                    E2.BackColor = Color.Black;
                    E3.BackColor = Color.White;
                    E4.BackColor = Color.Black;
                    E5.BackColor = Color.White;
                    E6.BackColor = Color.Black;
                    E7.BackColor = Color.White;
                    E8.BackColor = Color.Black;

                    F1.BackColor = Color.Black;
                    F2.BackColor = Color.White;
                    F3.BackColor = Color.Black;
                    F4.BackColor = Color.White;
                    F5.BackColor = Color.Black;
                    F6.BackColor = Color.White;
                    F7.BackColor = Color.Black;
                    F8.BackColor = Color.White;

                    G1.BackColor = Color.White;
                    G2.BackColor = Color.Black;
                    G3.BackColor = Color.White;
                    G4.BackColor = Color.Black;
                    G5.BackColor = Color.White;
                    G6.BackColor = Color.Black;
                    G7.BackColor = Color.White;
                    G8.BackColor = Color.Black;

                    H1.BackColor = Color.Black;
                    H2.BackColor = Color.White;
                    H3.BackColor = Color.Black;
                    H4.BackColor = Color.White;
                    H5.BackColor = Color.Black;
                    H6.BackColor = Color.White;
                    H7.BackColor = Color.Black;
                    H8.BackColor = Color.White;

                }
            }
            //If it has a picture
            else if (A6.Image != null)
            {
                A6.BackColor = Color.Green;
                Move1 = "A6";
                PCache.Image = A6.Image;
                Selected.Text = Move1;
                A6.Image = null;
            }
        }
        
    }
    }
