namespace modul03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            String button = textBox1.Text;
            label1.Text = "Halo " + button;
        }
    }
}
