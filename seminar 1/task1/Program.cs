// Задача 1 - Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго;
// a = 25 b = 5 -> да
// a = 2 b = 10 -> нет
// int number = Convert.ToInt32(Console.ReadLine()) - конвертация строки в число


Console.WriteLine("Введите число 1: ");
string? answer1 = Console.ReadLine();
int numberA = Convert.ToInt32(answer1);

Console.WriteLine("Введите число 2: ");
string? answer2 = Console.ReadLine();
int numberB = Convert.ToInt32(answer2);

if (numberB * numberB == numberA)
{
    Console.WriteLine($"{numberB} * {numberB} = {numberA}");
}
else
{
    Console.WriteLine("НЕТ!!");
}

//string answer = Console.ReadLine();
//Console.WriteLine(number * number);