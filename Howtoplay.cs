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
        }

        private void Howtoplay_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu menu = new menu();
            menu.Show();
        }
    }
}
