/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


int x = 2;
int y = 2;
int z = 2;
Console.Clear();
Console.WriteLine($"Сформирован трехмерный массив размером {x} x {y} x {z}");
Console.WriteLine();

int[,,] matrix3D = new int[x, y, z];
CreateArray(matrix3D);
PrintNumber(matrix3D);
void CreateArray(int[,,] matrix3D)
{
    int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 20);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 20);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < matrix3D.GetLength(0); x++)
    {
        for (int y = 0; y < matrix3D.GetLength(1); y++)
        {
            for (int z = 0; z < matrix3D.GetLength(2); z++)
            {
                matrix3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}
void PrintNumber(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}