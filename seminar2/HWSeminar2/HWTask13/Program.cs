// Напишите программу, которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет
// 645 -> 5
// 78-> третьей цифры нет
// 32678 -> 6


Console.WriteLine("Введите число - ");
int digit1 = Convert.ToInt32(Console.ReadLine());
int number1;
int number2;
int number3;

if (digit1 > 999 && digit1 < 1000000000)
{
    number2 = digit1 / 10;
    if (number2 < 1000 && number2 > 99)
    {
        number3 = number2 % 10;
        Console.WriteLine($"Третья цифра {number3}");
    }

}
else

if (digit1 < 1000 && digit1 > 99)
{
    number1 = digit1 % 10;
    Console.WriteLine($"Третья цифра {number1}");
}


else
{
    Console.WriteLine("Третьей цифры нет");
}

