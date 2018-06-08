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
            Settings.SetComboBoxData(EncodeComboBox, Code.codes);
            Settings.SetComboBoxData(InitTypeComboBox, Settings.GetInitTypeArray());

            // Блокируем кнопки, чтобы тупой пользователь не начал шифровать текс, до того, как появится текст. 
            EncodeButton.Enabled = false;
            DecodeButton.Enabled = false;

            // Скрываем ненужные элементы
            WayLabel1.Visible = false;
            WayLabel2.Visible = false;
            WayLabel3.Visible = false;
        }
        
        /// <summary>
        /// Тупая кнопка для задания
        /// </summary>
        private void StupidButton_Click(object sender, EventArgs e)
        {
            ArrayLengthComboBox.SelectedValue = 11;
            EncodeComboBox.SelectedValue = 0;
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
            
            // Явное приведение к INT, нужно потому что переменные INT, а SelectedValue -- OBJECT
            // Не смотря на то, что везде VALUE прискаевается INT, на момент компиляции этого еще не произошло и вылезет ошибка.
            // Если хочешь, попробуй удалить INT со скобками. 
            Program.N = (int)ArrayLengthComboBox.SelectedValue;
            Program.initType = (int)InitTypeComboBox.SelectedValue;
            Program.firstCoord = Code.GetFirstOperator(Code.codes[(int)EncodeComboBox.SelectedValue]);
            Program.d = Code.GetDeviation(Code.codes[(int)EncodeComboBox.SelectedValue]);
            Program.code = Code.codes[(int)EncodeComboBox.SelectedValue];

            Init.Start(); // инициализируем текст
            DGV.Create(Program.N, Program.N, dataGridView); // создаём таблицу
            DGV.Write(Program.array, dataGridView); // заполняем таблицу
            TextGroupBox.Text = "Шифруемый текст"; // Меняем заголовок
            textBox.Text = Program.originalText; // пишем шифруемый текст
            DGV.SpiralColoring(dataGridView);
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            TextGroupBox.Text = "Зашифрованный текст";  // Меняем заголовок
            Program.encodeText = Encode.Start();        // Запоминаем шифрованный текст
            textBox.Text = Program.encodeText;          // пишем шифруемый текст
            DecodeButton.Enabled = true;                // делаем кнопку дешифрования доступной
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            TextGroupBox.Text = "Расшифрованный текст";         // Меняем заголовок
            textBox.Text = Decode.Start(Program.encodeText);    // пишем шифруемый текст
        }
    }
}
