using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralCoder
{
    /// <summary>
    /// Дешифрование
    /// </summary>
    class Decode
    {
        /// <summary>
        /// Метод дешифрований
        /// </summary>
        /// <param name="text"> Дешифруемый текст </param>
        /// <returns> Дешифрованный текст </returns>
        internal static string Start(string text)
        {
            char[] encodeArray = text.ToCharArray();                    // зашифрованный массив
            string[] encodeString = new string[encodeArray.Length];     // исправляем косяким с массивом индексов (костыли, но тестить удобнее)
            string[,] decodeArray = new string[Program.N, Program.N];   // расшифрованный массив
            Program.firstCoord = Code.GetFirstOperator(Program.code);   // заново получаем первую координатную ось спирали
            Program.d = Code.GetDeviation(Program.code);                //                              и первые приращения
            char secondCoord = Program.firstCoord == 'x' ? 'y' : 'x';   // логическим образом получаемм вторую ось
            Point c = new Point(Program.N / 2, Program.N / 2);          // координата центра
            string str = "";                                            // итоговая расшифрованная строка
            string temp = text;                                         // дублируем шифрованный текст, чтобы издеваться над текстом, 
                                                                        //                              не сломав сохраненный вариант

            // разбирается массив индексов
            if (Program.initType == 0)
            {
                encodeString = new string[Program.N * Program.N];

                for (int i = 0; i < (Program.N * Program.N); i++)
                {
                    encodeString[i] = temp.Substring(0, temp.IndexOf(']') + 1); // добавляет один "элемент" с начала строки
                    temp = temp.Remove(0, temp.IndexOf(']') + 1);               // и удаляем первый "элемент"
                }
            }
            else // разбираются символьные массивы
            {
                for (int i = 0; i < (Program.N * Program.N); i++)
                {
                    encodeString[i] = temp.Substring(0, 1); // добавляет один символ с начала строки
                    temp = temp.Remove(0, 1);               // и удаляем первый символ
                }
            }

            /* Для дешифрования нужно:
             *      - разделить шифрованный текст на элементы (сделано выше); 
             *      - повторить ту же спираль, что и при шифровании, только не считывать элементы в строку, 
             *              а записывать по одному шифрованному элементу в массив; 
             *      - считать массив "построчно" и получить исходный текст. */

            int index = 0; // костылиндекс

            decodeArray[c.X, c.Y] = encodeString[index]; // записываем первый элемент в центр
            index++; // костылиндекс++

            Code.Reverse(Program.d); // я так и не понял, почему оно здесь, но без этого массив получается перевернутым

            for (int i = 0; i <= (Program.N - 1); i++)
            {
                // тут схожий непонятный кусок кода, см. Encode, только там обе операции в одной строке, а тут пришлось поделить, ибо index
                index = MagicDecode(decodeArray, encodeString, index, c, Program.firstCoord, Program.d[0], i);  // index возвращается, потому что иначе он не меняется
                index = MagicDecode(decodeArray, encodeString, index, c, secondCoord, Program.d[1], i);         // считай, очередной костыль
                Code.Reverse(Program.d); // разворачиваем отклонения
            }

            MagicDecode(decodeArray, encodeString, index, c, Program.firstCoord, Program.d[0], (Program.N - 1)); // добавляется финишная черта

            // Собирает построенный расшифрованный массив в строку
            str += Program.ArrayToString(decodeArray);

            return str;
        }

        /// <summary>
        /// Магия дешифрования
        /// </summary>
        /// <param name="decodeArray"> Дешифрованный массив </param>
        /// <param name="encodeString"> Шифрованный массив </param>
        /// <param name="index"> Индекс элемента шифрованного массива </param>
        /// <param name="c"> Точка </param>
        /// <param name="coord"> Обрабатываемая координатная ось </param>
        /// <param name="d"> Отклонение координаты по выбранной оси </param>
        /// <param name="n"> Количество циклов магии </param>
        /// <returns> Возвращает индекс шифрованного массива, чтобы не ломать порядок </returns>
        private static int MagicDecode(string[,] decodeArray, string[] encodeString, int index, Point c, char coord, int d, int n)
        {
            for (int j = 0; j < n; j++)
            {
                // бумажка в помощь
                c.Add(coord, d);
                decodeArray[c.X, c.Y] = encodeString[index];
                index++;
            }
            return index;
        }
    }
}
