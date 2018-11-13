/* Grading ID: A7872
   Program 1
   Due Date: 9/27/2016
   CIS199-01 
   An application that will calculate the total cost for a paint job*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class programOneForm : Form
    {
        const decimal PAINT_SQFT = 275m; //define variable for sqft per gallon
        const decimal LABOR_HOURS = 8m; //define variable for labor hours per sqft
        const decimal PRICE_PER_HOUR = 12.5m; //define variable for labor cost per 275 sqft

        public programOneForm()
        {
            InitializeComponent();
        }

        private void totalSqftOutputLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal sqftEntered; //variable for the sqft entered into text box
            sqftEntered = decimal.Parse(sqftTxtBox.Text); //parse the input
            decimal coatsNeeded; //variable for the total coats needed
            coatsNeeded = decimal.Parse(numberCoatsTxtBox.Text); //parse the input
            decimal totalSqftToPaint; //variable for total sqft to paint
            totalSqftToPaint = sqftEntered * coatsNeeded; //calculation for this variable
            totalSqftOutputLabel.Text = totalSqftToPaint.ToString("n1"); //convert float to text

            decimal gallonsReq; //variable for gallons required 
            gallonsReq = Math.Ceiling(totalSqftToPaint/PAINT_SQFT); //calculation for this variable using math.ceiling
            gallonsRequiredOutputLabel.Text = gallonsReq.ToString("n0"); //convert float to text

            decimal laborReq; //variable for labor required
            laborReq = (totalSqftToPaint / PAINT_SQFT) * LABOR_HOURS; //calculation for labor required
            hoursRequiredOutputLabel.Text = laborReq.ToString("n1"); //convert float to text

            decimal pricePerGallonEntered; //variable for price per gallon
            pricePerGallonEntered = decimal.Parse(paintPriceTxtBox.Text); //parse the input
            decimal paintCost; //variable for paint cost
            paintCost = pricePerGallonEntered * gallonsReq; //calculation for paint cost
            paintCostOutputLabel.Text = paintCost.ToString("c"); //convert float to text

            decimal laborCost; //variable for labor cost
            laborCost = laborReq * PRICE_PER_HOUR; //calculation for labor cost
            laborCostOutputLabel.Text = laborCost.ToString("c"); //convert float to text

            decimal totalCost; //variable for total cost
            totalCost = paintCost + laborCost; //calculation for total cost
            totalCostOutputLabel.Text = totalCost.ToString("c"); //convert float to text


            
        }
    }
}
