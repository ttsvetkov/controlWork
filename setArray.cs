public class setArray
{
    public static string[] ConsoleInputArray()
    {
        string[] arr = new string[5];

        int flag = 0; // флаг для парсинга строки 

        Console.WriteLine("Введите пять элементов массива через запятую:");
        // вводим строку
        string inputX = Console.ReadLine();

        if (inputX != null)
        {
            for (int i = 0; i < inputX.Length; i++)
            {
                if (inputX[i] == ',') flag++;
                if (inputX[i] != ',' && flag == 0) arr[flag] += inputX[i];
                if (inputX[i] != ',' && flag == 1) arr[flag] += inputX[i];
                if (inputX[i] != ',' && flag == 2) arr[flag] += inputX[i];
                if (inputX[i] != ',' && flag == 3) arr[flag] += inputX[i];
                if (inputX[i] != ',' && flag == 4) arr[flag] += inputX[i];

            }
        }
        else Console.WriteLine($" Массив не получился =) ");

        return arr;
    }

    public static string[] createOutputArray(string[] array)
    {
        int size = array.Length;
        int sizeOut = 0;

        string[] arrayOut = new string[size];

        for (int i = 0; i < size; i++)
        {
            if (array[i].Length <= 3) sizeOut++;
        }
        if(sizeOut > 0) 
        {
            string[] arr = new string[sizeOut];
            return arr;
        }
        else 
        {
            Console.WriteLine($" Массив не получился =( ");
            string[] arr = new string[0];
            return arr;
        }

        
    }
    public static int fillOutputArray(string[] array, string[] arrayOut)
    {
        int size = array.Length;
        int j = 0;

        for (int i = 0; i < size; i++)
        {
            if (array[i].Length <= 3)
            {
                arrayOut[j] = array[i]; 
                j++;
            }
        }
        return 1;
    }
    
    public static string Print(string[] array)
    {
        string result = string.Empty;

        int cell = array.GetLength(0);

        for (int i = 0; i < cell; i++)
        {
            
            result += $"{array[i]}({i}) ";
            result += "\n";
        }
        return result;
    }
}