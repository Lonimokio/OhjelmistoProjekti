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

        //Variable below here
        string Move1;
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

        int Calculation = 1;
        int Calculation1 = 1;
        int Calculation2 = 1;
        int color = 1;
        int counter = 1;
        int Turn = 1;

        bool Checking = false;
        bool CheckW = false;
        bool CheckB = false;
        bool EnPassant;
        bool EnPassantC = true;
        bool Towering;
        bool MovementCheck = true;
        bool OutOfBoundsCheck = false;
        bool IsGreen;

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

        //Methods
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
            MovementCheck = true;
            if (this.Controls[Result].Tag == this.Controls[Troop].Tag)
            {
                //MessageBox.Show("Im Here " + Troop + " " + Result);
                MovementCheck = false;
            }
            if (this.Controls[Result].Tag == this.Controls[Troop1].Tag)
            {
                //MessageBox.Show("Im Here " + Troop1 + " " + Result);
                MovementCheck = false;
            }
            if (this.Controls[Result].Tag == this.Controls[Troop2].Tag)
            {
                //MessageBox.Show("Im Here " + Troop2 + " " + Result);
                MovementCheck = false;
            }
            if (this.Controls[Result].Tag == this.Controls[Troop3].Tag)
            {
                //MessageBox.Show("Im Here " + Troop3 + " " + Result);
                MovementCheck = false;
            }
            if (this.Controls[Result].Tag == this.Controls[Troop4].Tag)
            {
                //MessageBox.Show("Im Here " + Troop4 + " " + Result);
                MovementCheck = false;
            }
            if (this.Controls[Result].Tag == this.Controls[Troop5].Tag)
            {
                //MessageBox.Show("Im Here " + Troop5 + " " + Result);
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
        public void CheckCheck()
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
                    //Checking legal white rook moves
                    if (PCache.Tag == WRook.Tag)
                    {
                        Unit = "White rook";

                        //RookMove
                        RookMove("A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7", x => x - 1, "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BRook", false);
                    }
                    //Checking legal black rook moves
                    if (PCache.Tag == BRook.Tag)
                    {
                        Unit = "Black rook";

                        //RookMove
                        RookMove("A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2", x => x + 1, "A5", "B5", "C5", "D5", "E5", "F5", "G5", "H5", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WRook", false);
                    }
                    //White knigth logic
                    else if (PCache.Tag == WKnigth.Tag)
                    {
                        Unit = "White knigth";

                        //Down knight logic
                        KnigthDownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 2, false);
                        //Up knight logic
                        KnigthDownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 2, false);
                        //Side knight logic
                        KnigthSideRigth("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, x => x - 1, false);
                        //Side knight logic
                        KnigthSideLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, x => x + 1, false);
                    }
                    //Black knigth logic
                    else if (PCache.Tag == BKnigth.Tag)
                    {
                        Unit = "Black knigth";

                        //Down knight logic
                        KnigthDownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 2, false);
                        //Up knight logic
                        KnigthDownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 2, false);
                        //Side knight logic
                        KnigthSideRigth("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, x => x - 1, false);
                        //Side logic
                        KnigthSideLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, x => x + 1, false);
                    }
                    //White tower move logic
                    else if (PCache.Tag == WTower.Tag)
                    {
                        Unit = "White tower";

                        //Down move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side logic rigth
                        SideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side logic left
                        SideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                    }
                    //Black tower move logic
                    else if (PCache.Tag == BTower.Tag)
                    {
                        Unit = "Black tower";

                        //Down move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side logic rigth
                        SideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side logic left
                        SideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                    }
                    //White bishop move logic
                    else if (PCache.Tag == WBishop.Tag)
                    {
                        Unit = "White bishop";

                        //Down rigth movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down left movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up rigth movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //up left movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                    }
                    //Black bishop move logic
                    else if (PCache.Tag == BBishop.Tag)
                    {
                        Unit = "Black bishop";

                        //Down rigth movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down left movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up rigth movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //up left movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                    }
                    //White king move logic
                    else if (PCache.Tag == WKing.Tag)
                    {
                        Unit = "White king";

                        //Down move logic
                        KDown("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up move logic
                        KDown("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side logic rigth
                        KSideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side logic left
                        KSideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down rigth movement logic
                        KDownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down left movement logic
                        KDownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up rigth movement logic
                        KUpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //up left movement logic
                        KUpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                    }
                    //Black king move logic
                    else if (PCache.Tag == BKing.Tag)
                    {
                        Unit = "Black king";

                        //Down move logic
                        KDown("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up move logic
                        KDown("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side logic rigth
                        KSideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side logic left
                        KSideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down rigth movement logic
                        KDownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down left movement logic
                        KDownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up rigth movement logic
                        KUpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //up left movement logic
                        KUpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                    }
                    //White queen move logic
                    else if (PCache.Tag == WQueen.Tag)
                    {
                        Unit = "White queen";

                        //Down move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side rigth logic 
                        SideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side left logic 
                        SideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down rigth movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down left movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up rigth movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //up left movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                    }
                    //Black queen move logic
                    else if (PCache.Tag == BQueen.Tag)
                    {
                        Unit = "Black queen";

                        //Down move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side rigth logic 
                        SideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side left logic 
                        SideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down rigth movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down left movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up rigth movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //up left movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
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
            MessageBox.Show("Progress");

            //Checking if king has been in check
            if (CheckB == true)
            {
                Checking = true; 
            }
            else if(CheckW == true)
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
                    Check.Visible = true;
                    CheckW = true;
                    Colour.Text = "White";
                    Colour.Visible = true;
                }
            }
            //Checking if black king is not in check
            else if (this.Controls[BKingL].BackColor != Color.LightGreen)
            {
                Check.Visible = false;
                CheckB = false;
                Colour.Visible = false;
                Checking = false;
            }
            //Checking if white king is not in check
            else if (this.Controls[WKingL].BackColor != Color.LightGreen)
            {
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
        //Checkmate system
        public void CheckMate()
        {
            MessageBox.Show("Test");
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
                    if (Turn == 2)
                    {
                        //Checking legal white rook moves
                        if (PCache.Tag == WRook.Tag)
                        {
                            Unit = "White rook";

                            //RookMove
                            RookMove("A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7", x => x - 1, "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BRook", true);
                        }
                        //White knigth logic
                        else if (PCache.Tag == WKnigth.Tag)
                        {
                            Unit = "White knigth";

                            //Down knight logic
                            KnigthDownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 2, true);
                            //Up knight logic
                            KnigthDownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 2, true);
                            //Side knight logic
                            KnigthSideRigth("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, x => x - 1, true);
                            //Side knight logic
                            KnigthSideLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, x => x + 1, true);
                        }
                        //White tower move logic
                        else if (PCache.Tag == WTower.Tag)
                        {
                            Unit = "White tower";

                            //Down move logic
                            DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Up move logic
                            DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Side logic rigth
                            SideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Side logic left
                            SideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                        }
                        //White bishop move logic
                        else if (PCache.Tag == WBishop.Tag)
                        {
                            Unit = "White bishop";

                            //Down rigth movement logic
                            DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Down left movement logic
                            DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Up rigth movement logic
                            UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //up left movement logic
                            UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                        }
                        //White king move logic
                        else if (PCache.Tag == WKing.Tag)
                        {
                            Unit = "White king";

                            //Down move logic
                            KDown("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Up move logic
                            KDown("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Side logic rigth
                            KSideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Side logic left
                            KSideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Down rigth movement logic
                            KDownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Down left movement logic
                            KDownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Up rigth movement logic
                            KUpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //up left movement logic
                            KUpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                        }
                        //White queen move logic
                        else if (PCache.Tag == WQueen.Tag)
                        {
                            Unit = "White queen";

                            //Down move logic
                            DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Up move logic
                            DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Side rigth logic 
                            SideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Side left logic 
                            SideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Down rigth movement logic
                            DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Down left movement logic
                            DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //Up rigth movement logic
                            UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                            //up left movement logic
                            UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", true);
                        }
                    }
                    else if (Turn == 1)
                    {
                        //Checking legal black rook moves
                        if (PCache.Tag == BRook.Tag)
                        {
                            Unit = "Black rook";

                            //RookMove
                            RookMove("A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2", x => x + 1, "A5", "B5", "C5", "D5", "E5", "F5", "G5", "H5", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WRook", true);
                        }
                        //Black knigth logic
                        else if (PCache.Tag == BKnigth.Tag)
                        {
                            Unit = "Black knigth";

                            //Down knight logic
                            KnigthDownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 2, true);
                            //Up knight logic
                            KnigthDownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 2, true);
                            //Side knight logic
                            KnigthSideRigth("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, x => x - 1, true);
                            //Side logic
                            KnigthSideLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, x => x + 1, true);
                        }
                        //Black tower move logic
                        else if (PCache.Tag == BTower.Tag)
                        {
                            Unit = "Black tower";

                            //Down move logic
                            DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Up move logic
                            DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Side logic rigth
                            SideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Side logic left
                            SideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                        }
                        //Black bishop move logic
                        else if (PCache.Tag == BBishop.Tag)
                        {
                            Unit = "Black bishop";

                            //Down rigth movement logic
                            DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Down left movement logic
                            DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Up rigth movement logic
                            UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //up left movement logic
                            UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                        }
                        //Black king move logic
                        else if (PCache.Tag == BKing.Tag)
                        {
                            Unit = "Black king";

                            //Down move logic
                            KDown("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Up move logic
                            KDown("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Side logic rigth
                            KSideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Side logic left
                            KSideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Down rigth movement logic
                            KDownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Down left movement logic
                            KDownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Up rigth movement logic
                            KUpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //up left movement logic
                            KUpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                        }
                        //Black queen move logic
                        else if (PCache.Tag == BQueen.Tag)
                        {
                            Unit = "Black queen";

                            //Down move logic
                            DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Up move logic
                            DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Side rigth logic 
                            SideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Side left logic 
                            SideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Down rigth movement logic
                            DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Down left movement logic
                            DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //Up rigth movement logic
                            UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                            //up left movement logic
                            UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", true);
                        }
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
                    //Checking legal white rook moves
                    if (PCache.Tag == WRook.Tag)
                    {
                        Unit = "White rook";

                        //RookMove
                        RookMove("A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7", x => x - 1, "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BRook", false);
                    }
                    //Checking legal black rook moves
                    if (PCache.Tag == BRook.Tag)
                    {
                        Unit = "Black rook";

                        //RookMove
                        RookMove("A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2", x => x + 1, "A5", "B5", "C5", "D5", "E5", "F5", "G5", "H5", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WRook", false);
                    }
                    //White knigth logic
                    else if (PCache.Tag == WKnigth.Tag)
                    {
                        Unit = "White knigth";

                        //Down knight logic
                        KnigthDownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 2, false);
                        //Up knight logic
                        KnigthDownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 2, false);
                        //Side knight logic
                        KnigthSideRigth("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, x => x - 1, false);
                        //Side knight logic
                        KnigthSideLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, x => x + 1, false);
                    }
                    //Black knigth logic
                    else if (PCache.Tag == BKnigth.Tag)
                    {
                        Unit = "Black knigth";

                        //Down knight logic
                        KnigthDownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 2, false);
                        //Up knight logic
                        KnigthDownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 2, false);
                        //Side knight logic
                        KnigthSideRigth("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, x => x - 1, false);
                        //Side logic
                        KnigthSideLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, x => x + 1, false);
                    }
                    //White tower move logic
                    else if (PCache.Tag == WTower.Tag)
                    {
                        Unit = "White tower";

                        //Down move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side logic rigth
                        SideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side logic left
                        SideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                    }
                    //Black tower move logic
                    else if (PCache.Tag == BTower.Tag)
                    {
                        Unit = "Black tower";

                        //Down move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side logic rigth
                        SideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side logic left
                        SideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                    }
                    //White bishop move logic
                    else if (PCache.Tag == WBishop.Tag)
                    {
                        Unit = "White bishop";

                        //Down rigth movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down left movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up rigth movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //up left movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                    }
                    //Black bishop move logic
                    else if (PCache.Tag == BBishop.Tag)
                    {
                        Unit = "Black bishop";

                        //Down rigth movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down left movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up rigth movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //up left movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                    }
                    //White king move logic
                    else if (PCache.Tag == WKing.Tag)
                    {
                        Unit = "White king";

                        //Down move logic
                        KDown("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up move logic
                        KDown("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side logic rigth
                        KSideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side logic left
                        KSideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down rigth movement logic
                        KDownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down left movement logic
                        KDownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up rigth movement logic
                        KUpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //up left movement logic
                        KUpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                    }
                    //Black king move logic
                    else if (PCache.Tag == BKing.Tag)
                    {
                        Unit = "Black king";

                        //Down move logic
                        KDown("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up move logic
                        KDown("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side logic rigth
                        KSideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side logic left
                        KSideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down rigth movement logic
                        KDownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down left movement logic
                        KDownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up rigth movement logic
                        KUpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //up left movement logic
                        KUpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                    }
                    //White queen move logic
                    else if (PCache.Tag == WQueen.Tag)
                    {
                        Unit = "White queen";

                        //Down move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side rigth logic 
                        SideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side left logic 
                        SideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down rigth movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down left movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up rigth movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //up left movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                    }
                    //Black queen move logic
                    else if (PCache.Tag == BQueen.Tag)
                    {
                        Unit = "Black queen";

                        //Down move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side rigth logic 
                        SideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side left logic 
                        SideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down rigth movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down left movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up rigth movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //up left movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
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

            MessageBox.Show("Progress checkmate");
            //Checking if black king is in check
            if (this.Controls[BKingL].BackColor == Color.LightGreen)
            {
                if (Check.Visible == true)
                {
                    Mate.Visible = true;
                }
            }
            //Checking if white king is in check
            else if (this.Controls[WKingL].BackColor == Color.LightGreen)
            {
                if (Check.Visible == true)
                {
                    Mate.Visible = true;
                }
            }
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
            }
        }

        //Movement logic as methods
        //Straigth movement
        public void DownUp(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative)
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
                DownUp(Side, Side1, Side2, Side3, Side4, Side5, op, OSide, OSide1, OSide2, OSide3, OSide4, OSide5, Alternative);
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        public void SideR(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative)
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
                SideR(Side, Side1, Side2, Side3, Side4, Side5, OSide, OSide1, OSide2, OSide3, OSide4, OSide5, Alternative);
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        public void SideL(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative)
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
                SideL(Side, Side1, Side2, Side3, Side4, Side5, OSide, OSide1, OSide2, OSide3, OSide4, OSide5, Alternative);
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
        public void DownRigthLeft(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative)
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
                DownRigthLeft(Side, Side1, Side2, Side3, Side4, Side5, op, OSide, OSide1, OSide2, OSide3, OSide4, OSide5, Alternative);
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        public void UpRigthLeft(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative)
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
                UpRigthLeft(Side, Side1, Side2, Side3, Side4, Side5, op, OSide, OSide1, OSide2, OSide3, OSide4, OSide5, Alternative);
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        //King movement
        public void KDown(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative)
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
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
            Math = Math1;
        }
        public void KSideR(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative)
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
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
            Math = Math1;
        }
        public void KSideL(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative)
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
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
            Math = Math1;
        }
        public void KDownRigthLeft(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative)
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
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
            Math = Math1;
        }
        public void KUpRigthLeft(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5, bool Alternative)
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
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
            Math = Math1;
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

            //Making picture boxes sdo stuff
            public void ChessClick(object sender, EventArgs e)
            {
            //Checking if the tile has a piece on it
            //If it doesntOutOfBounds();
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

                    CheckCheck();
                    CheckMate();

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

                    //Checking legal white rook moves
                    if (PCache.Tag == WRook.Tag)
                    {
                        Unit = "White rook";

                        //RookMove
                        RookMove("A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7", x => x - 1, "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BRook", false);
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //Checking legal black rook moves
                    if (PCache.Tag == BRook.Tag)
                    {
                        Unit = "Black rook";

                        //RookMove
                        RookMove("A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2", x => x + 1, "A5", "B5", "C5", "D5", "E5", "F5", "G5", "H5", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WRook", false);
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //White knigth logic
                    else if (PCache.Tag == WKnigth.Tag)
                    {
                        Unit = "White knigth";

                        //Down knight logic
                        KnigthDownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 2, false);
                        //Up knight logic
                        KnigthDownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 2, false);
                        //Side knight logic
                        KnigthSideRigth("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, x => x - 1, false);
                        //Side knight logic
                        KnigthSideLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, x => x + 1, false);
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //Black knigth logic
                    else if (PCache.Tag == BKnigth.Tag)
                    {
                        Unit = "Black knigth";

                        //Down knight logic
                        KnigthDownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 2, false);
                        //Up knight logic
                        KnigthDownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 2, false);
                        //Side knight logic
                        KnigthSideRigth("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, x => x - 1, false);
                        //Side logic
                        KnigthSideLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, x => x + 1, false);
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //White tower move logic
                    else if (PCache.Tag == WTower.Tag)
                    {
                        Unit = "White tower";

                        //Down move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side logic rigth
                        SideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side logic left
                        SideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //Black tower move logic
                    else if (PCache.Tag == BTower.Tag)
                    {
                        Unit = "Black tower";

                        //Down move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side logic rigth
                        SideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side logic left
                        SideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //White bishop move logic
                    else if (PCache.Tag == WBishop.Tag)
                    {
                        Unit = "White bishop";

                        //Down rigth movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down left movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up rigth movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //up left movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //Black bishop move logic
                    else if (PCache.Tag == BBishop.Tag)
                    {
                        Unit = "Black bishop";

                        //Down rigth movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down left movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up rigth movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //up left movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //White king move logic
                    else if (PCache.Tag == WKing.Tag)
                    {
                        Unit = "White king";

                        //Down move logic
                        KDown("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up move logic
                        KDown("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side logic rigth
                        KSideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side logic left
                        KSideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down rigth movement logic
                        KDownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down left movement logic
                        KDownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up rigth movement logic
                        KUpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //up left movement logic
                        KUpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        (sender as PictureBox).BackColor = Color.Green;
                        WKingL = Move1;
                    }
                    //Black king move logic
                    else if (PCache.Tag == BKing.Tag)
                    {
                        Unit = "Black king";

                        //Down move logic
                        KDown("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up move logic
                        KDown("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side logic rigth
                        KSideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side logic left
                        KSideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down rigth movement logic
                        KDownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down left movement logic
                        KDownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up rigth movement logic
                        KUpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //up left movement logic
                        KUpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        (sender as PictureBox).BackColor = Color.Green;
                        BKingL = Move1;
                    }
                    //White queen move logic
                    else if (PCache.Tag == WQueen.Tag)
                    {
                        Unit = "White queen";

                        //Down move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side rigth logic 
                        SideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Side left logic 
                        SideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down rigth movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Down left movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //Up rigth movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        //up left movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", false);
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //Black queen move logic
                    else if (PCache.Tag == BQueen.Tag)
                    {
                        Unit = "Black queen";

                        //Down move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side rigth logic 
                        SideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Side left logic 
                        SideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down rigth movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Down left movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //Up rigth movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        //up left movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", false);
                        (sender as PictureBox).BackColor = Color.Green;
                    }
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