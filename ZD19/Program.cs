// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
bool isNumberN = int.TryParse(Console.ReadLine(), out int N);

if (isNumberN != true )
{
     Console.WriteLine("Число введено не верно.");
    return;
}

if (N < 10000 || N > 99999)
{
     Console.WriteLine("Число введено не верно.");
    return;
}


    int n1 = N / 10000;
    int n2 = N / 1000;
    int n21 = n2 % 10;
    int n4 = N % 100;
    int n41 = n4 /10;
    int n5 = N % 10;
    if (n1 == n5 && n21 == n41)
    {
        Console.WriteLine("Число является полиндромом");
        return;
    }
 
 Console.WriteLine("Число не является полиндромом");
        return;

