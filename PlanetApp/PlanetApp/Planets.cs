using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetApp
{
    public partial class Planets : Form
    {
        public Planets()
        {
            InitializeComponent();
        }

        private void searchPlanetButton_Click(object sender, EventArgs e)
        {
            if (planetNameComboBox.Text == "Sun")
            {
                MessageBox.Show("Sun is in 1st Position");
            }
            else if (planetNameComboBox.Text == "Mercury")
            {
                MessageBox.Show("Mercury is in 2nd Position");
            }
            else if (planetNameComboBox.Text == "Venus")
            {
                MessageBox.Show("Venus is in 3rd Position");
            }
            else if (planetNameComboBox.Text == "Earth")
            {
                MessageBox.Show("Earth is in 4th Position");
            }
            else if (planetNameComboBox.Text == "Mars")
            {
                MessageBox.Show("Mars is in 5th Position");
            }
            else if (planetNameComboBox.Text == "Jupiter")
            {
                MessageBox.Show("Jupiter is in 6th Position");
            }
            else if (planetNameComboBox.Text == "Saturn")
            {
                MessageBox.Show("Saturn is in 7th Position");
            }
            else if (planetNameComboBox.Text == "Uranus")
            {
                MessageBox.Show("Uranus is in 8th Position");
            }
            else if (planetNameComboBox.Text == "Neptune")
            {
                MessageBox.Show("Neptune is in 9th Position");
            }




        }
    }
}
