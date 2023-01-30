/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int m = GetNumber("Введите количество строк: ");
int n = GetNumber("Введите количество столбцов первой и строк второй матрицы: ");
int l = GetNumber("Введите количество столбцов второй матрицы: ");
int[,] matrixOne = GetMatrix(m, n);
int[,] matrixTwo = GetMatrix(n, l);
int[,] matrixResult = GetMatrix(m, l);
PrintMatrix(matrixOne);
Console.WriteLine();
PrintSecMatrix(matrixTwo);
Console.WriteLine();
MultiplyMatrix(matrixOne, matrixTwo, matrixResult);
PrintResMatrix(matrixResult);
MultiplyMatrix(matrixOne, matrixTwo, matrixResult);

//Получить число с консоли
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

//Задать матрицы и заполнить их числами с консоли
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

//Распечатать первую матрицу
void PrintMatrix(int[,] matrixOne)
{
    Console.WriteLine("Первая матрица: ");
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            Console.Write($"{matrixOne[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Распечатать вторую матрицу
void PrintSecMatrix(int[,] matrixTwo)
{
    Console.WriteLine("Вторая матрица: ");
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            Console.Write($"{matrixTwo[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Найти произведение двух матриц
void MultiplyMatrix(int[,] matrixOne, int[,] matrixTwo, int[,] matrixResult)
{
  for (int i = 0; i < matrixResult.GetLength(0); i++)
  {
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrixOne.GetLength(1); k++)
      {
        sum = sum + matrixOne[i,k] * matrixTwo[k,j];
      }
      matrixResult[i,j] = sum;
    }
  }
}

//Распечатать полученную матрицу
void PrintResMatrix(int[,] matrixResult)
{
    Console.WriteLine($"Произведение первой и второй матриц:");
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            Console.Write($"{matrixResult[i, j]} ");
        }
        Console.WriteLine();
    }
}
