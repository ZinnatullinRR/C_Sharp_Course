// Вводим 3 числа. Выводим максимальное число

Console.Write("Enter the first number ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second number ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Enter the third number ");
int num3 = int.Parse(Console.ReadLine());
int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.Write("Max number ");
Console.WriteLine(max);