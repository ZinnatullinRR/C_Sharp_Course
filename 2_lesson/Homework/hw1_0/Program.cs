// 1. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int Number2 (int num)
{
    return num / 10;
}

Console.WriteLine("Введите трехзначное число");
int num1 = int.Parse(Console.ReadLine());
if (num1 > 99 && num1 < 1000)
{
    Console.WriteLine( Number2(num1) % 10);
}
else 
{
    Console.WriteLine("Это не трехзначное число");
}