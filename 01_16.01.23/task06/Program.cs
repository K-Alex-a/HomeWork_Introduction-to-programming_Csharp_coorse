﻿// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка):
// Пример: 4 -> true; -3 -> false

Console.Write("Введите любое число: ");                         // запрос ввода
int num = Convert.ToInt32(Console.ReadLine());                        // прием числа и установка его в переменную numA

if (num % 2 != 0) { Console.Write(num + " -> не четное"); }     // проверка на четность и печать ответа, если пройдена  
else { Console.Write(num + " -> четное"); }                     // проверка на четность (7) и печать ответа, если не пройдена