// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите первое число");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=int.Parse(Console.ReadLine());
int min=b;
int max=a;
if (b>a)
{
    max=b;
    min=a;
}
Console.WriteLine("min = " + min);
Console.WriteLine("max = " + max);