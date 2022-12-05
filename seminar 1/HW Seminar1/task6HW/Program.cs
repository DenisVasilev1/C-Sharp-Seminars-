Console.WriteLine("Введите число: ");
string? answer = Console.ReadLine();
int A = Convert.ToInt32(answer);
if (A % 2==1)
{
    Console.WriteLine("Число нечетное");
}
else 
{
    Console.WriteLine("Число четное");
}