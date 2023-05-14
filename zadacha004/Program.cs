// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число");
int N=int.Parse(Console.ReadLine());
int S=1;
while (N >= S)
{
    if (S%2==0)
    Console.Write("|" + S);
    S++;
}
