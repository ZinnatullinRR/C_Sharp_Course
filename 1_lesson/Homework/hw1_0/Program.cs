// Программа принимает 2 числа и выдает макс и мин. Если равны, пишет об этом
Console.Write("Enter the first number ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second number ");
int num2 = int.Parse(Console.ReadLine());
int max = num1;
int min = num2;
if (num1 > num2) 
{
    max = num1; 
    min = num2;
    Console.Write("Max number ");
    Console.WriteLine(max);
    Console.Write("Min number ");
    Console.WriteLine(min);
}
else if (num1 < num2)
{
    max = num2;
    min = num1;
    Console.Write("Max number ");
    Console.WriteLine(max);
    Console.Write("Min number ");
    Console.WriteLine(min);
}
else 
{
    Console.Write("Same numbers");
}
