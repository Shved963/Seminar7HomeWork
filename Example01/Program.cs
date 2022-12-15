// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
PrintArray(CreateRandom2DArray());

double[,] CreateRandom2DArray()
{
    int countOfRow = Common.Helper.IntoInt();
    int countOfColums = Common.Helper.IntoInt();
    double[,] array = new double[countOfRow, countOfColums];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.Next(-100, 101) + random.NextDouble(), 1);

        }
    }

    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}