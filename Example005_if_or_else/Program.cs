Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.Equals("Херило с горы", StringComparison.InvariantCultureIgnoreCase))
{
    Console.WriteLine("Ура, это же Херило с горы!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}