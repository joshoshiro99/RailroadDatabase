using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railroad
{
    public partial class Form_Request : Form
    {
        public Form_Request()
        {
            InitializeComponent();
            textBoxCustomer.Focus();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCustomer.Clear();
            textBoxCustomerID.Clear();
            textBoxRailcar.Clear();
            comboBoxRailcarType.Text = "";
            textBoxCustomer.Focus();
        }
    }
}
