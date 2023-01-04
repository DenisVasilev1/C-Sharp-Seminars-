// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в 
// массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}
const int SIZE = 30;
const int LEFTRANGE = 99;
const int RIGHTRANGE = 1000;


int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));

int res = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        res = res + 1;
    }

}
Console.WriteLine($"четных чисел в массиве - {res}");
