// 1. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

string FiveNumber(int num)
{
    if (num > 9999 && num < 100000)
        if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
        {
            return $"Это число палиндром";
        }
        else
            return $"Это число не палиндром";
    else
        return "Это не пятизначное число";
}


Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(FiveNumber(num));