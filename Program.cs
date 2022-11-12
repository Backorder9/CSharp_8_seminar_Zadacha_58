/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
void PrintArray(int[,] array)
{
    System.Console.WriteLine();
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    System.Console.WriteLine();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
            System.Console.Write("{0}\t", array[i, j]);
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] Snake()
{
    Console.WriteLine();
    Console.Write("Введите количество строк массива целых чисел ~Змейка~: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите количество столбцов массива целых чисел ~Змейка~: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int[,] snake = new int[a, b];
    snake[0, 0] = 1;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            if (i > 0 && j == 0) snake[i, j] = snake[i - 1, b - 1] + 1;
            if (j > 0) snake[i, j] = snake[i, j - 1] + 1;
        }
    }
    return snake;
}

int[,] RandomIntNumbersArray()
{
    Console.WriteLine();
    Console.Write("Введите количество строк массива случайных целых чисел: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите количество столбцов массива случайных целых чисел: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int[,] Num = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Num[i, j] = new Random().Next(0, 10);
        }
    }
    return Num;
}

int[,] MatricesProduct(int[,] factorA, int[,] factorB)
{
    int x = factorA.GetLength(0);
    int y = factorA.GetLength(1);
    int u = factorB.GetLength(0);
    int v = factorB.GetLength(1);
    if (y != u)
    {
        System.Console.WriteLine("Произведение двух матриц - невозможно:");
        System.Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй.");
        int[,] EmptyArray = { { 0 } };
        return EmptyArray;
    }
    int[,] ProductArray = new int[x, v];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < v; j++)
        {
            int sum = 0;
            for (int k = 0; k < u; k++)
            {
                sum += factorA[i, k] * factorB[k, j];
            }
            ProductArray[i, j] = sum;
        }
    }
    return ProductArray;
}

int [,] FirstMatrix = RandomIntNumbersArray();
int [,] SecondMatrix = Snake();
int [,] ProductMatrix = MatricesProduct(FirstMatrix,SecondMatrix);
Console.WriteLine();
System.Console.WriteLine("Массив случайных целых чисел:");
PrintArray(FirstMatrix);
Console.WriteLine();
System.Console.WriteLine("Массив целых чисел ~Змейка~:");
PrintArray(SecondMatrix);
Console.WriteLine();
System.Console.WriteLine("Произведение матриц массивов случайных целых чисел и ~Змейка~:");
PrintArray(ProductMatrix);