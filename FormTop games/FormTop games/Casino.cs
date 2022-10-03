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
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("SignIn");
            var coll = database.GetCollection<BsonDocument>("Users");
            var Search = coll.Find(new BsonDocument()).Project(Builders<BsonDocument>.Projection.Include("Balance")).ToList();
            var filter = Builders<BsonDocument>.Filter.Eq("Parameters.Value", Searching);
            var query = coll.Find(filter);
            foreach (var result in query.ToList())
            {
                Console.WriteLine(result);
            }
        }

        private void Balance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
