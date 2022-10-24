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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        //Variables stored here
        int Attempt = 3;
        int id = 0;
        public static string Name1 = "";
        public static string ID1 = "";
        public static string Password1 = "";
        //Variables above here
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Account creation. First we check if username already exists. Then we get an unigue id and create the account.
        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < View2.Items.Count; i++)
            {
                View2.SelectedIndex = i;
                if (SName.Text == View2.Text)
                {
                    break;
                }
            }
            if (SName.Text == View2.Text)
            {
                MessageBox.Show("Username " + View2.Text + " already exist", "Error: Username");
            }
            else
            {
                var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority&authSource=SignIn");
                settings.ServerApi = new ServerApi(ServerApiVersion.V1);
                var client = new MongoClient(settings); var database = client.GetDatabase("SignIn");
                var coll = database.GetCollection<BsonDocument>("Users");
                var Search = coll.Find(new BsonDocument()).Project(Builders<BsonDocument>.Projection.Include("Name").Include("Password").Include("Balance")).ToList();
                foreach (var OneDocument in Search)
                {
                    TestID.Items.Add(OneDocument.GetElement("_id").Value);
                }
                TestID.SelectedIndex = 0;
                int Length = TestID.Items.Count;
                Length = Length - 1;
                TestID.SelectedIndex = Length;
                id = int.Parse(TestID.Text);
                id = id + 1;

                //Take the values from CName and CPassword and adds them to database
                String name = CName.Text;
                String Password = CPassword.Text;
                int Balance = 500;
                var fil = Builders<BsonDocument>.Filter.Eq("_id", id);
                var filteredDocument = coll.Find(fil).FirstOrDefault();

                if (filteredDocument == null)
                {
                    var newDoc = new BsonDocument { { "_id", id }, { "Name", name }, { "Password", Password }, { "Balance", Balance } };
                    coll.InsertOne(newDoc);
                    MessageBox.Show("Created account succesfully!", "Account created");
                }
                else 
                {
                    MessageBox.Show("ID already exists!");
                }
            }
        }

        //Submit sign in point checking if username exists
        private void Submit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < View2.Items.Count; i++)
            {
                View2.SelectedIndex = i;
                if (SName.Text == View2.Text)
                {
                    break;
                }
            }
                     //If password is correct
                    if (SName.Text == View2.Text)
                    {
                        View3.SelectedIndex = View2.SelectedIndex;
                        if (SPassword.Text == View3.Text)
                        {
                            Name1 = SName.Text;
                            ID1 = id.ToString();
                            Password1 = SPassword.Text;
                            this.Hide();
                            System.Windows.Forms.MessageBox.Show("Welcome " +View2.Text, "Welcome");
                            Main frm2 = new Main();
                            frm2.ShowDialog();
                        }
                        //If password is incorrect
                        else
                        {
                            Attempt = Attempt - 1;
                            System.Windows.Forms.MessageBox.Show("Incorrect Password " + Attempt + " attempts left");
                            if (Attempt == 0)
                            {
                            System.Windows.Forms.MessageBox.Show("Too many failed attempts. Exiting");
                            System.Windows.Forms.Application.Exit();
                            }
                        }
                    }
                    //If username is wrong
                    else
                    {
                    MessageBox.Show("Username "+SName.Text +" doesnt exist", "Username not found");
                    }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/authdb?serverSelectionTimeoutMS=30000&connectTimeoutMS=30000&socketTimeoutMS=30000&authSource=SignIn");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("SignIn");
            var coll = database.GetCollection<BsonDocument>("Users");
            var Search = coll.Find(new BsonDocument()).Project(Builders<BsonDocument>.Projection.Include("Name").Include("Password")).ToList();
            foreach (var OneDocument in Search)
            {
                View2.Items.Add(OneDocument.GetElement("Name").Value);
                View3.Items.Add(OneDocument.GetElement("Password").Value);
            }
            View2.SelectedIndex = 0;
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

        private void CPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }