// как сравнить группу чисел в двух массивах



int[] a = {1, 2, 3, 2, 1};
//int[] b = {1, 2, 3, 4, 5};

bool res = true; // res = true то массивы равны, если res = false, то массивы не равны

for (int i = 0; i < a.Length / 2; i++)
{
    if (a[i] != a[a.Length - 1 - i])
    {
        res = false;
    }
}

Console.WriteLine(res);