/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int number1 = GetNumber("Введите число: ");
if (number1 % 7 == 0 && number1 % 23 == 0)
Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно");