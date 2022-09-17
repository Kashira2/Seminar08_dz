
int[,,] FillArray(int g, int m, int n)         // Создает трехмерный массив с уникальными числами
{
    int[,,] array = new int[g, m, n];
    int[] newArray = new int[g * m * n];
    int x = 0;
    for (int i = 0; i < g; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < n;)
            {
                int random = new Random().Next(1, 100);
                newArray[x] = random;
                bool alredyExists = false;
                for (int d = 0; d < x; d++)
                {
                    if (newArray[d] == random)
                    {
                        alredyExists = true;
                        break;
                    }
                }

                if (alredyExists == false)
                {
                    array[i, j, k] = random;
                    k++;
                    x++;
                }
            }
        }
    }
    return array;
}


void PrintArray(int[,,] table, int g, int m, int n)
{
    for (int i = 0; i < g; i++)
    {
        Console.WriteLine();
        Console.WriteLine($"Массив №{i + 1}");
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write($"{table[i, j, k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine("Введите колличество таблиц трехмерного массива: ");
int g = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество строк трехмерного массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов трехмерного массива: ");
int n = int.Parse(Console.ReadLine());

int[,,] mas = FillArray(g, m, n);

Console.WriteLine();
PrintArray(mas, g, m, n);