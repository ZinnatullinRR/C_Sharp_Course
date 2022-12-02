// 3. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

string Krat (int num)
{
    if ( num % 7 == 0 && num % 23 ==0)
    {
        return "Кратно";
    }

    else 
    {
        return "Не кратно";
    }
}

Console.Write("Enter the first number ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Krat(num));