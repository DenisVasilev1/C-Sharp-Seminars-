// Напишите программу, которая принимает на вход число (N), и выдает таблицу
// квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 25
// 2 -> 1, 4



Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 0)
{
    Console.WriteLine("Число N должно быть больше 0");
}
else
{
    for (int i = 1; i <= n; i++)
    {
         Console.WriteLine(i * i);
    }

}