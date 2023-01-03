// Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.


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

(int, int) GetSumPositiveAndNegative(int[] array)
{
    int SumPositive = 0;
    int SumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) // элемент массива положительный
        {
            SumPositive += array[i];
        }
        if (array[i] < 0) // элемент массива отрицательный
        {
            SumNegative += array[i];
        }
    }
    return (SumPositive, SumNegative);
}
const int SIZE = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);

Console.WriteLine(string.Join(",", arr));
(int sumP, int sumN) = GetSumPositiveAndNegative(arr);
Console.WriteLine($"сумма положительных чисел равна {sumP}, сумма отрицательных чисел равна {sumN}");
