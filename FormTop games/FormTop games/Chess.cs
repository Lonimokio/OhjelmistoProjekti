using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormTop_games
{
    public partial class Chess : Form
    {
        public Chess()
        {
            InitializeComponent();

            A1.Click += ChessClick;
            A2.Click += ChessClick;
            A3.Click += ChessClick;
            A4.Click += ChessClick;
            A5.Click += ChessClick;
            A6.Click += ChessClick;
            A7.Click += ChessClick;
            A8.Click += ChessClick;

            B1.Click += ChessClick;
            B2.Click += ChessClick;
            B3.Click += ChessClick;
            B4.Click += ChessClick;
            B5.Click += ChessClick;
            B6.Click += ChessClick;
            B7.Click += ChessClick;
            B8.Click += ChessClick;

            C1.Click += ChessClick;
            C2.Click += ChessClick;
            C3.Click += ChessClick;
            C4.Click += ChessClick;
            C5.Click += ChessClick;
            C6.Click += ChessClick;
            C7.Click += ChessClick;
            C8.Click += ChessClick;

            D1.Click += ChessClick;
            D2.Click += ChessClick;
            D3.Click += ChessClick;
            D4.Click += ChessClick;
            D5.Click += ChessClick;
            D6.Click += ChessClick;
            D7.Click += ChessClick;
            D8.Click += ChessClick;

            E1.Click += ChessClick;
            E2.Click += ChessClick;
            E3.Click += ChessClick;
            E4.Click += ChessClick;
            E5.Click += ChessClick;
            E6.Click += ChessClick;
            E7.Click += ChessClick;
            E8.Click += ChessClick;

            F1.Click += ChessClick;
            F2.Click += ChessClick;
            F3.Click += ChessClick;
            F4.Click += ChessClick;
            F5.Click += ChessClick;
            F6.Click += ChessClick;
            F7.Click += ChessClick;
            F8.Click += ChessClick;

            G1.Click += ChessClick;
            G2.Click += ChessClick;
            G3.Click += ChessClick;
            G4.Click += ChessClick;
            G5.Click += ChessClick;
            G6.Click += ChessClick;
            G7.Click += ChessClick;
            G8.Click += ChessClick;

            H1.Click += ChessClick;
            H2.Click += ChessClick;
            H3.Click += ChessClick;
            H4.Click += ChessClick;
            H5.Click += ChessClick;
            H6.Click += ChessClick;
            H7.Click += ChessClick;
            H8.Click += ChessClick;
        }

        //Variable below here
        string Move1;
        string Unit;
        string Math = "A";
        int Calculation = 1;
        string Result;
        string FString;
        int color;
        //Variable abowe here

        /*Image comparison
        public static List<bool> GetHash(Bitmap bmpSource)
        {
            List<bool> lResult = new List<bool>();
            //create new image with 16x16 pixel
            Bitmap bmpMin = new Bitmap(bmpSource, new Size(16, 16));
            for (int j = 0; j < bmpMin.Height; j++)
            {
                for (int i = 0; i < bmpMin.Width; i++)
                {
                    //reduce colors to true / false                
                    lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
                }
            }
            return lResult;
        }*/

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
        public void GetFString()
        {

            if (Math.Substring(0, 1) == "A")
            {
                FString = "B";
            }
            else if (Math.Substring(0, 1) == "B")
            {
                FString = "C";
            }
            else if (Math.Substring(0, 1) == "C")
            {
                FString = "D";
            }
            else if (Math.Substring(0, 1) == "D")
            {
                FString = "E";
            }
            else if (Math.Substring(0, 1) == "E")
            {
                FString = "F";
            }
            else if (Math.Substring(0, 1) == "F")
            {
                FString = "G";
            }
            else
            {

            }
        }


        //Making picture boxes do stuff
        public void ChessClick(object sender, EventArgs e)
        {
            //Checking if the tile has a piece on it
            //If it doesnt
            if ((sender as PictureBox).Image == null)
            {
                //Checking if a piece containing tile has been clicked
                if (Move1 == null)
                {

                }
                else if ((sender as PictureBox).BackColor == Color.LightGreen)
                {

                    PictureBox test = (sender as PictureBox);
                    (sender as PictureBox).Image = PCache.Image;
                    (sender as PictureBox).Tag = PCache.Tag;
                    Move1 = null;
                    PCache.Image = null;
                    PCache.Tag = null;


                    for (int i = 0; i <= 64; i++)
                    {
                        Result = FString + Calculation.ToString();
                        if (color == 1)
                        {
                            this.Controls[Result].BackColor = Color.White;
                        }
                        else if (color == 2) 
                        {
                            this.Controls[Result].BackColor = Color.Black;
                        }
                        Calculation++;
                        if (Calculation == 9)
                        {
                            GetFString();
                            Calculation = 1;
                        }
                    }

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
            //Checking legal moves
            else if ((sender as PictureBox).Image != null)
            {
                if (Move1 == null)
                {
                    (sender as PictureBox).BackColor = Color.Green;
                    Move1 = (sender as PictureBox).Name;
                    PCache.Image = (sender as PictureBox).Image;
                    PCache.Tag = (sender as PictureBox).Tag;

                    Selected.Text = "Selected slot: " + Move1;
                    (sender as PictureBox).Image = null;

                    //Checking legal white rook moves
                    if (PCache.Tag == WRook.Tag)
                    {
                        Math = (sender as PictureBox).Name;
                        Unit = "White rook";
                        //Checking if starting first square
                        if ((Move1 == "A7") || (Move1 == "B7") || (Move1 == "C7") || (Move1 == "D7") || (Move1 == "E7") || (Move1 == "F7") || (Move1 == "G7") || (Move1 == "H7"))
                        {
                            Calculation = int.Parse(Math.Substring(1, 1));
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            Test1.Text = Result.ToString();
                            this.Controls[Result].BackColor = Color.LightGreen;

                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            Test2.Text = Result.ToString();
                            this.Controls[Result].BackColor = Color.LightGreen;

                            Calculation = int.Parse(Math.Substring(1, 1));
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                            //Checking if you can eat
                            if (ReferenceBox.Image != null)
                            {
                                Calculation = int.Parse(Math.Substring(1, 1));
                                Calculation = Calculation - 1;

                                GetFString();
                                Result = FString + Calculation.ToString();
                                this.Controls[Result].BackColor = Color.LightGreen;
                            }
                        }

                        //En passant logic
                        else if ((Move1 == "A4") || (Move1 == "B4") || (Move1 == "C4") || (Move1 == "D4") || (Move1 == "E4") || (Move1 == "F4") || (Move1 == "G4") || (Move1 == "H4"))
                        {
                            Calculation = int.Parse(Math.Substring(1, 1));
                            GetFString();
                            Result = FString + Calculation.ToString();
                            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Image != null)
                            {
                                if (ReferenceBox.Image == Properties.Resources.White_rook || ReferenceBox.Image == Properties.Resources.Black_rook1)
                                {
                                    Calculation = Calculation - 1;
                                    Result = FString + Calculation.ToString();
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                }

                            }
                        }
                        else
                        {
                            Math = (sender as PictureBox).Name;
                            Calculation = int.Parse(Math.Substring(1, 1));
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();

                            this.Controls[Result].BackColor = Color.LightGreen;

                            if (B6.Image != null)
                            {
                                B6.BackColor = Color.LightGreen;
                            }
                        }
                    }

                    /*List<bool> iHash1 = GetHash(new Bitmap(PCache.Image));
                    List<bool> iHash2 = GetHash(new Bitmap(BRook.Image));

                    //determine the number of equal pixel (x of 256)
                    int equalElements = iHash1.Zip(iHash2, (i, j) => i == j).Count(eq => eq);*/

                    //Checking legal black rook moves
                    if (PCache.Tag == BRook.Tag)
                    {
                        Math = (sender as PictureBox).Name;
                        Unit = "Black rook";
                        //Checking if starting first square
                        if ((Move1 == "A2") || (Move1 == "B2") || (Move1 == "C2") || (Move1 == "D2") || (Move1 == "E2") || (Move1 == "F2") || (Move1 == "G2") || (Move1 == "H2"))
                        {


                            Calculation = int.Parse(Math.Substring(1, 1));
                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            this.Controls[Result].BackColor = Color.LightGreen;

                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            this.Controls[Result].BackColor = Color.LightGreen;

                            Calculation = int.Parse(Math.Substring(1, 1));
                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                            //Checking if you can eat
                            if (ReferenceBox.Image != null)
                            {
                                Calculation = int.Parse(Math.Substring(1, 1));
                                Calculation = Calculation + 1;

                                GetFString();
                                Result = FString + Calculation.ToString();
                                this.Controls[Result].BackColor = Color.LightGreen;
                            }
                        }

                        //En passant logic
                        else if ((Move1 == "A5") || (Move1 == "B5") || (Move1 == "C5") || (Move1 == "D5") || (Move1 == "E5") || (Move1 == "F5") || (Move1 == "G5") || (Move1 == "H5"))
                        {
                            Calculation = int.Parse(Math.Substring(1, 1));
                            GetFString();
                            Result = FString + Calculation.ToString();
                            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Image != null)
                            {
                                if (ReferenceBox.Image == Properties.Resources.White_rook || ReferenceBox.Image == Properties.Resources.Black_rook1)
                                {
                                    Calculation = Calculation + 1;
                                    Result = FString + Calculation.ToString();
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                }

                            }
                        }
                        else
                        {
                            Math = (sender as PictureBox).Name;
                            Calculation = int.Parse(Math.Substring(1, 1));
                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();

                            this.Controls[Result].BackColor = Color.LightGreen;

                            if (B6.Image != null)
                            {
                                B6.BackColor = Color.LightGreen;
                            }
                        }
                    }
                    else if (PCache.Tag == WKnigth.Tag || PCache.Tag == BKnigth.Tag)
                    {
                        Unit = "Knigth";
                    }
                    else if (PCache.Tag == WTower.Tag || PCache.Tag == BTower.Tag)
                    {
                        Unit = "Tower";
                    }
                    else if (PCache.Tag == WBishop.Tag || PCache.Tag == BBishop.Tag)
                    {
                        Unit = "Bishop";
                    }
                    else if (PCache.Tag == WKing.Tag || PCache.Tag == BKing.Tag)
                    {
                        Unit = "King";
                    }
                    else if (PCache.Tag == WQueen.Tag || PCache.Tag == BQueen.Tag)
                    {
                        Unit = "Queen";
                    }
                    Selected.Text = "Selected slot: " + Move1 + " Selected unit: " + Unit;
                }
            }
        }

        private void PCache_Click(object sender, EventArgs e)
        {

        }

        private void H8_Click(object sender, EventArgs e)
        {

        }

        private void A8_Click(object sender, EventArgs e)
        {

        }

        private void G8_Click(object sender, EventArgs e)
        {

        }

        private void B8_Click(object sender, EventArgs e)
        {

        }
    }
    }
