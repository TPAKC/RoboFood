using System;
using System.Windows.Forms;

namespace RoboFood
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void GoToWaiter(object sender, EventArgs e)
        {
            Waiter newForm = new Waiter();
            newForm.Show();
        }

        private void GoToMenu(object sender, EventArgs e)
        {
            Restauraunt_menu newForm = new Restauraunt_menu();
            newForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Title_Click(object sender, EventArgs e)
        {
            About newForm = new About();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Analysis newForm = new Analysis();
            newForm.Show();
        }
    }
}
