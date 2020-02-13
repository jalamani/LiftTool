using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LiftTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Update the label automatically from the setting
            List<string> appsettingsNames = new List<string> 
            {
                "LegRaiseWeight",
                "CalfRaiseWeight",
                "SquatWeight",
                "DeadLiftWeight",
                "ShoulderPressWeight",
                "BicepCurlWeight",
                "ShrugWeight",
                "BenchPressWeight",

            };
            weightInput.DataBindings.Add("Value", Properties.Settings.Default, "BodyWeight", true, DataSourceUpdateMode.OnPropertyChanged);
            for(int i =0;i<appsettingsNames.Count;i++)
            {
                Controls[i].DataBindings.Add("Value", Properties.Settings.Default, appsettingsNames[i], true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        
        private void weightSave_Click(object sender, EventArgs e)
        {
            //  Save the settings on click
            Properties.Settings.Default.Save();
        }

        private void bodyImage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
