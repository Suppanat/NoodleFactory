using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Client client;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new Client(this);
            client.Connect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.SendMessage(textBox3.Text);
        }

        public String getText()
        {
            return textBox3.Text;
        }

        public void setText(String str)
        {
            textBox1.AppendText(str);
        }



    }
}
