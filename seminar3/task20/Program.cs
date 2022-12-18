// напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве
// A (3, 6); B (2, 1) -> 5,09
// A (7, -5); B (1, -1) -> 7,21
//формула расстояния между точкамми

Console.WriteLine("Введите координаты первой точки по оси X: ");
double x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по оси Y: ");
double y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси X2: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси Y2: ");
double y1 = Convert.ToInt32(Console.ReadLine());

double res1 = Math.Pow(x-x1, 2);
double res2 = Math.Pow(y-y1, 2);
double sum = res1 + res2;
double resfin = Math.Sqrt(sum);
Console.WriteLine();
Console.WriteLine($"{resfin:f1}");

