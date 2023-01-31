// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите число: ");
int a = Int32.Parse(Console.ReadLine()!);
int b = a; // для второго варианта решения
// Первый вариант решения
while (a != 0)
{
    if (a % 2 == 0)
    {
        Console.WriteLine(a);
    }
    a--;
}

//  Второй вариант решения
Console.WriteLine("Второй вариант:");
int i = 1;
do
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}
while (i <= b);