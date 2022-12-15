Console.WriteLine("Введите целое число");
string numb = Console.ReadLine();

if (numb == "1")
{
    Console.WriteLine("Понедельник");
}
else if (numb == "2")
{
    Console.WriteLine("Вторник");
}
else if (numb == "3")
{
    Console.WriteLine("Среда");
}
else if (numb == "4")
{
    Console.WriteLine("Четверг");
}
else if (numb == "5")
{
    Console.WriteLine("Пятница");
}
else if (numb == "6")
{
    Console.WriteLine("Суббота");
}
else if (numb == "7")
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("Нет такого дня недели");
}