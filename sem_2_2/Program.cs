//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Console.WriteLine($"Вариант руководителя____");
Console.Clear();
int num = new Random().Next(100, 1000);
int result = (num / 100) * 10 + num % 10;
Console.WriteLine($"{num} -> {result}");
Console.WriteLine($"{num} -> {num/100}{num%10}");