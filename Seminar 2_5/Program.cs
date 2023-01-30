/*Напишите программу, которая будет принимать на вход два числа 
и проверяет является ли одно число квадратом другого
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int number1 = GetNumber("Введите первое число: ");
int number2 = GetNumber("Введите второе число: ");

if (number1*number1 == number2 || number2*number2 == number1)
Console.WriteLine("Да");
else Console.WriteLine($"Нет");
