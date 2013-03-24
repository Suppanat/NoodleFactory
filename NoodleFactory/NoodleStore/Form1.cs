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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ToolStripeExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่ ?", "ออกจากโปรแกรม", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ToolStripUpdateCustomer_Click(object sender, EventArgs e)
        {
            foreach (Form CurrentForm in this.MdiChildren)
            {
                if (CurrentForm is FormUpdateCustomer)
                {
                    CurrentForm.MdiParent = this;
                    CurrentForm.Show();
                    return;
                }
            }
            FormUpdateCustomer f = new FormUpdateCustomer();
            f.MdiParent = this;
            f.Show();
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void ToolStripUpdateProduct_Click(object sender, EventArgs e)
        {
            foreach (Form CurrentForm in this.MdiChildren)
            {
                if (CurrentForm is FormUpdateProduct)
                {
                    CurrentForm.MdiParent = this;
                    CurrentForm.Show();
                    return;
                }
            }
            FormUpdateProduct f = new FormUpdateProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void ToolStripSearchCustomer_Click(object sender, EventArgs e)
        {
            foreach (Form CurrentForm in this.MdiChildren)
            {
                if (CurrentForm is FormSearchCustomer)
                {
                    CurrentForm.MdiParent = this;
                    CurrentForm.Show();
                    return;
                }
            }
            FormSearchCustomer f = new FormSearchCustomer();
            f.MdiParent = this;
            f.Show();
        }


    }
}
