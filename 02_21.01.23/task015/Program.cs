//  Напиишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным:
// Пример: 6 -> да; 1 -> нет


// Вариант 0 (через функцию):
void WeekDay()                                       // задаем метод с названием WeekDay
{
    Console.Write("Введите число от 1 до 7: ");          // запрос ввода числа   
    int num = Convert.ToInt32(Console.ReadLine());       // принимаем введенное число
    if (num == 6 || num == 7)                           // проверка
    {
        Console.WriteLine(num + " -> да");             // если проверка пройдена, то выводим на печать "да"
    }
    if (num < 6)                                                // иначе ->
    {
        Console.WriteLine(num + " -> нет");            // выводим на печать "нет"
    }
    if (num > 7)                                             // иначе ->
    {
        Console.WriteLine("!Error!");            // выводим на печать "нет"
    }
}
WeekDay();                                           // запуск функии



// Вариант 1 (самый простой):
// Console.WriteLine("Введите цифру от 1 до 7");   // запрос ввода числа
// int num = Convert.ToInt32(Console.ReadLine());  // прием числа

// if ( num < 6 )                                  // проверка
// {
//     Console.WriteLine (num + " -> нет" );       // если проверка пройдена, то выводим на печать "нет"
// }
// else                                            // иначе ->
// {
//     Console.WriteLine (num + " -> да" );        // выводим на печать "да"
// }



// Вариант 2.1 (через кейсы (развернуто)):
// Console.Write("Введите цифру от 1 до 7: ");
// int  num = Convert.ToInt32(Console.ReadLine());

// switch (num)
// {
//     case 1:
//     {
//         Console.WriteLine("Рабочий день - Понедельник!");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("Рабочий день - Вторник!");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("Рабочий день - Среда!");
//         break;
//     }
//      case 4:
//     {
//         Console.WriteLine("Рабочий день - Четверг!");
//         break;
//     }
//      case 5: 
//     {
//         Console.WriteLine("Рабочий день - Пятница!");
//         break;
//     }
//      case 6: 
//     {
//         Console.WriteLine("Выходной день - Суббота!");
//         break;
//     }
//      case 7: 
//     {
//         Console.WriteLine("Выходной день - Воскресень!");
//         break;
//     }
//     default: 
//     {
//         Console.WriteLine("Такого дня недели не существует!");
//         break;
//     }
// }


//Вариант 2.2 (через кейсы (немного сжато и без минусовых чисел)):
// Console.Write("Введите цифру от 1 до 7: ");
// int num = Convert.ToInt32(Console.ReadLine());

// switch (num)
// {
//     case <= -1:
//         {
//             Console.WriteLine("Error!");
//             break;
//         }
//     case < 6:
//         {
//             Console.WriteLine("Рабочий день!");
//             break;
//         }
//     case 7:
//     case 6:
//         {
//             Console.WriteLine("Выходной день!");
//             break;
//         }
//     default:
//         {
//             Console.WriteLine("Такого дня недели не существует!");
//             break;
//         }
// }