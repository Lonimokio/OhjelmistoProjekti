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
        string Result = "Empty";
        string Result1;
        string FString = "A";
        string SString;

        int Calculation = 1;
        int color = 1;
        int counter = 1;
        int Turn = 1;

        bool EnPassant;
        bool Towering;
        bool MovementCheck = true;
        bool OutOfBoundsCheck = false;

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
        public void OutOfBounds()
        {
            Calculation = 1;
            FString = "A";
            Math = Math1;
            Result = Math;
            for (int i = 0; i < 32; i++)
            {
                Math = FString;
                Result1 = FString + Calculation.ToString();

                if (Result != Result1)
                {
                    //MessageBox.Show(Result + " first " + Result1);
                    OutOfBoundsCheck = false;
                    if (i == 32)
                    {
                        if (Result != Result1)
                        {
                            MessageBox.Show(Result + " first " + Result1);
                            OutOfBoundsCheck = true;
                        }
                    }
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
            /*if (Result != "A1") 
            {
                OutOfBoundsCheck = false;
                if (Result != "A2")
                {
                    if (Result != "A3")
                    {
                        OutOfBoundsCheck = false;
                        if (Result != "A4")
                        {
                            OutOfBoundsCheck = false;
                            if (Result != "A5")
                            {
                                OutOfBoundsCheck = false;
                                if (Result != "A6")
                                {
                                    OutOfBoundsCheck = false;
                                    if (Result != "A7")
                                    {
                                        OutOfBoundsCheck = false;
                                        if (Result != "A8")
                                        {
                                            OutOfBoundsCheck = false;
                                            if (Result != "B1")
                                            {
                                                OutOfBoundsCheck = false;
                                                if (Result != "B2")
                                                {
                                                    OutOfBoundsCheck = false;
                                                    if (Result != "B3")
                                                    {
                                                        OutOfBoundsCheck = false;
                                                        if (Result != "B4")
                                                        {
                                                            OutOfBoundsCheck = false;
                                                            if (Result != "B5")
                                                            {
                                                                OutOfBoundsCheck = false;
                                                                if (Result != "B6")
                                                                {
                                                                    OutOfBoundsCheck = false;
                                                                    if (Result != "B7")
                                                                    {
                                                                        OutOfBoundsCheck = false;
                                                                        if (Result != "B8")
                                                                        {
                                                                            OutOfBoundsCheck = false;
                                                                            if (Result != "C1")
                                                                            {
                                                                                OutOfBoundsCheck = false;
                                                                                if (Result != "C2")
                                                                                {
                                                                                    OutOfBoundsCheck = false;
                                                                                    if (Result != "C3")
                                                                                    {
                                                                                        OutOfBoundsCheck = false;
                                                                                        if (Result != "C4")
                                                                                        {
                                                                                            OutOfBoundsCheck = false;
                                                                                            if (Result != "C5")
                                                                                            {
                                                                                                OutOfBoundsCheck = false;
                                                                                                if (Result != "C6")
                                                                                                {
                                                                                                    OutOfBoundsCheck = false;
                                                                                                    if (Result != "C7")
                                                                                                    {
                                                                                                        OutOfBoundsCheck = false;
                                                                                                        if (Result != "C8")
                                                                                                        {
                                                                                                            OutOfBoundsCheck = false;
                                                                                                            if (Result != "D1")
                                                                                                            {
                                                                                                                OutOfBoundsCheck = false;
                                                                                                                if (Result != "D2")
                                                                                                                {
                                                                                                                    OutOfBoundsCheck = false;
                                                                                                                    if (Result != "D3")
                                                                                                                    {
                                                                                                                        OutOfBoundsCheck = false;
                                                                                                                        if (Result != "D4")
                                                                                                                        {
                                                                                                                            OutOfBoundsCheck = false;
                                                                                                                            if (Result != "D5")
                                                                                                                            {
                                                                                                                                OutOfBoundsCheck = false;
                                                                                                                                if (Result != "D6")
                                                                                                                                {
                                                                                                                                    OutOfBoundsCheck = false;
                                                                                                                                    if (Result != "D7")
                                                                                                                                    {
                                                                                                                                        OutOfBoundsCheck = false;
                                                                                                                                        if (Result != "D8")
                                                                                                                                        {
                                                                                                                                            OutOfBoundsCheck = false;
                                                                                                                                            if (Result != "E1")
                                                                                                                                            {
                                                                                                                                                OutOfBoundsCheck = false;
                                                                                                                                                if (Result != "E2")
                                                                                                                                                {
                                                                                                                                                    OutOfBoundsCheck = false;
                                                                                                                                                    if (Result != "E3")
                                                                                                                                                    {
                                                                                                                                                        OutOfBoundsCheck = false;
                                                                                                                                                        if (Result != "E4")
                                                                                                                                                        {
                                                                                                                                                            OutOfBoundsCheck = false;
                                                                                                                                                            if (Result != "E5")
                                                                                                                                                            {
                                                                                                                                                                OutOfBoundsCheck = false;
                                                                                                                                                                if (Result != "E6")
                                                                                                                                                                {
                                                                                                                                                                    OutOfBoundsCheck = false;
                                                                                                                                                                    if (Result != "E7")
                                                                                                                                                                    {
                                                                                                                                                                        OutOfBoundsCheck = false;
                                                                                                                                                                        if (Result != "E8")
                                                                                                                                                                        {
                                                                                                                                                                            OutOfBoundsCheck = false;
                                                                                                                                                                            if (Result != "F1")
                                                                                                                                                                            {
                                                                                                                                                                                OutOfBoundsCheck = false;
                                                                                                                                                                                if (Result != "F2")
                                                                                                                                                                                {
                                                                                                                                                                                    OutOfBoundsCheck = false;
                                                                                                                                                                                    if (Result != "F3")
                                                                                                                                                                                    {
                                                                                                                                                                                        OutOfBoundsCheck = false;
                                                                                                                                                                                        if (Result != "F4")
                                                                                                                                                                                        {
                                                                                                                                                                                            OutOfBoundsCheck = false;
                                                                                                                                                                                            if (Result != "F5")
                                                                                                                                                                                            {
                                                                                                                                                                                                OutOfBoundsCheck = false;
                                                                                                                                                                                                if (Result != "F6")
                                                                                                                                                                                                {
                                                                                                                                                                                                    OutOfBoundsCheck = false;
                                                                                                                                                                                                    if (Result != "F7")
                                                                                                                                                                                                    {
                                                                                                                                                                                                        OutOfBoundsCheck = false;
                                                                                                                                                                                                        if (Result != "F8")
                                                                                                                                                                                                        {
                                                                                                                                                                                                            OutOfBoundsCheck = false;
                                                                                                                                                                                                            if (Result != "G1")
                                                                                                                                                                                                            {
                                                                                                                                                                                                                OutOfBoundsCheck = false;
                                                                                                                                                                                                                if (Result != "G2")
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    OutOfBoundsCheck = false;
                                                                                                                                                                                                                    if (Result != "G3")
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        OutOfBoundsCheck = false;
                                                                                                                                                                                                                        if (Result != "G4")
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            OutOfBoundsCheck = false;
                                                                                                                                                                                                                            if (Result != "G5")
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                OutOfBoundsCheck = false;
                                                                                                                                                                                                                                if (Result != "G6")
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    OutOfBoundsCheck = false;
                                                                                                                                                                                                                                    if (Result != "G7")
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        OutOfBoundsCheck = false;
                                                                                                                                                                                                                                        if (Result != "G8")
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            OutOfBoundsCheck = false;
                                                                                                                                                                                                                                            if (Result != "H1")
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                OutOfBoundsCheck = false;
                                                                                                                                                                                                                                                if (Result != "H2")
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    OutOfBoundsCheck = false;
                                                                                                                                                                                                                                                    if (Result != "H3")
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        OutOfBoundsCheck = false;
                                                                                                                                                                                                                                                        if (Result != "H4")
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            OutOfBoundsCheck = false;
                                                                                                                                                                                                                                                            if (Result != "H5")
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                OutOfBoundsCheck = false;
                                                                                                                                                                                                                                                                if (Result != "H6")
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    OutOfBoundsCheck = false;
                                                                                                                                                                                                                                                                    if (Result != "H7")
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        OutOfBoundsCheck = false;
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
            }*/
        }
        public void MovementD(string Troop, string Troop1, string Troop2, string Troop3, string Troop4, string Troop5)
        {
            MovementCheck = true;
            if (this.Controls[Result].Tag == this.Controls[Troop].Tag)
            {
                MovementCheck = false;
                MessageBox.Show("Im here " + Troop + " " + Result);
            }
            if (this.Controls[Result].Tag == this.Controls[Troop1].Tag)
            {
                MovementCheck = false;
                MessageBox.Show("Im here " + Troop1 + " " + Result);
            }
            if (this.Controls[Result].Tag == this.Controls[Troop2].Tag)
            {
                MovementCheck = false;
                MessageBox.Show("Im here " + Troop2 + " " + Result);
            }
            if (this.Controls[Result].Tag == this.Controls[Troop3].Tag)
            {
                MovementCheck = false;
                MessageBox.Show("Im here " + Troop3 + " " + Result);
            }
            if (this.Controls[Result].Tag == this.Controls[Troop4].Tag)
            {
                MovementCheck = false;
                MessageBox.Show("Im here " + Troop4 + " " + Result);
            }
            if (this.Controls[Result].Tag == this.Controls[Troop5].Tag)
            {
                MovementCheck = false;
                MessageBox.Show("Im here " + Troop5 + " " + Result);
            }
        }
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

        //Movement logic as methods
        //Straigth movement
        public void DownUp(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5)
        {
            //Down and Up move logic
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            Result = Math.Substring(0, 1) + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Math = Math1;
                return;
            }

            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                MovementD(OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
                if (MovementCheck == false)
                {
                    Math = Math1;
                    return;
                }
                DownUp(Side, Side1, Side2, Side3, Side4, Side5, op, OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        public void SideR(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5)
        {
            //Side logic rigth
            Calculation = int.Parse(Math.Substring(1, 1));
            GetFString();
            Result = FString + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Math = Math1;
                return;
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                MovementD(OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
                if (MovementCheck == false)
                {
                    Math = Math1;
                    return;
                }
                SideR(Side, Side1, Side2, Side3, Side4, Side5, OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        public void SideL(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5)
        {
            //Side logic Left
            Calculation = int.Parse(Math.Substring(1, 1));
            GetFString();
            Result = SString + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Math = Math1;
                return;
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                MovementD(OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
                if (MovementCheck == false)
                {
                    Math = Math1;
                    return;
                }
                SideL(Side, Side1, Side2, Side3, Side4, Side5, OSide, OSide1, OSide2, OSide3, OSide4, OSide5 );
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        //Knigth movement
        public void KnigthDownUp(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op)
        {
            //Down and Up knight logic
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            GetFString();
            Result = FString + Calculation.ToString();
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Result = "Empty";
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }
            Result = SString + Calculation.ToString();
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Result = "Empty";
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }
            Math = Math1;
        }
        public void KnigthSideRigth(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, Func<int, int> op1)
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
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Result = "Empty";
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op1(Calculation);
            Result = FString + Calculation.ToString();
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Result = "Empty";
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }
            Math = Math1;
        }
        public void KnigthSideLeft(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, Func<int, int> op1)
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
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Result = "Empty";
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op1(Calculation);
            Result = SString + Calculation.ToString();
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Result = "Empty";
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }
            Math = Math1;
        }
        //Diagonal movement
        public void DownRigthLeft(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5)
        {
            //Down rigth and left movement logic
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            GetFString();
            Result = FString + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Math = Math1;
                return;
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                MovementD(OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
                if (MovementCheck == false)
                {
                    Math = Math1;
                    return;
                }
                DownRigthLeft(Side, Side1, Side2, Side3, Side4, Side5, op, OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        public void UpRigthLeft(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5)
        {
            //Up rigth and left movement logic
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            GetFString();
            Result = SString + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Math = Math1;
                return;
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                MovementD(OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
                if (MovementCheck == false)
                {
                    Math = Math1;
                    return;
                }
                UpRigthLeft(Side, Side1, Side2, Side3, Side4, Side5, op, OSide, OSide1, OSide2, OSide3, OSide4, OSide5);
            }
            else if (MovementCheck == false)
            {
                Math = Math1;
                return;
            }
        }
        //King movement
        public void KDown(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5)
        {
            //Down and Up move logic
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            Result = Math.Substring(0, 1) + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Math = Math1;
                return;
            }

            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
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
        }
        public void KSideR(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5)
        {
            //Side logic rigth
            Calculation = int.Parse(Math.Substring(1, 1));
            GetFString();
            Result = FString + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Math = Math1;
                return;
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
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
        }
        public void KSideL(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5)
        {
            //Side logic Left
            Calculation = int.Parse(Math.Substring(1, 1));
            GetFString();
            Result = SString + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Math = Math1;
                return;
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
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
        }
        public void KDownRigthLeft(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5)
        {
            //Down rigth and left movement logic
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            GetFString();
            Result = FString + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Math = Math1;
                return;
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
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
        }
        public void KUpRigthLeft(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, Func<int, int> op, string OSide, string OSide1, string OSide2, string OSide3, string OSide4, string OSide5)
        {
            //Up rigth and left movement logic
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = op(Calculation);
            GetFString();
            Result = SString + Calculation.ToString();
            Math = Result;
            OutOfBounds();
            if (OutOfBoundsCheck == true || Calculation >= 9 || Calculation <= 0)
            {
                Math = Math1;
                return;
            }
            MovementD(Side, Side1, Side2, Side3, Side4, Side5);
            if (MovementCheck == true)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
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
        }
        //Rook movement
        public void RookMove(string Side, string Side1, string Side2, string Side3, string Side4, string Side5, string Side6, string Side7, Func<int, int> op, string Side8, string Side9, string Side10, string Side11, string Side12, string Side13, string Side14, string Side15, string Side16, string Side17, string Side18, string Side19, string Side20)
        {
            //Checking if starting first square
            if ((Move1 == Side) || (Move1 == Side1) || (Move1 == Side2) || (Move1 == Side3) || (Move1 == Side4) || (Move1 == Side5) || (Move1 == Side6) || (Move1 == Side7))
            {
                Calculation = int.Parse(Math.Substring(1, 1));
                Calculation = op(Calculation);
                Result = Math.Substring(0, 1) + Calculation.ToString();
                Test1.Text = Result.ToString();
                if (this.Controls[Result].Tag == null)
                {
                    this.Controls[Result].BackColor = Color.LightGreen;

                    Calculation = op(Calculation);
                    Result = Math.Substring(0, 1) + Calculation.ToString();
                    Test2.Text = Result.ToString();
                    if (this.Controls[Result].Tag == null)
                    {
                        this.Controls[Result].BackColor = Color.LightGreen;
                    }
                }
            }
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            if (ReferenceBox.Image != null)
            {
                //Checking if you can eat
                Calculation = int.Parse(Math.Substring(1, 1));
                Calculation = op(Calculation);
                Result = Math.Substring(0, 1) + Calculation.ToString();
                ReferenceBox = (PictureBox)this.Controls[Result];

                if (ReferenceBox.Image != null)
                {
                    if (ReferenceBox.Tag == this.Controls[Side16].Tag || ReferenceBox.Tag == this.Controls[Side17].Tag || ReferenceBox.Tag == this.Controls[Side18].Tag || ReferenceBox.Tag == this.Controls[Side19].Tag || ReferenceBox.Tag == this.Controls[Side20].Tag)
                    {
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = op(Calculation);

                        GetFString();
                        Result = FString + Calculation.ToString();
                        this.Controls[Result].BackColor = Color.LightGreen;
                    }
                }
            }
            //En passant logic
            else if ((Move1 == Side8) || (Move1 == Side9) || (Move1 == Side10) || (Move1 == Side11) || (Move1 == Side12) || (Move1 == Side13) || (Move1 == Side14) || (Move1 == Side15))
            {
                Calculation = int.Parse(Math.Substring(1, 1));
                GetFString();
                Result = FString + Calculation.ToString();
                ReferenceBox = (PictureBox)this.Controls[Result];
                if (ReferenceBox.Image != null)
                {
                    if (ReferenceBox.Image == Properties.Resources.Black_rook1)
                    {
                        Calculation = op(Calculation);
                        Result = FString + Calculation.ToString();
                        this.Controls[Result].BackColor = Color.LightGreen;
                        EnPassant = true;
                    }

                }
            }
            //Normal rook movement
            else
            {
                Math = Math1;
                Calculation = int.Parse(Math.Substring(1, 1));
                Calculation = op(Calculation);
                Result = Math.Substring(0, 1) + Calculation.ToString();

                this.Controls[Result].BackColor = Color.LightGreen;

                Calculation = int.Parse(Math.Substring(1, 1));
                Calculation = op(Calculation);
                Result = Math.Substring(0, 1) + Calculation.ToString();
                ReferenceBox = (PictureBox)this.Controls[Result];

                //Checking if you can eat
                if (ReferenceBox.Image != null)
                {
                    if (ReferenceBox.Tag == BRook.Tag || ReferenceBox.Tag == BBishop.Tag || ReferenceBox.Tag == BQueen.Tag || ReferenceBox.Tag == BKnigth.Tag || ReferenceBox.Tag == BTower.Tag)
                    {
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = op(Calculation);

                        GetFString();
                        Result = FString + Calculation.ToString();
                        this.Controls[Result].BackColor = Color.LightGreen;
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
                else if ((sender as PictureBox).BackColor == Color.LightGreen || (sender as PictureBox).BackColor == Color.Green)
                {
                    (sender as PictureBox).Image = PCache.Image;
                    (sender as PictureBox).Tag = PCache.Tag;
                    Move1 = null;
                    PCache.Image = null;
                    PCache.Tag = null;
                    Math = "A1";
                    Calculation = int.Parse(Math.Substring(1, 1));
                    FString = "A";

                    if ((sender as PictureBox).BackColor == Color.LightGreen)
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
                    else if ((sender as PictureBox).BackColor == Color.Green)
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
                    (sender as PictureBox).Tag = null;

                    //Checking legal white rook moves
                    if (PCache.Tag == WRook.Tag)
                    {
                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;
                        Unit = "White rook";

                        //RookMove
                        RookMove("A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7", x => x-1, "A5", "B5", "C5", "D5", "E5", "F5", "G5", "H5", "WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //Checking legal black rook moves
                    if (PCache.Tag == BRook.Tag)
                    {
                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;
                        Unit = "Black rook";
                        //RookMove
                        RookMove("A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2", x => x + 1, "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4", "BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //White knigth logic
                    else if (PCache.Tag == WKnigth.Tag)
                    {
                        Unit = "White knigth";

                        //Calculation settup
                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;
                        //Down knight logic
                        KnigthDownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 2);
                        //Up knight logic
                        KnigthDownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 2);
                        //Side knight logic
                        KnigthSideRigth("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, x => x - 1);
                        //Side knight logic
                        KnigthSideLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, x => x + 1);
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //Black knigth logic
                    else if (PCache.Tag == BKnigth.Tag)
                    {
                        Unit = "Black knigth";

                        //Calculation settup
                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;

                        //Down knight logic
                        KnigthDownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 2);
                        //Up knight logic
                        KnigthDownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 2);
                        //Side knight logic
                        KnigthSideRigth("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, x => x - 1);
                        //Side logic
                        KnigthSideLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, x => x + 1);
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //White tower move logic
                    else if (PCache.Tag == WTower.Tag)
                    {
                        Unit = "White tower";
                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;


                        //Down move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Up move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Side logic rigth
                        SideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Side logic left
                        SideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //Black tower move logic
                    else if (PCache.Tag == BTower.Tag)
                    {
                        Unit = "Black tower";
                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;

                        //Down move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Up move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Side logic rigth
                        SideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Side logic left
                        SideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //White bishop move logic
                    else if (PCache.Tag == WBishop.Tag)
                    {
                        Unit = "White bishop";

                        //Calculation initialization
                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;

                        //Down rigth movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Down left movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Up rigth movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //up left movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //Black bishop move logic
                    else if (PCache.Tag == BBishop.Tag)
                    {
                        Unit = "Black bishop";

                        //Calculation initialization
                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;

                        //Down rigth movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Down left movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Up rigth movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //up left movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //White king move logic
                    else if (PCache.Tag == WKing.Tag)
                    {
                        Unit = "White king";

                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;

                        //Down move logic
                        KDown("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Up move logic
                        KDown("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Side logic rigth
                        KSideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Side logic left
                        KSideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Down rigth movement logic
                        KDownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Down left movement logic
                        KDownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Up rigth movement logic
                        KUpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //up left movement logic
                        KUpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //Black king move logic
                    else if (PCache.Tag == BKing.Tag)
                    {
                        Unit = "Black king";

                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;

                        //Down move logic
                        KDown("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Up move logic
                        KDown("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Side logic rigth
                        KSideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Side logic left
                        KSideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Down rigth movement logic
                        KDownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Down left movement logic
                        KDownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Up rigth movement logic
                        KUpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //up left movement logic
                        KUpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //White queen move logic
                    else if (PCache.Tag == WQueen.Tag)
                    {
                        Unit = "White queen";

                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;

                        //Down move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Up move logic
                        DownUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Side rigth logic 
                        SideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Side left logic 
                        SideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Down rigth movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Down left movement logic
                        DownRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //Up rigth movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x - 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        //up left movement logic
                        UpRigthLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing", x => x + 1, "BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing");
                        (sender as PictureBox).BackColor = Color.Green;
                    }
                    //Black queen move logic
                    else if (PCache.Tag == BQueen.Tag)
                    {
                        Unit = "Black queen";

                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;

                        //Down move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Up move logic
                        DownUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Side rigth logic 
                        SideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Side left logic 
                        SideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Down rigth movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Down left movement logic
                        DownRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //Up rigth movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x + 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
                        //up left movement logic
                        UpRigthLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop", "BKing", x => x - 1, "WKnigth", "WQueen", "WTower", "WRook", "WBishop", "WKing");
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