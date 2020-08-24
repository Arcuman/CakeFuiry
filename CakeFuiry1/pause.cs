using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeFuiry1
{
    public partial class pause : Form
    {
        public pause()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
