// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Int32.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int b = Int32.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int c = Int32.Parse(Console.ReadLine()!);

if (a > b && a > c)
{
    Console.WriteLine($"Число {a} - максимальное");
}
else if (b > a && b > c)
{
    Console.WriteLine($"Число {b} - максимальное");
}
else
{
    Console.WriteLine($"Число {c} - максимальное");
}


Console.WriteLine("Hello, World!");
