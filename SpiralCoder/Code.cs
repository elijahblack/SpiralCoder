using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralCoder
{
    /// <summary>
    /// Класс, который мне захотелось сделать, он удобный
    /// </summary>
    class Code
    {
        /// <summary>
        /// Массив строковых представлений методов шифрования
        /// </summary>
        public static string[] codes = new string[8] {
                "y+ x-",    
                "y+ x+",    
                "y- x+",    
                "y- x-",                                                               
                "x+ y-",
                "x+ y+",
                "x- y+",
                "x- y-"
            };
        
        /// <summary>
        /// Возвращает символьное значение переменной первой операции
        /// </summary>
        /// <param name="c"> Строковое представление кода </param>
        /// <returns> Возвращает символьное значение переменной первой операции </returns>
        internal static char GetFirstOperator(string c)
        {
            return c.ToCharArray()[0]; 
        }

        /// <summary>
        /// Возвращает массив отклонений первых двух операций шифрования
        /// </summary>
        /// <param name="code"> Строковое представление кода </param>
        /// <returns> Возвращает массив отклонений первых двух операций шифрования </returns>
        internal static int[] GetDeviation(string code)
        {
            int[] d = new int[2];

            // парсинг строчной записи "способов шифрования"
            d[0] = code.ToCharArray()[1] == '+' ? 1 : -1;   
            d[1] = code.ToCharArray()[4] == '+' ? 1 : -1;   

            Program.firstD = d; // запись первых отклонений, для последуйщего дешифрования

            return d;
        }

        /// <summary>
        /// Обращает значения отклонений
        /// </summary>
        /// <param name="d"> Массив отклонений </param>
        internal static void Reverse(int[] d)
        {
            d[0] = d[0] < 0 ? 1 : -1;
            d[1] = d[1] < 0 ? 1 : -1;
        }
    }
}
