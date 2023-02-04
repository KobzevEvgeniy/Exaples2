// 1 Метод, не принимает данные и не возвращает

void Method1()
{
    Console.WriteLine("Автор Кобзев Евгений");
}
// Method1(); // Так вызывается метод,убери // чтоб работало

// 2 Метод, принимает данные , но не возвращает

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Данный метод выводит строку сообщения");
// 2 Метод модифицированный, он может показывать обреденые аругменту заданое количество раз
void Method2_1(string msg, int count)
{
    int i=0;
    while(i<count)
    {   Console.WriteLine(msg);
        i++;
    }
}
Method2_1("Данный метод выводит строку сообщения, столько раз сколько указали в каунт",2);

// еще вариант работы метода ,можно указать сколько раз и каких аргументов выводить. например:
void Method2_2(string msg, int count)
{
    int i=0;
    while(i<count)
    {   Console.WriteLine(msg);
        i++;
    }
}
Method2_2(msg:"Данный метод выводит разные строки сообщений, столько раз сколько указали в каунт и такой ",count: 3);
Method2_2(count: 4,msg:"Другой текст сообщения, столько раз сколько указали в каунт");

//Метод №3. не принмиает, но возвращает данные
int Method3()
{
    return DateTime.Now.Year;
}
int Year=Method3();
Console.WriteLine(Year);

// Метод №4. Принимает данные и возвращает данные
string Method4(int count4, string text)
{
    int i=0;
    string result=String.Empty;
    while(i<count4)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Метод № 4  ");
Console.WriteLine(res);

// Метод 4 переписаный циклом for- наиболее используемый при разработке, собирает в себе все что в цикле while  в одну строку
string Method4_1(int count4, string text)
{
    string result=String.Empty;
    for (int i=0; i<count4; i++)
    {
        result = result + text;
    }
    return result;
}
string res1 = Method4_1(5, "Метод № 4_For  ");
Console.WriteLine(res1);