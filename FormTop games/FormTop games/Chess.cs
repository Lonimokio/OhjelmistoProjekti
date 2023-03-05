using MongoDB.Bson.Serialization.IdGenerators;
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

            Lock("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
        }

        #region Variables
        //Variable below here
        #region String Variables
        string Move1;
        string Move2;
        string Unit;
        string Math = "A";
        string Math1;
        string Math2;
        string Math3;
        string Result = "Empty";
        string Result1;
        string Result2;
        string FString = "A";
        string FString1 = "A";
        string SString;
        string BKingL = "E1";
        string WKingL = "E8";
        string CheckingN;
        string Indicator;
        string Indicator1;
        string Indicator2;
        string NumberIndicator;
        string NumberIndicator1;
        #endregion
        #region Int Variables
        int Calculation = 1;
        int Calculation1 = 1;
        int Calculation2 = 1;
        int color = 1;
        int counter = 1;
        int Turn = 1;
        int NumberIndicator2;
        int NumberIndicator3;
        #endregion
        #region Bool Variables
        bool FTime = true;
        bool Checking = false;
        bool CheckW = false;
        bool CheckB = false;
        bool EnPassant;
        bool EnPassantC = true;
        bool Towering;
        bool MovementCheck = true;
        bool OutOfBoundsCheck = false;
        bool IsGreen;
        bool WCKing = true;
        bool BCKing = true;
        bool WKRook = true;
        bool BooleanIndicator;
        #endregion

        //Variable abowe here
        #endregion

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

        #region Resize things
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
        #endregion

        #region Methods
        public void GetFString()
        {

            if (Math.Substring(0, 1) == "A")
            {
                SString = "I";
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
                FString = "I";
                SString = "G";
            }
            else
            {

            }
        }
        //Checking out of bounds
        public void OutOfBounds()
        {
            Calculation1 = Calculation;
            Calculation = 1;
            FString = "A";
            Math = Math1;
            for (int i = 0; i < 63; i++)
            {
                Math = FString;
                Result1 = FString + Calculation.ToString();

                //Checking if its different
                if (Result != Result1)
                {
                    OutOfBoundsCheck = true;
                }
                //Checking if its a valid tile
                if (Result == Result1)
                {
                    OutOfBoundsCheck = false;
                    Math = Result;
                    Calculation = Calculation1;
                    return;
                }

                Calculation++;
                if (Calculation == 9)
                {
                    GetFString();
                    Calculation = 1;
                }
            }
            Math = Result;
            Calculation = Calculation1;
            FString = "";
        }
        //Checking for own troops
        public void MovementD(string Troop, string Troop1, string Troop2, string Troop3, string Troop4, string Troop5)
        {
            if (Troop != "BKnigth" || Troop1 != "BQueen" || Troop2 != "BTower" || Troop3 != "BRook" || Troop4 != "BBishop" || Troop5 != "BKing")
            {
                if (Troop != "WKnigth" || Troop1 != "WQueen" || Troop2 != "WTower" || Troop3 != "WRook" || Troop4 != "WBishop" || Troop5 != "WKing")
                {
                    MessageBox.Show("Troop: " + Troop + " Troop1: " + Troop1 + " Troop2: " + Troop2 + " Troop3: " + Troop3 + " Troop4: " + Troop4 + " Troop5: " + Troop5);
                }
            }
                MovementCheck = true;
                if (this.Controls[Result].Tag == this.Controls[Troop].Tag || this.Controls[Result].Tag == this.Controls[Troop1].Tag || this.Controls[Result].Tag == this.Controls[Troop2].Tag || this.Controls[Result].Tag == this.Controls[Troop3].Tag || this.Controls[Result].Tag == this.Controls[Troop4].Tag || this.Controls[Result].Tag == this.Controls[Troop5].Tag)
                {
                    MovementCheck = false;
                }
        }
        //Locking other team
        public void Lock(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, bool Lock1)
        {
            Calculation = 1;
            FString = "A";
            Math = "A1";
            for (int i = 0; i < 64; i++)
            {
                Math = FString;
                Result = FString + Calculation.ToString();

                if (this.Controls[Result].Tag == this.Controls[Side].Tag || this.Controls[Result].Tag == this.Controls[Side1].Tag || this.Controls[Result].Tag == this.Controls[Side2].Tag || this.Controls[Result].Tag == this.Controls[Side3].Tag || this.Controls[Result].Tag == this.Controls[Side4].Tag || this.Controls[Result].Tag == this.Controls[Side5].Tag)
                {
                    this.Controls[Result].Enabled = Lock1;
                }
                Calculation++;
                if (Calculation == 9)
                {
                    GetFString();
                    Calculation = 1;
                }
            }
            Calculation = 1;
            Math = "A1";
            FString = "A";
        }
        //Resetting board
        public void Reset()
        {
            Math = "A1";
            Calculation = int.Parse(Math.Substring(1, 1));
            FString = "A";
            for (int i = 0; i <= 63; i++)
            {
                Result = FString + Calculation.ToString();
                Math = Result;
                if (color == 1)
                {
                    if (this.Controls[Result].BackColor == Color.Cyan)
                    {
                        this.Controls[Result].Tag = null;
                        PictureBox ImageBox = (PictureBox)this.Controls[Result];
                        ImageBox.Image = null;
                    }
                    this.Controls[Result].BackColor = Color.White;
                    color = 2;
                }
                else if (color == 2)
                {
                    if (this.Controls[Result].BackColor == Color.Cyan)
                    {
                        this.Controls[Result].Tag = null;
                        PictureBox ImageBox = (PictureBox)this.Controls[Result];
                        ImageBox.Image = null;
                    }
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
        //Check system
        public void CheckCheck(PictureBox sender)
        {
            //Reseting board for check checking

            Reset();

            Math2 = "A1";
            Math3 = "A1";
            Calculation2 = int.Parse(Math2.Substring(1, 1));
            FString1 = "A";
            //Checking for promotion and check
            for (int i = 0; i <= 63; i++)
            {
                FString1 = Math2.Substring(0, 1);
                Result2 = FString1 + Calculation2.ToString();
                Math2 = Result2;
                Math3 = Result2;
                Result = Result2;
                OutOfBounds();
                if (OutOfBoundsCheck == true)
                {

                }

                else if (this.Controls[Result2].Tag != null)
                {
                    //Calculation settup
                    Math = Result2;
                    Math1 = Result2;
                    PCache.Tag = this.Controls[Result2].Tag;
                    #region legal rook moves
                    //White
                    RookFullMovement(true, (sender as PictureBox), true, false);
                    //Black
                    RookFullMovement(false, (sender as PictureBox), true, false);
                    #endregion

                    #region Knigth logic
                    //WHite
                    KnightFullMovement(true, (sender as PictureBox), true, false);
                    //Black
                    KnightFullMovement(false, (sender as PictureBox), true, false);
                    #endregion

                    #region Tower move logic
                    //White
                    TowerFullMovement(true, sender, true, false);
                    //Black
                    TowerFullMovement(false, sender, true, false);
                    #endregion

                    #region Bishop move logic
                    //White
                    BishopFullMovement(true, sender, true, false);
                    //Black
                    BishopFullMovement(false, sender, true, false);
                    #endregion

                    #region King move logic
                    //White
                    KingFullMovement(true, sender, true, false);
                    //Black
                    KingFullMovement(false, sender, true, false);
                    #endregion

                    #region Queen move logic
                    //White
                    QueenFullMovement(true, sender, true, false);
                    //Black
                    QueenFullMovement(false, sender, true, false);
                    #endregion
                }
                    //Increment to loop trough board
                    Math2 = Math3;
                Calculation2 = Calculation2 + 1;
                if (Calculation2 == 9)
                {
                    Math = FString1;
                    GetFString();
                    FString1 = FString;
                    Math2 = FString1;
                    Math3 = FString1;
                    Calculation2 = 1;
                }
            }

            //Checking if king has been in check
            if (CheckB == true || CheckW == true)
            {
                Checking = true;
            }
            //Checking if black king is in check
            if (this.Controls[BKingL].BackColor == Color.LightGreen)
            {
                if (Turn == 2)
                {
                    //Undoing invalid move
                    PictureBox CheckingBox = (PictureBox)this.Controls[CheckingN];
                    PictureBox CheckingBox1 = (PictureBox)this.Controls[Move1];
                    CheckingBox1.Image = CheckingBox.Image;
                    CheckingBox1.Tag = CheckingBox.Tag;
                    if (CheckingBox.Tag == BKing.Tag)
                    {
                        BKingL = CheckingBox1.Name;
                    }
                    if (CheckingBox.Name != CheckingBox1.Name)
                    {
                        CheckingBox.Image = null;
                        CheckingBox.Tag = null;
                    }
                    IsGreen = true;
                }
                else
                {
                    if (FTime == true)
                    {
                        IsGreen = false;
                        FTime = false;
                        Move2 = Move1;
                    }
                    Check.Visible = true;
                    CheckB = true;
                    Colour.Text = "Black";
                    Colour.Visible = true;
                }
            }
            //Checking if white king is in check
            else if (this.Controls[WKingL].BackColor == Color.LightGreen)
            {
                if (Turn == 1)
                {
                    //Undoing invalid move
                    PictureBox CheckingBox = (PictureBox)this.Controls[CheckingN];
                    PictureBox CheckingBox1 = (PictureBox)this.Controls[Move1];
                    CheckingBox1.Image = CheckingBox.Image;
                    CheckingBox1.Tag = CheckingBox.Tag;
                    if (CheckingBox.Tag == WKing.Tag)
                    {
                        WKingL = CheckingBox1.Name;
                    }
                    if (CheckingBox.Name != CheckingBox1.Name)
                    {
                        CheckingBox.Image = null;
                        CheckingBox.Tag = null;
                    }
                    IsGreen = true;
                }
                else
                {
                    if (FTime == true)
                    {
                        IsGreen = false;
                        FTime = false;
                        Move2 = Move1;
                    }
                    Check.Visible = true;
                    CheckW = true;
                    Colour.Text = "White";
                    Colour.Visible = true;
                }
            }
            //Checking if black king is not in check
            else if (this.Controls[BKingL].BackColor != Color.LightGreen)
            {
                FTime = true;
                Check.Visible = false;
                CheckB = false;
                Colour.Visible = false;
                Checking = false;
            }
            //Checking if white king is not in check
            else if (this.Controls[WKingL].BackColor != Color.LightGreen)
            {
                FTime = true;
                Check.Visible = false;
                CheckW = false;
                Colour.Visible = false;
                Checking = false;
            }
            //Checking if king has been in check
            if (CheckB == true)
            {
                if (Checking == true)
                {
                    //Undoing invalid move
                    PictureBox CheckingBox = (PictureBox)this.Controls[CheckingN];
                    PictureBox CheckingBox1 = (PictureBox)this.Controls[Move1];
                    if (this.Controls[CheckingN].Tag != null)
                    {
                        CheckingBox1.Image = CheckingBox.Image;
                        CheckingBox1.Tag = CheckingBox.Tag;
                        if (CheckingBox.Tag == BKing.Tag)
                        {
                            BKingL = CheckingBox1.Name;
                        }
                    }
                    if (CheckingBox.Name != CheckingBox1.Name)
                    {
                        CheckingBox.Image = null;
                        CheckingBox.Tag = null;
                    }
                    IsGreen = true;
                }
            }
            else if (CheckW == true)
            {
                if (Checking == true)
                {
                    //Undoing invalid move
                    PictureBox CheckingBox = (PictureBox)this.Controls[CheckingN];
                    PictureBox CheckingBox1 = (PictureBox)this.Controls[Move1];
                    if (this.Controls[CheckingN].Tag != null)
                    {
                        CheckingBox1.Image = CheckingBox.Image;
                        CheckingBox1.Tag = CheckingBox.Tag;
                        if (CheckingBox.Tag == WKing.Tag)
                        {
                            WKingL = CheckingBox1.Name;
                        }
                    }
                    if (CheckingBox.Name != CheckingBox1.Name)
                    {
                        CheckingBox.Image = null;
                        CheckingBox.Tag = null;
                    }
                    IsGreen = true;
                }
            }
            //Clearing board
            Reset();
        }
        //Checkmate system components
        public void BKCheckmate(bool Bypass)
        {
            //Checking if black king is in check
            if (this.Controls[BKingL].BackColor == Color.LightGreen)
            {
                if (Check.Visible == true)
                {
                    if (Bypass == true)
                    {
                        Mate.Visible = true;
                        //Restart loop

                        Reset();
                        MessageBox.Show("Black King is in a checkmate \n                White Wins!!!");
                        const string message = "Would you like to play again?";
                        const string caption = "Retry";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        //If the no button gets pressed
                        if (result == DialogResult.No)
                        {
                            this.Hide();
                            Main frm2 = new Main();
                            frm2.ShowDialog();
                        }
                        else if (result == DialogResult.Yes)
                        {
                            this.Hide();
                            Chess frm2 = new Chess();
                            frm2.ShowDialog();
                        }
                    }
                    else if (Bypass == false)
                    {
                        if (this.Controls[Move2].BackColor != Color.LightGreen)
                        {
                            Mate.Visible = true;
                            //Restart loop

                            Reset();
                            MessageBox.Show("Black King is in a checkmate \n                White Wins!!!");
                            const string message = "Would you like to play again?";
                            const string caption = "Retry";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            //If the no button gets pressed
                            if (result == DialogResult.No)
                            {
                                this.Hide();
                                Main frm2 = new Main();
                                frm2.ShowDialog();
                            }
                            else if (result == DialogResult.Yes)
                            {
                                this.Hide();
                                Chess frm2 = new Chess();
                                frm2.ShowDialog();
                            }
                        }
                    }
                }
            }
        }
        public void WKCheckmate(bool Bypass)
        {
            //Checking if white king is in check
            if (this.Controls[WKingL].BackColor == Color.LightGreen)
            {
                if (Check.Visible == true)
                {
                    if (Bypass == true)
                    {
                        Mate.Visible = true;
                        //Restart loop

                        Reset();
                        MessageBox.Show("White King is in a checkmate \n                Black Wins!!!");
                        const string message = "Would you like to play again?";
                        const string caption = "Retry";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        //If the no button gets pressed
                        if (result == DialogResult.No)
                        {
                            this.Hide();
                            Main frm2 = new Main();
                            frm2.ShowDialog();
                        }
                        else if (result == DialogResult.Yes)
                        {
                            this.Hide();
                            Chess frm2 = new Chess();
                            frm2.ShowDialog();
                        }
                    }
                    if (Bypass == false)
                    {
                        if (this.Controls[Move2].BackColor != Color.LightGreen)
                        {
                            Mate.Visible = true;
                            //Restart loop

                            Reset();
                            MessageBox.Show("White King is in a checkmate \n                Black Wins!!!");
                            const string message = "Would you like to play again?";
                            const string caption = "Retry";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            //If the no button gets pressed
                            if (result == DialogResult.No)
                            {
                                this.Hide();
                                Main frm2 = new Main();
                                frm2.ShowDialog();
                            }
                            else if (result == DialogResult.Yes)
                            {
                                this.Hide();
                                Chess frm2 = new Chess();
                                frm2.ShowDialog();
                            }
                        }
                    }
                }
            }
        }
        //Checkmate system
        public void CheckMate(PictureBox sender)
        {
            Math2 = "A1";
            Math3 = "A1";
            Calculation2 = int.Parse(Math2.Substring(1, 1));
            FString1 = "A";
            //Checking for checkmate
            for (int i = 0; i <= 63; i++)
            {
                FString1 = Math2.Substring(0, 1);
                Result2 = FString1 + Calculation2.ToString();
                Math2 = Result2;
                Math3 = Result2;
                Result = Result2;
                OutOfBounds();
                if (OutOfBoundsCheck == true)
                {

                }
                else if (this.Controls[Result2].Tag != null)
                {
                    //Calculation settup
                    Math = Result2;
                    Math1 = Result2;
                    PCache.Tag = this.Controls[Result2].Tag;
                        if (Turn == 1)
                        {
                            #region legal rook moves
                            //White
                            RookFullMovement(true, sender, true, true);
                            #endregion

                            #region Knigth logic
                            //WHite
                            KnightFullMovement(true, sender, true, true);
                            #endregion

                            #region Tower move logic
                            //White
                            TowerFullMovement(true, sender, true, true);
                            #endregion

                            #region Bishop move logic
                            //White
                            BishopFullMovement(true, sender, true, true);
                            #endregion

                            #region King move logic
                            //White
                            KingFullMovement(true, sender, true, true);
                            #endregion

                            #region Queen move logic
                            //White
                            QueenFullMovement(true, sender, true, true);
                            #endregion
                        }
                        else if (Turn == 2)
                        {
                            #region legal rook moves
                            //Black
                            RookFullMovement(false, sender, true, true);
                            #endregion

                            #region Knigth logic
                            //Black
                            KnightFullMovement(true, sender, true, true);
                            #endregion

                            #region Tower move logic
                            //Black
                            TowerFullMovement(false, sender, true, true);
                            #endregion

                            #region Bishop move logic
                            //Black
                            BishopFullMovement(false, sender, true, true);
                            #endregion

                            #region King move logic
                            //Black
                            KingFullMovement(false, sender, true, true);
                            #endregion

                            #region Queen move logic
                            //Black
                            QueenFullMovement(false, sender, true, true);
                            #endregion
                        }
                }
                //Increment to loop trough board
                Math2 = Math3;
                Calculation2 = Calculation2 + 1;
                if (Calculation2 == 9)
                {
                    Math = FString1;
                    GetFString();
                    FString1 = FString;
                    Math2 = FString1;
                    Math3 = FString1;
                    Calculation2 = 1;
                }
            }

            Math2 = "A1";
            Math3 = "A1";
            Calculation2 = int.Parse(Math2.Substring(1, 1));
            FString1 = "A";
            //Checking for promotion and check
            for (int i = 0; i <= 63; i++)
            {
                FString1 = Math2.Substring(0, 1);
                Result2 = FString1 + Calculation2.ToString();
                Math2 = Result2;
                Math3 = Result2;
                Result = Result2;
                OutOfBounds();
                if (OutOfBoundsCheck == true)
                {

                }

                else if (this.Controls[Result2].Tag != null)
                {
                    //Calculation settup
                    Math = Result2;
                    Math1 = Result2;
                    PCache.Tag = this.Controls[Result2].Tag;

                    #region legal rook moves
                    //White
                    RookFullMovement(true, sender, true, false);
                    //Black
                    RookFullMovement(false, sender, true, false);
                    #endregion

                    #region Knigth logic
                    //WHite
                    KnightFullMovement(true, sender, true, false);
                    //Black
                    KnightFullMovement(false, sender, true, false);
                    #endregion

                    #region Tower move logic
                    //White
                    TowerFullMovement(true, sender, true, false);
                    //Black
                    TowerFullMovement(false, sender, true, false);
                    #endregion

                    #region Bishop move logic
                    //White
                    BishopFullMovement(true, sender, true, false);
                    //Black
                    BishopFullMovement(false, sender, true, false);
                    #endregion

                    #region King move logic
                    //White
                    KingFullMovement(true, sender, true, false);
                    //Black
                    KingFullMovement(false, sender, true, false);
                    #endregion

                    #region Queen move logic
                    //White
                    QueenFullMovement(true, sender, true, false);
                    //Black
                    QueenFullMovement(false, sender, true, false);
                    #endregion
                }

                //Increment to loop trough board
                Math2 = Math3;
                Calculation2 = Calculation2 + 1;
                if (Calculation2 == 9)
                {
                    Math = FString1;
                    GetFString();
                    FString1 = FString;
                    Math2 = FString1;
                    Math3 = FString1;
                    Calculation2 = 1;
                }
            }

            BKCheckmate(false);
            WKCheckmate(false);

            Reset();
        }
        //Alternation to normal movement
        public void Alternation(bool Alternative)
        {
            if (Alternative == true)
            {
                if (this.Controls[Result].Tag == null)
                {
                    if (this.Controls[Math1].BackColor != Color.Cyan)
                    {
                        this.Controls[Result].BackColor = Color.Cyan;
                        this.Controls[Result].Tag = this.Controls[Math1].Tag;
                        PictureBox ImageBox = (PictureBox)this.Controls[Result];
                        PictureBox ImageBox2 = (PictureBox)this.Controls[Math1];
                        ImageBox.Image = ImageBox2.Image;
                    }
                }
            }
            else if (Alternative == false)
            {
                if (this.Controls[Result].BackColor != Color.Cyan)
                {
                    this.Controls[Result].BackColor = Color.LightGreen;
                }
                if (this.Controls[Result].Tag == "WKing" || this.Controls[Result].Tag == "BKing")
                {
                    this.Controls[Result].BackColor = Color.LightGreen;
                    if (this.Controls[Result].Tag == "WKing")
                    {
                        WKingL = this.Controls[Result].Name;
                        WKCheckmate(true);
                    }
                    else if (this.Controls[Result].Tag == "BKing")
                    {
                        BKingL = this.Controls[Result].Name;
                        BKCheckmate(true);
                    }
                }
            }
        }
        //Method for turn change
        public void Turner()
        {
            if (Turn == 1)
            {
                Turn = 2;
            }
            else if (Turn == 2)
            {
                Turn = 1;
            }
            TurnDebug.Text = Turn.ToString();
            MessageBox.Show("TurnDebug: " + Turn.ToString());
        }

        #region Movement logic methods
        //Movement logic as methods
        //Straigth movement
        public void DownUp(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative, bool King)
        {
            //Down and Up move logic
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            Result = Math.Substring(0, 1) + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                Math = Math1;
                return;
            }

            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                Alternation(Alternative);
                MovementD(OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
                if (MovementCheck == false)
                {
                    Math = Math1;
                    return;
                }
                if (King == false)
                {
                    DownUp(Side, Side1, Side2, Side3, Side4, Side5, op, OSide, OSide1, OSide2, OSide3, OSide4, OSide5, Alternative, King);
                }
                
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        public void SideR(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative, bool King)
        {
            //Side logic rigth
            Calculation = int.Parse(Math.Substring(1, 1));
            GetFString();
            Result = FString + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                Math = Math1;
                return;
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                Alternation(Alternative);
                MovementD(OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
                if (MovementCheck == false)
                {
                    Math = Math1;
                    return;
                }
                if (King == false)
                {
                    SideR(Side, Side1, Side2, Side3, Side4, Side5, OSide, OSide1, OSide2, OSide3, OSide4, OSide5, Alternative, King);
                }
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        public void SideL(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative, bool King)
        {
            //Side logic Left
            Calculation = int.Parse(Math.Substring(1, 1));
            GetFString();
            Result = SString + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                Math = Math1;
                return;
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                Alternation(Alternative);
                MovementD(OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
                if (MovementCheck == false)
                {
                    Math = Math1;
                    return;
                }
                if (King == false)
                {
                    SideL(Side, Side1, Side2, Side3, Side4, Side5, OSide, OSide1, OSide2, OSide3, OSide4, OSide5, Alternative, King);
                }
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
            
        }
        //Knigth movement
        public void KnigthDownUp(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, bool Alternative)
        {
            //Down and Up knight logic
            Math = Math1;
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            GetFString();
            Result = FString + Calculation.ToString();
            Math = Math1;
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                Result = "Empty";
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                Alternation(Alternative);
            }
            Math = Math1;
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            GetFString();
            Result = SString + Calculation.ToString();
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                Result = "Empty";
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                Alternation(Alternative);
            }
            Math = Math1;
        }
        public void KnigthSideRigth(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, Func<int, int> op1, bool Alternative)
        {
            //Knigth rigth side movement logic
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            GetFString();
            Math = FString;
            GetFString();
            Result = FString + Calculation.ToString();
            Math = Math1;
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                Result = "Empty";
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                Alternation(Alternative);
            }
            Math = Math1;
            FString = Math.Substring(0,1);
            GetFString();
            Math = FString;
            GetFString();
            Math = Math1;
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op1(Calculation);
            Result = FString + Calculation.ToString();
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                Result = "Empty";
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                Alternation(Alternative);
            }
            Math = Math1;
        }
        public void KnigthSideLeft(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, Func<int, int> op1, bool Alternative)
        {
            //Knigth left side movement logic
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            GetFString();
            Math = SString;
            GetFString();
            Result = SString + Calculation.ToString();
            Math = Math1;
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                Result = "Empty";
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                Alternation(Alternative);
            }
            Math = Math1;
            FString = Math.Substring(0, 1);
            GetFString();
            Math = SString;
            GetFString();
            Math = Math1;
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op1(Calculation);
            Result = SString + Calculation.ToString();
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                Result = "Empty";
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                Alternation(Alternative);
            }
            Math = Math1;
        }
        //Diagonal movement
        public void DownRigthLeft(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative, bool King)
        {
            //Down rigth and left movement logic
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            GetFString();
            Result = FString + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                Math = Math1;
                return;
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                Alternation(Alternative);
                MovementD(OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
                if (MovementCheck == false)
                {
                    Math = Math1;
                    return;
                }
                if (King == false)
                {
                    DownRigthLeft(Side, Side1, Side2, Side3, Side4, Side5, op, OSide, OSide1, OSide2, OSide3, OSide4, OSide5, Alternative, King);
                }
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        public void UpRigthLeft(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative, bool King)
        {
            //Up rigth and left movement logic
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            GetFString();
            Result = SString + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                Math = Math1;
                return;
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                Alternation(Alternative);
                MovementD(OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
                if (MovementCheck == false)
                {
                    Math = Math1;
                    return;
                }
                if (King == false)
                {
                    UpRigthLeft(Side, Side1, Side2, Side3, Side4, Side5, op, OSide, OSide1, OSide2, OSide3, OSide4, OSide5, Alternative, King);
                }
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        //Rook movement
        public void RookEat(string Troop, string Troop1, string Troop2, string Troop3, string Troop4, string Troop5, Func<int, int> op, bool Alternative)
        {
            //Checking if you can eat rigth
            Math = Math1;
            GetFString();
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            Result = FString + Calculation.ToString();

            OutOfBounds();
            if (OutOfBoundsCheck == false)
            {
                if (this.Controls[Result].Tag != null)
                {
                    MovementD(Troop, Troop1, Troop2, Troop3, Troop4, Troop5);
                    if (MovementCheck == true)
                    {
                        Alternation(Alternative);
                    }
                }
            }

            //Checking if you can eat Left
            Math = Math1;
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            Result = SString + Calculation.ToString();

            OutOfBounds();
            if (OutOfBoundsCheck == false)
            {
                if (this.Controls[Result].Tag != null)
                {
                    MovementD(Troop, Troop1, Troop2, Troop3, Troop4, Troop5);
                    if (MovementCheck == true)
                    {
                        Alternation(Alternative);
                    }
                }
            }                                                                                     
        }
        public void RookMove(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, string Side6, string Side7, Func<int, int> op, string Pass, string Pass1, string Pass2, string Pass3, string Pass4, string Pass5, string Pass6, string Pass7, string Troop, string Troop1, string Troop2, string Troop3, string Troop4, string Troop5, string Troop6, bool Alternative)
        {
            //Checking if starting first square
            if ((Move1 == Side) || (Move1 == Side1) || (Move1 == Side2) || (Move1 == Side3) || (Move1 == Side4) || (Move1 == Side5) || (Move1 == Side6) || (Move1 == Side7))
            {
                Calculation = int.Parse(Math.Substring(1, 1));
                Calculation = op(Calculation);
                Result = Math.Substring(0, 1) + Calculation.ToString();

                if (this.Controls[Result].Tag == null)
                {
                    Alternation(Alternative);
                    Calculation = op(Calculation);
                    Result = Math.Substring(0, 1) + Calculation.ToString();

                    if (this.Controls[Result].Tag == null)
                    {
                        Alternation(Alternative);
                    }
                }
                RookEat(Troop, Troop1, Troop2, Troop3, Troop4, Troop5, op, Alternative);
            }
            //Normal rook movement
            else
            {
                Math = Math1;
                Calculation = int.Parse(Math.Substring(1, 1));
                Calculation = op(Calculation);
                Result = Math.Substring(0, 1) + Calculation.ToString();
                OutOfBounds();
                if (OutOfBoundsCheck == false)
                {
                    if (this.Controls[Result].Tag == null)
                    {
                        Alternation(Alternative);
                    }
                }

                RookEat(Troop, Troop1, Troop2, Troop3, Troop4, Troop5, op, Alternative);

                //Checking if EnPassant has been used
                if (EnPassantC == true)
                {
                    //En passant logic
                    if ((Move1 == Pass) || (Move1 == Pass1) || (Move1 == Pass2) || (Move1 == Pass3) || (Move1 == Pass4) || (Move1 == Pass5) || (Move1 == Pass6) || (Move1 == Pass7))
                    {
                        //Checking En passant rigth
                        Math = Math1;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        GetFString();
                        Result = SString + Calculation.ToString();

                        OutOfBounds();
                        if (OutOfBoundsCheck == false)
                        {
                            if (this.Controls[Result].Tag != null)
                            {
                                if (this.Controls[Result].Tag == this.Controls[Troop6].Tag)
                                {
                                    Calculation = op(Calculation);
                                    Result = SString + Calculation.ToString();
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Alternation(Alternative);
                                    EnPassant = true;
                                }
                            }
                        }

                        //Checking En passant left
                        Math = Math1;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        GetFString();
                        Result = FString + Calculation.ToString();

                        OutOfBounds();
                        if (OutOfBoundsCheck == false)
                        {
                            if (this.Controls[Result].Tag != null)
                            {
                                if (this.Controls[Result].Tag == this.Controls[Troop6].Tag)
                                {
                                    Calculation = op(Calculation);
                                    Result = FString + Calculation.ToString();
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Alternation(Alternative);
                                    EnPassant = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        public void PassantCheck(Func<int, int> op)
        {

            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            Result = Math.Substring(0, 1) + Calculation.ToString();
            MessageBox.Show(Result);
            this.Controls[Result].Tag = null;
            PictureBox Conversion = (PictureBox)this.Controls[Result];
            Conversion.Image = null;
        }
        //Castling
        public void Castling(bool King, bool KRook, bool QRook)
        {
                    if (KRook == true || King == true)
                    {
                        if (this.Controls[Result] == A1 || this.Controls[Result] == B1 || this.Controls[Result] == C1 || this.Controls[Result] == D1 || this.Controls[Result] == E1 || this.Controls[Result] == F1 || this.Controls[Result] == G1 || this.Controls[Result] == H1)
                        {
                            if (this.Controls["G1"].Tag == null)
                            {
                                if (this.Controls["G1"].BackColor != Color.LightGreen)
                                {
                                    if (this.Controls["F1"].Tag == null)
                                    {
                                        if (this.Controls["F1"].BackColor != Color.LightGreen)
                                        {
                                            this.Controls["G1"].BackColor = Color.LightGreen;
                                            this.Controls["F1"].BackColor = Color.LightGreen;
                                            Towering = true;
                                        }
                                    }
                                }
                            }
                        }
                        else if (this.Controls[Result] == A8 || this.Controls[Result] == B8 || this.Controls[Result] == C8 || this.Controls[Result] == D8 || this.Controls[Result] == E8 || this.Controls[Result] == F8 || this.Controls[Result] == G8 || this.Controls[Result] == H8)
                        {
                            if (this.Controls["G8"].Tag == null)
                            {
                                if (this.Controls["G8"].BackColor != Color.LightGreen)
                                {
                                    if (this.Controls["F8"].Tag == null)
                                    {
                                        if (this.Controls["F8"].BackColor != Color.LightGreen)
                                        {
                                            this.Controls["G8"].BackColor = Color.LightGreen;
                                            this.Controls["F8"].BackColor = Color.LightGreen;
                                            Towering = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (QRook == true || King == true)
                    {
                        if (this.Controls[Result] == A1 || this.Controls[Result] == B1 || this.Controls[Result] == C1 || this.Controls[Result] == D1 || this.Controls[Result] == E1 || this.Controls[Result] == F1 || this.Controls[Result] == G1 || this.Controls[Result] == H1)
                        {
                            if (this.Controls["B1"].Tag == null)
                            {
                                if (this.Controls["B1"].BackColor != Color.LightGreen)
                                {
                                    if (this.Controls["C1"].Tag == null)
                                    {
                                        if (this.Controls["C1"].BackColor != Color.LightGreen)
                                        {
                                            if (this.Controls["D1"].Tag == null)
                                            {
                                                if (this.Controls["D1"].BackColor != Color.LightGreen)
                                                {
                                                    this.Controls["B1"].BackColor = Color.LightGreen;
                                                    this.Controls["C1"].BackColor = Color.LightGreen;
                                                    this.Controls["D1"].BackColor = Color.LightGreen;
                                                    Towering = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (this.Controls[Result] == A8 || this.Controls[Result] == B8 || this.Controls[Result] == C8 || this.Controls[Result] == D8 || this.Controls[Result] == E8 || this.Controls[Result] == F8 || this.Controls[Result] == G8 || this.Controls[Result] == H8)
                        {
                            if (this.Controls["B8"].Tag == null)
                            {
                                if (this.Controls["B8"].BackColor != Color.LightGreen)
                                {
                                    if (this.Controls["C8"].Tag == null)
                                    {
                                        if (this.Controls["C8"].BackColor != Color.LightGreen)
                                        {
                                            if (this.Controls["D8"].Tag == null)
                                            {
                                                if (this.Controls["D8"].BackColor != Color.LightGreen)
                                                {
                                                    this.Controls["B8"].BackColor = Color.LightGreen;
                                                    this.Controls["C8"].BackColor = Color.LightGreen;
                                                    this.Controls["D8"].BackColor = Color.LightGreen;
                                                    Towering = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    Towering = true;
                }
        }
        #endregion

        #region Final Movement
        //Rook movement
        public void RookFullMovement(bool White, PictureBox sender, bool Normal, bool Alternative)
        {
            if (White == true)
            {
                Indicator = "W";
                Indicator1 = "White";
                Indicator2 = "B";
                NumberIndicator = "7";
                NumberIndicator1 = "4";
                NumberIndicator2 = - 1;
            }
            else if (White == false)
            {
                Indicator = "B";
                Indicator1 = "Black";
                Indicator2 = "W";
                NumberIndicator = "2";
                NumberIndicator1 = "5";
                NumberIndicator2 = + 1;
            }
            if (PCache.Tag == this.Controls[Indicator + "Rook"].Tag)
            {
                Unit = Indicator1 + " rook";

                //RookMove
                RookMove("A" +NumberIndicator, "B" + NumberIndicator, "C" + NumberIndicator, "D" + NumberIndicator, "E" + NumberIndicator, "F" + NumberIndicator, "G" + NumberIndicator, "H" + NumberIndicator, x => x +NumberIndicator2, "A" + NumberIndicator1, "B" + NumberIndicator1, "C" + NumberIndicator1, "D" + NumberIndicator1, "E" + NumberIndicator1, "F" + NumberIndicator1, "G" + NumberIndicator1, "H" + NumberIndicator1, Indicator+"Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", Indicator2+"Rook", Alternative);
                if (Normal == true)
                {
                    sender.BackColor = Color.Green;
                }
            }
        }
        //Knight movement 
        public void KnightFullMovement(bool White, PictureBox sender, bool Normal, bool Alternative)
        {
            if (White == true)
            {
                Indicator = "W";
                Indicator1 = "White";
            }
            else if (White == false)
            {
                Indicator = "B";
                Indicator1 = "Black";
            }
            if (PCache.Tag == this.Controls[Indicator+ "knigth"].Tag)
            {
                Unit =  Indicator1 +" knigth";

                //Down knight logic
                KnigthDownUp(Indicator+"Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x + 2, Alternative);
                //Up knight logic
                KnigthDownUp(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x - 2, Alternative);
                //Side knight logic
                KnigthSideRigth(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x + 1, x => x - 1, Alternative);
                //Side knight logic
                KnigthSideLeft(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x - 1, x => x + 1, Alternative);
                if (Normal == true)
                {
                    sender.BackColor = Color.Green;
                }
            }
        }
        //Tower movement
        public void TowerFullMovement(bool White, PictureBox sender, bool Normal, bool Alternative)
        {
            if (White == true)
            {
                Indicator = "W";
                Indicator1 = "White";
                Indicator2 = "B";
                NumberIndicator = "8";
            }
            else if (White == false)
            {
                Indicator = "B";
                Indicator1 = "Black";
                Indicator2 = "W";
                NumberIndicator = "1";
            }

            if (PCache.Tag == this.Controls[Indicator + "Tower"].Tag)
            {
                Unit =  Indicator1+" tower";


                if (sender == this.Controls["A" + Indicator])
                {
                    Castling(false, false, true);
                }
                else if (sender == this.Controls["H" + Indicator])
                {
                    Castling(false, true, false);
                }
                //Down move logic
                DownUp(Indicator+"Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x - 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", Alternative, false);
                //Up move logic
                DownUp(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x + 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", Alternative, false);
                //Side logic rigth
                SideR(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", Alternative, false);
                //Side logic left
                SideL(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", Alternative, false);

                if (Normal == true)
                {
                    sender.BackColor = Color.Green;
                }
            }
        }
        //Bishop movement
        public void BishopFullMovement(bool White, PictureBox sender, bool Normal, bool Alternative)
        {
            if (White == true)
            {
                Indicator = "W";
                Indicator1 = "White";
                Indicator2 = "B";
            }
            else if (White == false)
            {
                Indicator = "B";
                Indicator1 = "Black";
                Indicator2 = "W";
            }
            if (PCache.Tag == this.Controls[Indicator + "Bishop"].Tag)
            {
                Unit =  Indicator1 + "bishop";

                //Down rigth movement logic
                DownRigthLeft(Indicator+"Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x + 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 +"King", Alternative, false);
                //Down left movement logic
                DownRigthLeft(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x - 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", Alternative, false);
                //Up rigth movement logic
                UpRigthLeft(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x + 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", Alternative, false);
                //up left movement logic
                UpRigthLeft(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => - 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", Alternative, false);
                if (Normal == true)
                {
                    sender.BackColor = Color.Green;
                }
            }
        }
        //King movement
        public void KingFullMovement(bool White, PictureBox sender, bool Normal, bool Alternative)
        {
            if (White == true)
            {
                Indicator = "W";
                Indicator1 = "White";
                Indicator2 = "B";
            }
            else if (White == false)
            {
                Indicator = "B";
                Indicator1 = "Black";
                Indicator2 = "W";
            }

            if (PCache.Tag == this.Controls[Indicator + "King"].Tag)
            {
                Unit = Indicator1+"king";

                Castling(true, false, false);
                //Down move logic
                DownUp( Indicator+"Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x - 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, true);
                //Up move logic
                DownUp(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x  + 1,  Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, true);
                //Side logic rigth
                SideR(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, true);
                //Side logic left
                SideL(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, true);
                //Down rigth movement logic
                DownRigthLeft(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x + 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, true);
                //Down left movement logic
                DownRigthLeft(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x - 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, true);
                //Up rigth movement logic
                UpRigthLeft(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x + 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, true);
                //up left movement logic
                UpRigthLeft(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x - 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, true);
                if (Normal == true)
                {
                    sender.BackColor = Color.Green;
                }
            }
        }
        //Queen movement
        public void QueenFullMovement(bool White, PictureBox sender, bool Normal, bool Alternative)
        {
            if (White == true)
            {
                Indicator = "W";
                Indicator1 = "White";
                Indicator2 = "B";
            }
            else if (White == false)
            {
                Indicator = "B";
                Indicator1 = "Black";
                Indicator2 = "W";
            }

            if (PCache.Tag == this.Controls[Indicator + "Queen"].Tag)
            {
                Unit =  Indicator1 + "queen";

                //Down move logic
                DownUp(Indicator+"Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x - 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, false);
                //Up move logic
                DownUp(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x + 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, false);
                //Side rigth logic 
                SideR(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, false);
                //Side left logic 
                SideL(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, false);
                //Down rigth movement logic
                DownRigthLeft(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x + 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, false);
                //Down left movement logic
                DownRigthLeft(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x - 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, false);
                //Up rigth movement logic
                UpRigthLeft(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x + 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, false);
                //up left movement logic
                UpRigthLeft(Indicator + "Knigth", Indicator + "Queen", Indicator + "Tower", Indicator + "Rook", Indicator + "Bishop", Indicator + "King", x => x - 1, Indicator2 + "Knigth", Indicator2 + "Queen", Indicator2 + "Tower", Indicator2 + "Rook", Indicator2 + "Bishop", Indicator2 + "King", false, false);
                if (Normal == true)
                {
                    sender.BackColor = Color.Green;
                }
            }
        }
        #endregion
        #endregion

        //Making picture boxes do stuff
        public void ChessClick(object sender, EventArgs e)
            {
            //Checking if the tile has a piece on it
            //If it doesnt OutOfBounds();
            if ((sender as PictureBox).BackColor == Color.LightGreen || (sender as PictureBox).BackColor == Color.Green)
            {
                //Checking if a piece containing tile has been clicked
                if (Move1 == null)
                {

                }
                else
                {
                    //Checking if rook for EnPassant
                    if (PCache.Tag == BRook.Tag || PCache.Tag == WRook.Tag)
                    {
                        if (EnPassant == true)
                        {
                            Math = (sender as PictureBox).Name;
                            if (PCache.Tag == BRook.Tag)
                            {
                                PassantCheck(x => x - 1);
                            }
                            else if (PCache.Tag == WRook.Tag)
                            {
                                PassantCheck(x => x + 1);
                            }
                        }
                    }
                    //Checking if king for tracking
                    if (PCache.Tag == BKing.Tag)
                    {
                        BKingL = (sender as PictureBox).Name;
                    }
                    if (PCache.Tag == WKing.Tag)
                    {
                        WKingL = (sender as PictureBox).Name;
                    }
                    //Resetting and setting values for movement
                    (sender as PictureBox).Image = PCache.Image;
                    (sender as PictureBox).Tag = PCache.Tag;
                    CheckingN = (sender as PictureBox).Name;
                    PCache.Image = null;
                    PCache.Tag = null;
                    Math = "A1";
                    Calculation = int.Parse(Math.Substring(1, 1));
                    FString = "A";
                    //Disabling EnPassant
                    if (EnPassant == true)
                    {
                        EnPassant = false;
                        EnPassantC = false;
                    }
                    //Towering
                    if (Towering == true)
                    {
                        //Black Queen side towering
                        if ((sender as PictureBox) == A1 || (sender as PictureBox) == E1)
                        {
                            if (D1.BackColor != Color.LightGreen)
                            {
                                if (C1.BackColor != Color.LightGreen)
                                {
                                    if (B1.BackColor != Color.LightGreen)
                                    {
                                        //BKing movement things
                                        C1.Image = E1.Image;
                                        C1.Tag = E1.Tag;
                                        BKingL = "C1";

                                        //BTower
                                        D1.Image = A1.Image;
                                        D1.Tag = A1.Tag;
                                    }
                                }
                            }
                        }
                        //White Queen side towering
                        else if ((sender as PictureBox) == A8 || (sender as PictureBox) == E8)
                        {
                            if (D8.BackColor != Color.LightGreen)
                            {
                                if (C8.BackColor != Color.LightGreen)
                                {
                                    if (B8.BackColor != Color.LightGreen)
                                    {
                                        //WKing movement things
                                        C8.Image = E8.Image;
                                        C8.Tag = E8.Tag;
                                        WKingL = "C8";

                                        //WTower
                                        D8.Image = A8.Image;
                                        D8.Tag = A8.Tag;
                                    }
                                }
                            }
                        }
                        //White King side towering
                        else if ((sender as PictureBox) == H8 || (sender as PictureBox) == E8)
                        {
                            if (F8.BackColor != Color.LightGreen)
                            {
                                if (G8.BackColor != Color.LightGreen)
                                {
                                    //WKing movement things
                                    G8.Image = E8.Image;
                                    G8.Tag = E8.Tag;
                                    WKingL = "G8";

                                    //WTower
                                    F8.Image = A8.Image;
                                    F8.Tag = A8.Tag;
                                }
                            }
                        }
                        //Black King side towering
                        else if ((sender as PictureBox) == H1 || (sender as PictureBox) == E1)
                        {
                            if (F1.BackColor != Color.LightGreen)
                            {
                                if (G1.BackColor != Color.LightGreen)
                                {
                                    //WKing movement things
                                    G1.Image = E1.Image;
                                    G1.Tag = E1.Tag;
                                    BKingL = "G1";

                                    //WTower
                                    F1.Image = A1.Image;
                                    F1.Tag = A1.Tag;
                                }
                            }
                        }
                    }

                    Towering = false;

                    //Checking if troop moved (Troop moved)
                    if ((sender as PictureBox).BackColor == Color.LightGreen)
                    {
                        IsGreen = false;
                    }
                    //Checking if troop moved (Troop didn´t move)
                    else if ((sender as PictureBox).BackColor == Color.Green)
                    {
                        IsGreen = true;
                    }

                    CheckCheck((sender as PictureBox));
                    CheckMate((sender as PictureBox));

                    Move1 = null;

                    //Checking if troop moved (Troop moved)
                    if (IsGreen == false)
                    {
                        Math = (sender as PictureBox).Name;
                        Calculation = Calculation = int.Parse(Math.Substring(1, 1));
                        GetFString();
                        if (Turn == 1)
                        {
                            Turn = 2;
                            Lock("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                            Lock("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            TurnLabel.Text = "Black turn";
                        }
                        else if (Turn == 2)
                        {
                            Turn = 1;
                            Lock("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                            Lock("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            TurnLabel.Text = "White turn";
                        }
                    }
                    //Checking if troop moved (Troop didn´t move)
                    else if (IsGreen == true)
                    {
                        if (Turn == 1)
                        {
                            Lock("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        }
                        else if (Turn == 2)
                        {
                            Lock("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
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
                    (sender as PictureBox).Tag = null;

                    //Calculation settup
                    Math = (sender as PictureBox).Name;
                    Math1 = (sender as PictureBox).Name;

                    #region legal rook moves
                    //White
                    RookFullMovement(true, (sender as PictureBox), true, false);
                    //Black
                    RookFullMovement(false, (sender as PictureBox), true, false);
                    #endregion

                    #region Knigth logic
                    //WHite
                    KnightFullMovement(true, (sender as PictureBox), true, false);
                    //Black
                    KnightFullMovement(false, (sender as PictureBox), true, false);
                    #endregion

                    #region Tower move logic
                    //White
                    TowerFullMovement(true, (sender as PictureBox), true, false);
                    //Black
                    TowerFullMovement(false, (sender as PictureBox), true, false);
                    #endregion

                    #region Bishop move logic
                    //White
                    BishopFullMovement(true, (sender as PictureBox), true, false);
                    //Black
                    BishopFullMovement(false, (sender as PictureBox), true, false);
                    #endregion

                    #region King move logic
                    //White
                    KingFullMovement(true, (sender as PictureBox), true, false);
                    //Black
                    KingFullMovement(false, (sender as PictureBox), true, false);
                    //King tracking
                    if (PCache.Tag == "WKing")
                    {
                        WKingL = Move1;
                    }
                    else if (PCache.Tag == "BKing")
                    {
                        BKingL = Move1;
                    }
                    #endregion

                    #region Queen move logic
                    //White
                    QueenFullMovement(true, (sender as PictureBox), true, false);
                    //Black
                    QueenFullMovement(false, (sender as PictureBox), true, false);
                    #endregion

                    Selected.Text = "Selected slot: " + Move1 + " Selected Unit: " + Unit;
                    if (Turn == 1)
                    {
                        Lock("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                    }
                    else if (Turn == 2)
                    {
                        Lock("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                    }
                }
            }
        }
    }
    }