// Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число A - ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B - ");
int number1 = Convert.ToInt32(Console.ReadLine());

int result = number;
for (int i = 1; i < number1; i = i +1)
{
    result = result * number;
}
Console.WriteLine(result);