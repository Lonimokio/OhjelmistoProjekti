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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SName.Text == "Placeholder same")
            {
                MessageBox.Show("That username already exist", "");
            }
        }

        //Submit sign in point
        private void Submit_Click(object sender, EventArgs e)
        {
            if (SName.Text == "Placeholder correc")
            {
                if (SPassword.Text == "Placeholder correcy")
                {

                }
                //If password is incorrect
                else
                {
                    MessageBox.Show("Wrong password try again", "Wrong password");
                }
            }
            //If username is wrong
            else
            {
                MessageBox.Show("That username doesnt exist", "Username not found");
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
