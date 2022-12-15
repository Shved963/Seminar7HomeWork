namespace Common;

public static class Helper
{
    public static void PrintArray(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
            Console.Write(" ");
        }
    }

    public static int[] CreateRandomArray()
    {
        Random random = new Random();

        int[] array = new int[10];

        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(int.MinValue, int.MaxValue);

        }

        return array;
    }

    public static void PrintArray(int[,] array)
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

    public static int[,] CreateRandom2DArray(int countOfRow, int countOfColums)
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

    public static int[,] Create2DArrayAndCopy()
    {
        int countOfRow = Common.Helper.IntoInt();
        int countOfColums = Common.Helper.IntoInt();

        int[,] array = new int[countOfRow, countOfColums];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = i + j;
            }
        }

        return array;
    }

    public static int IntoInt()
    {
        bool isParsed = int.TryParse(Console.ReadLine(), out int num);
        if (isParsed)
        {
            return num;
        }
        else
        {
            throw new Exception("Ввели не корректные данные");
        }

    }

}
