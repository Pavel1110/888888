Console.WriteLine("введите число A");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число B");
int b = int.Parse(Console.ReadLine()!);
int chislo = a;
int i = 1;
while (i < b)
{
chislo = chislo * a;
i++;
}
Console.WriteLine("A в степени B равно: " + chislo);