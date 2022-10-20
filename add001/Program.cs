// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
{
    Console.Clear();
    Console.Write("Введите значение m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Ackermann(m, n));
}
int Ackermann(int m, int n)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Введите положительное число!");
        return 0;
    }
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    return Ackermann(n, m);
}
