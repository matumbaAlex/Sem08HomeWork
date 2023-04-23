
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Main()
{
    Console.Clear();
    int row = UserInput("Введите количество строк");
    int col = UserInput("Введите количество столбцов");
    int minVal = UserInput("Введите минимальное значение");
    int maxVal = UserInput("Введите максимальное значение");
    int[,] array = GetArray(row, col, minVal, maxVal);
    PrintArray(array);
    Console.WriteLine();
    int[] sumArray=GetSumArray(array);
    GetMinSum(sumArray);
    
    PrintArray(array);
    
    Console.WriteLine();

}

int UserInput(string text)
{
    Console.Write($"{text}: ");
    int temp = int.Parse(Console.ReadLine()!);
    return temp;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");  //   -> \t это для отделения столбцов.
        }
        Console.WriteLine();
    }
}

int[] GetSumArray(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[index]+= array[i,j];
        }
        index++;
    }
    return result;
}

void GetMinSum (int[] array)
{
    int minimum = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
      if (array[i] < minimum)
        {
            minimum = array[i];
            index = i;
        }

    Console.WriteLine ($"сумма элементов наименьшая в строке номер {index+1} ");
    Console.WriteLine();
}
Main();