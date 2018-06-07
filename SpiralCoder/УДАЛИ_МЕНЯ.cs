//static void Main()
//{
//    Dialog.Start(); // лаконично и красиво
//    Init.Start();   // на будущее: в main методе лучше писать самый минимум команд

//    // вот так делать не надо:
//    //Console.WriteLine();
//    //Console.WriteLine();
//    //Console.WriteLine("Ну что, погнали! \n");
//    //Console.WriteLine("Шифруемый текст: \n");
//    Console.WriteLine(ArrayToString(array)); // написал метод - могу выводить массив строкой хоть при каждом изменении значения
//    //Console.WriteLine();

//    Show(); // выводит массив массивом
//    //Console.WriteLine();

//    //Console.WriteLine("Зашифрованный текст: ");
//    string text = Encode.Start(); // шифрует строку и сохраняет её для последующей дешифровки
//    Console.WriteLine(text.Replace("][", "] ["));   // На случай массива индексов - выводит строку, заменяя "][" на "] [", 
//                                                    //      т.е. добавляет пробелы между скобками. Так читать удобнее.

//    //Console.WriteLine();
//    //Console.WriteLine("Расшифрованный текст: ");
//    Console.WriteLine(Decode.Start(text));  // расшифровывает и выводит текст из строки
//                                            // при желании можно организовать ввод текста с клавиатуры и дешифровать его (но зачем?)

//    //Console.ReadKey();
//}