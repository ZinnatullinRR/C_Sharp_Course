// Вводим число N. Выводим все четные числа от 1 до N

Console.Write("Enter the number ");
int num = int.Parse(Console.ReadLine());
if (num < 2)
{
Console.Write("There are no even numbers less than ");
Console.Write(num);
}
else {
int i = 2;
Console.Write("Even numbers less than ");
Console.Write(num);
Console.WriteLine("");
while (num >= i) 
{
    Console.WriteLine(i);
    i = i + 2;
}
}