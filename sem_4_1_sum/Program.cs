// программа которая считает сумму чисел от 1 до а
Console.Clear();
Console.WriteLine("Введите число ");
int n= int.Parse (Console.ReadLine());
int GetSum(int limit){
    int sum =0;
for (int i=1; i<limit; i++){
    sum+=i;
}
return sum;
}
Console.WriteLine($"Сумма от 1 до {n} равно {GetSum(n)}");