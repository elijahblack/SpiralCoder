using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiralCoder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Settings.SetComboBoxData(ArrayLengthComboBox, Settings.GetArrayLengthArray());
            Settings.SetComboBoxData(SetEncodeComboBox, Code.codes);
            Settings.SetComboBoxData(InitTypeComboBox, Settings.GetInitTypeArray());


        }

        private void ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //Program.initType = Convert.ToInt32(InitTypeComboBox.SelectedValue);


            // TEST
            //StupidButton.Text = Program.N.ToString();
            //StupidButton.Text = ArrayLengthComboBox.SelectedValue.ToString();
            //StupidButton.Text = SetEncodeComboBox.SelectedValue.ToString();
            //StupidButton.Text = InitTypeComboBox.SelectedValue.ToString();
        }

        private void StupidButton_Click(object sender, EventArgs e)
        {
            ArrayLengthComboBox.SelectedValue = 11;
            SetEncodeComboBox.SelectedValue = 0;
            InitTypeComboBox.SelectedValue = 2;
        }
    }
}
