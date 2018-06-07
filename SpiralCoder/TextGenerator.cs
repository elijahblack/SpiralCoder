using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralCoder
{
    class TextGenerator
    {


        /// <summary>
        /// Преобразование массива в строку
        /// </summary>
        /// <param name="array"> Массив </param>
        /// <returns> Строка </returns>
        public static string ArrayToString(string[,] array)
        {
            string temp = "";

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    temp += array[i, j];

            return temp;
        }
    }
}
