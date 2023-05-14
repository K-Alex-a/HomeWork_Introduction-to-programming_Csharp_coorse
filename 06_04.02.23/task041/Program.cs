// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Вариант 1.1:
// Console.Write("Введите несколько чисел через пробел: ");
// int[] arr = Console.ReadLine().Split().Select(e => Convert.ToInt32(e)).ToArray();    // нагуглено: ввод массива через пробел с конвертацией
// Console.Write(String.Join(", ", arr));
// SeachPosNumbers(arr);

// int SeachPosNumbers(int[] arr)  // метод для подсчета чисел меньше нуля во введенном массиве
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) count++;
//     }
//     Console.Write($" -> {count}");
//     return count;
// }


// Вариант 1.2:
// Console.Write("Введите несколько чисел через пробел: ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);    // еще один вариант конвертации введенных через пробел чисел в массив
// Console.Write(String.Join(", ", arr));
// SeachPosNumbers(arr);

// int SeachPosNumbers(int[] arr)  // метод для подсчета чисел меньше нуля во введенном массиве
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) count++;
//     }
//     Console.Write($" -> {count}");
//     return count;
// }