using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerTest
{
    public partial class Form1 : Form
    {
        Farmers farmer;

        public Form1()
        {
            InitializeComponent();
            farmer = new Farmers(15, 30) ;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine($@"I need {farmer.BagsOfFeed} bags of fee for {farmer.NumberOfCows} moo cows");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int) numericUpDown1.Value;
        }

        private void feedButton_Click(object sender, EventArgs e)
        {
            //farmer.BagsOfFeed = 5;
        }
    }
}
