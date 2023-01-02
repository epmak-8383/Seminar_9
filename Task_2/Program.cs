// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int Sum(int m, int n)
{
    if (n == m) return n;
    if (m == n) return m;
    return (m + Sum(m+1, n));
}

int Enterdata(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = Enterdata("Введите число M:  ");
int n = Enterdata("Введите число N:  ");
Sum(m, n);
Console.Write(Sum(m, n));