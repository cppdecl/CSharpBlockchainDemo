namespace CSharpBlockchainDemo
{
    public partial class mainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public mainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mainPanel_Enter(object sender, EventArgs e)
        { 
            this.BackColor = Color.FromArgb(255, 113, 96, 232);
        }

        private void mainPanel_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 31, 31, 31);
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 113, 96, 232);
        }

        private void mainForm_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 31, 31, 31);           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}