// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10



void PrintBinaryView(int number)
{
    if (number <= 0) return;
    PrintBinaryView(number / 2);
    Console.Write(number % 2);
}

int a = 13;
PrintBinaryView(a);