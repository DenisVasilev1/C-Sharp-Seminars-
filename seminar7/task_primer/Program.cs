


// int number = Convert.ToInt32("абракадабра");


//int number = int.TryParse();
//double floatnumber = double.TryParse();


string str = "1213";
bool res = int.TryParse(str, out int result);
if (res == true)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("конвертация не произошла");
}


