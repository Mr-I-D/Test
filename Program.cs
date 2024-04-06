using System;

class Program
{
    static void Main()
    {
        // Шаг 1: Ввод массива строк
        Console.Write("Введите количество строк в массиве: ");
        int n = int.Parse(Console.ReadLine());
        string[] strings = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            strings[i] = Console.ReadLine();
        }

        // Шаг 2: Фильтрация строк
        string[] newStrings = new string[strings.Length];
        int count = 0;
        foreach (string str in strings)
        {
            if (str.Length <= 3)
            {
                newStrings[count] = str;
                count++;
            }
        }
        Array.Resize(ref newStrings, count);

        // Шаг 3: Вывод нового массива строк
        Console.WriteLine("Новый массив строк:");
        foreach (string str in newStrings)
        {
            Console.WriteLine(str);
        }
    }
}
