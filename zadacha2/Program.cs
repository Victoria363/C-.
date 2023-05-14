// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int n=int.Parse(Console.ReadLine());
int max=a;
if (b>max) max=b;
if (n>max) max=n;
Console.WriteLine("max = " + max);