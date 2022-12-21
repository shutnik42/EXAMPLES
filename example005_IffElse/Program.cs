Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "alexey")
{
    Console.WriteLine("Шалом, дорогой наш " + username + " Как дела?");
}
else
{
    Console.WriteLine("Здравствуйте, " + username);
}