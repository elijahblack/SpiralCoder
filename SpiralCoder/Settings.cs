using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiralCoder
{
    class Settings
    {
        

        /// <summary>
        /// Минимальное значение размерности массива
        /// </summary>
        public static int MinValueArrayLength = 3; // размерность массива начнётся с этого числа
        /// <summary>
        /// Количество размерностей массива
        /// </summary>
        public static int QuantityArrayLength = 10; // И чисел будет столько

        /// <summary>
        /// Метод, добавляющий в ComboBox данные из массива строк
        /// </summary>
        /// <param name="comboBox"> Редактируемый ComboBox </param>
        /// <param name="array"> Массив строк </param>
        public static void SetComboBoxData(ComboBox comboBox, string[] array)
        {
            if (comboBox.Name == "ArrayLengthComboBox")
                comboBox.DataSource = GetArrayLengthComboBox(array).DataSource;
            else
                comboBox.DataSource = GetComboBox(array).DataSource;
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
        }

        /// <summary>
        /// Метод, получающий ComboBox из массива строк
        /// </summary>
        /// <param name="array"> Массив строк </param>
        /// <returns> ComboBox с данными </returns>
        public static ComboBox GetComboBox(string[] array)
        {
            ComboBox comboBox = new ComboBox();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            for (int i = 0; i < array.Length; i++)
                dictionary.Add(i, array[i]);

            comboBox.DataSource = new BindingSource(dictionary, null);
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";

            return comboBox;
        }

        /// <summary>
        /// Метод, получающий ComboBox специально для размерностей массивов из массива строк
        /// </summary>
        /// <param name="array"> Массив строк </param>
        /// <returns> Получает ComboBox специально для размерностей массивов </returns>
        public static ComboBox GetArrayLengthComboBox(string[] array)
        {
            ComboBox comboBox = new ComboBox();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            for (int i = 0; i < array.Length; i++)
                dictionary.Add(Convert.ToInt32(array[i]), array[i] + " x " + array[i]);

            comboBox.DataSource = new BindingSource(dictionary, null);
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";

            return comboBox;
        }

        /// <summary>
        /// Метод возвращает массив вариантов размерностей матрицы
        /// </summary>
        /// <param name="quantity"> Количество вариантов размерностей </param>
        /// <returns> Строковый массив вариантов </returns>
        public static string[] GetArrayLengthArray()
        {
            string[] array = new string[QuantityArrayLength];
            // На случай, если кто-то придумает поставить мин. размерность четной:
            int count = MinValueArrayLength % 2 == 0 ? MinValueArrayLength + 1 : MinValueArrayLength;    
            count = count > 0 ? count : -count;  // Или если отрицательной
            for (int i = 0; i < QuantityArrayLength; i++)
            {
                array[i] = count.ToString();
                count += 2;
            }
            return array;
        }
        
        /// <summary>
        /// Метод возвращает массив типов инициализации текста
        /// </summary>
        /// <returns> Строковый массив типов инициализации текста </returns>
        public static string[] GetInitTypeArray()
        {
            return new string[] {
                "Индексы (удобно для тестирования)",
                "Упорядоченные символы (текст для ленивых)",
                "Текст (фрагмент)"
            };
        }
    }
}
