// Задача 28: Напишите программу, которая принимает на 
// вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


Console.WriteLine("Введите чесло");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    int res = 1;
    for (int i = 1; i <= number; i++)
        {
            res = i * res;
        }
    Console.WriteLine(res);
}

else 
{
    Console.WriteLine("Введите число больше или равно 1 ");
}

