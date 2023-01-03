//  Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetRandomArray(int size, int leftRange, int rightRange)// данный метод заполняет массив случайными числами
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}


const int SIZE = 12; //создание массива на 12 элементов
const int LEFTRANGE = -200;
const int RIGHTRANGE = 200;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);

Console.WriteLine($"[{string.Join(", ", arr)}]");

for (int i = 0; i < SIZE; i++)
{
    arr[i] = arr[i] *-1;
}
Console.WriteLine($"[{string.Join(", ", arr)}]");