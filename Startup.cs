using System;
using System.Windows.Forms;

namespace RussianRouletteGame
{
    public partial class Startup : Form

    {
        public Startup()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {

        }

        //Play Function
        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game f1 = new Game();
            f1.Show();
            this.Visible = false;
            
        }

        //Exit function
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Kill process
            Application.Exit();
        }

        //This function triggers a new form
        private void Button1_Click(object sender, EventArgs e)
        {
            InstructClass instruct = new InstructClass();
            instruct.Show();
        }
    }
}
