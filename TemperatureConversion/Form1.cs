/*
Written by: Farhan Naeem
Written For: Mr. Kolch
Date: February 23, 2024
Course Code: TER3M1
Description: This program transforms temperatures between Celsius, Fahrenheit, and Kelvin, converting them into various units.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class fnformTemperatureConversions : Form
    {

        // Variable to store the converted temperature.
        String temperature;
        //// Variable to store the initial temperature value.
        double initialTemp;
        // Variable to store the final temperature value.  
        double finalNum;

        public fnformTemperatureConversions()
        {
            InitializeComponent();
        }

        private void fnformTemperatureConversions_Load(object sender, EventArgs e)
        {

        }


        //Click event if user presses the inital celsius radio button.
        private void fnradiobtninitalcelsius_CheckedChanged(object sender, EventArgs e)
        {
            //Try block which attempts to execute the code. Any errors encountered will be caught and handled by the catch block.
            try
            {
                // Stores user input as a double variable.
                //The double.Parse method is used to convert a string into a double data type, allowing it to be used for the calculations.
                initialTemp = double.Parse(fntxtinitialTemp.Text);

                //This if statement checks if the final celsius button is clicked.
                //It then calculates and stores the value in the string temperature and rounds to 2 decimal points. It also concatenates "°C".
                if (fnrdofinalcelsius.Checked)
                    {
                        finalNum = initialTemp;
                        temperature = finalNum.ToString("F2") + "°C";
                    }
                    //This else if statement checks if the final kelvin button is clicked.
                    //It then calculates and stores the value in the string temperature and rounds to 2 decimal points. It also concatenates "K".
                    else if (fnrdofinalkelvin.Checked)
                    {
                        finalNum = initialTemp + 273.15;
                        temperature = finalNum.ToString("F2") + "K";
                    }
                    //This else if statement checks if the final fahrenheit button is clicked.
                    //It then calculates and stores the value in the string temperature and rounds to 2 decimal points. It also concatenates "°F".
                    else if (fnrdofinalfahrenheit.Checked)
                    {
                        finalNum = (initialTemp * 9.0 / 5.0) + 32;
                        temperature = finalNum.ToString("F2") + "°F";
                    }
                   
                }
            //The catch block is executed if there is an error caused by the user failing to enter any values into the first textbox.
            catch (Exception)
                {
                   //Error message to remind user to enter a value.
                   MessageBox.Show("Input initial temperature");
                }
            
            
        }

        //Click event if user presses the inital kelvin radio button.
        private void fnradiobtninitalkelvin_CheckedChanged(object sender, EventArgs e)
        {
            //Try block which attempts to execute the code. Any errors encountered will be caught and handled by the catch block.
            try
            {
                // Stores user input as a double variable.
                //The double.Parse method is used to convert a string into a double data type, allowing it to be used for the calculations.
                initialTemp = double.Parse(fntxtinitialTemp.Text);

                //This if statement checks if the final celsius button is clicked.
                //It then calculates and stores the value in the string temperature and rounds to 2 decimal points. It also concatenates "°C".
                if (fnrdofinalcelsius.Checked)
                    {
                        finalNum = initialTemp - 273.15;
                        temperature = finalNum.ToString("F2") + "°C";
                    }
                //This else if statement checks if the final kelvin button is clicked.
                //It then calculates and stores the value in the string temperature and rounds to 2 decimal points. It also concatenates "K".
                else if (fnrdofinalkelvin.Checked)
                    {
                       finalNum = initialTemp;
                       temperature = finalNum.ToString("F2") + "K";
                    }
                //This else if statement checks if the final fahrenheit button is clicked.
                //It then calculates and stores the value in the string temperature and rounds to 2 decimal points. It also concatenates "°F".
                else if (fnrdofinalfahrenheit.Checked)
                    {
                        finalNum = (initialTemp - 273.15) * (9.0 / 5.0) + 32;
                        temperature = finalNum.ToString("F2") + "°F";
                    }
                    
                }
            //The catch block is executed if there is an error caused by the user failing to enter any values into the first textbox.
            catch (Exception)
                {
                    //Error message to remind user to enter a value.
                    MessageBox.Show("Input initial temperature");
                }
            
            
        }

        //Click event if user presses the inital fahrenheit radio button.
        private void fnradiobtninitalfahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            //Try block which attempts to execute the code. Any errors encountered will be caught and handled by the catch block.
            try
            {

                // Stores user input as a double variable.
                //The double.Parse method is used to convert a string into a double data type, allowing it to be used for the calculations
                initialTemp = double.Parse(fntxtinitialTemp.Text);

                //This if statement checks if the final celsius button is clicked.
                //It then calculates and stores the value in the string temperature and rounds to 2 decimal points. It also concatenates "°C".
                if (fnrdofinalcelsius.Checked)
                    {
                        finalNum = (5.0 / 9.0) * (initialTemp - 32);
                        temperature = finalNum.ToString("F2") + "°C";
                    }
                //This else if statement checks if the final kelvin button is clicked.
                //It then calculates and stores the value in the string temperature and rounds to 2 decimal points. It also concatenates "K".
                else if (fnrdofinalkelvin.Checked)
                    {
                        finalNum = (initialTemp - 32) * (5.0 / 9.0) + 273.15;
                        temperature = finalNum.ToString("F2") + "K";
                    }
                //This else if statement checks if the final fahrenheit button is clicked.
                //It then calculates and stores the value in the string temperature and rounds to 2 decimal points. It also concatenates "°F".
                else if (fnrdofinalfahrenheit.Checked)
                    {
                        finalNum = initialTemp;
                        temperature = finalNum.ToString("F2") + "°F";
                }
                   
                }
            //The catch block is executed if there is an error caused by the user failing to enter any values into the first textbox.
            catch (Exception)
                {
                    //Error message to remind user to enter a value.
                    MessageBox.Show("Input initial temperature");
                }
            
        }

        //Click event if user presses the calculate button
        private void fnbtncalculate_Click(object sender, EventArgs e)
        {
            //Try block which attempts to execute the code. Any errors encountered will be caught and handled by the catch block.
            try
            {
                //if statement which checks if any of the unit radio buttons are clicked.
                if ((!fnrdoinitalcelsius.Checked && !fnrdoinitalkelvin.Checked && !fnrdoinitalfahrenheit.Checked) || (!fnrdofinalcelsius.Checked && !fnrdofinalfahrenheit.Checked && !fnrdofinalkelvin.Checked))
                {
                    //Error message to remind user to click the radio buttons for the units.
                    MessageBox.Show("Input all of the units before calculating!");
                }

                //Invoke the corresponding event handler method depending on which radio buttons were checked.
                if (fnrdoinitalfahrenheit.Checked)
                {
                    fnradiobtninitalfahrenheit_CheckedChanged(sender, e);
                }
                else if (fnrdoinitalcelsius.Checked)
                {
                    fnradiobtninitalcelsius_CheckedChanged(sender, e);
                }
                else if (fnrdoinitalkelvin.Checked)
                {
                    fnradiobtninitalkelvin_CheckedChanged(sender, e);
                }

                //if statment to make sure there is atleast one of the inital unit picked and one converted unit picked.
                if ((fnrdoinitalcelsius.Checked || fnrdoinitalkelvin.Checked || fnrdoinitalfahrenheit.Checked) && (fnrdofinalcelsius.Checked || fnrdofinalfahrenheit.Checked || fnrdofinalkelvin.Checked))
                {
                    //sets the label to the correct value calculated for the new temperature which is converted.
                    fnlblAns.Text = temperature;
                }
            }
            //The catch block is executed if there is an error caused by the user failing to click any of the buttons.
            catch (Exception)
            {
                //Error message to remind the user to input all units.
                MessageBox.Show("Make sure all of the units are inputted before calculating!");
            }
        }

        private void fnlblFinalTemp_Click(object sender, EventArgs e)
        {

        }

        private void fnlblAns_Click(object sender, EventArgs e)
        {

        }

        //Exit Button click event
        private void fnbtnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
