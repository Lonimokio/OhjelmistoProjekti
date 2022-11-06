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

        private void Roulette_Load(object sender, EventArgs e)
        {

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
        }

        private void B0_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B5_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B6_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B7_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B8_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B9_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B10_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B11_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B12_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B13_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B14_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B15_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B16_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B17_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B18_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B19_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B20_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B21_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B22_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B23_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B24_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B25_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B26_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B27_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B28_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B29_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B30_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B31_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B32_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B33_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B34_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B35_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void B36_Click(object sender, EventArgs e)
        {
            Bets();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            i2 = 0;
            Bet.Text = "0";
        }
    }
}
