namespace Son_of_Duo;

public partial class menu : Form
{


    public menu()
    {
        InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e)
    {


    }

    private void button1_Click(object sender, EventArgs e)
    {
        var confirmResult = MessageBox.Show("Do you really want to Exit ??",
                                     "Exit the Game !",
                                     MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
        {
            this.Close();
        }
        else
        {
            
        }
        

    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void StoryMode_Click(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
        HowToPlay htp = new HowToPlay();

        htp.Show();
        this.Hide();

    }

    private void button3_Click(object sender, EventArgs e)
    {
        Settings st = new Settings();
        st.Show();
        this.Hide();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Quickgame qc= new Quickgame();
        qc.Show();
        this.Hide();
    }
}
