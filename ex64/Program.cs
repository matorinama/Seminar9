/*Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"N = {N} -> {NumToN(N)}");

string NumToN(int N)
{
    if (N == 1) return N.ToString();
    return (N + " " + NumToN(N - 1));
}

