/* 
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/


int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int number1 = GetNumber("Введите первое число: ");
int number2 = GetNumber("Введите второе число: ");
if (number1 % number2 == 0)
Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток: {number1 % number2}");
