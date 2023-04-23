// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1                                                      // доделать!!!!

// 9 5 3 2
// 8 4 4 2


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
    Sort(array);
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

void Sort(int[,] array)
{

    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = j + 1; n < array.GetLength(1); n++)
            {
                if (array[i, j] < array[i, n])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, n];
                    array[i, n] = temp;
                }
            }
        }
    }
}

Main();



// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// for (int k = 0; k < array.GetLength(1) — 1; k++)
// {
// if (array[i, k] < array[i, k + 1])
// {
// int temp = array[i, k + 1];
// array[i, k + 1] = array[i, k];
// array[i, k] = temp;
// }
// }
// }