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
        int astro = new int(arraySize);
        Random rand = new Random();
        int currentIndex = 0;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up form properties
            this.Text = "Astronomical Processing";

            // Initialize UI components
            BtnSort = CreateButton("Sort", Sort_Click);
            BtnSearch = CreateButton("Search", Search_Click);
            BtnEdit = CreateButton("Edit", Edit_Click);
            BtnGenerate = Create Button("Generate", Generate_Click);
            BtnDelete =
            txtSearch = new TextBox();
            txtEdit = new TextBox();

            listBox = new ListBox();

            // Set up layout
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Controls.AddRange(new Control[] { BtnSort, BtnSearch, btnEdit, btnUpdate, btnMenu, btnRefresh, btnHelp, btnGenerate, txtSearch, txtEdit, listBox });

            // Add panel to the form
            this.Controls.Add(panel);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}