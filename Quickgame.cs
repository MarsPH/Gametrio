using Son_of_Duo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Son_of_Duo
{
    public partial class Quickgame : Form
    {
        public Quickgame()
        {
            InitializeComponent();
           
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "patrick")
            {

                label1.Text = "Correct \n So, i think you are here to pratice French,\n oh I mean francaise";
                textBox1.Text = "";
                button2.Visible = false;
                button7.Visible = true;




            }
            else if (textBox1.Text.ToLower() != "patrick")
            {
                label1.Text = "I am Patrick , you dumb creature \n write it so you dont forget again";
                textBox1.Text = "";
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            game1 obj = new game1();
            obj.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {this.Hide();
            FillBlanks gaame = new FillBlanks();
            gaame.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.ToLower() == "oui") || (textBox1.Text.ToLower() == "yes"))
            {
                label1.Text = "Thats some dedication, Select a game to continue";
                textBox1.Text = "";
                button7.Hide();
                textBox1.Hide();
               
                button5.Visible = true;
                button6.Visible = true;


            }
            else if ((textBox1.Text.ToLower() == "non") || (textBox1.Text.ToLower() == "no"))
            {
                label1.Text = "This game will close now .... you dont want to learn french";
                Thread.Sleep(3000);
                this.Close();

            }
            else
            {
                label1.Text = "i dont understand";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}