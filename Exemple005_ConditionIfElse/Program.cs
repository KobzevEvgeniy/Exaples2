// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();
if(username.ToLower()=="марина")
{
    Console.WriteLine("Ура, это же МАРИНА!!!");
}
else
{
    Console.WriteLine($"Привет, {username}");
}
