using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoodleStore
{
    public partial class FormUpdateCustomer : Form
    {
        

        public FormUpdateCustomer()
        {
            InitializeComponent();
            
        }

        private void createCustomer()
        {
            groupBoxCustomerDetails.Enabled = true;
            buttonDelete.Enabled = false;
        }

        private void clearAllText()
        {
            textBoxCustomerCode.Text = null;
            textBoxCustomerName.Text = null;
            textBoxCompany.Text = null;
            textBoxAddress.Text = null;
            textBoxPhone.Text = null;
            textBoxEmail.Text = null;
            comboBoxLine.Text = null;
        }

        private void updateCustomer()
        {

        }

        private void FormUpdateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void toolStripAddNewCustomer_Click(object sender, EventArgs e)
        {
            createCustomer();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            groupBoxCustomerDetails.Enabled = false;
            clearAllText();
        }

    }
}
