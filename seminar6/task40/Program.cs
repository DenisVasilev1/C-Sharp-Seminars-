// Напишите программу, которая принимает на вход три числа и проверяет
// может ли существовать треугольник со сторонами такой длины
// (теорема о неравенстве треугольника - каждая сторона треугольника
// меньше суммы двух других)

Console.WriteLine("Введите первое число - ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число - ");
int z = Convert.ToInt32(Console.ReadLine());

if (x + y > z && x + z > y && y + z > x)
{
    Console.WriteLine("может!");
}
else
{
    Console.WriteLine("не может!");
}


