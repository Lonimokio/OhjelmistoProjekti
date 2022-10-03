using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTop_games
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //Picturebox are missing pictures of these things. They will be added later

        //Button to send you to the casino
        private void Casino_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.MessageBox.Show("Welcome to the casino. Remember to gamble responsibly");
            Casino frm2 = new Casino();
            frm2.ShowDialog();
        }

        //Button to send you to simple games form
        private void SimpleGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.MessageBox.Show("Welcome to simple games, a collection of simple games like tic tac toe");
            SimpleGames frm2 = new SimpleGames();
            frm2.ShowDialog();
        }

        //Button to send you to Table top form
        private void TableTopB_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.MessageBox.Show("Welcome to table top games. Here you will find classical tabletop games");
            Table_Top frm2 = new Table_Top();
            frm2.ShowDialog();
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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
    }
}
