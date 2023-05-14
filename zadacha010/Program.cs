// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int rand = new Random().Next(100,1000);
Console.WriteLine("Рандомное число - " + rand);
int a = FindSecondNumber(rand);
Console.WriteLine("Вторая цифра числа - " + a);

int FindSecondNumber(int rand)
{
    int r =  rand%100 / 10;
    return r;
}