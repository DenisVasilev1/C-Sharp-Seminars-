﻿//напишите программу, которая принимает на вход (X и Y), причем
// X ≠ 0, Y ≠ 0 и выдает номер четвертой плоскости, в которой
// находится эта точка 


 Console.WriteLine("Введите коородинаты по X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коородинаты по Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
 {
    Console.WriteLine("Точка находится в первой координатной четверти");
 }

else if (x < 0 && y > 0)
 {
    Console.WriteLine("Точка находится во второй координатной четверти");
 }

else if (x < 0 && y < 0)
 {
    Console.WriteLine("Точка находится в третьей координатной четверти");
 }

else if (x > 0 && y < 0)
 {
    Console.WriteLine("Точка находится в четвертой координатной четверти");
 }

 else 
{ 
    Console.WriteLine("Невозможно определить координатную четверть");
} 