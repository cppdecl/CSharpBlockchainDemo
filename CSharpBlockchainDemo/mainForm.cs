namespace CSharpBlockchainDemo
{
    public partial class mainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public List<Tuple<int, Form>> nodes = new List<Tuple<int, Form>>();
        public int currentNodeID = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(this, currentNodeID);
            form.Show();

            nodes.Add(new Tuple<int, Form>(currentNodeID++, form));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            foreach (var node in nodes)
            {
                comboBox1.Items.Add("Node " + node.Item1.ToString());
            }
        }
    }
}