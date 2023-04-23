// // Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Main()
{
    Console.Clear();
    int row = UserInput("Введите количество строк");
    int col = UserInput("Введите количество столбцов");
    string[,] matrix = GetMatrixSpiral(row, col);
    PrintMatrix(matrix);
    Console.WriteLine();
}

int UserInput(string text)
{
    Console.Write($"{text}: ");
    int temp = int.Parse(Console.ReadLine()!);
    return temp;
}


void PrintMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");  //   -> \t это для отделения столбцов.
        }
        Console.WriteLine();
    }
}
string[] ArrayOfValues(int size)
{
    string[] array = new string[size];
    int count = 01;
    for (int i = 0; i < size; i++)
    {
        array[i] = count.ToString("000");
        count++;
    }
    return array;
}

string[,] GetMatrixSpiral(int m, int n)
{
    string[,] matrix = new string[m, n];
    string[] array = ArrayOfValues(matrix.Length);
    int arrayCount = 0;
    for (int i = 0; i < matrix.Length; i++)
    {
        if (arrayCount < array.Length)
        {
            for (int rowStepRight = 0 + i; rowStepRight < matrix.GetLength(1) - i; rowStepRight++)
            {
                int positionForStepRight = 0 + i;
                matrix[positionForStepRight, rowStepRight] = array[arrayCount++];
            }
        }
        if (arrayCount < array.Length)
        {
            for (int colStepDown = 1 + i; colStepDown < matrix.GetLength(0) - i; colStepDown++)
            {
                int positionForStepDown = matrix.GetLength(1) - 1 - i;
                matrix[colStepDown, positionForStepDown] = array[arrayCount++];
            }
        }
        if (arrayCount < array.Length)
        {
            for (int rowStepLeft = matrix.GetLength(1) - 2 - i; rowStepLeft >= i; rowStepLeft--)
            {
                int positionForStepLeft = matrix.GetLength(0) - 1 - i;
                matrix[positionForStepLeft, rowStepLeft] = array[arrayCount++];
            }
        }
        if (arrayCount < array.Length)
        {
            for (int colStepUp = matrix.GetLength(0) - 2 - i; colStepUp > i; colStepUp--)
            {
                int positionForStepUp = 0 +i;
                matrix[colStepUp,positionForStepUp] = array[arrayCount++];
            }
        }

    }
    return matrix;
}
Main();

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07