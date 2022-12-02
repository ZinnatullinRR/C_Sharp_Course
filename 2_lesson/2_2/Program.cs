// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.

Console.Write("Enter the first number ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter the first number ");
int num2 = int.Parse(Console.ReadLine());
string Krat (int num1, int num2)
{
    if ( num2 % num1 == 0)
    {
        return "Кратно";
    }
    else 
    {
        return $"Не кратно, остаток = {num2 % num1}";
    }
}

Console.WriteLine(Krat(num1, num2));
