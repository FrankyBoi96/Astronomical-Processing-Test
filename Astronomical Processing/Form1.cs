using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Astronomical_Processing
{
    // Joseph Jinadu, Francisco Soares , Useful Programmer, Sprint Number 1

    // Date: 18/11/2023

    // Version: 1

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
    }
}
