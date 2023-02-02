// // Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
///double s = Math.Sqrt(...);
Console.Clear();
Console.Write("Введите координаты для первой точки X: ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите координаты для первой точки Y: ");
int Y = int.Parse(Console.ReadLine());

Console.Write("Введите координаты для второй точки X: ");
int B = int.Parse(Console.ReadLine());

Console.Write("Введите координаты для второй точки Y: ");
int Z = int.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(X-B,2)+Math.Pow(Y-Z,2));
Console.Write($"Расстояние между точками result= {result:F3}");
