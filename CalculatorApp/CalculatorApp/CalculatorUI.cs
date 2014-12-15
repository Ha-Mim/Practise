using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            int result = Convert.ToInt32(firstNumberTextBox.Text) + Convert.ToInt32(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(result);

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(firstNumberTextBox.Text) - Convert.ToInt32(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(result);
        }

        private void multipyButton_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(firstNumberTextBox.Text)*Convert.ToInt32(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(result);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(firstNumberTextBox.Text)/Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(result);
        }

       
    }
}
