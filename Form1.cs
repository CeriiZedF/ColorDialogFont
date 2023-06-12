namespace ColorDialo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = new ColorDialog();
            temp.ShowDialog();
            this.BackColor = temp.Color;
        }
    }
}