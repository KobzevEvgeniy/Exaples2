// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
double[] Array1 = GetArray(5, -2, 15);
Console.WriteLine(String.Join(" ", Array1));
Console.WriteLine($"Разница между максимальным и минимальным = {Difference(Array1)}");

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble();
    }
    return result;
}

double Difference(double[] array)
{
    double minnumber = array[0];
    double maxnumber = array[0];
    foreach (double el in array)
    {  
        if (minnumber > el) minnumber = el;
        if (maxnumber< el) maxnumber  = el;
    }
    Console.WriteLine($"Максимальное ={maxnumber},Минимальное ={minnumber}");
    return  maxnumber-minnumber;
    }