using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FormTop_games
{
    public partial class Roulette : Form
    {
        public Roulette()
        {
            InitializeComponent();
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

        private void Roulette_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            //Balance checking and showing system here
            var uri = "mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority";
            var client = new MongoClient(uri);

            var db = client.GetDatabase("SignIn");
            var coll = db.GetCollection<BsonDocument>("Users");

            var cursor = from Users in coll.AsQueryable()
                         where Users["Name"] == SignIn.Name1
                         select Users;

            foreach (var document in cursor)
            {
                Money.Items.Add(document.GetElement("Balance").Value);
            }
            Money.SelectedIndex = 0;
            Money1 = int.Parse(Money.Text);
            MoneyCounter.Start();

            Random rnd = new Random();
            int random = rnd.Next(1, 10);
        }

        int i = 1;
        int i2 = 0;
        int Money1;

        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void BR_Click(object sender, EventArgs e)
        {

        }

        private void MoneyCounter_Tick(object sender, EventArgs e)
        {
            if (i <= Money1)
            {
                Balance.Text = i.ToString();
                i++;
            }
            else
            {
                MoneyCounter.Stop();
                Money.Items.Clear();
            }
        }

        private void Money_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Bets()
        {

            Convert.ToInt32(i2);
            if (Chip1.Enabled == false)
            {
                i2 = i2 + 1;
                Convert.ToString(i2);
                Bet.Text = Convert.ToString(i2);
            }
            if (Chip5.Enabled == false)
            {
                i2 = i2 + 5;
                Convert.ToString(i2);
                Bet.Text = Convert.ToString(i2);
            }
            if (Chip10.Enabled == false)
            {
                i2 = i2 + 10;
                Convert.ToString(i2);
                Bet.Text = Convert.ToString(i2);
            }
            if (Chip25.Enabled == false)
            {
                i2 = i2 + 25;
                Convert.ToString(i2);
                Bet.Text = Convert.ToString(i2);
            }
            if (Chip50.Enabled == false)
            {
                i2 = i2 + 50;
                Convert.ToString(i2);
                Bet.Text = Convert.ToString(i2);
            }
            if (Chip100.Enabled == false)
            {
                i2 = i2 + 100;
                Convert.ToString(i2);
                Bet.Text = Convert.ToString(i2);
            }
            if (Chip500.Enabled == false)
            {
                i2 = i2 + 500;
                Convert.ToString(i2);
                Bet.Text = Convert.ToString(i2);
            }
            if (Chip1000.Enabled == false)
            {
                i2 = i2 + 1000;
                Convert.ToString(i2);
                Bet.Text = Convert.ToString(i2);
            }
        }

        private void Chip1_Click(object sender, EventArgs e)
        {
            Chip1.Enabled = false;
            Chip5.Enabled = true;
            Chip10.Enabled = true;
            Chip25.Enabled = true;
            Chip50.Enabled = true;
            Chip100.Enabled = true;
            Chip500.Enabled = true;
            Chip1000.Enabled = true;
            Chip.Text = "1";
        }

        private void Chip5_Click(object sender, EventArgs e)
        {
            Chip1.Enabled = true;
            Chip5.Enabled = false;
            Chip10.Enabled = true;
            Chip25.Enabled = true;
            Chip50.Enabled = true;
            Chip100.Enabled = true;
            Chip500.Enabled = true;
            Chip1000.Enabled = true;
            Chip.Text = "5";
        }

        private void Chip10_Click(object sender, EventArgs e)
        {
            Chip1.Enabled = true;
            Chip5.Enabled = true;
            Chip10.Enabled = false;
            Chip25.Enabled = true;
            Chip50.Enabled = true;
            Chip100.Enabled = true;
            Chip500.Enabled = true;
            Chip1000.Enabled = true;
            Chip.Text = "10";
        }

        private void Chip25_Click(object sender, EventArgs e)
        {
            Chip1.Enabled = true;
            Chip5.Enabled = true;
            Chip10.Enabled = true;
            Chip25.Enabled = false;
            Chip50.Enabled = true;
            Chip100.Enabled = true;
            Chip500.Enabled = true;
            Chip1000.Enabled = true;
            Chip.Text = "25";    
        }

        private void Chip50_Click(object sender, EventArgs e)
        {
            Chip1.Enabled = true;
            Chip5.Enabled = true;
            Chip10.Enabled = true;
            Chip25.Enabled = true;
            Chip50.Enabled = false;
            Chip100.Enabled = true;
            Chip500.Enabled = true;
            Chip1000.Enabled = true;
            Chip.Text = "50";

        }

        private void Chip100_Click(object sender, EventArgs e)
        {
            Chip1.Enabled = true;
            Chip5.Enabled = true;
            Chip10.Enabled = true;
            Chip25.Enabled = true;
            Chip50.Enabled = true;
            Chip100.Enabled = false;
            Chip500.Enabled = true;
            Chip1000.Enabled = true;
            Chip.Text = "100";
        }

        private void Chip500_Click(object sender, EventArgs e)
        {
            Chip1.Enabled = true;
            Chip5.Enabled = true;
            Chip10.Enabled = true;
            Chip25.Enabled = true;
            Chip50.Enabled = true;
            Chip100.Enabled = true;
            Chip500.Enabled = false;
            Chip1000.Enabled = true;
            Chip.Text = "500";
        }

        private void Chip1000_Click(object sender, EventArgs e)
        {
            Chip1.Enabled = true;
            Chip5.Enabled = true;
            Chip10.Enabled = true;
            Chip25.Enabled = true;
            Chip50.Enabled = true;
            Chip100.Enabled = true;
            Chip500.Enabled = true;
            Chip1000.Enabled = false;
            Chip.Text = "1000";
        }

        private void B00_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if(B00.Text == "00")
            {
               i3 = 0;
            }

            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B00.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B00.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B00.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B00.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B00.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B00.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B00.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B00.Text = "00, " + i3 + "e";
            }
        }

        private void B0_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B0.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B0.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B0.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B0.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B0.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B0.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B0.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B0.Text = "00, " + i3 + "e";
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
           Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B1.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B1.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B1.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B1.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B1.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B1.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B1.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B1.Text = "00, " + i3 + "e";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B2.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B2.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B2.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B2.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B2.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B2.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B2.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B2.Text = "00, " + i3 + "e";
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B3.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B3.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B3.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B3.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B3.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B3.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B3.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B3.Text = "00, " + i3 + "e";
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B4.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B4.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B4.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B4.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B4.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B4.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B4.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B4.Text = "00, " + i3 + "e";
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B5.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B5.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B5.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B5.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B5.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B5.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B5.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B5.Text = "00, " + i3 + "e";
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B6.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B6.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B6.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B6.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B6.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B6.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B6.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B6.Text = "00, " + i3 + "e";
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B7.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B7.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B7.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B7.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B7.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B7.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B7.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B7.Text = "00, " + i3 + "e";
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B8.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B8.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B8.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B8.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B8.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B8.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B8.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B8.Text = "00, " + i3 + "e";
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B9.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B9.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B9.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B9.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B9.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B9.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B9.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B9.Text = "00, " + i3 + "e";
            }
        }

        private void B10_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B10.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B10.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B10.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B10.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B10.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B10.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B10.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B10.Text = "00, " + i3 + "e";
            }
        }

        private void B11_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B11.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B11.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B11.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B11.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B11.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B11.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B11.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B11.Text = "00, " + i3 + "e";
            }
        }

        private void B12_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B12.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B12.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B12.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B12.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B12.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B12.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B12.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B12.Text = "00, " + i3 + "e";
            }
        }

        private void B13_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B13.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B13.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B13.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B13.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B13.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B13.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B13.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B13.Text = "00, " + i3 + "e";
            }
        }

        private void B14_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B14.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B14.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B14.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B14.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B14.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B14.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B14.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B14.Text = "00, " + i3 + "e";
            }
        }

        private void B15_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B15.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B15.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B15.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B15.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B15.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B15.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B15.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B15.Text = "00, " + i3 + "e";
            }
        }

        private void B16_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B16.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B16.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B16.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B16.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B16.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B16.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B16.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B16.Text = "00, " + i3 + "e";
            }
        }

        private void B17_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B17.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B17.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B17.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B17.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B17.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B17.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B17.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B17.Text = "00, " + i3 + "e";
            }
        }

        private void B18_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B18.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B18.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B18.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B18.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B18.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B18.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B18.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B18.Text = "00, " + i3 + "e";
            }
        }

        private void B19_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B19.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B19.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B19.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B19.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B19.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B19.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B19.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B19.Text = "00, " + i3 + "e";
            }
        }

        private void B20_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B20.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B20.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B20.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B20.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B20.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B20.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B20.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B20.Text = "00, " + i3 + "e";
            }
        }

        private void B21_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B21.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B21.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B21.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B21.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B21.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B21.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B21.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B21.Text = "00, " + i3 + "e";
            }
        }

        private void B22_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B22.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B22.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B22.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B22.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B22.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B22.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B22.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B22.Text = "00, " + i3 + "e";
            }
        }

        private void B23_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B23.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B23.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B23.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B23.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B23.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B23.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B23.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B23.Text = "00, " + i3 + "e";
            }
        }

        private void B24_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B24.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B24.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B24.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B24.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B24.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B24.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B24.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B24.Text = "00, " + i3 + "e";
            }
        }

        private void B25_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B25.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B25.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B25.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B25.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B25.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B25.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B25.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B25.Text = "00, " + i3 + "e";
            }
        }

        private void B26_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B26.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B26.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B26.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B26.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B26.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B26.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B26.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B26.Text = "00, " + i3 + "e";
            }
        }

        private void B27_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B27.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B27.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B27.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B27.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B27.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B27.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B27.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B27.Text = "00, " + i3 + "e";
            }
        }

        private void B28_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B28.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B28.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B28.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B28.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B28.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B28.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B28.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B28.Text = "00, " + i3 + "e";
            }
        }

        private void B29_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B29.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B29.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B29.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B29.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B29.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B29.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B29.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B29.Text = "00, " + i3 + "e";
            }
        }

        private void B30_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B30.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B30.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B30.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B30.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B30.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B30.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B30.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B30.Text = "00, " + i3 + "e";
            }
        }

        private void B31_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B31.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B31.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B31.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B31.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B31.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B31.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B31.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B31.Text = "00, " + i3 + "e";
            }
        }

        private void B32_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B32.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B32.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B32.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B32.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B32.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B32.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B32.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B32.Text = "00, " + i3 + "e";
            }
        }

        private void B33_Click(object sender, EventArgs e)
        {
            Bets();
                        int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B33.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B33.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B33.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B33.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B33.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B33.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B33.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B33.Text = "00, " + i3 + "e";
            }
        }

        private void B34_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B34.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B34.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B34.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B34.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B34.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B34.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B34.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B34.Text = "00, " + i3 + "e";
            }
        }

        private void B35_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B35.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B35.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B35.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B35.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B35.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B35.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B35.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B35.Text = "00, " + i3 + "e";
            }
        }

        private void B36_Click(object sender, EventArgs e)
        {
            Bets();
            int i3 = 0;
            if (Chip1.Enabled == false)
            {
                i3 = i3 + 1;
                B36.Text = "00, " + i3 + "e";
            }
            if (Chip5.Enabled == false)
            {
                i3 = i3 + 5;
                B36.Text = "00, " + i3 + "e";
            }
            if (Chip10.Enabled == false)
            {
                i3 = i3 + 10;
                B36.Text = "00, " + i3 + "e";
            }
            if (Chip25.Enabled == false)
            {
                i3 = i3 + 25;
                B36.Text = "00, " + i3 + "e";
            }
            if (Chip50.Enabled == false)
            {
                i3 = i3 + 50;
                B36.Text = "00, " + i3 + "e";
            }
            if (Chip100.Enabled == false)
            {
                i3 = i3 + 100;
                B36.Text = "00, " + i3 + "e";
            }
            if (Chip500.Enabled == false)
            {
                i3 = i3 + 500;
                B36.Text = "00, " + i3 + "e";
            }
            if (Chip1000.Enabled == false)
            {
                i3 = i3 + 1000;
                B36.Text = "00, " + i3 + "e";
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            i2 = 0;
            Bet.Text = "0";
        }

        private void MainLobby_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main frm2 = new Main();
            frm2.ShowDialog();
        }

        private void TableTop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Casino frm2 = new Casino();
            frm2.ShowDialog();
        }

        private void R36_Click(object sender, EventArgs e)
        {

        }
    }
}
