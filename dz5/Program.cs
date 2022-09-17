int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    int x = 0;
    int time = m * n / 4;
        for (int round = 0; round < time; round++)
        {
            for (int side = 0; side <= 3; side++)
            {
                if (side < 2)
                {
                    if (side == 0)
                    {
                        for (int i = round; i < n - 1; i++)
                        {
                            x++;
                            array[round, i] = x;
                        }
                    }
                    if (side == 1)
                    {
                        for (int j = round; j < m - 1; j++)
                        {
                            x++;
                            array[j, n - 1] = x;
                        }
                    }
                }
                if (side >= 2)
                {
                    if (side == 2)
                    {
                        for (int k = n - 1; k > round; k--)
                        {
                            x++;
                            array[m - 1, k] = x;
                        }
                    }
                    if (side == 3)
                    {
                        for (int l = m - 1; l > round; l--)
                        {
                            x++;
                            array[l, round] = x;
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