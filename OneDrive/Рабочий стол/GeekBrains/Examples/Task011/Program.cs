Console.WriteLine("Введите целое число");
string numb = Console.ReadLine();

if (numb == "1")
{
    Console.WriteLine("Понедельник");
    Console.WriteLine("Это будний день");
}
else if (numb == "2")
{
    Console.WriteLine("Вторник");
    Console.WriteLine("Это будний день");
}
else if (numb == "3")
{
    Console.WriteLine("Среда");
    Console.WriteLine("Это будний день");
}
else if (numb == "4")
{
    Console.WriteLine("Четверг");
    Console.WriteLine("Это будний день");
}
else if (numb == "5")
{
    Console.WriteLine("Пятница");
    Console.WriteLine("Это будний день");
}
else if (numb == "6")
{
    Console.WriteLine("Суббота");
    Console.WriteLine("Это выходной день");
}
else if (numb == "7")
{
    Console.WriteLine("Воскресенье");
    Console.WriteLine("Это выходной день");
}
else 
{
    Console.WriteLine("Нет такого дня недели");
}