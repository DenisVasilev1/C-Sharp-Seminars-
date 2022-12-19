//  Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36 
bool Validate(int number)
{
    if (number > 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int Sum1toA(int A)
{
    int sum = 0;
    for (int i = 0; i <= A; i++)
    {
        sum += i; // sum = sum + 1;
    }
    return sum;
}

int GetNomber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetNomber("Введите число: ");
bool isCorrect = Validate(number);
if (isCorrect == true)
{
    int suma = Sum1toA(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {suma}");
}
else
{
    Console.WriteLine($"Невозможно получить сумму от 1 до {number}");
}
