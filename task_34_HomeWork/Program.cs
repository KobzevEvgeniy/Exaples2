// // Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string el = Console.ReadLine();
int[] baseArray = MasterArray(el);
Console.Write($"Количество четных чисел в массиве = {CountNumbers(baseArray)}");

int[] MasterArray(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
        if (res[i]<0)
{
    Console.WriteLine("Вы ввели отрицательное число");
    break;
}
    }
    return res;
}

int CountNumbers(int [] array)
{ 
    int count=0;
    foreach (int number in array)
{ 
    if (number%2==0) count++;
}
    return count;
    
}
