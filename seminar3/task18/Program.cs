// Напишите программу, которая по заданному номеру четверти, показывает
// диапозон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите четверть: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
 {
    Console.WriteLine("x < 0 и y > 0");
 }

else if (a == 2)
 {
    Console.WriteLine("x < 0 и y > 0");
 }

else if (a == 3)
 {
    Console.WriteLine("x < 0 и y < 0");
 }

else if (a == 4)
 {
    Console.WriteLine("x > 0 и y < 0");
 }

 else 
{ 
    Console.WriteLine("Такой четверти не существует");
} 