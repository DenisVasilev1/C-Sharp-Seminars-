﻿//  Задайте массив. Напишите программу, которая определяет, присутствует ли заданное
//  число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
//true - элемент найден, false - не найден

bool isNumberInArray(int[] array, int findNumber)
{
    bool res = false; // изначально полагаем, что элемента в массиве нет
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == findNumber)
        {
            res = true;
            break;
        }
    }
    return res;

}

const int SIZE = 12; //создание массива на 12 элементов
const int LEFTRANGE = -10;
const int RIGHTRANGE = 10;
const int FINDNUMBER = 5;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);

Console.WriteLine(string.Join(", ", arr));
bool result = isNumberInArray(arr, FINDNUMBER);// bool - тип данных
if (result == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


