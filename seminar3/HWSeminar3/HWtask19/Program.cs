// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a;
int b;  
int c;
int d;

if (n < 100000 && n > 9999)
    {
        a = n / 10000;
        b = n / 1000 - (a * 10);
        c = (n % 100) / 10;
        d = n % 10;
        if (a == d && b == c)
             {
             Console.WriteLine("Да");
             }
        else 
        {
            Console.WriteLine("Нет");
        }
    }

else
    {
    Console.WriteLine("это не пятизначное число");
    }