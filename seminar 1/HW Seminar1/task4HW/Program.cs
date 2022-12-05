Console.WriteLine("Введите число 1: ");
string? answer1 = Console.ReadLine();
int numberA = Convert.ToInt32(answer1);

Console.WriteLine("Введите число 2: ");
string? answer2 = Console.ReadLine();
int numberB = Convert.ToInt32(answer2);

Console.WriteLine("Введите число 3: ");
string? answer3 = Console.ReadLine();
int numberC = Convert.ToInt32(answer3);

if (numberA > numberB)
{
    if (numberA > numberC)
    {
    Console.WriteLine("Максимальное - ");
    Console.WriteLine(numberA); 
    }
}   
if (numberB > numberA)
{
    if (numberB > numberC)
    {
    Console.WriteLine("Максимальное - ");
    Console.WriteLine(numberB); 
    }
}   
    if (numberC > numberA)
{
    if (numberC > numberB)
    {
    Console.WriteLine("Максимальное - ");
    Console.WriteLine(numberC); 
    }
} 
   