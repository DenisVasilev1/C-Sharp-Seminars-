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
    Console.WriteLine($"Остаток от деления -  {digit1 % digit2}");
}





//int digit2 = number % 10;
//int digit1 = number / 100;
//Console.WriteLine($"Искомое число: {digit1}{digit2}");
//if (digit1 > digit2)
//{
//   Console.WriteLine(digit1);
//}
//else
//{
//    Console.WriteLine(digit2);
//}
