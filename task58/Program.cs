

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 3  | 3 4 4 
// 3 2 5  | 3 5 4 
// 2 4 4  | 3 3 4 
// Результирующая матрица будет:
// 18 20
// 15 18


void Main()
{
    Console.Clear();
    int row1 = UserInput("Введите количество строк первой матрицы");
    int col1 = UserInput("Введите количество столбцов первой матрицы");
    int row2 = UserInput("Введите количество строк второй матрицы");
    int col2 = UserInput("Введите количество столбцов второй матрицы");
    int minVal = UserInput("Введите минимальное значение");
    int maxVal = UserInput("Введите максимальное значение");
    int[,] matrix1 = GetMatrix(row1, col1, minVal, maxVal);
    int[,] matrix2 = GetMatrix(row2, col2, minVal, maxVal);
    if (col1 != row2) Console.WriteLine("заданные массивы нельзя перемножить");
    else
    {
        int[,] result = MultMatrix(matrix1, matrix2);
        PrintMatrix(matrix1);
        Console.WriteLine();
        PrintMatrix(matrix2);
        Console.WriteLine();
        PrintMatrix(result);
    }
}
int UserInput(string text)
{
    Console.Write($"{text}: ");
    int temp = int.Parse(Console.ReadLine()!);
    return temp;
}

int[,] GetMatrix(int m, int n, int min, int max)
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

void PrintMatrix(int[,] array)
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

int[,] MultMatrix(int[,] matr1, int[,] matr2)
{
    int[,] result = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                result[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return result;
}
Main();