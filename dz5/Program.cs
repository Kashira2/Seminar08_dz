int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    int x = 0;
    int time = m * n / 4;
        for (int k = 0; k < time; k++)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (i < 2)
                {
                    if (i == 0)
                    {
                        for (int j = k; j < n - 1; j++)
                        {
                            x++;
                            array[k, j] = x;
                        }
                    }
                    if (i == 1)
                    {
                        for (int z = k; z < m - 1; z++)
                        {
                            x++;
                            array[z, n - 1] = x;
                        }
                    }
                }
                if (i >= 2)
                {
                    if (i == 2)
                    {
                        for (int g = n - 1; g > k; g--)
                        {
                            x++;
                            array[m - 1, g] = x;
                        }
                    }
                    if (i == 3)
                    {
                        for (int l = m - 1; l > k; l--)
                        {
                            x++;
                            array[l, k] = x;
                        }
                    }
                }
            }
            m--;
            n--;
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

Console.WriteLine("Введите колличество строк двумерного массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine());

int[,] mas = FillArray(m, n);

Console.WriteLine();
PrintArray(mas);
Console.WriteLine();