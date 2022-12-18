// Напишите программу, которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет
// 645 -> 5
// 78-> третьей цифры нет
// 32678 -> 6


Console.WriteLine("Введите число - ");
int a = Convert.ToInt32(Console.ReadLine());
int number1;

for (int i = 1000; i < a; i++)
{
    a = a / 10;
} 


if (a < 1000 && a > 99)
{
    number1 = a % 10;
    Console.WriteLine($"Третья цифра {number1}");
}

else
{
    Console.WriteLine("Третьей цифры нет");
}