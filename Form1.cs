using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Color()
        {
            //Car's Color

            string color = "";
            if (radioButton_Grey.Checked)
            {
                color = radioButton_Grey.Text;
            }
            else if (radioButton_Red.Checked)
            {
                color = radioButton_Red.Text;
            }
            else if (radioButton_Blue.Checked)
            {
                color = radioButton_Blue.Text;
            }
            else if (radioButton_Black.Checked)
            {
                color = radioButton_Black.Text;
            }
            else if (radioButton_Orange.Checked)
            {
                color = radioButton_Orange.Text;
            }
            else if (radioButton_Green.Checked)
            {
                color = radioButton_Green.Text;
            }
            
            return color;
        }
        public string Fuel()
        {
            //Car's Fuel

            string Fuel = " ";
            if (radioButton_Benzin.Checked)
            {
                Fuel = radioButton_Benzin.Text;
            }
            else if (radioButton_Disel.Checked)
            {
                Fuel = radioButton_Disel.Text;
            }
            else if (radioButton_Gas.Checked)
            {
                Fuel = radioButton_Gas.Text;
            }
            return Fuel;
        }
      
        public double PriceCalculator(double Cost)
        {
             //Car's Price on Hourse Power

            
            if (horsePowerTrack.Value > 350 && horsePowerTrack.Value < 550)
            {
                Cost *= 1.5;
            }
            else if (horsePowerTrack.Value > 550 && horsePowerTrack.Value < 750)
            {
                Cost *= 2;
            }
            else if (horsePowerTrack.Value > 750 && horsePowerTrack.Value < 850)
            {
                Cost *= 2.5;
            }
            else if (horsePowerTrack.Value > 850)
            {
                Cost *= 3;
            }

            //Price on Engine Fuel

            if (Fuel() == "Petrol")
            {
                Cost -= Cost * 0.1;
            }
            else if (Fuel() == "Gas")
            {
                Cost -= Cost * 0.5;  ;
            }
            return Cost;
        }
        private void horsePowerTrack_Scroll(object sender, EventArgs e)
        {
          horsePowerLabel.Text = horsePowerTrack.Value.ToString();

            //Porshe Price

            int PorshePrice = 121725;
            labelPorsche.Text = PriceCalculator(PorshePrice).ToString();

            //Lamborghini Price

            int LamborghiniPrice = 321152;
            LamboPriceLabel.Text = PriceCalculator(LamborghiniPrice).ToString();

            //CHEVROLET Camaro Price

            int CamaroPrice = 57650;
            CamaroPriceLabel.Text = PriceCalculator(CamaroPrice).ToString();

            //Golf Price
            int GolfPrice = 5250;
            GolfPriceLabel.Text = PriceCalculator(GolfPrice).ToString();

            //Mclaren Price
            int MclarenPrice = 184900;
            MclarenLabelPrice.Text = PriceCalculator(MclarenPrice).ToString();

            //Ferrari Price
            int FerrariPrice = 335000;
            FerrariPriceLabel.Text = PriceCalculator(FerrariPrice).ToString();

            //Mercedes Price
            int MercedesPrice = 130900;
            MercedesLabelPrice.Text = PriceCalculator(MercedesPrice).ToString();

            //Audi Price
            int AudiPrice = 195900;
            AudiPriceLabel.Text = PriceCalculator(AudiPrice).ToString();
        }  
        public void MessegeShow(string carName, int price)
        {           
           //Thats Write a File
            StreamWriter sw = new StreamWriter(Application.StartupPath +
                "\\Employees\\" + carName + " " + horsePowerTrack.Value.ToString() + ".txt");

            sw.WriteLine("Your order has been accepted");
            sw.WriteLine();
            sw.WriteLine("1. The car model is: " + carName);
            sw.WriteLine("2. The horsepower is: " + horsePowerTrack.Value.ToString());
            sw.WriteLine("3. The car costs: " + PriceCalculator(price) + '$');
            sw.WriteLine("4. The car's fuel: " + Fuel());
            sw.WriteLine("5. The car color is: " + Color());
            sw.WriteLine();
            sw.Close();

            //Thats Read a File
            StreamReader sr = new StreamReader(Application.StartupPath + 
                "\\Employees\\" + carName + " " + horsePowerTrack.Value.ToString() + ".txt");

            ReadFiles.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void PorsheButton_Click(object sender, EventArgs e)
        {
            //Porshce Button
            int PorshePrice = 121725;
            MessegeShow(PorcheName.Text, PorshePrice);

        }

        private void LamboButton_Click(object sender, EventArgs e)
        {
            //Lambo Button
            int LamborghiniPrice = 321152;           
            MessegeShow(LamboName.Text, LamborghiniPrice);
        }

        private void CamaroButton_Click(object sender, EventArgs e)
        {
            //CHEVROLET Camaro Button
            int CamaroPrice = 57650;
            MessegeShow(CamaroName.Text, CamaroPrice);
        }

        private void GolfButton_Click(object sender, EventArgs e)
        {
            //Golf Button
            int GolfPrice = 5250;
            MessegeShow(GolfName.Text, GolfPrice);
        }

        private void MclarenButton_Click(object sender, EventArgs e)
        {
            //Mclaren Button
            int MclarenPrice = 184900;
            MessegeShow(MclarenName.Text, MclarenPrice);
        }

        private void FerrariButton_Click(object sender, EventArgs e)
        {
            //Ferrari Button
            int FerrariPrice = 335000;
            MessegeShow(FerrariName.Text, FerrariPrice);
        }

        private void MercedesButton_Click(object sender, EventArgs e)
        {
            //Mercedes Button
            int MercedesPrice = 130900;
            MessegeShow(MercedesName.Text, MercedesPrice);
        }

        private void AudiButton_Click(object sender, EventArgs e)
        {
            //Audi Button
            int AudiPrice = 195900;
            MessegeShow(AudiName.Text, AudiPrice);
        }

    }
}
