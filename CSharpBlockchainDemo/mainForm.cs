using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CSharpBlockchainDemo
{
    public partial class mainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public List<Tuple<int, Form1>> nodes = new List<Tuple<int, Form1>>();
        public int currentNodeID = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(this, currentNodeID);
            form.Show();

            nodes.Add(new Tuple<int, Form1>(currentNodeID++, form));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedNodeText = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (this.comboBox1.SelectedItem == null)
                return;

            if (selectedNodeText == null)
                return;

            int selectedNode = 0;
            
            if (!Int32.TryParse(selectedNodeText, out selectedNode))
                return;

            foreach (var node in nodes)
            {
                if (node.Item1 == selectedNode)
                {
                    node.Item2.SetNewIncomingData(richTextBox1.Text);
                }
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            foreach (var node in nodes)
            {
                comboBox1.Items.Add(node.Item1.ToString());
            }
        }
    }
}