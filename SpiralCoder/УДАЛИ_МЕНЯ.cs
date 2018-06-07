    //    /// <summary>
    //    /// Класс, обеспечивающий диалог с пользователем
    //    /// </summary>
    //    internal class Dialog
    //    {
    //        /* Массив типов инициализации
    //         *  С массивом их проще добавлять
    //         *  Просто добавляешь (или удаляешь) запись, остальное (большей частью) работает само */
    //        static string[] initTypeArray = {
    //            "Индексы (удобно для тестирования)",
    //            "Упорядоченные символы (текст для ленивых)",
    //            "Текст (фрагмент)"
    //        };

    //        /// <summary>
    //        /// Запуск диалога
    //        /// </summary>
    //        internal static void Start()
    //        {
    //            /* Логичный вопрос: зачем добавлять классы (тем более статичные), которые используются один раз, 
    //             * реализуют кучу приватных методов, которые используются один раз в единственном доступном методе?
    //             * 
    //             * Если коротко: оптимизация хаоса. 
    //             * Изначально я написал весь код с одним кастомным классом Point. 
    //             * Его почти невозможно было редактировать или просто читать. 
    //             * А так, каждой операции - свой метод в соответствующем классе. 
    //             * Просто представь, что методы инициализации массивов находятся по соседству с диалоговым методом, 
    //             *      в котором под сотню строк и найти, где выбирается метод инициализации массивов.
    //             * Плюс, методы внутри класса можно свернуть вместе с классом. Тоже удобно. */
    //            SetArrayLength();
    //            SetEncodeMethod();
    //            SetInitType();
    //        }

    //        /// <summary>
    //        /// Установка размерности массива
    //        /// </summary>
    //        static void SetArrayLength()
    //        {
    //            Console.Write("Введите размер матрицы: ");
    //            N = Int32.Parse(Console.ReadLine());

    //            // Этот кусок кода будет парить мозг, пока не введёшь нормальное значение
    //            if ((N % 2 == 0) || N < 3)
    //            {
    //                while ((N % 2 == 0) || N < 3)
    //                {
    //                    Console.WriteLine("Неверный размер матрицы! ");
    //                    Console.Write("Введите другое значение: ");
    //                    N = Int32.Parse(Console.ReadLine());
    //                }
    //            }
    //            Console.WriteLine();
    //        }

    //        /// <summary>
    //        /// Установка метода шифрования
    //        /// </summary>
    //        static void SetEncodeMethod()
    //        {
    //            int type = 0;
    //            Console.Write("Отлично! \nА теперь выберите способ шифрования: \n\n");
    //            for (int i = 0; i < Code.codes.Length; i++) // для всех, перечисленных в массиве, способов шифрования вывести их описание
    //                Console.Write("[" + (i + 1) + "]  " + "[" + Code.codes[i] + "]\n"); // до этого тут были восемь строк вывода, написанных от руки (захочешь добавить/удалить один, ищи в коде эту телегу, меняй строку; это тупо, яжпрограммист)
    //            Console.WriteLine();
    //            Console.Write("Выбранный способ шифрования определяет первые два шага формирования спирали. \n"); // кривое управление в консоле лучше пояснять
    //            Console.Write("Введите номер: ");
    //            type = Int32.Parse(Console.ReadLine()) - 1; // массив нумеруется с 0, а выводимый список - с 1. Парсим, уменьшаем на 1, охапка дров, type готов 

    //            // Этот кусок кода будет парить мозг, пока не введёшь нормальное значение
    //            if (type < 0 || type > 7)
    //            {
    //                while (type < 0 || type > 7)
    //                {
    //                    Console.Write("Неверный номер! \n");
    //                    Console.Write("Введите другой номер: ");
    //                    type = Int32.Parse(Console.ReadLine()) - 1;
    //                }
    //            }
    //            Console.WriteLine();

    //            firstCoord = Code.GetFirstOperator(Code.codes[type]); // запоминаем первую операцию реализованым своими руками методом, вторая всегда по второй оси, её можно н запоминать, а вычислить
    //            d = Code.GetDeviation(Code.codes[type]); // и тоже с отклонениями
    //            code = Code.codes[type]; // запоминаем код метода шифрования, потому что почему бы и нет
    //        }

    //        /// <summary>
    //        /// Установка типа инициализации массива
    //        /// </summary>
    //        static void SetInitType()
    //        {
    //            int init = 0;
    //            Console.WriteLine("Осталось совсем чуть-чуть. ");
    //            Console.WriteLine("Выберите тип массива: ");
    //            Console.WriteLine();
    //            for (int i = 0; i < initTypeArray.GetLength(0); i++) // снова выводим элементы массива строк
    //                Console.Write("[" + (i + 1) + "]  " + initTypeArray[i] + "\n");
    //            Console.WriteLine();
    //            Console.Write("Введите номер типа массива: ");
    //            init = Int32.Parse(Console.ReadLine());

    //            // Этот кусок кода будет парить мозг, пока не введёшь нормальное значение
    //            if (init < 1 || init > initTypeArray.GetLength(0))
    //            {
    //                while (init < 1 || init > initTypeArray.GetLength(0))
    //                {
    //                    Console.Write("Неверный номер! \n");
    //                    Console.Write("Введите другой номер: ");
    //                    init = Int32.Parse(Console.ReadLine());
    //                }
    //            }

    //            // странный костыль, но мне так удобнее
    //            switch (init)
    //            {
    //                case 1:
    //                    initType = "index";
    //                    break;
    //                case 2:
    //                    initType = "simbols";
    //                    break;
    //                case 3:
    //                    initType = "text";
    //                    break;
    //                default:
    //                    break;
    //            }

    //            Console.WriteLine();
    //        }
    //    }

    //    /// <summary>
    //    /// Шифрование
    //    /// </summary>
    //    internal class Encode
    //    {
    //        /// <summary>
    //        /// Метод шифрования
    //        /// </summary>
    //        /// <param name="array"> Шифруемый массив </param>
    //        /// <returns> Возвращает шифрованную строку </returns>
    //        internal static string Start()
    //        {
    //            char secondCoord = firstCoord == 'x' ? 'y' : 'x'; // зачем запоминать, когда можно вычислить? получаем ось для второй операции
    //            Point c = new Point(N / 2, N / 2); // координата центра, хоть N и нечетное, но работает
    //            string str = ""; // итоговая возвращаемая строка

    //            str += array[c.X, c.Y]; // записывает значение центральной ячейки массива

    //            for (int i = 1; i <= (N - 1); i++) // магия делает бочку (спираль)
    //            {
    //                // это очень сложно объяснить
    //                // повторю совет с нарисованной на бумажке спиралью в массиве и записью всех изменений координат
    //                // если не поможет, пиши, скину свои зарисовки, объясню
    //                str += MagicEncode(c, firstCoord, d[0], i) + MagicEncode(c, secondCoord, d[1], i);
    //                Code.Reverse(d);    // меняеет знаки значений отклонений (удобный метод)
    //                                    // P.S.: сейчас я задумался и не понял, зачем этому методу аргумент, по идеи, должно работать и без него, но мне лень исправлять
    //            }

    //            str += MagicEncode(c, firstCoord, d[0], (N - 1)); // добавляет в строку финишную прямую, она в любом случае выбивается из общего цикла

    //            return str;
    //        }

    //        /// <summary>
    //        /// Магия шифрований
    //        /// </summary>
    //        /// <param name="array"> Шифруемый ассив </param>
    //        /// <param name="c"> Точка </param>
    //        /// <param name="coord"> Обрабатываемая координатная ось </param>
    //        /// <param name="d"> Отклонение координаты по выбранной оси </param>
    //        /// <param name="n"> Количество циклов магии </param>
    //        /// <returns> Возвращает кусок строки, познавшей магию шифрования </returns>
    //        static string MagicEncode(Point c, char coord, int d, int n)
    //        {
    //            string temp = "";

    //            // это без бумажки и полулитра не понять
    //            for (int i = 0; i < n; i++)
    //            {
    //                c.Add(coord, d); // добавляет нужной координате нужную поправку
    //                temp += array[c.X, c.Y]; // добавляет значение массива по полученной координате точки 
    //            }

    //            return temp;
    //        }
    //    }

    //    /// <summary>
    //    /// Дешифрование
    //    /// </summary>
    //    internal class Decode
    //    {
    //        /// <summary>
    //        /// Метод дешифрований
    //        /// </summary>
    //        /// <param name="text"> Дешифруемый текст </param>
    //        /// <returns> Дешифрованный текст </returns>
    //        internal static string Start(string text)
    //        {
    //            char[] encodeArray = text.ToCharArray(); // зашифрованный массив
    //            string[] encodeString = new string[encodeArray.Length]; // исправляем косяким с массивом индексов (костыли, но тестить удобнее)
    //            string[,] decodeArray = new string[N, N]; // расшифрованный массив
    //            firstCoord = Code.GetFirstOperator(code); // заново получаем первую координатную ось спирали
    //            d = Code.GetDeviation(code); //                             и первые приращения
    //            char secondCoord = firstCoord == 'x' ? 'y' : 'x'; // логическим образом получаемм вторую ось
    //            Point c = new Point(N / 2, N / 2); // координата центра
    //            string str = ""; // итоговая расшифрованная строка
    //            string temp = text; // дублируем шифрованный текст, чтобы издеваться над текстом, не сломав сохраненный вариант

    //            // тут исправляется косяк, порожденный моей ленью
    //            if (initType == "index")
    //            {
    //                encodeString = new string[N * N];

    //                for (int i = 0; i < (N * N); i++)
    //                {
    //                    /* Так как я ленивый, я добавил удобный для тестирования вариант массива с элементами вида "[x y]" 
    //                     * Отсюда потекли проблемы. В частности, при посимвольном шифровании, 
    //                     *      каждый элемент шифрованной строки является элементом исходной строки (один элемент - один символ, просто). 
    //                     * А в случае с индексами, каждый элемент состоит минимум из 5 символов (один элемент - несколько символов, не надо так), 
    //                     *      где каждый элемент начинается с "[" и заканчивается на "]" 
    //                     */
    //                    encodeString[i] = temp.Substring(0, temp.IndexOf(']') + 1); // Метод  Substring(i, j) возвращает j элементов строки, начиная с i
    //                                                                                //      "[" искать нет смысла, этот символ всегда первый
    //                                                                                //      А IndexOf(char) возвращает индекс первого вхождения char в строку
    //                    temp = temp.Remove(0, temp.IndexOf(']') + 1);               // Метод Remove(i, j) возвращает строку, 
    //                                                                                //      в которой было удалено j символов, начиная с i
    //                }
    //            }
    //            else // если бы не моя лень и не массив индексов, хватило бы куска ниже
    //            {
    //                for (int i = 0; i < (N * N); i++)
    //                {
    //                    // Тот же фокус, что и в IF выше, но по одному элементу
    //                    encodeString[i] = temp.Substring(0, 1); // добавляет один символ с начала строки
    //                    temp = temp.Remove(0, 1);               // и удаляем первый симво
    //                }
    //            }

    //            /* Для дешифрования нужно:
    //             *      - разделить шифрованный текст на элементы (сделано выше); 
    //             *      - повторить ту же спираль, что и при шифровании, только не считывать элементы в строку, 
    //             *              а записывать по одному шифрованному элементу в массив; 
    //             *      - считать массив "построчно" и получить исходный текст. */

    //            int index = 0; // костылиндекс

    //            decodeArray[c.X, c.Y] = encodeString[index]; // записываем первый элемент в центр
    //            index++; // костылиндекс++

    //            Code.Reverse(d); // я так и не понял, почему оно здесь, но без этого массив получается перевернутым

    //            for (int i = 0; i <= (N - 1); i++)
    //            {
    //                // тут схожий непонятный кусок кода, см. Encode, только там обе операции в одной строке, а тут пришлось поделить, ибо index
    //                index = MagicDecode(decodeArray, encodeString, index, c, firstCoord, d[0], i);  // index возвращается, потому что иначе он не меняется
    //                index = MagicDecode(decodeArray, encodeString, index, c, secondCoord, d[1], i); // считай, очередной костыль
    //                Code.Reverse(d); // разворачиваем отклонения
    //            }

    //            MagicDecode(decodeArray, encodeString, index, c, firstCoord, d[0], (N - 1)); // добавляется финишная черта

    //            // Собирает построенный расшифрованный массив в строку
    //            str += ArrayToString(decodeArray);

    //            return str;
    //        }

    //        /// <summary>
    //        /// Магия дешифрования
    //        /// </summary>
    //        /// <param name="decodeArray"> Дешифрованный массив </param>
    //        /// <param name="encodeString"> Шифрованный массив </param>
    //        /// <param name="index"> Индекс элемента шифрованного массива </param>
    //        /// <param name="c"> Точка </param>
    //        /// <param name="coord"> Обрабатываемая координатная ось </param>
    //        /// <param name="d"> Отклонение координаты по выбранной оси </param>
    //        /// <param name="n"> Количество циклов магии </param>
    //        /// <returns> Возвращает индекс шифрованного массива, чтобы не ломать порядок </returns>
    //        static int MagicDecode(string[,] decodeArray, string[] encodeString, int index, Point c, char coord, int d, int n)
    //        {
    //            for (int j = 0; j < n; j++)
    //            {
    //                // бумажка в помощь
    //                c.Add(coord, d);
    //                decodeArray[c.X, c.Y] = encodeString[index];
    //                index++;
    //            }
    //            return index;
    //        }
    //    }


    //    static void Main()
    //    {
    //        Dialog.Start(); // лаконично и красиво
    //        Init.Start();   // на будущее: в main методе лучше писать самый минимум команд

    //        // вот так делать не надо:
    //        Console.WriteLine();
    //        Console.WriteLine();
    //        Console.WriteLine("Ну что, погнали! \n");
    //        Console.WriteLine("Шифруемый текст: \n");
    //        Console.WriteLine(ArrayToString(array)); // написал метод - могу выводить массив строкой хоть при каждом изменении значения
    //        Console.WriteLine();

    //        Show(); // выводит массив массивом
    //        Console.WriteLine();

    //        Console.WriteLine("Зашифрованный текст: ");
    //        string text = Encode.Start(); // шифрует строку и сохраняет её для последующей дешифровки
    //        Console.WriteLine(text.Replace("][", "] ["));   // На случай массива индексов - выводит строку, заменяя "][" на "] [", 
    //                                                        //      т.е. добавляет пробелы между скобками. Так читать удобнее.

    //        Console.WriteLine();
    //        Console.WriteLine("Расшифрованный текст: ");
    //        Console.WriteLine(Decode.Start(text));  // расшифровывает и выводит текст из строки
    //                                                // при желании можно организовать ввод текста с клавиатуры и дешифровать его (но зачем?)

    //        Console.ReadKey();
    //    }

    //    /// <summary>
    //    /// Вывод массива
    //    /// </summary>
    //    /// <param name="array"> Выводимый массив </param>
    //    static void Show()
    //    {
    //        for (int i = 0; i < array.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < array.GetLength(1); j++)
    //            {
    //                Console.Write(array[i, j] + "  ");
    //            }
    //            Console.WriteLine();
    //        }
    //        Console.WriteLine();
    //    }

    //    /// <summary>
    //    /// Преобразование массива в строку
    //    /// </summary>
    //    /// <param name="array"> Массив </param>
    //    /// <returns> Строка </returns>
    //    static string ArrayToString(string[,] array)
    //    {
    //        string temp = "";

    //        for (int i = 0; i < array.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < array.GetLength(1); j++)
    //            {
    //                temp += array[i, j];
    //            }
    //        }

    //        return temp;
    //    }
    //}