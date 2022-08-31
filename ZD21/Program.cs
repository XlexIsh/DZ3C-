// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("Введите координату X первой точки");
bool isNumberX_1 = int.TryParse(Console.ReadLine(), out int x1);


Console.WriteLine("Введите координату Y первой точки");
bool isNumberY_1 = int.TryParse(Console.ReadLine(), out int y1);


Console.WriteLine("Введите координату Z первой точки");
bool isNumberZ_1 = int.TryParse(Console.ReadLine(), out int z1);


Console.WriteLine("Введите координату X второй точки");
bool isNumberX_2 = int.TryParse(Console.ReadLine(), out int x2);


Console.WriteLine("Введите координату Y второй точки");
bool isNumberY_2 = int.TryParse(Console.ReadLine(), out int y2);


Console.WriteLine("Введите координату Z второй точки");
bool isNumberZ_2 = int.TryParse(Console.ReadLine(), out int z2);


if(isNumberX_1 != true || isNumberY_1 != true || isNumberZ_1 != true || isNumberX_2 != true || isNumberY_2 != true || isNumberZ_2 != true)
{
    Console.WriteLine("Числа введены не верно.");
    return;
}


// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.WriteLine($"Расстояние равно: {GetLenght(x1,y1,z1,x2,y2,z2)}");

double GetLenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2)+ Math.Pow((z2-z1), 2));
}