// нахождение максимального числа из 9 чисел
Console.WriteLine("первый вариант решения");
int a1=15;
int b1=21;
int c1=39;
int a2=12;
int b2=27773;
int c2=33;
int a3=13;
int b3=23;
int c3=338;

int max=a1;
if (b1>max) max=b1;
if (c1>max) max=c1;
if (a2>max) max=a2;
if (b2>max) max=b2;
if (c2>max) max=c2;
if (a3>max) max=a3;
if (b3>max) max=b3;
if (c3>max) max=c3;
Console.Write($"Максимальное число из девяти предложенных- {max} ");


Console.WriteLine("------------------");
Console.WriteLine("Второй вариант решения");
int Max(int arg1, int arg2, int arg3)
{
    int result =arg1;
    if (arg2>result) result= arg2;
    if (arg3>result) result= arg3;
    return result;
}
int d1=15;
int f1=21;
int g1=39;
int d2=12;
int f2=23;
int g2=33788;
int d3=13;
int f3=23;
int g3=338;

int max1=Max(d1, f1, g1);
int max2=Max(d2, f2, g2);
int max3=Max(d3, f3, g3);
int maximum=Max(max1, max2, max3);
Console.Write($"Максимальное число из девяти предложенных- {maximum} ");
