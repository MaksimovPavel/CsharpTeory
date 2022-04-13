Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "пахан")
{
    Console.WriteLine("Пахан, мое почтение!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}