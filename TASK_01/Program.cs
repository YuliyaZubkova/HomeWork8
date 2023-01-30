// See https://aka.ms/new-console-template for more information

Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8

1. получаем рандомное число
2. получаем наибольшую цифру
*/

int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(10,100);// [10, 100)
    return result;
}

int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if(firstDigit > secondDigit)
      return firstDigit;
    else
      return secondDigit;
}

int number = GetNumber();
Console.WriteLine($"сгенерированное число:{number}");
int maxDigit = GetMaxDigitOfNumber(number);
Console.WriteLine($"максимальная цифра числа {number} = {maxDigit}");
