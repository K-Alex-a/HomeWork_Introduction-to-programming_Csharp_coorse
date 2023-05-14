// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Задайте значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"m = {m}, n = {n} -> A(m, n) = {AkkermanFunction(m, n)}");


int AkkermanFunction(int m, int n)      // 3 условия функции Аккермана через рекурсию(функцию Аккермана)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}



/*=========================================
Результат (по вар.1 и вар.2):
===========================================

Задайте значение m: 3
Задайте значение n: 2
m = 3, n = 2 -> A(m, n) = 29

===========================================*/
