﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Int32.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int b = Int32.Parse(Console.ReadLine()!);

if (a > b)
{
   Console.WriteLine($"Число {a} больше числа {b}"); 
}
else
{
    Console.WriteLine($"Число {b} больше числа {a}"); 
}
