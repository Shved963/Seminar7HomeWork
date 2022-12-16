// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static Common.Helper;

Console.Clear();

Console.WriteLine("Введите размер двумерного массива");
int[,] array = CreateRandom2DArray();
Console.WriteLine();
Common.Helper.PrintArray(array);
Console.WriteLine();
double[] average = GetAverageColums(array);
PrintArray(average);



double[] GetAverageColums(int[,] array)
{
    double[] averageArray = new double[array.GetLength(1)];
    int count = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            averageArray[j] = averageArray[j] + array[i, j];
            count++;
        }
        averageArray[j] = Math.Round(averageArray[j] / count, 1);
        count = 0;
    }

    return averageArray;
}




int[,] CreateRandom2DArray()
{
    int countOfRow = IntoInt();
    int countOfColums = IntoInt();
    int[,] array = new int[countOfRow, countOfColums];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);

        }
    }

    return array;
}


void PrintArray(double[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
}

int IntoInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (isParsed && num > 0)
    {
        return num;
    }
    else
    {
        throw new ArgumentException("Ввели не корректные данные");
    }

}