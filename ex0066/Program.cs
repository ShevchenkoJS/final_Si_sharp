// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

int InputIntNumberM()
{
    while (true)
    try
        {
            Console.Write("Введите значение M: ");
            int M = int.Parse(Console.ReadLine() ?? "0");
            return M;
        }
        catch 
        {
            Console.WriteLine("Введите целое число!");
        }
}

int InputIntNumberN()
{
    while (true)
    try
        {
            Console.Write("Введите значение N: ");
            int N = int.Parse(Console.ReadLine() ?? "0");
            return N;
        }
        catch 
        {
            Console.WriteLine("Введите целое число!");
        }
}

int M = InputIntNumberM();
int N = InputIntNumberN();

int SumRec(int M, int N)
{
    if (M <= N)
    {
        if (M - N == 0) return M;
        else return M + SumRec(M + 1, N);
    }
    else
    {
        if (N - M == 0) return N;
        else return N + SumRec(N + 1, M);
    }
}
Console.WriteLine(SumRec(M, N));