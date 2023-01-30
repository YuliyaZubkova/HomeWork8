/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(100, 1000);
    return result;
}

int DeleteSecond(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    int res = firstDigit * 10 + secondDigit;
    return res;
}



int number = GetNumber();
Console.Write($"Заданное число: {number}");
int res = DeleteSecond(number);
Console.Write($" -> {res}");