// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int b=int.Parse(Console.ReadLine());
if (b % 2==0)
{
    Console.WriteLine("четное - " + b);
} 
else
{
    Console.WriteLine("нечетное - " + b);
}
