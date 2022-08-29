// Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.

Console.Write($"Введите количество строк массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество столбцов массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] CreateMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int row = 0; row < m; row++)
    {
        for (int colum = 0; colum < n; colum++)
        {
            matrix[row, colum] = new Random().NextDouble()*20 - 10;// ограничила выводимые числа промежутком от -10 до 10, как в примере 
            matrix[row, colum] = Math.Round(matrix[row, colum], 1); // один знак после запятой, то же как в примере
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            System.Console.Write($"{matrix[m, n]}\t");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);

