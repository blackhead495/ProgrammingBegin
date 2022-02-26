

Console.Write("введите имя пользователя : ");

#nullable disable
string name = Console.ReadLine();
#nullable restore

if (name.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.WriteLine("Привет " + name);
}
