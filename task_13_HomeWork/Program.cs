﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
 Console.WriteLine("Введите любое число:");
int number = Int32.Parse(Console.ReadLine());
if (number < 100 )
{
    Console.WriteLine("третьей цифры нет");
}
else
{   while(number>1000)
{
    number/=10;
}
    Console.WriteLine($"третье число {number%10}");

}