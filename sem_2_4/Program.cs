//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//14  ->  нет
//46  ->  нет
//161 ->  да
Console.Clear();
Console.WriteLine("Введите  число");
int number1= int.Parse(Console.ReadLine());
int number2=7;
int number3=23;
if(number1%number2==0 && number1%number3==0)
{
    Console.WriteLine("да");
}

else{Console.WriteLine("нет");}