//Задача 40: Напишите программу, которая принимает на вход три
//числа и проверяет, может ли существовать треугольник с сторонами
//такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника
//меньше суммы двух других сторон.

Console.WriteLine("Введите длину 1-й стороны: ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину 2-й стороны: ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину 3-й стороны: ");
int side3 = Convert.ToInt32(Console.ReadLine());

bool canTriangleExist = CanTriangleExist(side1, side2, side3);
Console.WriteLine(canTriangleExist ? "Треугольние существует" : "Треугольник не существует");

bool CanTriangleExist(int firstSide, int secondSide, int thirdSide)
{
    if (firstSide > secondSide + thirdSide || 
    secondSide > firstSide + thirdSide || 
    thirdSide > firstSide + secondSide) return true;
    return false;
}