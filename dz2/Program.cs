int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] MinSumLine(int[,] array, int[] sums)
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sums[k] = array[i, j] + sums[k];
        }
        k++;
    }
    return sums;
}

int Result(int[] array)
{
    int min = array[0];
    int indexMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            indexMin = i + 1;
        }
    }
    return indexMin;
}

Console.WriteLine("Введите колличество строк двумерного массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine());

int[,] mas = FillArray(m, n);

Console.WriteLine();
PrintArray(mas);
Console.WriteLine();

int[] sums = new int[mas.GetLength(0)];
Console.WriteLine($"Минимальная сумма элементов находится в {Result(MinSumLine(mas, sums))} строке");