/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая удалит строку и столбец, на пересечении которых
 расположен наименьший элемент массива
 */


namespace ConsoleApp1
{
    class Programm
    {
        static void Main(string[] args)
        {
            int[,] InitArray(int m, int n)
            {
                int[,] array = new int[m, n];
                Random rnd = new Random();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = rnd.Next(-10, 10);
                    }
                }
                return array;
            }

            Min(array);

            int[,] Delete(int[,] array, int minRow, int minColumn)
            {
                int countI = 0;
                int countJ = 0;
                int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (i != minRow && j != minColumn)
                        {
                            result[countI, countJ] = array[i, j];
                            countJ++;
                        }
                    }
                    countJ = 0;
                    if (i != minRow)
                    {
                        countI++;
                    }
                }
                return result;
            }

            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i, j]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            int[,] array = InitArray(3, 4);
            PrintArray(array);
            (int a, int b) = Min(array);
            PrintArray(Delegate(array, a, b));
            Console.ReadKey();
        }
    }
}

