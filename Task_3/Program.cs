// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) return n+1;
    else
    if (n == 0) return Akkerman(m-1, 1);
    return (Akkerman(m-1, Akkerman(m, n-1)));
}

int Enterdata(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = Enterdata("Введите число M:  ");
int n = Enterdata("Введите число N:  ");
Akkerman(m, n);
Console.Write(Akkerman(m, n));