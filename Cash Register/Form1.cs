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

namespace Cash_Register
{

    public partial class Form1 : Form
    {
        double beverages = 2.00;
            double sandWiches = 5.00;
            double sideSalads = 3.00;
        double tax = 0.13;
        double beverage;
        double sandWich;
        double sideSalad;
        double subTotal;
        double taxAmount;
        double taxtotal;
        double total;
        double tender;
        double change;
        double sandwichCost;
        double sidesaladCost;
        double beverageCost;

        
       
 
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                sandWich = Convert.ToInt32(sandwichBox.Text);
                beverage = Convert.ToInt32(beverageBox.Text);
                sideSalad = Convert.ToInt32(sidesaladBox.Text);
                subTotal = beverage * beverages + sideSalads * sideSalad + sandWich * sandWiches;
                taxAmount = subTotal * tax;
                total = subTotal + taxAmount;
                taxText.Text = taxAmount.ToString("$.00");
                taxtotal = subTotal * taxAmount;
                totalTax.Text = $"{total.ToString("$.00")}";
                subtotalText.Text = subTotal.ToString("$.00");





            }
            catch
            {
                subtotalText.Text = "Please Enter A Digit";
            }

        

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tender = Convert.ToDouble(tenderedBox.Text);
            change = tender - total;
            changeLabel.Text = $"{change.ToString("C")}";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SoundPlayer cashSound = new SoundPlayer(Properties.Resources.sound);

            titleBox.Visible = true;
            Refresh();
            Thread.Sleep(500);
            cashSound.Play();

            orderBox.Visible = true;
            Refresh();
            Thread.Sleep(500);
            cashSound.Play();

            dateBox.Visible = true;
            Refresh();
            Thread.Sleep(500);
            cashSound.Play();

            sandwichCost = sandWiches * sandWich;
            sidesaladCost = sideSalads * sideSalad;
            beverageCost = beverages * beverage;

            foodBox.Visible = true;
            numberBox.Visible = true;
            foodBox.Text = $"Sandwich x {sandWich}";
            numberBox.Text = $"{sandwichCost.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            cashSound.Play();

            foodBox.Text += $"\nSide Salad x {sideSalad}";
            numberBox.Text += $"\n{sidesaladCost.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            cashSound.Play();

            foodBox.Text += $"\nBeverage x {beverage}";
            numberBox.Text += $"\n{beverageCost.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            cashSound.Play();

            foodBox.Text += $"\n\nSubtotal:";
            numberBox.Text += $"\n\n{subTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            cashSound.Play();

            foodBox.Text += $"\nTax:";
            numberBox.Text += $"\n{taxtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            cashSound.Play();

            foodBox.Text += $"\nTotal:";
            numberBox.Text += $"\n{total.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            cashSound.Play();

            foodBox.Text += $"\n\nTendered";
            numberBox.Text += $"\n\n{tender.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            cashSound.Play();


            foodBox.Text += $"\nChange:";
            numberBox.Text += $"\n{change.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            cashSound.Play();


            foodBox.Text += $"\n\nHope You Enjoyed!";
          
            Refresh();
            Thread.Sleep(500);
            
















        }
    }
}
