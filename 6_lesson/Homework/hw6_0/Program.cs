//  1. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void PozNum(int num)
{
    double Sum = 0;
    double kol = 0;
    for (int i = 0; i < num; i++)
    {
        Console.Write("Введите число: ");
        double num1 = double.Parse(Console.ReadLine());
        if (num1 > 0)
        {
            Sum = Sum + num1;
            kol = kol + 1;
        }

    }
    Console.WriteLine($"Сумма чисел больше 0: {Sum}");
    Console.WriteLine($"Количество чисел больше 0: {kol}");
}

Console.WriteLine("Сколько чисел будем вводить?");
int num = int.Parse(Console.ReadLine());
PozNum(num);
