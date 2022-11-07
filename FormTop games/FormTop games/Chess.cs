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

            Lock("BKnigth", "BQueen", "BTower", "BRook", "BBishop", false);
        }

        //Variable below here
        string Move1;
        string Unit;
        string Math = "A";
        string Math1;
        string Result = "Empty";
        string FString;
        string SString;

        int Calculation = 1;
        int color = 1;
        int counter = 1;
        int Turn = 1;

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
        //Methods
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
        public void Lock(string Side, string Side1, string Side2, string Side3, string Side4, bool Lock1)
        {
            for (int i = 0; i < 63; i++)
            {
                Result = FString + Calculation.ToString();
                Math = Result;
                OutOfBounds();
                if (OutOfBoundsCheck == true)
                {
                    Result = "Empty";
                }

                if (this.Controls[Result].Tag == this.Controls[Side].Tag || this.Controls[Result].Tag == this.Controls[Side1].Tag || this.Controls[Result].Tag == this.Controls[Side2].Tag || this.Controls[Result].Tag == this.Controls[Side3].Tag || this.Controls[Result].Tag == this.Controls[Side4].Tag)
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
        }

        //Movement logic as methods
        public void Down(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                ReferenceBox = (PictureBox)this.Controls["Empty"];
                Result = "Empty";
            }

            //Down move logic
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                Calculation = Calculation + 1;
                Result = Math.Substring(0, 1) + Calculation.ToString();
                ReferenceBox = (PictureBox)this.Controls[Result];
                OutOfBounds();
                if (OutOfBoundsCheck == true)
                {
                    ReferenceBox = (PictureBox)this.Controls["Empty"];
                    Result = "Empty";
                }
                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                {
                    this.Controls[Result].BackColor = Color.LightGreen;
                    Calculation = Calculation + 1;
                    Result = Math.Substring(0, 1) + Calculation.ToString();
                    ReferenceBox = (PictureBox)this.Controls[Result];
                    OutOfBounds();
                    if (OutOfBoundsCheck == true)
                    {
                        ReferenceBox = (PictureBox)this.Controls["Empty"];
                        Result = "Empty";
                    }
                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                    {
                        this.Controls[Result].BackColor = Color.LightGreen;
                        Calculation = Calculation + 1;
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        OutOfBounds();
                        if (OutOfBoundsCheck == true)
                        {
                            ReferenceBox = (PictureBox)this.Controls["Empty"];
                            Result = "Empty";
                        }
                        if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            OutOfBounds();
                            if (OutOfBoundsCheck == true)
                            {
                                ReferenceBox = (PictureBox)this.Controls["Empty"];
                                Result = "Empty";
                            }
                            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                OutOfBounds();
                                if (OutOfBoundsCheck == true)
                                {
                                    ReferenceBox = (PictureBox)this.Controls["Empty"];
                                    Result = "Empty";
                                }
                                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    OutOfBounds();
                                    if (OutOfBoundsCheck == true)
                                    {
                                        ReferenceBox = (PictureBox)this.Controls["Empty"];
                                        Result = "Empty";
                                    }
                                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                                    {
                                        this.Controls[Result].BackColor = Color.LightGreen;
                                        Calculation = Calculation + 1;
                                        Result = Math.Substring(0, 1) + Calculation.ToString();
                                        OutOfBounds();
                                        if (OutOfBoundsCheck == true)
                                        {
                                            ReferenceBox = (PictureBox)this.Controls["Empty"];
                                            Result = "Empty";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void Up(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            Calculation = int.Parse(Math.Substring(1, 1));
            Result = Math.Substring(0, 1) + Calculation.ToString();
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            //Up move logic
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                Calculation = Calculation - 1;
                Result = Math.Substring(0, 1) +
                Calculation.ToString();
                ReferenceBox = (PictureBox)this.Controls[Result];
                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                {
                    this.Controls[Result].BackColor = Color.LightGreen;
                    Calculation = Calculation - 1;
                    Result = Math.Substring(0, 1) + Calculation.ToString();
                    ReferenceBox = (PictureBox)this.Controls[Result];
                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                    {
                        this.Controls[Result].BackColor = Color.LightGreen;
                        Calculation = Calculation - 1;
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            Result = Math.Substring(0, 1) + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                Result = Math.Substring(0, 1) + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    Result = Math.Substring(0, 1) + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
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
        }
        public void SideR(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            //Side logic rigth
            Calculation = int.Parse(Math.Substring(1, 1));
            GetFString();
            Result = FString + Calculation.ToString();
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                GetFString();
                Result = FString + Calculation.ToString();
                ReferenceBox = (PictureBox)this.Controls[Result];
                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                {
                    this.Controls[Result].BackColor = Color.LightGreen;
                    GetFString();
                    Result = FString + Calculation.ToString();
                    ReferenceBox = (PictureBox)this.Controls[Result];
                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                    {
                        this.Controls[Result].BackColor = Color.LightGreen;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
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
        }
        public void SideL(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            //Side logic left
            Math = Math1;
            GetFString();
            Result = SString + Calculation.ToString();
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                GetFString();
                Result = SString + Calculation.ToString();
                ReferenceBox = (PictureBox)this.Controls[Result];
                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                {
                    this.Controls[Result].BackColor = Color.LightGreen;
                    GetFString();
                    Result = SString + Calculation.ToString();
                    ReferenceBox = (PictureBox)this.Controls[Result];
                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                    {
                        this.Controls[Result].BackColor = Color.LightGreen;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
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

        public void KnigthDown(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            //Down knight logic
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }
            Result = SString + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                ReferenceBox = (PictureBox)this.Controls["Empty"];
                Result = "Empty";
            }

            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }
        }
        public void KnigthUp(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            Calculation = Calculation - 4;
            Result = FString + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                ReferenceBox = (PictureBox)this.Controls["Empty"];
                Result = "Empty";
            }

            Test1.Text = Result;
            if (ReferenceBox.Tag != this.Controls[Side].Tag || ReferenceBox.Tag != this.Controls[Side1].Tag || ReferenceBox.Tag != this.Controls[Side2].Tag || ReferenceBox.Tag != this.Controls[Side3].Tag || ReferenceBox.Tag != this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }

            Result = SString + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];


            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                ReferenceBox = (PictureBox)this.Controls["Empty"];
                Result = "Empty";
            }
            Test2.Text = Result;
            if (ReferenceBox.Tag != this.Controls[Side].Tag || ReferenceBox.Tag != this.Controls[Side1].Tag || ReferenceBox.Tag != this.Controls[Side2].Tag || ReferenceBox.Tag != this.Controls[Side3].Tag || ReferenceBox.Tag != this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }
        }
        public void KnigthSideL(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            GetFString();
            Calculation = Calculation + 3;
            Result = FString + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                ReferenceBox = (PictureBox)this.Controls["Empty"];
                Result = "Empty";
            }

            if (ReferenceBox.Tag != this.Controls[Side].Tag || ReferenceBox.Tag != this.Controls[Side1].Tag || ReferenceBox.Tag != this.Controls[Side2].Tag || ReferenceBox.Tag != this.Controls[Side3].Tag || ReferenceBox.Tag != this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }

            Result = SString + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                ReferenceBox = (PictureBox)this.Controls["Empty"];
                Result = "Empty";
            }

            if (ReferenceBox.Tag != this.Controls[Side].Tag || ReferenceBox.Tag != this.Controls[Side1].Tag || ReferenceBox.Tag != this.Controls[Side2].Tag || ReferenceBox.Tag != this.Controls[Side3].Tag || ReferenceBox.Tag != this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }
        }
        public void KnigthSideR(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            Calculation = Calculation + 2;
            Result = SString + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];
            OutOfBounds();
            if (OutOfBoundsCheck == true)
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
            OutOfBounds();
            if (OutOfBoundsCheck == true)
            {
                ReferenceBox = (PictureBox)this.Controls["Empty"];
                Result = "Empty";
            }

            if (ReferenceBox.Tag != WRook.Tag || ReferenceBox.Tag != WBishop.Tag || ReferenceBox.Tag != WQueen.Tag || ReferenceBox.Tag != WKnigth.Tag || ReferenceBox.Tag != WTower.Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
            }
        }

        public void DownRigth(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            //Down rigth movement logic
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                Calculation = Calculation + 1;
                GetFString();
                Result = FString + Calculation.ToString();
                ReferenceBox = (PictureBox)this.Controls[Result];
                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                {
                    this.Controls[Result].BackColor = Color.LightGreen;
                    Calculation = Calculation + 1;
                    GetFString();
                    Result = FString + Calculation.ToString();
                    ReferenceBox = (PictureBox)this.Controls[Result];
                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                    {
                        this.Controls[Result].BackColor = Color.LightGreen;
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
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
        }
        public void UpRigth(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            Math = Math1;
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = Calculation - 1;
            GetFString();
            Result = FString + Calculation.ToString();
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

            //Up rigth movement logic
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                Calculation = Calculation - 1;
                GetFString();
                Result = FString + Calculation.ToString();
                ReferenceBox = (PictureBox)this.Controls[Result];
                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                {
                    this.Controls[Result].BackColor = Color.LightGreen;
                    Calculation = Calculation - 1;
                    GetFString();
                    Result = FString + Calculation.ToString();
                    ReferenceBox = (PictureBox)this.Controls[Result];
                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                    {
                        this.Controls[Result].BackColor = Color.LightGreen;
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = FString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = FString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                GetFString();
                                Result = FString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    GetFString();
                                    Result = FString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
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
        }
        public void Upleft(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            Math = Math1;
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = Calculation - 1;
            GetFString();
            Result = SString + Calculation.ToString();
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

            //Up left movement logic
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                Calculation = Calculation - 1;
                GetFString();
                Result = SString + Calculation.ToString();
                ReferenceBox = (PictureBox)this.Controls[Result];
                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                {
                    this.Controls[Result].BackColor = Color.LightGreen;
                    Calculation = Calculation - 1;
                    GetFString();
                    Result = SString + Calculation.ToString();
                    ReferenceBox = (PictureBox)this.Controls[Result];
                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                    {
                        this.Controls[Result].BackColor = Color.LightGreen;
                        Calculation = Calculation - 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation - 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation - 1;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation - 1;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
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
        }
        public void Downleft(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            Math = Math1;
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = Calculation + 1;
            GetFString();
            Result = SString + Calculation.ToString();
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

            //Down left movement logic
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                Calculation = Calculation + 1;
                GetFString();
                Result = SString + Calculation.ToString();
                ReferenceBox = (PictureBox)this.Controls[Result];
                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                {
                    this.Controls[Result].BackColor = Color.LightGreen;
                    Calculation = Calculation + 1;
                    GetFString();
                    Result = SString + Calculation.ToString();
                    ReferenceBox = (PictureBox)this.Controls[Result];
                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                    {
                        this.Controls[Result].BackColor = Color.LightGreen;
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = SString + Calculation.ToString();
                        ReferenceBox = (PictureBox)this.Controls[Result];
                        if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                        {
                            this.Controls[Result].BackColor = Color.LightGreen;
                            Calculation = Calculation + 1;
                            GetFString();
                            Result = SString + Calculation.ToString();
                            ReferenceBox = (PictureBox)this.Controls[Result];
                            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                            {
                                this.Controls[Result].BackColor = Color.LightGreen;
                                Calculation = Calculation + 1;
                                GetFString();
                                Result = SString + Calculation.ToString();
                                ReferenceBox = (PictureBox)this.Controls[Result];
                                if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
                                {
                                    this.Controls[Result].BackColor = Color.LightGreen;
                                    Calculation = Calculation + 1;
                                    GetFString();
                                    Result = SString + Calculation.ToString();
                                    ReferenceBox = (PictureBox)this.Controls[Result];
                                    if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
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

        public void KDown(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            //Down move logic
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                Calculation = Calculation + 1;
                Result = Math.Substring(0, 1) + Calculation.ToString();
            }
            Calculation = int.Parse(Math.Substring(1, 1));
            Result = Math.Substring(0, 1) + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];
        }
        public void KUp(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            //Up move logic
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                Calculation = Calculation - 1;
                Result = Math.Substring(0, 1) + Calculation.ToString();
            }
        }
        public void KSideR(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            //Side logic rigth
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            Calculation = int.Parse(Math.Substring(1, 1));
            GetFString();
            Result = FString + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                GetFString();
                Result = FString + Calculation.ToString();
            }
        }
        public void KSideL(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            //Side logic left
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            Math = Math1;
            GetFString();
            Result = SString + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];
            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                GetFString();
                Result = SString + Calculation.ToString();
            }
        }
        public void KDownRigth(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            //Down rigth movement logic
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            Math = Math1;
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = Calculation + 1;
            GetFString();
            Result = FString + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];


            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                Calculation = Calculation + 1;
                GetFString();
                Result = FString + Calculation.ToString();
            }
        }
        public void KUpRigth(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            //Up rigth movement logic
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            Math = Math1;
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = Calculation - 1;
            GetFString();
            Result = FString + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];


            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                Calculation = Calculation - 1;
                GetFString();
                Result = FString + Calculation.ToString();
            }
        }
        public void KUpLeft(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            //Up left movement logic
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            Math = Math1;
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = Calculation - 1;
            GetFString();
            Result = SString + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];


            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                Calculation = Calculation - 1;
                GetFString();
                Result = SString + Calculation.ToString();
            }
        }
        public void KDownLeft(string Side, string Side1, string Side2, string Side3, string Side4)
        {
            //Down left movement logic
            PictureBox ReferenceBox = (PictureBox)this.Controls[Result];
            Math = Math1;
            Calculation = int.Parse(Math.Substring(1, 1));
            Calculation = Calculation + 1;
            GetFString();
            Result = SString + Calculation.ToString();
            ReferenceBox = (PictureBox)this.Controls[Result];


            if (ReferenceBox.Tag == this.Controls[Side].Tag || ReferenceBox.Tag == this.Controls[Side1].Tag || ReferenceBox.Tag == this.Controls[Side2].Tag || ReferenceBox.Tag == this.Controls[Side3].Tag || ReferenceBox.Tag == this.Controls[Side4].Tag)
            {
                this.Controls[Result].BackColor = Color.LightGreen;
                Calculation = Calculation + 1;
                GetFString();
                Result = SString + Calculation.ToString();
            }
        }

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
                Calculation = Calculation - 1;
                Result = Math.Substring(0, 1) + Calculation.ToString();

                this.Controls[Result].BackColor = Color.LightGreen;

                Calculation = int.Parse(Math.Substring(1, 1));
                Calculation = Calculation - 1;
                Result = Math.Substring(0, 1) + Calculation.ToString();
                ReferenceBox = (PictureBox)this.Controls[Result];

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
                    PictureBox test = (sender as PictureBox);
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
                        Math = (sender as PictureBox).ToString();
                        Calculation = Calculation = int.Parse(Math.Substring(1, 1));
                        GetFString();
                        if (Turn == 1)
                        {
                            Turn = 2;
                            Lock("WKnigth", "WQueen", "WTower", "WRook", "WBishop", false);
                            TurnLabel.Text = "Black turn";
                        }
                        else if (Turn == 2)
                        {
                            Turn = 1;
                            Lock("BKnigth", "BQueen", "BTower", "BRook", "BBishop", false);
                            TurnLabel.Text = "White turn";
                        }
                    }
                    else
                    {

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

                    //Checking legal white rook moves
                    if (PCache.Tag == WRook.Tag)
                    {
                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;
                        Unit = "White rook";

                        //RookMove
                        RookMove("A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7", x => x-1, "A5", "B5", "C5", "D5", "E5", "F5", "G5", "H5", "WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                    }
                    //Checking legal black rook moves
                    if (PCache.Tag == BRook.Tag)
                    {
                        Math = (sender as PictureBox).Name;
                        Unit = "Black rook";
                        //RookMove
                        RookMove("A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2", x => x + 1, "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4", "BKnigth", "BQueen", "BTower", "BRook", "BBishop");
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
                        OutOfBounds();
                        if (OutOfBoundsCheck == true)
                        {
                            ReferenceBox = (PictureBox)this.Controls["Empty"];
                            Result = "Empty";
                        }
                        //Down knight logic
                        KnigthDown("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Up knight logic
                        KnigthUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Side knight logic
                        KnigthSideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Side logic
                        KnigthSideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
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
                        OutOfBounds();
                        if (OutOfBoundsCheck == true)
                        {
                            ReferenceBox = (PictureBox)this.Controls["Empty"];
                            Result = "Empty";
                        }

                        //Down knight logic
                        KnigthDown("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Up knight logic
                        KnigthUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Side knight logic
                        KnigthSideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Side logic
                        KnigthSideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                    }
                    //White tower move logic
                    else if (PCache.Tag == WTower.Tag)
                    {
                        Unit = "White tower";
                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down move logic
                        Down("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Up move logic
                        Up("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Side logic rigth
                        SideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Side logic left
                        SideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
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
                        Down("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Up move logic
                        Up("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Side logic rigth
                        SideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Side logic left
                        SideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                    }
                    //White bishop move logic
                    else if (PCache.Tag == WBishop.Tag)
                    {
                        Unit = "White bishop";

                        //Calculation initialization
                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = FString + Calculation.ToString();

                        //Down rigth movement logic
                        DownRigth("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Up rigth movement logic
                        UpRigth("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Up left movement logic
                        Upleft("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Down left movement logic
                        Downleft("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                    }
                    //Black bishop move logic
                    else if (PCache.Tag == BBishop.Tag)
                    {
                        Unit = "Black bishop";

                        //Calculation initialization
                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        GetFString();
                        Result = FString + Calculation.ToString();

                        //Down rigth movement logic
                        DownRigth("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Up rigth movement logic
                        UpRigth("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Up left movement logic
                        Upleft("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Down left movement logic
                        Downleft("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                    }
                    //White king move logic
                    else if (PCache.Tag == WKing.Tag)
                    {
                        Unit = "White king";

                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        //Down move logic
                        KDown("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Up move logic
                        KUp("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Side logic rigth
                        KSideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Side logic left
                        KSideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Down rigth movement logic
                        KDownRigth("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Up rigth movement logic
                        KUpRigth("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Up left movement logic
                        KUpLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Down left movement logic
                        KDownLeft("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                    }
                    //Black king move logic
                    else if (PCache.Tag == BKing.Tag)
                    {
                        Unit = "Black king";

                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        //Down move logic
                        KDown("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Up move logic
                        KUp("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Side logic rigth
                        KSideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Side logic left
                        KSideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Down rigth movement logic
                        KDownRigth("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Up rigth movement logic
                        KUpRigth("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Up left movement logic
                        KUpLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Down left movement logic
                        KDownLeft("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                    }
                    //White queen move logic
                    else if (PCache.Tag == WQueen.Tag)
                    {
                        Unit = "White queen";

                        Math = (sender as PictureBox).Name;
                        Math1 = (sender as PictureBox).Name;
                        Calculation = int.Parse(Math.Substring(1, 1));
                        Calculation = Calculation + 1;
                        Result = Math.Substring(0, 1) + Calculation.ToString();
                        PictureBox ReferenceBox = (PictureBox)this.Controls[Result];

                        //Down move logic
                        Down("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Up move logic
                        Up("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Side rigth logic 
                        SideR("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Side left logic 
                        SideL("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Down Rigth logic
                        DownRigth("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Up Rigth logic
                        UpRigth("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Up left logic
                        Upleft("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
                        //Down left logic
                        Downleft("WKnigth", "WQueen", "WTower", "WRook", "WBishop");
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
                        Down("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Up move logic
                        Up("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Side rigth logic 
                        SideR("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Side left logic 
                        SideL("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Down Rigth logic
                        DownRigth("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Up Rigth logic
                        UpRigth("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Up left logic
                        Upleft("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                        //Down left logic
                        Downleft("BKnigth", "BQueen", "BTower", "BRook", "BBishop");
                    }
                    Selected.Text = "Selected slot: " + Move1 + " Selected Unit: " + Unit;
                    if (Turn == 1)
                    {
                        Lock("BKnigth", "BQueen", "BTower", "BRook", "BBishop", true);
                    }
                    else if (Turn == 2)
                    {
                        Lock("WKnigth", "WQueen", "WTower", "WRook", "WBishop", true);
                    }
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

        private void pictureBox65_Click(object sender, EventArgs e)
        {

        }
    }
    }