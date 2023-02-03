// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;

if (amount < 5 || amount > 5)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else
{   int number1=((number/10000) % 10000);
    int number5 = ((number) % 10);
    int number2=((number/1000) % 10);
    int number4 =((number/10) % 10);
    if(number1==number5 && number2==number4){
        Console.WriteLine($"Число {number}  -полиндром");
    }
    else{ Console.WriteLine($"Число {number}  - не полиндром");}
}
