// Напишите программу, которая перевернет одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем)
// [1 2 3 4 5] -> [5 4 3 2 1]



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
void Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length -i - 1];
        array[array.Length - i - 1] = temp;
    }
}



const int SIZE = 10; 
const int LEFTRANGE = 0;
const int RIGHTRANGE = 150;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));

Reverse(arr);
Console.WriteLine();
Console.WriteLine(string.Join(", ", arr));
