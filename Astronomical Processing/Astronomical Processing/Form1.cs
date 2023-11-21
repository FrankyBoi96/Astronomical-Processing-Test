using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Astronomical_Processing
{
    // Joseph Jinadu, Francisco Soares , Useful Programmer, Sprint Number 1

    // Date: 18/11/2023

    // Version: 1

    // Astronomical Processing application.
    // Astronomical Processing application

    // Brief explanation of the program and list, 

    // Inputs, Processes, Outputs

    public partial class Form1 : Form
    {
        #region Global Variables
        const int arraySize = 24;
        int[] astro = new int[arraySize];
        Random rand = new Random();
        int currentIndex = 0;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Methods 
        private void ArraySort()
        {
            int temp;
            for (int i = 0; i < arraySize - 1; i++)
            {
                for (int j = 0; j < arraySize - 1; j++)
                {
                    if (astro[j] > astro[j + 1])
                    {
                        temp = astro[j];
                        astro[j] = astro[j + 1];
                        astro[j + 1] = temp;

                    }
                }

            }

        }

        private void DisplayArray()
        {
           
            lstBox.Items.Clear();
            for (int i = 0; i < arraySize; i++)
            {

                if (lstBox.Items.Contains(0))
                {
                    lstBox.Items.Remove(0);
                }
                lstBox.Items.Add(astro[i]);
            }
            

        }




        #endregion
        private void BtnSort_Click(object sender, EventArgs e)
        {
            ArraySort();
            DisplayArray();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}