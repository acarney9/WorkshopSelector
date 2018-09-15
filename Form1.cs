using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Alex Carney
//10/02/17
//This program calculates total price for a workshop
namespace WorkshopSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //declare variable
            double days = 0,
                   registrationFee = 0,
                   lodgingFee = 0,
                   lodgeTotal = 0,
                   extrasCost = 0,
                   insuranceCost = 0,
                   extraNightCost = 0,
                   total = 0;

            int index = 0;

            string conference = "",
                   extraNight = "",
                   output = "";
            //make sure a list item is selected
            if (workshopListBox.SelectedIndex != -1)
            {
                

                index = (workshopListBox.SelectedIndex);
                //create a switch for the differet=nt list box selections
                switch (index)
                {
                    case 0:
                        {
                            
                            days = 3;
                            registrationFee = 1000;
                            break;
                        }

                    case 1:
                        {
                            
                            days = 3;
                            registrationFee = 800;
                            break;
                        }

                    case 2:
                        {
                            
                            days = 3;
                            registrationFee = 1500;
                            break;
                        }

                    case 3:
                        {
                            
                            days = 5;
                            registrationFee = 1300;
                            break;
                        }

                    case 4:
                        {
                            
                            days = 1;
                            registrationFee = 500;
                            break;
                        }

                }
            }

            else
            {
                MessageBox.Show("Please select an option from the workshop list box.");
            }

            if (locationListBox.SelectedIndex != -1)
            {
                

                index = (locationListBox.SelectedIndex);

                switch (index)
                {
                    case 0:
                        {
                            lodgingFee = 150;
                            break;
                        }

                    case 1:
                        {
                            lodgingFee = 225;
                            break;
                        }

                    case 2:
                        {
                            lodgingFee = 175;
                            break;
                        }

                    case 3:
                        {
                            lodgingFee = 300;
                            break;
                        }

                        
                    
                }
            }

            

            //show a message in case the user doesnt select an item from the list box
            else
            {
                MessageBox.Show("Please select an option from the lodging list box.");
                
            }
            //create 3 if statements for the check boxes
            if (programmingCheckBox.Checked)
            {
                extrasCost = 125;
                conference += "Programming Training: $125";
            }
            
            if (securityCheckBox.Checked)
            {
                extrasCost += 125;
                conference += "\nSecurity Training: $125";
            }

            if (socialCheckBox.Checked)
            {
                extrasCost += 25;
                conference += "\nSocial Event: $25";
            }
                //create an if statement for the is=nsurance radio button
                if (insuranceRadioButton.Checked)
                {
                    insuranceCost = 30;
                }

            if (nightsListBox.SelectedIndex != -1)
            {
                

                index = (nightsListBox.SelectedIndex);

                switch (index)
                {
                    case 0:
                        {
                            extraNightCost = 0;
                            extraNight = "No extra nights";
                            break;
                        }

                    case 1:
                        {
                            extraNightCost = 100;
                            extraNight = "1 Extra Night: $100";

                            break;
                        }

                    case 2:
                        {
                            extraNightCost = 200;
                            extraNight = "2 Extra Nights: $200";
                            break;
                        }

                    case 3:
                        {
                            extraNightCost = 300;
                            extraNight = "3 Extra Nights: $300";
                            break;
                        }


                }
            }
            else
            {
                MessageBox.Show("Please select a value for Additional Nights.");
                
                
            }
            //calculate totals
            lodgeTotal = lodgingFee * days;
            total = registrationFee + lodgeTotal + extrasCost + insuranceCost + extraNightCost;

            //create the output for the output label
            output = "Registration Fee: " + registrationFee.ToString("c0") + "\nLodging for " + days.ToString() + " days: " +
                lodgeTotal.ToString("c0") + "\n" + conference +"\nInsurance Cost: " + 
                insuranceCost.ToString("c0") + "\n" +extraNight + "\n__________________" + "\nTotal: " + total.ToString("c0");
            
            //display the information onto the label
            outputLabel.Text = output;






        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the output label...not neccasary but looks nice
            outputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
    }
}
