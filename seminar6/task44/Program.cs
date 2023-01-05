// Не используя рекурсию, выведите первые N числе Фибоначчи.
// Первые два числа Фибоначчи - 0 и 1.
// Если N=5 -> 01123
// Если N=3 -> 011
// Если N=7 -> 0112358


Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());

int[] name = new int[n];
name [0] = 0;
name [1] = 1;
for (int i = 2; i < n; i++)
{
    name[i] = name[i - 2] + name[i - 1];
}
Console.WriteLine($"{string.Join(" ", name)}");