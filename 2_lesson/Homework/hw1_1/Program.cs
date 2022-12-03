// 2. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

int FirstNumber (int num)
{
    return num / 100;
}
int LastNumber (int num)
{
    return num % 10;
}
int num = new Random().Next(100,999);
//Console.WriteLine(MaxNumber(new Random().Next(100,999)));
Console.WriteLine($"Random number {num}");
Console.WriteLine($"First number {FirstNumber(num)}");
Console.WriteLine($"Last number {LastNumber(num)}");
Console.WriteLine($"Result {FirstNumber(num) * 10 + LastNumber(num)}");
//Console.WriteLine(FirstNumber(num)+LastNumber(num));
