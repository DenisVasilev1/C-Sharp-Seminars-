Console.WriteLine("Введите число 1: ");
string? answer1 = Console.ReadLine();
int numberA = Convert.ToInt32(answer1);

Console.WriteLine("Введите число 2: ");
string? answer2 = Console.ReadLine();
int numberB = Convert.ToInt32(answer2);

if (numberA > numberB)
{
    Console.Write("Большее - ");
    Console.Write(numberA);
    Console.WriteLine (" ");
    Console.Write("Меньшее - ");
    Console.Write(numberB);
}
else
{
    Console.Write("Большее - ");
    Console.Write(numberB);
    Console.WriteLine (" ");
    Console.Write("Меньшее - ");
    Console.Write(numberA);
}
