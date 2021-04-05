using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            float ans = 0, num1 = 0, num2 = 0;
            num1 = float.Parse(richTextBox1.Text);
            num2 = float.Parse(richTextBox2.Text);
            ans = num1 + num2;
            richTextBox3.Text = ans.ToString();

        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            /*float ans = 0, num1 = 0, num2 = 0;
            num1 = float.Parse(richTextBox1.Text);
            num2 = float.Parse(richTextBox2.Text);
            ans = num1 - num2;
            richTextBox3.Text = ans.ToString();*/

            richTextBox3.Text = (float.Parse(richTextBox1.Text) - float.Parse(richTextBox2.Text)).ToString();
        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            /*float ans = 0, num1 = 0, num2 = 0;
            num1 = float.Parse(richTextBox1.Text);
            num2 = float.Parse(richTextBox2.Text);
            ans = num1 * num2;
            richTextBox3.Text = ans.ToString();*/

            richTextBox3.Text = (float.Parse(richTextBox1.Text) * float.Parse(richTextBox2.Text)).ToString();
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            float ans = 0, num1 = 0, num2 = 0;
            num1 = float.Parse(richTextBox1.Text);
            num2 = float.Parse(richTextBox2.Text);
            ans = num1 / num2;
            richTextBox3.Text = ans.ToString();
        }

        private void RemButton_Click(object sender, EventArgs e)
        {
            float ans = 0, num1 = 0, num2 = 0;
            num1 = float.Parse(richTextBox1.Text);
            num2 = float.Parse(richTextBox2.Text);
            ans = num1 % num2;
            richTextBox3.Text = ans.ToString();
        }

        private void SqRt_Click(object sender, EventArgs e)
        {
            double ans = 0, num1 = 0;
            num1 = double.Parse(richTextBox1.Text);
            ans = Math.Sqrt(num1);
            richTextBox3.Text = ans.ToString();
        }
    }
}
