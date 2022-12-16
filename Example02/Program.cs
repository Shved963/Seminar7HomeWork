// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static Common.Helper;

Console.WriteLine("Введите позицию в массиве");
int row = Common.Helper.IntoInt();
int colums = Common.Helper.IntoInt();

int[,] array = CreateRandom2DArray(5, 5);
Common.Helper.PrintArray(array);

(int, bool) meaning = TryGetValue(array, row, colums);
PrintResult(meaning);




void PrintResult((int, bool) meaning)
{
    if (meaning.Item2 == true)
    {
        Console.WriteLine(meaning.Item1);
    }
    else
    {
        Console.WriteLine($"{meaning.Item2} Элемента с такой позицией {(row, colums)} не существует");
    }
}



(int, bool) TryGetValue(int[,] array, int row, int colums)
{

    int num = 0;
    bool notExist = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == row && j == colums)
            {
                num = array[i, j];
                notExist = true;
            }
        }
    }

    return (num, notExist);
}



int[,] CreateRandom2DArray(int countOfRow, int countOfColums)
{
    int[,] array = new int[countOfRow, countOfColums];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 11);
        }
    }

    return array;
}