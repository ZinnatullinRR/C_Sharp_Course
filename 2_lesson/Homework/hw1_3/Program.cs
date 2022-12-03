// 4. Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

string DaysNumber(int num)
{
if (num > 0 && num < 8)
{
    if (num == 6 || num == 7)
    {
        return "Это выходной";
    }
    else
    return "Это будний день";
}
else 
    return "Ты дурачок? В неделе 7 дней!";
}
Console.WriteLine("Введите день недели цифрой");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(DaysNumber(num));