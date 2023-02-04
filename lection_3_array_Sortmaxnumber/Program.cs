﻿// Данн массив чисел.
//Надо найти позицию максимального числа в неотсортированной части массива
//Произвести обмен этого значения со значением из первой позиции 
// повторять пока есть элементы неотсортированные 
int [] array = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i=0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort (int [] array)
{
    for (int i=0; i < array.Length -1; i++)
    {
        int maxPosition = i;
            for(int j= i +1 ; j< array.Length; j++)
            {
                if (array [j]> array [maxPosition]) maxPosition =j;
            }
        int temperary = array [i];
        array [i] = array [maxPosition];
        array [maxPosition] = temperary;
    }
}
PrintArray(array);
SelectionSort(array);
PrintArray(array);

