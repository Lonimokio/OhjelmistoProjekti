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
        string Result;
        string FString;
        string SString;

        int Calculation = 1;
        int color = 1;
        int counter = 1;

        bool EnPassant;
        bool Towering;
        bool OutOfBoundsCheck;
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
        public void GetFString()
        {

            if (Math.Substring(0, 1) == "A")
            {
                FString = "B";
            }
            else if (Math.Substring(0, 1) == "B")
            {
                FString = "C";
                SString = "A";
            }
            else if (Math.Substring(0, 1) == "C")
            {
                FString = "D";
                SString = "B";
            }
            else if (Math.Substring(0, 1) == "D")
            {
                FString = "E";
                SString = "C";
            }
            else if (Math.Substring(0, 1) == "E")
            {
                FString = "F";
                SString = "D";
            }
            else if (Math.Substring(0, 1) == "F")
            {
                FString = "G";
                SString = "E";
            }
            else if (Math.Substring(0, 1) == "G")
            {
                FString = "H";
                SString = "F";
            }
            else if (Math.Substring(0, 1) == "H")
            {
                SString = "G";
            }
            else
            {

            }
        }
        public void OutOfBounds()
        {
            if (Result != "A1")
            {
                if (Result != "A2")
                {
                    if (Result != "A3")
                    {
                        if (Result != "A4")
                        {
                            if (Result != "A5")
                            {
                                if (Result != "A6")
                                {
                                    if (Result != "A7")
                                    {
                                        if (Result != "A8")
                                        {
                                            if (Result != "B1")
                                            {
                                                if (Result != "B2")
                                                {
                                                    if (Result != "B3")
                                                    {
                                                        if (Result != "B4")
                                                        {
                                                            if (Result != "B5")
                                                            {
                                                                if (Result != "B6")
                                                                {
                                                                    if (Result != "B7")
                                                                    {
                                                                        if (Result != "B8")
                                                                        {
                                                                            if (Result != "C1")
                                                                            {
                                                                                if (Result != "C2")
                                                                                {
                                                                                    if (Result != "C3")
                                                                                    {
                                                                                        if (Result != "C4")
                                                                                        {
                                                                                            if (Result != "C5")
                                                                                            {
                                                                                                if (Result != "C6")
                                                                                                {
                                                                                                    if (Result != "C7")
                                                                                                    {
                                                                                                        if (Result != "C8")
                                                                                                        {
                                                                                                            if (Result != "D1")
                                                                                                            {
                                                                                                                if (Result != "D2")
                                                                                                                {
                                                                                                                    if (Result != "D3")
                                                                                                                    {
                                                                                                                        if (Result != "D4")
                                                                                                                        {
                                                                                                                            if (Result != "D5")
                                                                                                                            {
                                                                                                                                if (Result != "D6")
                                                                                                                                {
                                                                                                                                    if (Result != "D7")
                                                                                                                                    {
                                                                                                                                        if (Result != "D8")
                                                                                                                                        {
                                                                                                                                            if (Result != "E1")
                                                                                                                                            {
                                                                                                                                                if (Result != "E2")
                                                                                                                                                {
                                                                                                                                                    if (Result != "E3")
                                                                                                                                                    {
                                                                                                                                                        if (Result != "E4")
                                                                                                                                                        {
                                                                                                                                                            if (Result != "E5")
                                                                                                                                                            {
                                                                                                                                                                if (Result != "E6")
                                                                                                                                                                {
                                                                                                                                                                    if (Result != "E7")
                                                                                                                                                                    {
                                                                                                                                                                        if (Result != "E8")
                                                                                                                                                                        {
                                                                                                                                                                            if (Result != "F1")
                                                                                                                                                                            {
                                                                                                                                                                                if (Result != "F2")
                                                                                                                                                                                {
                                                                                                                                                                                    if (Result != "F3")
                                                                                                                                                                                    {
                                                                                                                                                                                        if (Result != "F4")
                                                                                                                                                                                        {
                                                                                                                                                                                            if (Result != "F5")
                                                                                                                                                                                            {
                                                                                                                                                                                                if (Result != "F6")
                                                                                                                                                                                                {
                                                                                                                                                                                                    if (Result != "F7")
                                                                                                                                                                                                    {
                                                                                                                                                                                                        if (Result != "F8")
                                                                                                                                                                                                        {
                                                                                                                                                                                                            if (Result != "G1")
                                                                                                                                                                                                            {
                                                                                                                                                                                                                if (Result != "G2")
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    if (Result != "G3")
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        if (Result != "G4")
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            if (Result != "G5")
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                if (Result != "G6")
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    if (Result != "G7")
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        if (Result != "G8")
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            if (Result != "H1")
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                if (Result != "H2")
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    if (Result != "H3")
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        if (Result != "H4")
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            if (Result != "H5")
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                if (Result != "H6")
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    if (Result != "H7")
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        if (Result != "H8")
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            OutOfBoundsCheck = true;
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                }
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
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
                    Math = "A1";
                    Calculation = int.Parse(Math.Substring(1, 1));
                    FString = "A";

                    for (int i = 0; i <= 63; i++)
                    {
                        Result = FString + Calculation.ToString();
                        Math = Result;
                        if (color == 1)
                        {
                            this.Controls[Result].BackColor = Color.White;
                            color = 2;
                        }
                        else if (color == 2)
                        {
                            this.Controls[Result].BackColor = Color.Black;
                            color = 1;
                        }
                        Calculation++;
                        if (Calculation == 9)
                        {
                            GetFString();
                            Calculation = 1;
                            if (counter == 1)
                            {
                                color = 2;
                                counter++;
                            }
                            else if (counter == 2)
                            {
                                color = 1;
                                counter = 1;
                            }
                        }
                    }
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
                            if (this.Controls[Result].Tag == null)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;

                                Calculation = Calculation - 1;
                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                Test2.Text = Result.ToString();
                                if (this.Controls[Result].Tag == null)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                }
                            }

                            Calculation = int.Parse(Math.Substring(1, 1));
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                            //Checking if you can eat
                            if (ReferenceBox.Image != null)
                            {
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    Calculation = int.Parse(Math.Substring(1, 1));
                                    Calculation = Calculation - 1;

                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                }
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
                                if (ReferenceBox.Image == Properties.Resources.Black_rook1)
                                {
                                    Calculation = Calculation - 1;
                                    Result = FString + Calculation.ToString();
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    EnPassant = true;
                                }

                            }
                        }
                        //Normal rook movement
                        else
                        {
                            Math = (sender as PictureBox).Name;
                            Calculation = int.Parse(Math.Substring(1, 1));
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();

                            this.Controls[Result].BackColor = Color.LightGreen;

                            Calculation = int.Parse(Math.Substring(1, 1));
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                            //Checking if you can eat
                            if (ReferenceBox.Image != null)
                            {
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    Calculation = int.Parse(Math.Substring(1, 1));
                                    Calculation = Calculation - 1;

                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                }
                            }
                        }
                    }
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
                            if (this.Controls[Result].Tag == null)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;

                                Calculation = Calculation + 1;
                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                Test2.Text = Result.ToString();
                                if (this.Controls[Result].Tag == null)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                }
                            }

                            Calculation = int.Parse(Math.Substring(1, 1));
                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                            //Checking if you can eat
                            if (ReferenceBox.Image != null)
                            {
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    Calculation = int.Parse(Math.Substring(1, 1));
                                    Calculation = Calculation + 1;

                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                }
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
                                if (ReferenceBox.Image == Properties.Resources.White_rook)
                                {
                                    Calculation = Calculation + 1;
                                    Result = FString + Calculation.ToString();
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    EnPassant = true;
                                }

                            }
                        }
                        //Normal rook movement
                        else
                        {
                            Math = (sender as PictureBox).Name;
                            Calculation = int.Parse(Math.Substring(1, 1));
                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();

                            this.Controls[Result].BackColor = Color.LightGreen;

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
                    }
                    //White knigth logic
                    else if (PCache.Tag == WKnigth.Tag)
                    {
                        Unit = "White knigth";

                        //Calculation settup
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 2;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
                        if (Result != "A1" || Result != "A2" || Result != "A3" || Result != "A4" || Result != "A5" || Result != "A6" || Result != "A7" || Result != "A8" || Result != "B1" || Result != "B2" || Result != "B3" || Result != "B4" || Result != "B5" || Result != "B6" || Result != "B7" || Result != "B8" || Result != "C1" || Result != "C2" || Result != "C3" || Result != "C4" || Result != "C5" || Result != "C6" || Result != "C7" || Result != "C8" || Result != "D1" || Result != "D2" || Result != "D3" || Result != "D4" || Result != "D5" || Result != "D6" || Result != "D7" || Result != "D8" || Result != "E1" || Result != "E2" || Result != "E3" || Result != "E4" || Result != "E5" || Result != "E6" || Result != "E7" || Result != "E8" || Result != "F1" || Result != "F2" || Result != "F3" || Result != "F4" || Result != "F5" || Result != "F6" || Result != "F7" || Result != "F8" || Result != "G1" || Result != "G2" || Result != "G3" || Result != "G4" || Result != "G5" || Result != "G6" || Result != "G7" || Result != "G8" || Result != "H1" || Result != "H2" || Result != "H3" || Result != "H4" || Result != "H5" || Result != "H6" || Result != "H7" || Result != "H8")
                        {
                            ReferenceBox = (PictureBox)this.Controls["Empty"];
                            Result = "Empty";
                        }

                        //Down knight logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (Result != "A1" || Result != "A2" || Result != "A3" || Result != "A4" || Result != "A5" || Result != "A6" || Result != "A7" || Result != "A8" || Result != "B1" || Result != "B2" || Result != "B3" || Result != "B4" || Result != "B5" || Result != "B6" || Result != "B7" || Result != "B8" || Result != "C1" || Result != "C2" || Result != "C3" || Result != "C4" || Result != "C5" || Result != "C6" || Result != "C7" || Result != "C8" || Result != "D1" || Result != "D2" || Result != "D3" || Result != "D4" || Result != "D5" || Result != "D6" || Result != "D7" || Result != "D8" || Result != "E1" || Result != "E2" || Result != "E3" || Result != "E4" || Result != "E5" || Result != "E6" || Result != "E7" || Result != "E8" || Result != "F1" || Result != "F2" || Result != "F3" || Result != "F4" || Result != "F5" || Result != "F6" || Result != "F7" || Result != "F8" || Result != "G1" || Result != "G2" || Result != "G3" || Result != "G4" || Result != "G5" || Result != "G6" || Result != "G7" || Result != "G8" || Result != "H1" || Result != "H2" || Result != "H3" || Result != "H4" || Result != "H5" || Result != "H6" || Result != "H7" || Result != "H8")
                        {
                            ReferenceBox = (PictureBox)this.Controls["Empty"];
                            Result = "Empty";
                        }

                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        //Up knight logic
                        Calculation = Calculation - 4;
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (Result != "A1" || Result != "A2" || Result != "A3" || Result != "A4" || Result != "A5" || Result != "A6" || Result != "A7" || Result != "A8" || Result != "B1" || Result != "B2" || Result != "B3" || Result != "B4" || Result != "B5" || Result != "B6" || Result != "B7" || Result != "B8" || Result != "C1" || Result != "C2" || Result != "C3" || Result != "C4" || Result != "C5" || Result != "C6" || Result != "C7" || Result != "C8" || Result != "D1" || Result != "D2" || Result != "D3" || Result != "D4" || Result != "D5" || Result != "D6" || Result != "D7" || Result != "D8" || Result != "E1" || Result != "E2" || Result != "E3" || Result != "E4" || Result != "E5" || Result != "E6" || Result != "E7" || Result != "E8" || Result != "F1" || Result != "F2" || Result != "F3" || Result != "F4" || Result != "F5" || Result != "F6" || Result != "F7" || Result != "F8" || Result != "G1" || Result != "G2" || Result != "G3" || Result != "G4" || Result != "G5" || Result != "G6" || Result != "G7" || Result != "G8" || Result != "H1" || Result != "H2" || Result != "H3" || Result != "H4" || Result != "H5" || Result != "H6" || Result != "H7" || Result != "H8")
                        {
                            ReferenceBox = (PictureBox)this.Controls["Empty"];
                            Result = "Empty";
                        }

                        Test1.Text = Result;
                        if (ReferenceBox.Tag != WRook.Tag || ReferenceBox.Tag != WBishop.Tag || ReferenceBox.Tag != WQueen.Tag || ReferenceBox.Tag != WKnigth.Tag || ReferenceBox.Tag != WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];


                        if (Result != "A1" || Result != "A2" || Result != "A3" || Result != "A4" || Result != "A5" || Result != "A6" || Result != "A7" || Result != "A8" || Result != "B1" || Result != "B2" || Result != "B3" || Result != "B4" || Result != "B5" || Result != "B6" || Result != "B7" || Result != "B8" || Result != "C1" || Result != "C2" || Result != "C3" || Result != "C4" || Result != "C5" || Result != "C6" || Result != "C7" || Result != "C8" || Result != "D1" || Result != "D2" || Result != "D3" || Result != "D4" || Result != "D5" || Result != "D6" || Result != "D7" || Result != "D8" || Result != "E1" || Result != "E2" || Result != "E3" || Result != "E4" || Result != "E5" || Result != "E6" || Result != "E7" || Result != "E8" || Result != "F1" || Result != "F2" || Result != "F3" || Result != "F4" || Result != "F5" || Result != "F6" || Result != "F7" || Result != "F8" || Result != "G1" || Result != "G2" || Result != "G3" || Result != "G4" || Result != "G5" || Result != "G6" || Result != "G7" || Result != "G8" || Result != "H1" || Result != "H2" || Result != "H3" || Result != "H4" || Result != "H5" || Result != "H6" || Result != "H7" || Result != "H8")
                        {
                            ReferenceBox = (PictureBox)this.Controls["Empty"];
                            Result = "Empty";
                        }
                        Test2.Text = Result;
                        if (ReferenceBox.Tag != WRook.Tag || ReferenceBox.Tag != WBishop.Tag || ReferenceBox.Tag != WQueen.Tag || ReferenceBox.Tag != WKnigth.Tag || ReferenceBox.Tag != WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        //Side knight logic
                        GetFString();
                        Calculation = Calculation + 3;
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (Result != "A1" || Result != "A2" || Result != "A3" || Result != "A4" || Result != "A5" || Result != "A6" || Result != "A7" || Result != "A8" || Result != "B1" || Result != "B2" || Result != "B3" || Result != "B4" || Result != "B5" || Result != "B6" || Result != "B7" || Result != "B8" || Result != "C1" || Result != "C2" || Result != "C3" || Result != "C4" || Result != "C5" || Result != "C6" || Result != "C7" || Result != "C8" || Result != "D1" || Result != "D2" || Result != "D3" || Result != "D4" || Result != "D5" || Result != "D6" || Result != "D7" || Result != "D8" || Result != "E1" || Result != "E2" || Result != "E3" || Result != "E4" || Result != "E5" || Result != "E6" || Result != "E7" || Result != "E8" || Result != "F1" || Result != "F2" || Result != "F3" || Result != "F4" || Result != "F5" || Result != "F6" || Result != "F7" || Result != "F8" || Result != "G1" || Result != "G2" || Result != "G3" || Result != "G4" || Result != "G5" || Result != "G6" || Result != "G7" || Result != "G8" || Result != "H1" || Result != "H2" || Result != "H3" || Result != "H4" || Result != "H5" || Result != "H6" || Result != "H7" || Result != "H8")
                        {
                            ReferenceBox = (PictureBox)this.Controls["Empty"];
                            Result = "Empty";
                        }

                        if (ReferenceBox.Tag != WRook.Tag || ReferenceBox.Tag != WBishop.Tag || ReferenceBox.Tag != WQueen.Tag || ReferenceBox.Tag != WKnigth.Tag || ReferenceBox.Tag != WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (Result != "A1" || Result != "A2" || Result != "A3" || Result != "A4" || Result != "A5" || Result != "A6" || Result != "A7" || Result != "A8" || Result != "B1" || Result != "B2" || Result != "B3" || Result != "B4" || Result != "B5" || Result != "B6" || Result != "B7" || Result != "B8" || Result != "C1" || Result != "C2" || Result != "C3" || Result != "C4" || Result != "C5" || Result != "C6" || Result != "C7" || Result != "C8" || Result != "D1" || Result != "D2" || Result != "D3" || Result != "D4" || Result != "D5" || Result != "D6" || Result != "D7" || Result != "D8" || Result != "E1" || Result != "E2" || Result != "E3" || Result != "E4" || Result != "E5" || Result != "E6" || Result != "E7" || Result != "E8" || Result != "F1" || Result != "F2" || Result != "F3" || Result != "F4" || Result != "F5" || Result != "F6" || Result != "F7" || Result != "F8" || Result != "G1" || Result != "G2" || Result != "G3" || Result != "G4" || Result != "G5" || Result != "G6" || Result != "G7" || Result != "G8" || Result != "H1" || Result != "H2" || Result != "H3" || Result != "H4" || Result != "H5" || Result != "H6" || Result != "H7" || Result != "H8")
                        {
                            ReferenceBox = (PictureBox)this.Controls["Empty"];
                            Result = "Empty";
                        }

                        if (ReferenceBox.Tag != WRook.Tag || ReferenceBox.Tag != WBishop.Tag || ReferenceBox.Tag != WQueen.Tag || ReferenceBox.Tag != WKnigth.Tag || ReferenceBox.Tag != WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        Calculation = Calculation + 2;
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (Result != "A1" || Result != "A2" || Result != "A3" || Result != "A4" || Result != "A5" || Result != "A6" || Result != "A7" || Result != "A8" || Result != "B1" || Result != "B2" || Result != "B3" || Result != "B4" || Result != "B5" || Result != "B6" || Result != "B7" || Result != "B8" || Result != "C1" || Result != "C2" || Result != "C3" || Result != "C4" || Result != "C5" || Result != "C6" || Result != "C7" || Result != "C8" || Result != "D1" || Result != "D2" || Result != "D3" || Result != "D4" || Result != "D5" || Result != "D6" || Result != "D7" || Result != "D8" || Result != "E1" || Result != "E2" || Result != "E3" || Result != "E4" || Result != "E5" || Result != "E6" || Result != "E7" || Result != "E8" || Result != "F1" || Result != "F2" || Result != "F3" || Result != "F4" || Result != "F5" || Result != "F6" || Result != "F7" || Result != "F8" || Result != "G1" || Result != "G2" || Result != "G3" || Result != "G4" || Result != "G5" || Result != "G6" || Result != "G7" || Result != "G8" || Result != "H1" || Result != "H2" || Result != "H3" || Result != "H4" || Result != "H5" || Result != "H6" || Result != "H7" || Result != "H8")
                        {
                            ReferenceBox = (PictureBox)this.Controls["Empty"];
                            Result = "Empty";
                        }


                        if (ReferenceBox.Tag != WRook.Tag || ReferenceBox.Tag != WBishop.Tag || ReferenceBox.Tag != WQueen.Tag || ReferenceBox.Tag != WKnigth.Tag || ReferenceBox.Tag != WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        
                        {
                            ReferenceBox = (PictureBox)this.Controls["Empty"];
                            Result = "Empty";
                        }
                    

                        if (ReferenceBox.Tag != WRook.Tag || ReferenceBox.Tag != WBishop.Tag || ReferenceBox.Tag != WQueen.Tag || ReferenceBox.Tag != WKnigth.Tag || ReferenceBox.Tag != WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                            }
                    }
                    //Black knigth logic
                    else if (PCache.Tag == BKnigth.Tag)
                    {
                        Unit = "Black knigth";

                        //Calculation settup
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 2;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down knight logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        Result = SString + Calculation.ToString();

                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        //Up knight logic
                        Calculation = Calculation - 4;
                        Result = FString + Calculation.ToString();

                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        Result = SString + Calculation.ToString();

                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        //Side knight logic
                        GetFString();
                        Calculation = Calculation + 3;
                        Result = FString + Calculation.ToString();

                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        Result = SString + Calculation.ToString();

                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        Calculation = Calculation + 2;
                        Result = SString + Calculation.ToString();

                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }

                        Result = FString + Calculation.ToString();

                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                        }
                    }
                    //White tower move logic
                    else if (PCache.Tag == WTower.Tag)
                    {
                        Unit = "White tower";
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down move logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        Result = Math.Substring(0, 1) + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation + 1;
                                            Result = Math.Substring(0, 1) + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation + 1;
                                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation + 1;
                                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Calculation = int.Parse(Math.Substring(1, 1));
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        //Up move logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation - 1;
                                        Result = Math.Substring(0, 1) + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation - 1;
                                            Result = Math.Substring(0, 1) + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation - 1;
                                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation - 1;
                                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Side logic rigth
                        Calculation = int.Parse(Math.Substring(1, 1));
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            //Side logic left
                            Math = (sender as PictureBox).Name;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        GetFString();
                                        Result = SString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            GetFString();
                                            Result = SString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                GetFString();
                                                Result = SString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    GetFString();
                                                    Result = SString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                    {
                                                        this.Controls[Result].BackColor = Color.LightGreen;
                                                        GetFString();
                                                        Result = SString + Calculation.ToString();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                    //Black tower move logic
                    else if (PCache.Tag == BTower.Tag)
                    {
                        Unit = "Black tower";
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down move logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        Result = Math.Substring(0, 1) + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation + 1;
                                            Result = Math.Substring(0, 1) + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation + 1;
                                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation + 1;
                                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Calculation = int.Parse(Math.Substring(1, 1));
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        //Up move logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation - 1;
                                        Result = Math.Substring(0, 1) + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation - 1;
                                            Result = Math.Substring(0, 1) + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation - 1;
                                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation - 1;
                                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Side logic rigth
                        Calculation = int.Parse(Math.Substring(1, 1));
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            //Side logic left
                            Math = (sender as PictureBox).Name;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        GetFString();
                                        Result = SString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            GetFString();
                                            Result = SString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                GetFString();
                                                Result = SString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    GetFString();
                                                    Result = SString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                    {
                                                        this.Controls[Result].BackColor = Color.LightGreen;
                                                        GetFString();
                                                        Result = SString + Calculation.ToString();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                    //White bishop move logic
                    else if (PCache.Tag == WBishop.Tag)
                    {
                        Unit = "White bishop";

                        //Calculation initialization
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
                        
                        //Down rigth movement logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation + 1;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation + 1;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation + 1;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Up rigth movement logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation - 1;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation - 1;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation - 1;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation - 1;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Up left movement logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation - 1;
                                        GetFString();
                                        Result = SString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation - 1;
                                            GetFString();
                                            Result = SString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation - 1;
                                                GetFString();
                                                Result = SString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation - 1;
                                                    GetFString();
                                                    Result = SString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down left movement logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        GetFString();
                                        Result = SString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation + 1;
                                            GetFString();
                                            Result = SString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation + 1;
                                                GetFString();
                                                Result = SString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation + 1;
                                                    GetFString();
                                                    Result = SString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {

                        }
                    }
                    //Black bishop move logic
                    else if (PCache.Tag == BBishop.Tag)
                    {
                        Unit = "Black bishop";

                        //Calculation initialization
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down rigth movement logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation + 1;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation + 1;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation + 1;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Up rigth movement logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation - 1;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation - 1;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation - 1;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation - 1;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Up left movement logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation - 1;
                                        GetFString();
                                        Result = SString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation - 1;
                                            GetFString();
                                            Result = SString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation - 1;
                                                GetFString();
                                                Result = SString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation - 1;
                                                    GetFString();
                                                    Result = SString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down left movement logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        GetFString();
                                        Result = SString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation + 1;
                                            GetFString();
                                            Result = SString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation + 1;
                                                GetFString();
                                                Result = SString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation + 1;
                                                    GetFString();
                                                    Result = SString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    //White king move logic
                    else if (PCache.Tag == WKing.Tag)
                    {
                        Unit = "White king";

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down move logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                        }
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        //Up move logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                        }
                        //Side logic rigth
                        Calculation = int.Parse(Math.Substring(1, 1));
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            GetFString();
                            Result = FString + Calculation.ToString();
                        }
                        //Side logic left
                        Math = (sender as PictureBox).Name;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            GetFString();
                            Result = SString + Calculation.ToString();
                        }

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down rigth movement logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                        }
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Up rigth movement logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                        }
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Up left movement logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                        }
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down left movement logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                        }
                    }
                    //Black king move logic
                    else if (PCache.Tag == BKing.Tag)
                    {
                        Unit = "Black king";

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down move logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                        }
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        //Up move logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                        }
                        //Side logic rigth
                        Calculation = int.Parse(Math.Substring(1, 1));
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            GetFString();
                            Result = FString + Calculation.ToString();
                        }
                        //Side logic left
                        Math = (sender as PictureBox).Name;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            GetFString();
                            Result = SString + Calculation.ToString();
                        }

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down rigth movement logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                        }
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Up rigth movement logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                        }
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Up left movement logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                        }
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down left movement logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                        }
                    }
                    //White queen move logic
                    else if (PCache.Tag == WQueen.Tag)
                    {
                        Unit = "White queen";

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down move logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        Result = Math.Substring(0, 1) + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation + 1;
                                            Result = Math.Substring(0, 1) + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation + 1;
                                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation + 1;
                                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Calculation = int.Parse(Math.Substring(1, 1));
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        //Up move logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation - 1;
                                        Result = Math.Substring(0, 1) + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation - 1;
                                            Result = Math.Substring(0, 1) + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation - 1;
                                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation - 1;
                                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Side logic rigth
                        Calculation = int.Parse(Math.Substring(1, 1));
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Side logic left
                        Math = (sender as PictureBox).Name;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        //Calculation initialization
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down rigth movement logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation + 1;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation + 1;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation + 1;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Up rigth movement logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation - 1;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation - 1;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation - 1;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation - 1;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Up left movement logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation - 1;
                                        GetFString();
                                        Result = SString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation - 1;
                                            GetFString();
                                            Result = SString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation - 1;
                                                GetFString();
                                                Result = SString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation - 1;
                                                    GetFString();
                                                    Result = SString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down left movement logic
                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        GetFString();
                                        Result = SString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation + 1;
                                            GetFString();
                                            Result = SString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation + 1;
                                                GetFString();
                                                Result = SString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == WRook.Tag || ReferenceBox.Tag == WBishop.Tag || ReferenceBox.Tag == WQueen.Tag || ReferenceBox.Tag == WKnigth.Tag || ReferenceBox.Tag == WTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation + 1;
                                                    GetFString();
                                                    Result = SString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Selected.Text = "Selected slot: " + Move1 + " Selected unit: " + Unit;
                    }
                    //Black queen move logic
                    else if (PCache.Tag == BQueen.Tag)
                    {
                        Unit = "Black queen";

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down move logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        Result = Math.Substring(0, 1) + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation + 1;
                                            Result = Math.Substring(0, 1) + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation + 1;
                                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation + 1;
                                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Calculation = int.Parse(Math.Substring(1, 1));
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        //Up move logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation - 1;
                                        Result = Math.Substring(0, 1) + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation - 1;
                                            Result = Math.Substring(0, 1) + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation - 1;
                                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation - 1;
                                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Side logic rigth
                        Calculation = int.Parse(Math.Substring(1, 1));
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Side logic left
                        Math = (sender as PictureBox).Name;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        //Calculation initialization
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down rigth movement logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation + 1;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation + 1;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation + 1;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Up rigth movement logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation - 1;
                                        GetFString();
                                        Result = FString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation - 1;
                                            GetFString();
                                            Result = FString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation - 1;
                                                GetFString();
                                                Result = FString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation - 1;
                                                    GetFString();
                                                    Result = FString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Up left movement logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation - 1;
                                        GetFString();
                                        Result = SString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation - 1;
                                            GetFString();
                                            Result = SString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation - 1;
                                                GetFString();
                                                Result = SString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation - 1;
                                                    GetFString();
                                                    Result = SString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        Math = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down left movement logic
                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        GetFString();
                                        Result = SString + Calculation.ToString();
                                        ReferenceBox = (PictureBox)this.Controls[Result];
                                        if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                        {
                                            this.Controls[Result].BackColor = Color.LightGreen;
                                            Calculation = Calculation + 1;
                                            GetFString();
                                            Result = SString + Calculation.ToString();
                                            ReferenceBox = (PictureBox)this.Controls[Result];
                                            if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                            {
                                                this.Controls[Result].BackColor = Color.LightGreen;
                                                Calculation = Calculation + 1;
                                                GetFString();
                                                Result = SString + Calculation.ToString();
                                                ReferenceBox = (PictureBox)this.Controls[Result];
                                                if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                                                {
                                                    this.Controls[Result].BackColor = Color.LightGreen;
                                                    Calculation = Calculation + 1;
                                                    GetFString();
                                                    Result = SString + Calculation.ToString();
                                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    }
                Selected.Text = "Selected slot: " + Move1 + " Selected Unit: " + Unit;
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