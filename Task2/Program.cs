/* Напишите программу которая заменяет строки на столбцы
Если это невозможно программа должна вывести сообщение для пользователя
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

//Распечатать массив
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

//Замена строк на столбцы
void PrintNewMatrix(int[,] matrix)
{
    //if (matrix.GetLength(0) != matrix.GetLength(1))
    //{
      //  Console.WriteLine($"Замена невозможна, так как введено разное количество строк и столбцов.");
    //}
    //else
    //{
        int [,] arrayreverse = new int[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < arrayreverse.GetLength(0); i++)
        {
            for (int j = 0; j < arrayreverse.GetLength(1); j++)
            { 
                arrayreverse[i,j] = matrix[j,i];
                Console.Write($"{arrayreverse[i,j]} ");

            }
            Console.WriteLine();
        }
    }


int m = GetNumber("Введите количество строк: ");
int n = GetNumber("Введите количество столбцов: ");

int[,] matrix = GetMatrix(m, n);

Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
PrintNewMatrix(matrix);




