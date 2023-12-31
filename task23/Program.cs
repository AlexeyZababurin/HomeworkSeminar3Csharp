﻿// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Sqrt (int n)
{
    Console.WriteLine($"Таблица кубов числа от 1 до {n}:", n);
    for (int i = 1; i < n; i++)
    {
        Console.Write(i*i*i+", ");
    }
    Console.Write(n*n*n);
}
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
n = Math.Abs(n);
Sqrt(n);
