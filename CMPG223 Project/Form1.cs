namespace CMPG223_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assistant_Menu assistant_Menu = new Assistant_Menu(this);
            assistant_Menu.Closed += (s, args) => this.Show();
            assistant_Menu.ShowDialog();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Menu admin_Menu = new Admin_Menu();
            admin_Menu.Closed += (s, args) => this.Show();
            admin_Menu.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
