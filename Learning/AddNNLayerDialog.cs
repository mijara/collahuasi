using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning
{
    public partial class AddNNLayerDialog : Form
    {
        public int NNSize { get; private set; }

        public AddNNLayerDialog()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NNSize = (int)nnSizeTextBox.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddNNLayerDialog_Load(object sender, EventArgs e)
        {
            AcceptButton = addButton;
            ActiveControl = nnSizeTextBox;
        }

        private void addNNLayerDialog_Shown(object sender, EventArgs e)
        {
            nnSizeTextBox.Select(0, nnSizeTextBox.Text.Length);
        }
    }
}
