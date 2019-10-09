using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashMachineSummative
{
    public partial class Form1 : Form
    {
        const double BURGER = 4.99;
        const double FRIES = 2.99;
        const double DRINK = 1.50;
        const double TAX = 0.13;
        double subTotal, tax, total, tendered, change;
        int numberOfBurgers, numberOfFries, numberOfDrinks;
        double burgerTotal = 0;
        double friesTotal = 0;
        double drinkTotal = 0;

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            //Reseting text boxes and labels back to 0 or $0.00
            burgerInput.Text = Convert.ToString("0");
            friesInput.Text = Convert.ToString("0");
            drinksInput.Text = Convert.ToString("0");
            subTotalOutput.Text = Convert.ToString("$0.00");
            taxOutput.Text = Convert.ToString("$0.00");
            totalOuput.Text = Convert.ToString("$0.00");
            tenderedInput.Text = Convert.ToString("0");
            changeOutput.Text = Convert.ToString("$0.00");

            //Reseting all variables back to 0
            subTotal = 0;
            tax = 0;
            total = 0;
            tendered = 0;
            change = 0;
            numberOfBurgers = 0;
            numberOfFries = 0;
            numberOfDrinks = 0;
            burgerTotal = 0;
            friesTotal = 0;
            drinkTotal = 0;

            //Getting rid of receipt
            g.Clear(Color.Tomato);
        }

        

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font receiptFont = new Font("Sitka Small", 11, FontStyle.Regular);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SoundPlayer cashSound = new SoundPlayer(Properties.Resources.Cash_Register);
            SoundPlayer printSound = new SoundPlayer(Properties.Resources.receipt);

            //Random order number generator
            Random orderRan = new Random();
            int orderNumber = orderRan.Next(1, 1000);

            //Sound of register and receipt printing
            cashSound.Play();
            Thread.Sleep(1000);
            printSound.Play();
            Thread.Sleep(700);

            //White part of receipt
            g.FillRectangle(whiteBrush, 350, 80, 350, 375);
            Thread.Sleep(250);

            //Restaurant, date and random order number print
            g.DrawString("Erik's Burgers and Fries!", receiptFont, blackBrush, 425, 100);
            Thread.Sleep(250);
            g.DrawString("October 7, 2019, 1:25p.m.", receiptFont, blackBrush, 370, 140);
            Thread.Sleep(250);
            g.DrawString("Order Number " + orderNumber, receiptFont, blackBrush, 370, 160);
            Thread.Sleep(250);

            //Number of burgers, fries, drinks and their price print
            g.DrawString("Burgers      x" + numberOfBurgers + "  " + burgerTotal.ToString("C"), receiptFont, blackBrush, 370, 200);
            Thread.Sleep(250);
            g.DrawString("Fries          x" + numberOfFries + "  " + friesTotal.ToString("C"), receiptFont, blackBrush, 370, 220);
            Thread.Sleep(250);
            g.DrawString("Drinks        x" + numberOfDrinks + "  " + drinkTotal.ToString("C"), receiptFont, blackBrush, 370, 240);
            Thread.Sleep(250);

            //Subtotal, tax and total print
            g.DrawString("Subtotal           " + subTotal.ToString("C"), receiptFont, blackBrush, 370, 280);
            Thread.Sleep(250);
            g.DrawString("Tax                   " + tax.ToString("C"), receiptFont, blackBrush, 370, 300);
            Thread.Sleep(250);
            g.DrawString("Total                " + total.ToString("C"), receiptFont, blackBrush, 370, 320);
            Thread.Sleep(250);

            //Tendered and change print
            g.DrawString("Tendered         " + tendered.ToString("C"), receiptFont, blackBrush, 370, 360);
            Thread.Sleep(250);
            g.DrawString("Change            " + change.ToString("C"), receiptFont, blackBrush, 370, 380);

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToInt16(tenderedInput.Text);
                change = tendered - total;
                changeOutput.Text = change.ToString("C");
            }
            catch
            {
                changeOutput.Text = "Invalid";
                return;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateTotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                numberOfBurgers = Convert.ToInt16(burgerInput.Text);
                numberOfFries = Convert.ToInt16(friesInput.Text);
                numberOfDrinks = Convert.ToInt16(drinksInput.Text);

                burgerTotal = numberOfBurgers * BURGER;
                friesTotal = numberOfFries * FRIES;
                drinkTotal = numberOfDrinks * DRINK;

                subTotal = burgerTotal + friesTotal + drinkTotal;
                tax = subTotal * TAX;
                total = subTotal + tax;

                subTotalOutput.Text = subTotal.ToString("C");
                taxOutput.Text = tax.ToString("C");
                totalOuput.Text = total.ToString("C");

            }
            catch
            {
                subTotalOutput.Text = "Invalid";
                taxOutput.Text = "Invalid";
                totalOuput.Text = "Invalid";
                return;
            }
        }
    }
}
