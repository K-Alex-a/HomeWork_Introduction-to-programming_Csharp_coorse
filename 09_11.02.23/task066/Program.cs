// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



// Вариант 1 (по условию):
Console.Write("Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Sum(int m, int n)      // метод подсчета суммы всех натуральных чисел между М и N, при любых M и N
{
    int sum = 0;
    if (m <= n)
        while (m <= n)
        {
            {
                sum += m;
                m++;
            }
        }
    else
    {
        while (m >= n)
        {
            {
                sum += m;
                m--;
            }
        }
    }
    return sum;
}

Console.Write($"M = {m}; N = {n} -> {Sum(m, n)}");



// Вариант 1 (через рекурсию):
// Console.Write("Задайте значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// int PrintNumbers(int m, int n)      // метод подсчета суммы всех натуральных чисел между М и N через рекурсию, при M < N
// {
//     if (m > n) return 0;
//     return (sum + m) + PrintNumbers(m + 1, n);
// }

// Console.Write($"M = {m}; N = {n} -> {PrintNumbers(m, n)}");





/*=========================================
Результат (по вар.1 и вар.2):
===========================================

Задайте значение M: 4
Задайте значение N: 8
M = 4; N = 8 -> 30

===========================================*/