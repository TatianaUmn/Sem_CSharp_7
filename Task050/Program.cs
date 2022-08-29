// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет.

Console.Write($"Введите номер строки массива (x): ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите номер столбца массива (y): ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           array[i, j] = i + j;
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            System.Console.Write($"{array[m, n]}\t");
        }
        Console.WriteLine();
    }
}

void NumberArray(int[,] array)
{
 if(x > array.GetLength(0) || y > array.GetLength(1))
    {
        Console.Write("Такого числа нет в массиве");
    }
 else 
    {
        Console.Write($"Число с позициями в массиве {x} и {y} равно {array[x-1, y-1]}");
    }
}

int[,] array = CreateMatrix(5, 5, 0, 10);
PrintMatrix(array);
NumberArray(array);

