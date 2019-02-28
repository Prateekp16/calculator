using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultvalue = 0;
        string Operationperformed = "";
        bool isOperationperformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((Text_result.Text == "0") || (isOperationperformed))
                Text_result.Clear();

            isOperationperformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!Text_result.Text.Contains("."))
                    Text_result.Text = Text_result.Text + button.Text;
            } else
                Text_result.Text = Text_result.Text + button.Text;
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultvalue != 0)
            {
                button_equals.PerformClick();
                Operationperformed = button.Text; ;
                labelcurrentOperation.Text = resultvalue + " " + Operationperformed;
                isOperationperformed = true;

            }
            else
            {
                Operationperformed = button.Text;
                resultvalue = Double.Parse(Text_result.Text);
                labelcurrentOperation.Text = resultvalue + " " + Operationperformed;
                isOperationperformed = true;

            }
        }

        private void button_delall_Click(object sender, EventArgs e)
        {
            Text_result.Text = "0";
            
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            Text_result.Text = "0";
            resultvalue = 0;
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            switch(Operationperformed)
            {
                case "+":
                    Text_result.Text = (resultvalue + Double.Parse(Text_result.Text)).ToString();
                    break;

                case "-":
                    Text_result.Text = (resultvalue + Double.Parse(Text_result.Text)).ToString();
                    break;
                case "*":
                    Text_result.Text = (resultvalue + Double.Parse(Text_result.Text)).ToString();
                    break;
                case "/":
                    Text_result.Text = (resultvalue + Double.Parse(Text_result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
