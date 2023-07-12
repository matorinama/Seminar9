/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/



Console.Clear();
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"M = {M}; N = {N} -> {SumNum(M, N)}");

int SumNum(int A, int B)
{
    if (A == B) return A;
    return (A + SumNum(A + 1, B));
}