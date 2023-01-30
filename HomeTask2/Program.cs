/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число.");

        }
    }

    return result;
}

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinimumNumber(int[,] matrix)
{
    int min = 0;
    int sum = 0;
    int number = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        min = min + matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (sum < min)
        {
            min = sum;
            number = i;
        }
        sum = 0;
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов: {number + 1} строка.");
}

int m = GetNumber("Введите количество строк: ");
int n = GetNumber("Введите количество столбцов: ");

int[,] matrix = GetMatrix(m, n);

Console.WriteLine();
PrintMatrix(matrix);
MinimumNumber(matrix);
