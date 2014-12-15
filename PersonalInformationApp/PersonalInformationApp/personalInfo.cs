using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class personalInfo : Form
    {
        public personalInfo()
        {
            InitializeComponent();
        }

        private string name = "";
        private string fatherName = "";
        private string motherName = "";
        private string address = "";
        private void saveButton_Click(object sender, EventArgs e)
        {
            name = firstNameTextBox.Text+ " " +lastNameTextBox.Text;
            fatherName = fatherNameTextBox.Text;
            motherName = motherNameTextBox.Text;
            address = addressTextBox.Text;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            fatherNameTextBox.Text = string.Empty;
            motherNameTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;

        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Name : " + name + " \nFather's Name : " + fatherName + " \nMother's Name : " + motherName + " \nAddress : " +address);
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name : " +name);
        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Father's Name : " + fatherName + " \nMother's Name : " + motherName);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address : " + address);
        }
    }
}
