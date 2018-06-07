///// <summary>
///// Класс, обеспечивающий диалог с пользователем
///// </summary>
//internal class Dialog
//{




//    /// <summary>
//    /// Установка размерности массива
//    /// </summary>
//    static void SetArrayLength()
//    {
//        //Console.Write("Введите размер матрицы: ");
//        Program.N = ArrayLengthComboBox;

//        // Этот кусок кода будет парить мозг, пока не введёшь нормальное значение
//        if ((N % 2 == 0) || N < 3)
//        {
//            while ((N % 2 == 0) || N < 3)
//            {
//                //Console.WriteLine("Неверный размер матрицы! ");
//                //Console.Write("Введите другое значение: ");
//                N = Int32.Parse(Console.ReadLine());
//            }
//        }
//        Console.WriteLine();
//    }

//    /// <summary>
//    /// Установка метода шифрования
//    /// </summary>
//    static void SetEncodeMethod()
//    {
//        int type = 0;
//        Console.Write("Отлично! \nА теперь выберите способ шифрования: \n\n");
//        for (int i = 0; i < Code.codes.Length; i++) // для всех, перечисленных в массиве, способов шифрования вывести их описание
//            Console.Write("[" + (i + 1) + "]  " + "[" + Code.codes[i] + "]\n"); // до этого тут были восемь строк вывода, написанных от руки (захочешь добавить/удалить один, ищи в коде эту телегу, меняй строку; это тупо, яжпрограммист)
//        Console.WriteLine();
//        Console.Write("Выбранный способ шифрования определяет первые два шага формирования спирали. \n"); // кривое управление в консоле лучше пояснять
//        Console.Write("Введите номер: ");
//        type = Int32.Parse(Console.ReadLine()) - 1; // массив нумеруется с 0, а выводимый список - с 1. Парсим, уменьшаем на 1, охапка дров, type готов 

//        // Этот кусок кода будет парить мозг, пока не введёшь нормальное значение
//        if (type < 0 || type > 7)
//        {
//            while (type < 0 || type > 7)
//            {
//                Console.Write("Неверный номер! \n");
//                Console.Write("Введите другой номер: ");
//                type = Int32.Parse(Console.ReadLine()) - 1;
//            }
//        }
//        Console.WriteLine();

//        firstCoord = Code.GetFirstOperator(Code.codes[type]); // запоминаем первую операцию реализованым своими руками методом, вторая всегда по второй оси, её можно н запоминать, а вычислить
//        d = Code.GetDeviation(Code.codes[type]); // и тоже с отклонениями
//        code = Code.codes[type]; // запоминаем код метода шифрования, потому что почему бы и нет
//    }

//    /// <summary>
//    /// Установка типа инициализации массива
//    /// </summary>
//    static void SetInitType()
//    {
//        int init = 0;
//        Console.WriteLine("Осталось совсем чуть-чуть. ");
//        Console.WriteLine("Выберите тип массива: ");
//        Console.WriteLine();
//        for (int i = 0; i < initTypeArray.GetLength(0); i++) // снова выводим элементы массива строк
//            Console.Write("[" + (i + 1) + "]  " + initTypeArray[i] + "\n");
//        Console.WriteLine();
//        Console.Write("Введите номер типа массива: ");
//        init = Int32.Parse(Console.ReadLine());

//        // Этот кусок кода будет парить мозг, пока не введёшь нормальное значение
//        if (init < 1 || init > initTypeArray.GetLength(0))
//        {
//            while (init < 1 || init > initTypeArray.GetLength(0))
//            {
//                Console.Write("Неверный номер! \n");
//                Console.Write("Введите другой номер: ");
//                init = Int32.Parse(Console.ReadLine());
//            }
//        }

//        // странный костыль, но мне так удобнее
//        switch (init)
//        {
//            case 1:
//                initType = "index";
//                break;
//            case 2:
//                initType = "simbols";
//                break;
//            case 3:
//                initType = "text";
//                break;
//            default:
//                break;
//        }

//        Console.WriteLine();
//    }
//}

//static void Main()
//{
//    Dialog.Start(); // лаконично и красиво
//    Init.Start();   // на будущее: в main методе лучше писать самый минимум команд

//    // вот так делать не надо:
//    Console.WriteLine();
//    Console.WriteLine();
//    Console.WriteLine("Ну что, погнали! \n");
//    Console.WriteLine("Шифруемый текст: \n");
//    Console.WriteLine(ArrayToString(array)); // написал метод - могу выводить массив строкой хоть при каждом изменении значения
//    Console.WriteLine();

//    Show(); // выводит массив массивом
//    Console.WriteLine();

//    Console.WriteLine("Зашифрованный текст: ");
//    string text = Encode.Start(); // шифрует строку и сохраняет её для последующей дешифровки
//    Console.WriteLine(text.Replace("][", "] ["));   // На случай массива индексов - выводит строку, заменяя "][" на "] [", 
//                                                    //      т.е. добавляет пробелы между скобками. Так читать удобнее.

//    Console.WriteLine();
//    Console.WriteLine("Расшифрованный текст: ");
//    Console.WriteLine(Decode.Start(text));  // расшифровывает и выводит текст из строки
//                                            // при желании можно организовать ввод текста с клавиатуры и дешифровать его (но зачем?)

//    Console.ReadKey();
//}

///// <summary>
///// Вывод массива
///// </summary>
///// <param name="array"> Выводимый массив </param>
//static void Show()
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write(array[i, j] + "  ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}