// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int NumSum(int n)
{
    int count = 0;
    while (n > 0)
    {
        count = count + n % 10;
        n = n / 10;
    }
    return count;

}
//Console.WriteLine("Введите число A");
//Console.WriteLine(NumbSum(int.Parse(Console.ReadLine())));

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
Console.Write($"Сумма цифр числа {n} - ");
Console.Write(NumSum(n));