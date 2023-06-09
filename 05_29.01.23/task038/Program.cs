﻿// Задача 38: 
// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Пример: [3 7 22 2 78] -> 76

//Вариант 1 (в 3 метода):
// void FillArray(int[] coll)                                                  // создаем метод FillArray для создания и печати массива
// {
//     for (int i = 0; i < coll.Length; i++)                                   // пока index меньше чем length будем делать ->
//     {
//         Console.Write($"{coll[i] = new Random().Next(1, 100)}, ");          // выводим на печать собранный массив из цифр от 1 до 100 (можно варьировать)
//     }
//     Console.Write("\b\b");                                                  // убираем запятушку
// }

// int MaxArray(int[] arr)                        // создаем метод для поиска максимального значения в индексе
// {
//     int max = arr[0];                          // создаем переменную max в которую на старте вкладываем значение под нулевым индексом
//     for (int i = 1; i < arr.Length; i++)       // запускаем цикл до тех пор пока наш i не станет больше длинны массива
//     {
//         if (arr[i] > max) max = arr[i];        // проверяем больше ли текущий элемент max-а. Если больше, то обновляем переменную max
//     }   
//     return max;                                // выводим полученный после прохождения циклом всего массива наш max
// }

// int MinArray(int[] arr)                        // создаем метод для поиска минимального значения в индексе
// {
//     int min = arr[0];                          // создаем переменную min в которую на старте вкладываем значение под нулевым индексом
//     for (int i = 1; i < arr.Length; i++)       // запускаем цикл до тех пор пока наш i не станет больше длинны массива
//     {
//         if (arr[i] < min) min = arr[i];        // проверяем меньше ли текущий элемент min-а. Если меньше, то обновляем переменную min
//     }
//     return min;                                // выводим полученный после прохождения циклом всего массива наш min
// }


// int[] array = new int[new Random().Next(3, 10)];                // задаем массив с рандомным количеством цифр внутри 
// Console.Write("[");                                             // начало печати результата
// FillArray(array);                                               // запускаем метод заполнения массива
// Console.Write($"] -> {MaxArray(array) - MinArray(array)}");     // выводим на печать результат c просчетом разницы внутри него



//Вариант 2 (в 2 метода):
void FillArray(int[] coll)                                                  // создаем метод FillArray для создания и печати массива
{
    for (int i = 0; i < coll.Length; i++)                                   // пока index меньше чем length будем делать ->
    {
        Console.Write($"{coll[i] = new Random().Next(1, 100)}, ");          // выводим на печать собранный массив из цифр от 1 до 100 (можно варьировать)
    }
    Console.Write("\b\b");                                                  // убираем запятушку
}

int MaxMinDiff(int[] arr)                     // создаем метод для поиска максимального значения в индексе
{
    int max = arr[0];                          // создаем переменную max в которую на старте вкладываем значение под нулевым индексом
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)       // запускаем цикл до тех пор пока наш i не станет больше длинны массива
    {
        if (arr[i] > max) max = arr[i];        // проверяем больше ли текущий элемент max-а. Если больше, то обновляем переменную max
        else                                   // иначе ->
        {
            if (arr[i] < min) min = arr[i];    // проверяем меньше ли текущий элемент min-а. Если меньше, то обновляем переменную min
        }
    }
    return max-min;                            // выводим полученный после прохождения циклом всего массива наш max
    
}


int[] array = new int[new Random().Next(3, 10)];    // задаем массив с рандомным количеством цифр внутри 
Console.Write("[");                                 // начало печати результата
FillArray(array);                                   // запускаем метод заполнения массива
Console.Write($"] -> {MaxMinDiff(array)}");         // выводим на печать результат c просчетом разницы внутри него