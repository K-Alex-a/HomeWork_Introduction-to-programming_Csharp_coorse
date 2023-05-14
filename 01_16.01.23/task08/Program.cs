﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N:
// Пример: 5 -> 2, 4; 8 -> 2, 4, 6, 8

Console.Write("Введите любое число: ");     // запрос ввода
int numA = Convert.ToInt32(Console.ReadLine());   // прием числа и установка его в переменную numA

if (numA % 2 != 0)                          // проверка на четность
numA = numA - 1;                            // если проверка (7) пройдена, то вычитаем единицу из numA
int count = 2;                              // вводим переменную count=2, которая далее будет в цикле увеличиваться так же на 2

while (count <= numA)                       // пока count меньше либо равен numA, то делаем ->
{
    Console.Write(count + ", ");            // выводим на печать count 
    count = count + 2;                      // добавляем к текущему count +2, т.к. нужны будут четные только
}
Console.Write("\b\b   ");                   // вместо последних двух символов подставляет 2 пробела