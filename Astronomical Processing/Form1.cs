using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Astronomical_Processing
{
    // Joseph Jinadu, Francisco Soares , Useful Programmer, Sprint Number 2

    // Date: 23/11/2023

    // Version: 2

    // Astronomical Processing application.

    // Brief explanation of the program and list, 

    // Inputs, Processes, Outputs

    public partial class Form1 : Form
    {
        #region Global Variables
        const int arraySize = 24;
        int[] astro = new int[arraySize];
        Random rand = new Random();
        int currentIndex = 0;
        int[] count = new int[100];
        List<int> modeList = new List<int>();
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

        private void CheckSort()
        {
            if (string.IsNullOrEmpty(txtBox.Text))
            {
                MessageBox.Show("Pick a Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lstBox.ClearSelected();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Have you sorted the Array", "Index", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    BinarySearch();
                    txtBox.Clear();
                    lstBox.ClearSelected();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Sorting Array");
                    ArraySort();
                    DisplayArray();
                }


            }

        }

        //make Search method
        private void BinarySearch()
        {
            int mid;
            int low = 0;
            int high = arraySize;
            int target = int.Parse(txtBox.Text);
            int index;
            bool found = false;
            try
            {
                while (!found && low <= high)
                {
                    mid = (low + high) / 2;

                    if (astro[mid] == target)
                    {
                        found = true;
                        index = mid;
                        lstBox.SetSelected(index, true);
                        index++;
                        MessageBox.Show("Value found at: " + index, "Index", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (astro[mid] > target)
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }

                if (!astro.Contains(int.Parse(txtBox.Text)))
                {
                    MessageBox.Show("Not Found", "Index", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error");
            }


        }



        private void RandomNumGene()
        {
            lstBox.Items.Clear();
            for (int i = 0; i < arraySize; i++)
            {
                astro[i] = rand.Next(10, 99);
            }
        }

        private void SequentialSearch()
        {
            int index = -1;
            if (string.IsNullOrEmpty(txtBox.Text))
            {
                MessageBox.Show("The Text Box is Empty");
            }
            else
            {
                for (int i = 0; i < arraySize; i++)
                {
                    if (astro[i] == int.Parse(txtBox.Text))
                    {
                        index = i;
                        lstBox.SetSelected(index, true);
                        MessageBox.Show("Found at index " + (index));
                        break;
                    }
                }

                if (index == -1)
                {
                    MessageBox.Show("Not Found");
                }
            }
        }

        private void Range()
        {
            double min = astro.Min();
            double max = astro.Max();
            double total = max - min;
            txtBoxRange.Text = total.ToString();
        }

        private void Average()
        {
            double sum = 0;
            foreach(double value in astro)
            {
                sum += value;
            }
            sum = sum / arraySize;
            txtBoxAverage.Text = sum.ToString();
        }

        private void Mode()
        {
            count = new int[100];
            for (int i = 0; i < astro.Length; i++)
            {
                count[astro[i]]++;
            }
            int max = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > max)
                {
                    max = count[i];
                }
            }
            //Add number to modelist if it occurs max times 
            //and is not equal to 1

            if (max != 1)
            {
                for (int i = 0; i < count.Length; i++)
                {
                    if ((count[i] == max) && (count[i] != 1))
                    {
                        modeList.Add(i);
                    }
                    else if (count[i] == 1)
                    {

                    }
                }
            }
            else
            {
                txtBoxMode.Text += "No Mode";
            }
        }

        private void DisplayMode()
        {
            txtBoxMode.Clear();
            modeList = new List<int>();
            Mode();
            for (int i = 0; i < modeList.Count(); i++)
            {
                txtBoxMode.Text += modeList[i] + ",";
            }

        }

        private void MidExtreme()
        {
            double min = astro.Min();
            double max = astro.Max();
            double mid = (max + min) / 2;
            txtBoxMidEx.Text = mid.ToString(); 
        }


        #endregion
        private void BtnSort_Click(object sender, EventArgs e)
        {
            ArraySort();
            DisplayArray();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox.Text))
            {
                MessageBox.Show("No Data in Text Box", "Empty Text Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstBox.ClearSelected();
            }
            else if (lstBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Number", "Select Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstBox.ClearSelected();
            }
            else
            {
                astro[lstBox.SelectedIndex] = int.Parse(txtBox.Text);
                ArraySort();
                DisplayArray();
                txtBox.Clear();
                lstBox.ClearSelected();
            }

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            RandomNumGene();
            DisplayArray();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            CheckSort();
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBox_MouseDown(object sender, MouseEventArgs e)
        {
            txtBox.Text = astro[lstBox.SelectedIndex].ToString();
        }

        private void btnSeq_Click(object sender, EventArgs e)
        {
            SequentialSearch(); 
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            Range(); 
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            Average(); 
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            DisplayMode();
        }

        private void btnMidEx_Click(object sender, EventArgs e)
        {
            MidExtreme();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            btnRange_Click(sender, e);
            btnAverage_Click(sender, e);
            btnMode_Click(sender, e);
            btnMidEx_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnGenerate, "Clicking this button will generate 24 random numbers between 10 and 99");
            toolTip.SetToolTip(btnAverage, "Clicking this button will calculate the average of all the numbers in the array");
            toolTip.SetToolTip(btnBinarySearch, "Clicking this button will find the number value you have searching in the text box");
            toolTip.SetToolTip(btnSort, "Clicking this button will sort the array from lowest to highest");
            toolTip.SetToolTip(btnEdit, "Clicking this button will edit the selected value with the value enter in the text box");
            toolTip.SetToolTip(btnMidEx, "Clicking this button will calcualte the mid extreme of all the numbers in the array");
            toolTip.SetToolTip(btnMode, "Clicking this button will calcuate the mode of all the numbers in the array");
            toolTip.SetToolTip(btnRange, "Clicking this button will calcuate the range of all the numbers in the array");
            toolTip.SetToolTip(btnSeq, "Clicking this button will search the array for the value entered in the text box");
        }
    }
}
