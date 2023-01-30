/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Clear();
int n = 4;
int[,] Matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
    Matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < 3)
        j++;
    else
    if (i < j && i + j >= 3)
        i++;
    else
    if (i >= j && i + j > 3)
        j--;
    else
        i--;
}

WriteMatrix(Matrix);

void WriteMatrix(int[,] matrix)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (matrix[i, j] / 10 <= 0)
                Console.Write($" {matrix[i, j]} ");

            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}