// напишиие программу, которая будет принимать на вход два числа и выводить
// является ли второе число кратным первому? Если число два не 
// кратно числу 1, то программа выводит остаток от деления
// например
// 34 -> 5, не кратно, остаток 4
// 16 -> 4, кратно


Console.WriteLine("Введите первое число - ");
int digit1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число - ");
int digit2 = Convert.ToInt32(Console.ReadLine());

 if (digit1 % digit2 == 0)
 {
    Console.WriteLine("Кратны");
 }
else
{
    Console.WriteLine($"Не кратно, остаток от деления -  {digit1 % digit2}");
}


