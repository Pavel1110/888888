// See https://aka.ms/new-console-template for more information
Console.Write("введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("проверяем является ли первое число квадратом второго");
if (a == b*b)
{
    Console.Write ("число a является квадратом числа b");
}
else
{
    Console.Write ("число a не является квадратом числа b");
}
