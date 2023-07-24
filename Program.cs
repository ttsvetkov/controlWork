// Написать программу которая из имеющегосямассива строк, длина которых меньше либо равна 3 символа.

using static setArray;

string[] array = ConsoleInputArray(); // запрос к пользователю и заполнение массива строк
string[] outArray = createOutputArray(array); // создаем массив нужной размерности

fillOutputArray(array, outArray); // заполняем массив подходящими элементами
string output = Print(outArray); 
System.Console.WriteLine(output);

