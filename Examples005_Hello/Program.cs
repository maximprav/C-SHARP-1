Console.Clear();
Console.WriteLine("Введите ваше имя:");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Привет, " + username + "!" + " Хорошего дня!");
}
else 
{
    Console.WriteLine("Привет, " + username + "!");
}