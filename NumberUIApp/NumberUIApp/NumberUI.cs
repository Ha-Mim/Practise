using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberUIApp
{
    public partial class NumberUI : Form
    {
        public NumberUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numberTextBox.Text);
            addListBox.Items.Clear();
            for (int i = 0; i <= number; i++)
            {
                addListBox.Items.Add(i);
               
            }
        }

        

        private void showButton_Click(object sender, EventArgs e)
        {
            string selected = addListBox.GetItemText(addListBox.SelectedItem);
            MessageBox.Show(selected);
        }
    }
}
