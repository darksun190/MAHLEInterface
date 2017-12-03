using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAHLEInterface
{
    public partial class textbox : UserControl
    {
        public textbox()
        {
            InitializeComponent();
        }
        [Browsable(true), Category("TEST")]
        public string LabelName
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
    }
}
