// напишиие программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом второго
// например
// 8,9, нет
// 5, 25, да

Console.WriteLine("Введите число - ");
int digit1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число - ");
int digit2 = Convert.ToInt32(Console.ReadLine());


if (digit2 == digit1 * digit1 || digit1 == digit2 * digit2)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}
