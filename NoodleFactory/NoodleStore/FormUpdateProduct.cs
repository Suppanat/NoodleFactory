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
    public partial class FormUpdateProduct : Form
    {
        public FormUpdateProduct()
        {
            InitializeComponent();
        }

        private void createProduct()
        {
            groupBoxProductDetails.Enabled = true;
            buttonDeleteProduct.Enabled = false;
        }

        private void updateProduct()
        {

        }

        private void clearAllText()
        {
            textBoxProductCode.Text = null;
            textBoxProductCategory.Text = null;
            textBoxProductName.Text = null;
            textBoxProductAmount.Text = null;
            textBoxProductPrice.Text = null;
            textBoxProductDetails.Text = null;
        }

        private void toolStripAddNewProduct_Click(object sender, EventArgs e)
        {
            createProduct();
        }

        private void buttonCancelProduct_Click(object sender, EventArgs e)
        {
            clearAllText();
            groupBoxProductDetails.Enabled = false;
        }
    }
}
