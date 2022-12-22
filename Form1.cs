namespace Kasir
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.ShowDialog();
        }
    }
}