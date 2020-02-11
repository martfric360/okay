using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okay
{
    public partial class VariablesPractice : Form
    {
        public VariablesPractice()
        {
            InitializeComponent();
            outputLabel.Text = "Waiting For Input..."; 
            
        }

        private void Hockey_Click(object sender, EventArgs e)
        {
            int Number = 99; 
            String Hockey = "WayneGretzky";
            outputLabel.Text = Hockey + "' s Number is..." + Number; 
        }

        private void Area_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = radius * radius * pi;
            outputLabel.Text = "The area of a circle with a 15 cm radius is..." + area + "cm^2"; 
        }

        private void Carpet_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = length * width * costPerMeter;
            outputLabel.Text = "The area of the room is..." + area + "m^2" + "\n" + "\n" + " The cost for carpet at 19.95 per square metre is ..." + totalCost + "$";
           
            
            
            

        }

        private void Bill_Click(object sender, EventArgs e)
        {

            double shirt = 12.49;
            double tax = shirt * 0.13;
            double total = shirt + tax;
            double cash = 20;
            double back = cash - total; 
            outputLabel.Text = "Bill of Sale" + "\n" + "\n" + "Shirt:       " + shirt + "\n" + "\n" + "Tax:         " + tax + "\n" + "Total:       " + total + "\n" + "\n" + "Cash:        " + cash + "\n" + "Back:       " + back; 

        }
    }
}
