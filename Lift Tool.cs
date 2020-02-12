using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            weightInput.DataBindings.Add("Value", Properties.Settings.Default, "BodyWeight", true,
                                   DataSourceUpdateMode.OnPropertyChanged);
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
