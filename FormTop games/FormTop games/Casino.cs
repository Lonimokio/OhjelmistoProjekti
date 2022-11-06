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
    public partial class Casino : Form
    {
        public Casino()
        {
            InitializeComponent();
        }

        //Variable below here
        int i = 1;
        int Money1;
        //Variables abowe here

        //Button to send you back to main lobby
        private void Lobby_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main frm2 = new Main();
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

        private void Casino_Load(object sender, EventArgs e)
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

        private void Balance_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
