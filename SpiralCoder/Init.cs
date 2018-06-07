using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralCoder
{
    /// <summary>
    /// Класс инициализации массива
    /// </summary>
    class Init
    {
        /// <summary>
        /// Запуск инициализации
        /// </summary>
        public static void Start()
        {
            Program.array = new string[Program.N, Program.N];
            Program.originalText = "";
            
            switch (Program.initType)
            {
                case 0:
                    Init.Index();
                    break;
                case 1:
                    Init.Simbols();
                    break;
                case 2:
                    Init.Text();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Инициализация массива индексов
        /// </summary>
        private static void Index()
        {
            // массив индексов вида "[x y][x y+1]..."
            for (int i = 0; i < Program.array.GetLength(0); i++)
            {
                for (int j = 0; j < Program.array.GetLength(1); j++)
                {
                    Program.array[i, j] = "[" + i + " " + j + "]";      // запись в массив для последующего шифрования
                    Program.originalText += "[" + i + " " + j + "]";    // запись в строку, чтобы вывести "шифруемый текст"
                }
            }
        }

        /// <summary>
        /// Инициализация массива символов
        /// </summary>
        private static void Simbols()
        {
            char a = '0';   // присваеваем в char '0'
            int count = 0;  // счетчик, нужный для того, чтобы было красиво и читаемо (дальше подробнее)

            for (int i = 0; i < Program.array.GetLength(0); i++)
            {
                for (int j = 0; j < Program.array.GetLength(1); j++)
                {
                    if (count % 74 == 0) a = '0';  // если счетчик кратный 74, присвоить char'у обратно '0', потому что через 74 символа -- боль
                    Program.array[i, j] = a.ToString();     // присваеваем символ в массив
                    Program.originalText += a.ToString();   //      и в строку

                    a++;    // магия char'а
                    count++;    // и увеличиваем счетчик
                }
            }
        }

        /// <summary>
        /// Инициализация массива текста
        /// </summary>
        private static void Text()
        {
            //  не лучший способ записи длинных строк, но, это хоть прочитать можно
            string str = "Against that time, if ever that time come, " +
                "When I shall see thee frown on my defects, " +
                "When as thy love hath cast his utmost sum, " +
                "Called to that audit by advis'd respects; " +
                "" +
                "Against that time when thou shalt strangely pass, " +
                "And scarcely greet me with that sun, thine eye, " +
                "When love, converted from the thing it was, " +
                "Shall reasons find of settled gravity; " +
                "" +
                "Against that time do I ensconce me here, " +
                "Within the knowledge of mine own desert, " +
                "And this my hand, against my self uprear, " +
                "To guard the lawful reasons on thy part: " +
                "" +
                "To leave poor me thou hast the strength of laws," +
                "Since why to love I can allege no cause. ";
            int a = 0;  // индекс текстового массива

            /* Цикл на случай, если кто-нибудь догадается ввести размер матрицы 101 (текста не хватит, приложение упадет)
             *          
             * Первое правило программиста: "Пользователь всегда идиот. Пиши код исходя из этого." */
            while (str.Length < (Program.N * Program.N))
                str += str;

            for (int i = 0; i < Program.array.GetLength(0); i++)
            {
                for (int j = 0; j < Program.array.GetLength(1); j++)
                {
                    Program.array[i, j] = str.ToCharArray()[a].ToString();      // расчленяем строку на массив символов и записываем очередной элемент в массив
                    Program.originalText += str.ToCharArray()[a].ToString();    // и в строку
                    a++;    // увеличиваем индекс, немного криво, но зато работает
                }
            }
        }
    }
}
