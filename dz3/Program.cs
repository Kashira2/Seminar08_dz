int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 4);
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

int[,] MatrixProduct(int[,] array1, int[,] array2, int m1, int n2)
{
    int[,] resultArray = new int[m1, n2];
    int sumMatrix = 0;
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            sumMatrix = 0;
            for (int g = 0; g < m1; g++)
            {
                sumMatrix = array1[j, g] * array2[g, i] + sumMatrix;
            }
            resultArray[j, i] = sumMatrix;
        }

    }
    return resultArray;
}

//Console.WriteLine("Введите колличество строк первой матрицы: ");
int m1 = 2; //int.Parse(Console.ReadLine());
//Console.WriteLine("Введите колличество столбцов первой матрицы: ");
int n1 = 2; //int.Parse(Console.ReadLine());
//Console.WriteLine("Введите колличество строк второй матрицы: ");
int m2 = 2; //int.Parse(Console.ReadLine());
//Console.WriteLine("Введите колличество столбцов второй матрицы: ");
int n2 = 2; //int.Parse(Console.ReadLine());

int[,] mas1 = FillArray(m1, n1);
int[,] mas2 = FillArray(m1, n1);

Console.WriteLine();
PrintArray(mas1);
Console.WriteLine();
PrintArray(mas2);
Console.WriteLine();

PrintArray(MatrixProduct(mas1, mas2, m1, n2));

//if (n1 == m2) MatrixProduct(mas1, mas2, m1, n2);

