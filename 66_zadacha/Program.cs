// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
using System;
using static System.Console;
Clear();
Write("Введите число M: ");
int m = int.Parse(ReadLine());
Write("Введите число N: ");
int n = int.Parse(ReadLine());
WriteLine(SumElements(m, n));

int SumElements(int start, int end)
{
    if (start == end) return end;
    if (start < end)
    return (start + SumElements(start + 1, end));
    else 
    return (start + SumElements(start - 1, end));
}