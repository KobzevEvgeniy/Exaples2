// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
 Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int result = ((number/ 10) % 10);
    Console.WriteLine($"втрое число {result}");
}

