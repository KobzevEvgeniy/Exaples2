// // Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int [] array1 =GetArray(5,0,100);
Console.Write($"[{String.Join(", ", array1)}]");
Console.WriteLine("");
Console.Write($"Cумма элементов, стоящих на нечётных позициях = {GetSum(array1)}");

int [] GetArray (int size, int minValue, int maxValue)
{
int [] res = new int [size];
for (int i=0; i<size; i++)
{
    res[i] =new Random().Next(minValue, maxValue);
}
return res;
}

int GetSum(int []array)
{
    int SumPosition = 0;
   for (int i=0; i < array.Length; i++)
   {
    int el = array[i];
    if(i%2==1){
        SumPosition=SumPosition+el;
    }
    }
return SumPosition;
}
