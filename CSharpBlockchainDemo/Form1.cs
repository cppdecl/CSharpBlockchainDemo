using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBlockchainDemo
{
    public partial class Form1 : Form
    {
        public Form parentForm;
        public int nodeID;

        public Form1(Form parent, int id)
        {
            parentForm = parent;
            nodeID = id;

            InitializeComponent();

            this.Text = "Node " + id.ToString();

        }
    }
}
