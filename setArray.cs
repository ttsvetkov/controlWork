public class setArray
{
    public static string[] ConsoleInputArray()
    {
        string[] arr = new string[5];

        int flagX = 0; // флаг для парсинга строки координат X

        Console.WriteLine("Введите пять элементов массива через запятую:");
        // вводим строку
        string inputX = Console.ReadLine();

        if (inputX != null)
        {
            for (int i = 0; i < inputX.Length; i++)
            {
                if (inputX[i] == ',') flagX++;
                if (inputX[i] != ',' && flagX == 0) arr[flagX] += inputX[i];
                if (inputX[i] != ',' && flagX == 1) arr[flagX] += inputX[i];
                if (inputX[i] != ',' && flagX == 2) arr[flagX] += inputX[i];
                if (inputX[i] != ',' && flagX == 3) arr[flagX] += inputX[i];
                if (inputX[i] != ',' && flagX == 4) arr[flagX] += inputX[i];

            }
        }
        else Console.WriteLine($" Массив не получился =) ");

        return arr;
    }

    public static string[] OutputArray(string[] array)
    {
        int size = array.Length;
        int sizeOut = 0;

        string[] arrayOut = new string[size]; 

        for (int i = 0; i < size; i++)
            {
                if(array[i].Length <= 3) sizeOut++;
            }
        return arr;
    }
}