namespace fongy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
            if (e.KeyCode == Keys.F11)
            {
                WindowState = FormWindowState.Maximized;
                TopMost = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            
        }
            
    }
}