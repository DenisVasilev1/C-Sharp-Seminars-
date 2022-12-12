// напишиие программу, которая принимает на вход число и проверяет, кратно
// ли оно одновременно 7 и 23
// например
// 14, нет
// 161, да

Console.WriteLine("Введите число - ");
int digit1 = Convert.ToInt32(Console.ReadLine());


if (digit1 % 7 == 0 && digit1 % 23 == 0)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}
