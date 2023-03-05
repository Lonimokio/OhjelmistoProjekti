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
    public partial class Slot : Form
    {



        int i = 1;
        int i2 = 0;
        int id;
        int Money1;

        private void Slot_Load(object sender, EventArgs e)
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




        public Slot()
        {
            InitializeComponent();
        }


        public void Random1()
        {

            Random rnd = new Random();
            int random = rnd.Next(1, 11);

            if (random <= 2)
            {
                if (Slot1.Image == Slotbar.Image)
                {
                    Slot1.Image = Slotheart.Image;
                }

                else
                {
                    Slot1.Image = Slotbar.Image;
                }
            }

            if (random == 3 || random == 4)
            {
                if (Slot1.Image == Slotheart.Image)
                {
                    Slot1.Image = Sloticon.Image;
                }

                else
                {
                    Slot1.Image = Slotheart.Image;
                }
            }

            if (random == 5 || random == 6 || random == 7)
            {

                if (Slot1.Image == Sloticon.Image)
                {
                    Slot1.Image = Slotdiamond.Image;
                }

                else
                {
                    Slot1.Image = Sloticon.Image;
                }
            }

            if (random == 8)
            {

                if (Slot1.Image == Slotdiamond.Image)
                {
                    Slot1.Image = Slotcherry.Image;
                }

                else
                {
                    Slot1.Image = Slotdiamond.Image;
                }
            }

            if (random >= 9)
            {

                if (Slot1.Image == Slotcherry.Image)
                {
                    Slot1.Image = Slotbar.Image;
                }

                else
                {
                    Slot1.Image = Slotcherry.Image;
                }
            }

            random = 0;
        }

        public void Random2()
        {

            Random rnd = new Random();
            int random = rnd.Next(1, 11);

            if (random <= 2)
            {
                if (Slot2.Image == Slotbar.Image)
                {
                    Slot2.Image = Slotheart.Image;
                }

                else
                {
                    Slot2.Image = Slotbar.Image;
                }
            }

            if (random == 3 || random == 4)
            {
                if (Slot2.Image == Slotheart.Image)
                {
                    Slot2.Image = Sloticon.Image;
                }

                else
                {
                    Slot2.Image = Slotheart.Image;
                }
            }

            if (random == 5 || random == 6 || random == 7)
            {

                if (Slot2.Image == Sloticon.Image)
                {
                    Slot2.Image = Slotdiamond.Image;
                }

                else
                {
                    Slot2.Image = Sloticon.Image;
                }
            }

            if (random == 8)
            {

                if (Slot2.Image == Slotdiamond.Image)
                {
                    Slot2.Image = Slotcherry.Image;
                }

                else
                {
                    Slot2.Image = Slotdiamond.Image;
                }
            }

            if (random >= 9)
            {

                if (Slot2.Image == Slotcherry.Image)
                {
                    Slot2.Image = Slotbar.Image;
                }

                else
                {
                    Slot2.Image = Slotcherry.Image;
                }
            }

            random = 0;
        }

        public void Random3()
        {

            Random rnd = new Random();
            int random = rnd.Next(1, 11);

            if (random <= 2)
            {
                if (Slot3.Image == Slotbar.Image)
                {
                    Slot3.Image = Slotheart.Image;
                }

                else
                {
                    Slot3.Image = Slotbar.Image;
                }
            }

            if (random == 3 || random == 4)
            {
                if (Slot3.Image == Slotheart.Image)
                {
                    Slot3.Image = Sloticon.Image;
                }

                else
                {
                    Slot3.Image = Slotheart.Image;
                }
            }

            if (random == 5 || random == 6 || random == 7)
            {

                if (Slot3.Image == Sloticon.Image)
                {
                    Slot3.Image = Slotdiamond.Image;
                }

                else
                {
                    Slot3.Image = Sloticon.Image;
                }
            }

            if (random == 8)
            {

                if (Slot3.Image == Slotdiamond.Image)
                {
                    Slot3.Image = Slotcherry.Image;
                }

                else
                {
                    Slot3.Image = Slotdiamond.Image;
                }
            }

            if (random >= 9)
            {

                if (Slot3.Image == Slotcherry.Image)
                {
                    Slot3.Image = Slotbar.Image;
                }

                else
                {
                    Slot3.Image = Slotcherry.Image;
                }
            }

            random = 0;
        }

        public void Win()
        {
            Winn.Value = 0;

            if (Slot1.Image == Slot2.Image)
            {

                if (Slot1.Image == Slot3.Image)
                {

                    if (Slot1.Image == Sloticon.Image)
                    {
                        Totalbet.Value = Totalbet.Value * 3;
                        Winn.Value = Winn.Value + Totalbet.Value;
                        MessageBox.Show("You Won " + Totalbet.Value);
                    }

                    if (Slot1.Image == Slotheart.Image)
                    {
                        Totalbet.Value = Totalbet.Value * 6;
                        Winn.Value = Winn.Value + Totalbet.Value;
                        MessageBox.Show("You Won " + Totalbet.Value);
                    }

                    if (Slot1.Image == Slotdiamond.Image)
                    {
                        Totalbet.Value = Totalbet.Value * 15;
                        Winn.Value = Winn.Value + Totalbet.Value;
                        MessageBox.Show("You Won " + Totalbet.Value);
                    }

                    if (Slot1.Image == Slotcherry.Image)
                    {
                        Totalbet.Value = Totalbet.Value * 8;
                        Winn.Value = Winn.Value + Totalbet.Value;
                        MessageBox.Show("You Won " + Totalbet.Value);
                    }
                    if (Slot1.Image == Slotbar.Image)
                    {
                        Totalbet.Value = Totalbet.Value * 4;
                        Winn.Value = Winn.Value + Totalbet.Value;
                        MessageBox.Show("You Won " + Totalbet.Value);
                    }
                }


                else
                {
                    if (Slot1.Image == Sloticon.Image)
                    {
                        Totalbet.Value = Totalbet.Value * 2;
                        Winn.Value = Winn.Value + Totalbet.Value;
                        MessageBox.Show("You Won " + Totalbet.Value);
                    }

                    if (Slot1.Image == Slotheart.Image)
                    {
                        Totalbet.Value = Totalbet.Value * 4;
                        Winn.Value = Winn.Value + Totalbet.Value;
                        MessageBox.Show("You Won " + Totalbet.Value);
                    }

                    if (Slot1.Image == Slotdiamond.Image)
                    {
                        Totalbet.Value = Totalbet.Value * 8;
                        Winn.Value = Winn.Value + Totalbet.Value;
                        MessageBox.Show("You Won " + Totalbet.Value);
                    }

                    if (Slot1.Image == Slotcherry.Image)
                    {
                        Totalbet.Value = Totalbet.Value * 3;
                        Winn.Value = Winn.Value + Totalbet.Value;
                        MessageBox.Show("You Won " + Totalbet.Value);
                    }
                    if (Slot1.Image == Slotbar.Image)
                    {
                        Totalbet.Value = Totalbet.Value * 2;
                        Winn.Value = Winn.Value + Totalbet.Value;
                        MessageBox.Show("You Won " + Totalbet.Value);
                    }

                }

            }

            else
            {
                MessageBox.Show("No Win");
            }

            Balance.Text = (Winn.Value + int.Parse(Balance.Text)).ToString();

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


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Spin_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Spin.Enabled = false;
            Bet.Enabled = false;
            Add1.Enabled = false;
            Add10.Enabled = false;
            Add50.Enabled = false;


            Balance.Text = (int.Parse(Balance.Text) - Totalbet.Value).ToString();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Add1_Click(object sender, EventArgs e)
        {
            Betting.Value = Betting.Value + 1;
        }

        private void Add10_Click(object sender, EventArgs e)
        {
            Betting.Value = Betting.Value + 10;
        }

        private void Add50_Click(object sender, EventArgs e)
        {
            Betting.Value = Betting.Value + 50;
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

        private void timer1_Tick(object sender, EventArgs e)
        {

            i2 = i2 + 1;

            if(i2 < 9)
            {
                timer1.Enabled = false;
                timer1.Enabled = true;

                Random1();
            }

            if (i2 > 9)
            {
                i2 = 0;

                Random1();

                timer1.Enabled = false;

                timer2.Enabled = true;

            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            i2 = i2 + 1;

            if (i2 < 9)
            {
                timer2.Enabled = false;
                timer2.Enabled = true;

                Random2();

            }

            if (i2 > 9)
            {
                timer2.Enabled = false;

                i2 = 0;

                if (Slot1.Image == Slot2.Image)
                {
                    Random2();

                    timer4.Enabled = true;
                }

                else
                {
                    Random2();

                    timer3.Enabled = true;
                }

            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            i2 = i2 + 1;

            if (i2 < 9)
            {
                timer3.Enabled = false;
                timer3.Enabled = true;

                Random3();
            }

            if (i2 > 9)
            {
                Random3();

                timer3.Enabled = false;

                i2 = 0;

                Win();

                Add1.Enabled = true;
                Add10.Enabled = true;
                Add50.Enabled = true;
                Bet.Enabled = true;
                Totalbet.Value = 0;
                Betting.Value = 0;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            i2 = i2 + 1;

            if (i2 < 14)
            {
                timer4.Enabled = false;
                timer4.Enabled = true;

                Random3();

            }

            if (i2 > 14)
            {
                Random3();

                i2 = 0;

                timer4.Enabled = false;

                Win();

                Add1.Enabled = true;
                Add10.Enabled = true;
                Add50.Enabled = true;
                Bet.Enabled = true;
                Totalbet.Value = 0;
                Betting.Value = 0;
            }
        }

        private void Bet_Click(object sender, EventArgs e)
        {

            if (int.Parse(Balance.Text) < Totalbet.Value || int.Parse(Balance.Text) <= 0)
            {
                MessageBox.Show("Ei ole tarpeeksi rahaa");
            }

            else
            {
                Spin.Enabled = true;
                Totalbet.Value = Totalbet.Value + Betting.Value;
                MessageBox.Show("You Bet " + Betting.Value);
                Betting.Value = 0;
            }
        }

        private void Balance_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Totalbet.Value = 0;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            SlotHelp frm3 = new SlotHelp();
            frm3.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Casino frm3 = new Casino();
            frm3.ShowDialog();
        }
    }
}
