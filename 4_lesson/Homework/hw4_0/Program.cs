// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.

int NumDegree(int num1, int num2)
{
    int num_res = 1;

    for (int i = 1; i <= num2; i++)
    {

        num_res = num_res * num1;
    }

    return num_res;
}

Console.WriteLine("Введите число A");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B>=0");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(NumDegree(num1, num2));
