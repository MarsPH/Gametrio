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
    public partial class HowToPlay : Form
    {


        public HowToPlay()
        {
            InitializeComponent();
            label2.Hide();
            pictureBox1.Visible = false;
        }

        private void Howtoplay_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Son_of_Duo.Quickgame.SoundManager.PlayButtonSound();
            this.Close();
            menu menu = new menu();
            menu.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Son_of_Duo.Quickgame.SoundManager.PlayButtonSound();
            label2.Show();
            pictureBox1.Visible = true;
            label2.Text = "MATCH MADNESS IS A GAME WHERE THERE WILL BE 16 TILES AND PLAYER WILL HAVE TO MATCH THE CORRECT TILES BY THE READING THE WORDS ON THE TILES";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Son_of_Duo.Quickgame.SoundManager.PlayButtonSound();
            label2.Show();
            pictureBox1.Visible = true;
            label2.Text = "PLAYER WILL BE ASKED DIFFERENT QUESTION WITH ONE MISSING WORD IN BETWEEN AND PLAYER WILL HAVE TO ANSWER IT CORRECTLY IN ORDER TO WIN THE GAME";
        }

      
    }
}
