using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dreamteam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            label1.Text = $"{Convert.ToString(sum(a, b))}  {Convert.ToString(mult(a, b))}  {Convert.ToString(div(a, b))}";
        }
        public static int sum(int a, int b)
        {
            return a + b;
        }
        public static int mult(int a, int b)
        {
            return a * b;
        }
        public static int div(int a, int b)
        {
            return a - b;
        }
    }
   
}
