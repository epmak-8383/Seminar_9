// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

int FirstRecurtion(int n)
{
    if (n == 1) return n;
    n--;
    Console.Write($"{n},  ");
    FirstRecurtion(n);
    return n;
}

int Enterdata(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int n = Enterdata("Введите число N:  ");
Console.Write(n + ",  ");
FirstRecurtion(n);