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
            // Инициализация списков
            Settings.SetComboBoxData(ArrayLengthComboBox, Settings.GetArrayLengthArray());
            Settings.SetComboBoxData(SetEncodeComboBox, Code.codes);
            Settings.SetComboBoxData(InitTypeComboBox, Settings.GetInitTypeArray());

            // Блокируем кнопки, чтобы тупой пользователь не начал шифровать текс, до того, как появится текст. 
            EncodeButton.Enabled = false;
            DecodeButton.Enabled = false;

            // Скрываем ненужные элементы
            WayLabel1.Visible = false;
            WayLabel2.Visible = false;
            WayLabel3.Visible = false;
        }
        
        private void StupidButton_Click(object sender, EventArgs e)
        {
            ArrayLengthComboBox.SelectedValue = 11;
            SetEncodeComboBox.SelectedValue = 0;
            InitTypeComboBox.SelectedValue = 2;
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            // включаем кнопку шифрования
            EncodeButton.Enabled = true;

            // Отображаем ненужные элементы
            WayLabel1.Visible = true;
            WayLabel2.Visible = true;
            WayLabel3.Visible = true;
        }
    }
}
