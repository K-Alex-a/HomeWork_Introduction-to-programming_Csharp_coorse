// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Пример: 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125:

Console.Write("Введите число: ");                   // запрос на ввод числа
int num = Convert.ToInt32(Console.ReadLine());            // прием числа и установка его в переменную num

for (int i = 1; i <= num; i++)                      // условие при выполнении которого будет выполняться действие ->
{
    Console.Write($"{Math.Pow(i, 3)}, ");           // вывод на печать всех данных, пройденных через библу Math.Pow(ввод в степень)
}
Console.WriteLine("\b\b  ");                        // подтирание лишней запятой в конце



// Вариант2 (с семинара):                           // чисто подставила куда и что надо, не понимая еще как работает ----String.Join(", ", Enumerable.Range(start: 1, count: num).Select---
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine(String.Join(", ", Enumerable.Range(start: 1, count: num).Select(s => s * s * s)));

