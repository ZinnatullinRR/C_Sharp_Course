// 3. Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

string ThreeNumber(int num)
{
if (num > 99)
{
while (num > 999)
{
    num = num / 10 ;
}
return $"Третья цифра числа это {num % 10} ";
}
else 
    return "Нет третьей цифры заданного числа";
}
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(ThreeNumber(num));