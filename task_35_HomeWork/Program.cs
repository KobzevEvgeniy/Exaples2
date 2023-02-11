// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5
Console.Clear();
int [] array1 =GetArray(123,0,1000);
Console.Write($"[{String.Join(", ", array1)}]");
Console.WriteLine("");
Console.Write($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {CountNumbers(array1,10,99)}");

int [] GetArray (int size, int minValue, int maxValue)
{
int [] res = new int [size];
for (int i=0; i<size; i++)
{
    res[i] =new Random().Next(minValue, maxValue);
}
return res;
}

int CountNumbers(int [] array, int minNamber, int maxNamber)
{ 
    int count=0;
    foreach (int el in array)
{ 
    if (el>=minNamber && el<=maxNamber) count++;
}
    return count;
    
}

