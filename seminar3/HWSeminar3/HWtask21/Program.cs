// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("Введите координаты первой точки по оси X: ");
double x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по оси Y: ");
double y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по оси Z: ");
double z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси X: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси Y: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси Z: ");
double z1 = Convert.ToInt32(Console.ReadLine());

double res1 = Math.Pow(x-x1, 2);
double res2 = Math.Pow(y-y1, 2);
double res3 = Math.Pow(z-z1, 2);
double resfin = Math.Sqrt(res1+res2+res3);
Console.WriteLine( );
Console.WriteLine($"{resfin:f1}");