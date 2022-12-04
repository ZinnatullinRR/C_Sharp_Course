// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int N)
{
    int i = 0;
    double num3;
    while (i < N)
    {
        i += 1;
        if (i == (N))
        {
            num3 = Math.Pow(i, 3);
            Console.Write($"{num3}");
        }
        else
        {
            num3 = Math.Pow(i, 3);
            Console.Write($"{num3},");
        }
    }

}
Console.WriteLine("Введите число");
int chislo = int.Parse(Console.ReadLine());
Console.WriteLine($"Числа в кубе от 1 до {chislo}");
Cube(chislo);