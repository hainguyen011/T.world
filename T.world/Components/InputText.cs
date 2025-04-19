using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.world.common
{
    public partial class InputText: UserControl
    {
        public InputText()
        {
            InitializeComponent();
        }

        private void InputText_Load(object sender, EventArgs e)
        {
            this.InputText_title.Text = "Title";
            this.InputText_message.Text = "Error message";
        }
    }
}
