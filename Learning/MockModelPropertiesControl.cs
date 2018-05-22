using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning
{
    public partial class MockModelPropertiesControl : UserControl, ModelPropertiesControl
    {
        public MockModelPropertiesControl()
        {
            InitializeComponent();
        }

        public Model GenerateModel(string name)
        {
            return new MockModel(name);
        }

        public void Populate(Model model)
        {

        }
    }
}
