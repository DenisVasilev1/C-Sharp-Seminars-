// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


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
const int SIZE = 20;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 100;


int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));

int max = LEFTRANGE;
int min = RIGHTRANGE;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
}


Console.WriteLine($"максимальный элемент массива - {max}");
Console.WriteLine($"минимальный элемент массива - {min}");
Console.WriteLine($"разница между максимальным и минимальным элементами массива - {max-min}");