// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке 
//от N до 1. Выполнить с помощью рекурсии.
using System;
using static System.Console;
Clear();
Write("Введите число N: ");
int n = int.Parse(ReadLine());

WriteLine(Elements(n));

string Elements(int start)
{
    if (start == 1) return "1";
    return (start.ToString() + " " + Elements(start-1));
}
