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

        /// <summary>
        /// Тип инициализации массива
        /// </summary>
        public static int initType = -1;
        /// <summary>
        /// Код метода шифрования
        /// </summary>
        public static string code = "";
        /// <summary>
        /// Первая обрабатываемая ось
        /// </summary>
        public static char firstCoord = 'y';
        /// <summary>
        /// Исходные отклонения
        /// </summary>
        public static int[] firstD = new int[2];
        /// <summary>
        /// Отклонения
        /// </summary>
        public static int[] d = new int[2];

        /// <summary>
        /// Исходный текст
        /// </summary>
        public static string originalText = "";
        /// <summary>
        /// Массив шифруемого чего-нибудь
        /// </summary>
        public static string[,] array;
        /// <summary>
        /// Размерность массива
        /// </summary>
        public static int N = 0; 

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //Dialog.Start();
            Init.Start();
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
