// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите любое число от 1 до 7:");
int day = int.Parse(Console.ReadLine());
if(day==6 || day==7){
    Console.WriteLine($"{day} -выходной");
 }
if(day>7){
    Console.WriteLine("введено не верное число, введите от 1 до 7");
    return;
}
else{
    Console.WriteLine($"{day} -не выходной");
}