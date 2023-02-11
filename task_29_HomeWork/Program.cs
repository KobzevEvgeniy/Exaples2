// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
int[] array = GetArray();
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetArray(){
    int[] array = new int[8];
    for (int i = 1; i <= 8; i++)
    {
        Console.Write($"Введите {i} число: ");
        int num = int.Parse(Console.ReadLine());
        array[i-1] = num;
    }
    return array;
}