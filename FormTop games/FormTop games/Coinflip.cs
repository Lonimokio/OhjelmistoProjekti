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
    public partial class Coinflip : Form
    {

        int i = 1;
        int i2 = 0;
        int Money1;

        private void Coinflip_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Welcome to the casino. Remember to gamble responsibly");

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

        public void Winnings()
        {
            Balance.Text = (Win.Value + int.Parse(Balance.Text)).ToString();

            Name = SignIn.Name1;
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1); var client = new MongoClient(settings);
            var database = client.GetDatabase("SignIn");
            var coll = database.GetCollection<BsonDocument>("Users");
            int Balance2 = int.Parse(Balance.Text);
            var fil1 = Builders<BsonDocument>.Filter.Eq("Name", Name);
            var filteredDocument = coll.Find(fil1).FirstOrDefault();
            if (filteredDocument == null)
            {
                MessageBox.Show("ID not found!");
            }
            else
            {
                var fil = Builders<BsonDocument>.Filter.Eq("Name", Name);
                var update = Builders<BsonDocument>.Update.Set("Balance", Balance2);
                coll.UpdateOne(fil, update);
            }

        }

        public void Losings()
        {
            Balance.Text = (int.Parse(Balance.Text) - ShowBet.Value).ToString();

            Name = SignIn.Name1;
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1); var client = new MongoClient(settings);
            var database = client.GetDatabase("SignIn");
            var coll = database.GetCollection<BsonDocument>("Users");
            int Balance2 = int.Parse(Balance.Text);
            var fil1 = Builders<BsonDocument>.Filter.Eq("Name", Name);
            var filteredDocument = coll.Find(fil1).FirstOrDefault();
            if (filteredDocument == null)
            {
                MessageBox.Show("ID not found!");
            }
            else
            {
                var fil = Builders<BsonDocument>.Filter.Eq("Name", Name);
                var update = Builders<BsonDocument>.Update.Set("Balance", Balance2);
                coll.UpdateOne(fil, update);
            }

        }

        public Coinflip()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PlaceBet_Click(object sender, EventArgs e)
        {
            if (Bet.Value > 0)
            {
                ShowBet.Value = Bet.Value;
                PlaceBet.Enabled = false;
                Tailss.Enabled = true;
                Headss.Enabled = true;
            }

            if(Bet.Value <= 0)
            {
                MessageBox.Show("Bet Must Be 1 Or Higher");
            }
        }

        private void Flip_Click(object sender, EventArgs e)
        {
            Losings();

            Random rnd = new Random();
            int random = rnd.Next(1, 3);
            if (Bet.Value > 0)
            {
                if (random == 1)
                {
                    Coins.Image = CoinH.Image;
                    MessageBox.Show("Heads");

                    if(Choice.Text == "Heads")
                    {
                        Win.Value = Win.Value * 2;
                        Winnings();
                    }
                }

                else if (random == 2)
                {
                    Coins.Image = CoinT.Image;
                    MessageBox.Show("Tails");

                    if (Choice.Text == "Tails")
                    {
                        Win.Value = Win.Value * 2;
                        Winnings();
                    }
                }




                Headss.Enabled = false;
                Tailss.Enabled = false;
            }

            if (Bet.Value <= 0)
            {
                MessageBox.Show("Please Put A Bet");
            }

            Flip.Enabled = true;
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

        private void Balance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tailss_Click(object sender, EventArgs e)
        {
            Choice.Text = "Tails";
            Flip.Enabled = true;
            Headss.Enabled = true;
            Tailss.Enabled = false;
        }

        private void Headss_Click(object sender, EventArgs e)
        {
            Choice.Text = "Heads";
            Flip.Enabled = true;
            Headss.Enabled = false;
            Tailss.Enabled = true;
        }
    }
}
