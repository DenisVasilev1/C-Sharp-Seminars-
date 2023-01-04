// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. Результат запишите в 
//новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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
const int SIZE = 5; //создание массива на 5 элементов
const int LEFTRANGE = 1;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));

int[] result = new int[arr.Length / 2 + arr.Length % 2];

for (int i = 0; i < arr.Length / 2; i++)
{
    result[i] = arr[i] * arr[arr.Length - 1 - i];
}

if (arr.Length % 2 == 1) // проверка на четность
{
    result[result.Length - 1] = arr[arr.Length / 2];
}


Console.WriteLine(string.Join(", ", result));