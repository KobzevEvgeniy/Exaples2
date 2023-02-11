// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21
Console.Clear();
int [] array1 =GetArray(11,0,10);
Console.Write($"[{String.Join(", ", array1)}]");
Console.WriteLine("");
Console.Write($"[{String.Join(", ", Array2(array1))}]");


int [] GetArray (int size, int minValue, int maxValue)
{
int [] res = new int [size];
for (int i=0; i<size; i++)
{
    res[i] =new Random().Next(minValue, maxValue);
}
return res;
}

int[] Array2(int[] array)
{
    int size = (array.Length + 1)/ 2;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        
        result[i] = array[i] * array[array.Length - i-1];
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
    return result;
}
