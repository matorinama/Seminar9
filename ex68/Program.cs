/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.Clear();
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m, n)}");

int Akkerman(int a, int b)
{
    if (a == 0) return b + 1;
    if (b == 0) return Akkerman(a - 1, 1);
    return Akkerman(a - 1, Akkerman(a, b - 1));
}