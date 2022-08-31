// Задача 23
// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
bool isNumberN = int.TryParse(Console.ReadLine(), out int N);

if (isNumberN != true )
{
     Console.WriteLine("Число введено не верно.");
    return;
}

Console.WriteLine("Таблица кубов:");

PrintCube (GetCube(N));

int[] GetCube(int n)
{
    int i = 1;
    int[] results = new int[n];
    while (i <= n)
    {
        results[i-1] = (int) Math.Pow(i,3);
        i++;
    }
    return results;
}

void PrintCube(int[] cube)
{
    int i = 0;
    int len = cube.Length;
    while (i < len)
    {
       Console.WriteLine(cube[i]);
       i++; 
    }
}