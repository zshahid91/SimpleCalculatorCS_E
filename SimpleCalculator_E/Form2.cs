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
    public partial class Form2 : Form
    {

        private float number1 = 0, number2 = 0, ans = 0;
        private bool AddButton_clicked = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void num2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
            number2 = 2;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
            AddButton_clicked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AddButton_clicked == true)
            {
                ans = number1 + number2;
                richTextBox1.Text = ans.ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
            number1 = 1;
        }
    }
}
