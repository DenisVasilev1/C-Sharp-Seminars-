// Напишите программу, которая на вход принимает трехзначное число и на 
// выходе показывает вторую цифру этого числа
// 124 -> 2;
// 432 -> 3

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int digit1 = number / 10;
int digit2 = digit1 / 10;
int digit3 = digit1 - (digit2 * 10);

Console.WriteLine($"Искомое число: {digit3}");

