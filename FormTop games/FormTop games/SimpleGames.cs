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
    public partial class SimpleGames : Form
    {
        public SimpleGames()
        {
            InitializeComponent();
        }

        //Button sends you back to main lobby
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

        private void SimpleGames_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Welcome to simple games, a collection of simple games like tic tac toe");
        }
    }
}
