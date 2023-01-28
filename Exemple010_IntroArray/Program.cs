// ищет в массиве число совпадающее с введенным и говорит нашел или нет
int [] array = {1, 12, 34, 44, 54, 64, 44, 74, 84};

int n= array.Length;
int find=44;
int index=0;

while (index<n)
{
    if (array [index] == find)
    {
        Console.WriteLine(index);
        break;
        }
    index++;
}