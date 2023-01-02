// как сравнить группу чисел массива



int[] a = {1, 2, 3, 4, 5};
int[] b = {1, 2, 3, 4, 5};

bool res = true; // res = true то массивы равны, если res = false, то массивы не равны

for (int i = 0; i < a.Length; i++)
{
    if (a[i] != b[i])
    {
        res = false;
    }
}

Console.WriteLine(res);