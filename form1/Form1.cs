using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        private Draw test;
        public Form1()
        {
            int width = int.Parse(textBox1.Text);
            int length = int.Parse(textBox2.Text);
            InitializeComponent();
            Draw test = new Draw(width,length);
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.test.DrawRectangleInt();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
