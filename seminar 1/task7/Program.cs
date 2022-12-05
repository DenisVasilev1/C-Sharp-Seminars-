// Написать программу, которая на вход принимает трехзначное число,
// а на выходе показывает последнюю цифру этого числа
// 456 -> 6
// 982 -> 2

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    int mod = number % 10;
    Console.WriteLine(mod);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}


