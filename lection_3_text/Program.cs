// Работа с текстом
// Дан текст. В тексте надо заменить все проблемы черточками, заменить "к" на "К", заменить "c" на "C".
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            +"ежеле бы вас послали вместо нашего милого Винцергероде,"
            +"вы бы взяли приступом согласие прусского короля. "
            +"Вы так красноречивы. Вы дадите мне чаю?";
//string s= "gwerty"
// индекс    012345
// S[3] = r
string Replace (string text, char OldValue, char NewValue)
{
    string result = String.Empty;
    int Length = text.Length;
    for (int i=0; i<Length; i++)
    {
        if( text[i]==OldValue) result = result+ $"{NewValue}";
        else result = result+ $"{text[i]}";
    }
    return result;
}
string NewText = Replace(text, ' ', '|');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Replace(NewText, 'к', 'К');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Replace(NewText, 'с', 'С');
Console.WriteLine(NewText);