/* Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.

1. Получить числа с консоли
2. Задать матрицу и заполнить ее числами с консоли
3. Распечатать матрицу
*/


// Получить числа с консоли
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);
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

//Задать матрицу и заполнить ее числами с консоли
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

//Распечатать матрицу
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

//Замена элементов массива
int [,] ArrayStringReplace (int[,] matrix)
{
    int [,] resultArray = new int [matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
               resultArray[i,j] = matrix[matrix.GetLength(0)-1, j]; 
            }
            else 
            if (i == matrix.GetLength(0)-1)
            {
                resultArray[i,j] = matrix[0,j];
            }
            else 
            {
                resultArray[i,j] = matrix[i,j];
            }
        }
    }
    return resultArray;    
}

void PrintResult(int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            Console.Write($"{resultArray[i, j]} ");
        }
        Console.WriteLine();
    }
}



int m = GetNumber("Введите количество строк: ");
int n = GetNumber("Введите количество столбцов: ");

int[,] matrix = GetMatrix(m, n);
int[,] resultArray = ArrayStringReplace (matrix);

Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
ArrayStringReplace(matrix);
Console.WriteLine();
PrintResult(resultArray);


