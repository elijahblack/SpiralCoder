using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiralCoder
{
    static class Program
    {
        // слишком много глобальных переменных
        // делать так -- очень плохо, но работает
        public static string initType = "null";     // тип инициализации массива
        public static string code = "";             // код метода шифрования
        public static char firstCoord = 'y';        // первая обрабатываемая ось
        public static int[] firstD = new int[2];    // исходные отклонения
        public static int[] d = new int[2];         // отклонения

        public static string originalText = "";     // исходный текст
        public static string[,] array;              // массив шифруемого чего-нибудь
        public static int N = 0;                    // размерность массива

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        /// Преобразование массива в строку
        /// </summary>
        /// <param name="array"> Массив </param>
        /// <returns> Строка </returns>
        public static string ArrayToString(string[,] array)
        {
            string temp = "";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    temp += array[i, j];
                }
            }

            return temp;
        }
    }
}
