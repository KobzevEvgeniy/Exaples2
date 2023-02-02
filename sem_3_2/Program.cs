// **Задача 18:**

//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
Console.Clear();
Console.Write("Задайте номер четверти: ");
int part = int.Parse(Console.ReadLine());

if(part==1)
{
    Console.WriteLine("координаты расположены в диапозоне X>0 Y>0");
}
if(part==2)
{
    Console.WriteLine("координаты расположены в диапозоне X<0 Y>0");
}
if(part==3)
{
    Console.WriteLine("координаты расположены в диапозоне X<0 Y<0");
}
if(part==4)
{
    Console.WriteLine("координаты расположены в диапозонеX>0 Y<0");
}
if (part== 0)
    Console.WriteLine("На оси X == 0 || Y == 0");
if (part>5)
{
    Console.WriteLine("задано не верно число");
}

