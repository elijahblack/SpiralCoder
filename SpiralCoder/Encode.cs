using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralCoder
{
    /// <summary>
    /// Шифрование
    /// </summary>
    class Encode
    {
        /// <summary>
        /// Метод шифрования
        /// </summary>
        /// <param name="array"> Шифруемый массив </param>
        /// <returns> Возвращает шифрованную строку </returns>
        public static string Start()
        {
            char secondCoord = Program.firstCoord == 'x' ? 'y' : 'x'; // зачем запоминать, когда можно вычислить? получаем ось для второй операции
            Point c = new Point(Program.N / 2, Program.N / 2); // координата центра, хоть N и нечетное, но работает
            string str = ""; // итоговая возвращаемая строка

            str += Program.array[c.X, c.Y]; // записывает значение центральной ячейки массива

            for (int i = 1; i <= (Program.N - 1); i++) // магия делает бочку (спираль)
            {
                // это очень сложно объяснить
                // повторю совет с нарисованной на бумажке спиралью в массиве и записью всех изменений координат
                // если не поможет, пиши, скину свои зарисовки, объясню
                str += MagicEncode(c, Program.firstCoord, Program.d[0], i) + MagicEncode(c, secondCoord, Program.d[1], i);
                Code.Reverse(Program.d);    // меняеет знаки значений отклонений (удобный метод)
                                    // P.S.: сейчас я задумался и не понял, зачем этому методу аргумент, по идеи, должно работать и без него, но мне лень исправлять
            }

            str += MagicEncode(c, Program.firstCoord, Program.d[0], (Program.N - 1)); // добавляет в строку финишную прямую, она в любом случае выбивается из общего цикла

            return str;
        }

        /// <summary>
        /// Магия шифрований
        /// </summary>
        /// <param name="array"> Шифруемый ассив </param>
        /// <param name="c"> Точка </param>
        /// <param name="coord"> Обрабатываемая координатная ось </param>
        /// <param name="d"> Отклонение координаты по выбранной оси </param>
        /// <param name="n"> Количество циклов магии </param>
        /// <returns> Возвращает кусок строки, познавшей магию шифрования </returns>
        private static string MagicEncode(Point c, char coord, int d, int n)
        {
            string temp = "";

            // это без бумажки и полулитра не понять
            for (int i = 0; i < n; i++)
            {
                c.Add(coord, d); // добавляет нужной координате нужную поправку
                temp += Program.array[c.X, c.Y]; // добавляет значение массива по полученной координате точки 
            }

            return temp;
        }
    }
}
