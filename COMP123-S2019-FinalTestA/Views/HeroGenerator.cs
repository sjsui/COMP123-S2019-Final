using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

/*
 * STUDENT NAME: Shijun Sui
 * STUDENT ID: 301027587
 * DESCRIPTION: This is the Here Generator Form
 */

namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTestA.Views.MasterForm
    {
        public HeroGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        ///
        ///define the FirstNameList and LastNameList
        ///
        List<string> FirstNameList = new List<string>();
        List<string> LastNameList = new List<string>();

        ///
        //1b 
        ///Create a method called LoadNames that loads the entire firstNames.txt and lastNames.txt file into FirstNameList and LastNameList respectively
        public void LoadNames()
        {
            try
            {

                using (StreamReader fsr = new StreamReader("firstName.txt"))
                {
                    string fname;

                    while ((fname = fsr.ReadLine()) != null)
                    {
                        FirstNameList.Add(fname);

                    }
                }
                fsr.close();
            }
            catch (Exception e)
            {

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        
    

	
	        try
            {
                using (StreamReader lsr = new StreamReader("lastName.txt"))
                {
                    string lname;
                   
		            while ((lname = lsr.ReadLine()) != null)
                    {
			            LastNameList.Add(lname);
			
                    }
                
			lsr.close();

            }
            catch (Exception e)
            {
                
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        } 

        ///
        ///Create the GenerateNames Method
        ///
        public void GenerateNames()
        {
            var random = new Random();
            int index1 = random.Next(FirstNameList.Count);
            int index2 = random.Next(LastNameList.Count);
            string firstname = FirstNameList[index1];
            string lastname = LastNameList[index2];
        }


        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        /// <summary>
        /// This is the event handler for the GenerateNameButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        ///create the PowerList item
        List<string> PowersList = new List<string>();

        public void GenerateRandomPowers()
        {
            var random = new Random();
            int index1 = random.Next(PowersList.Count);
            int index2 = random.Next(PowersList.Count);
            int index3 = random.Next(PowersList.Count);
            int index4 = random.Next(PowersList.Count);
            Power1Label.Text = PowersList[index1];
            Power2Label.Text = PowersList[index2];
            Power3Label.Text = PowersList[index3];
            Power4Label.Text = PowersList[index4];
        }



        /// <summary>
        /// THis is the event handler for the GenerateAbilitiesButton CLick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            Random ability = new Random();
            FightingDataLabel.Text = Convert.ToString(ability.Next(0, 50));
            AgilityDataLabel.Text = Convert.ToString(ability.Next(0, 50));
            StrengthDataLabel.Text = Convert.ToString(ability.Next(0, 50));
            EnduranceDataLabel.Text = Convert.ToString(ability.Next(0, 50));
            ReasonDataLabel.Text = Convert.ToString(ability.Next(0, 50));
            IntuitionDataLabel.Text = Convert.ToString(ability.Next(0, 50));
            PsycheDataLabel.Text = Convert.ToString(ability.Next(0, 50));
            PopularityDataLabel.Text = Convert.ToString(ability.Next(0, 50));

        }

        private void GeneratePowerButton_Click(object sender, EventArgs e)
        {
            GenerateRandomPowers();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
