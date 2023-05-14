// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Пример: A (3,6,8); B (2,1,-7), -> 15.84;  A (7,-5, 0); B (1,-1,9) -> 11.53:



// Вариант 1:

Console.WriteLine("Введите координаты точки А (x1, y1, z1): ");
int x1 = Convert.ToInt32(Console.ReadLine()),                                                      // прием координаты точки А: x
    y1 = Convert.ToInt32(Console.ReadLine()),                                                      // прием координаты точки А: y
    z1 = Convert.ToInt32(Console.ReadLine());                                                      // прием координаты точки А: z

Console.WriteLine("Введите координаты точки В (x2, y2, z2): ");
int x2 = Convert.ToInt32(Console.ReadLine()),                                                      // прием координаты точки B: x
    y2 = Convert.ToInt32(Console.ReadLine()),                                                      // прием координаты точки B: y
    z2 = Convert.ToInt32(Console.ReadLine());                                                      // прием координаты точки B: z

int numX = x1 - x2;                                                                                 // расчет numX
int numY = y1 - y2;                                                                                 // расчет numY
int numZ = z1 - z2;                                                                                 // расчет numZ

double sum = Math.Pow(numX, 2) + Math.Pow(numY, 2) + Math.Pow(numZ, 2);                             // подсчет по формуле через библу Math        
Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {Math.Round(Math.Sqrt(sum), 2)}");    // вывод на печать результата с округлением до сотых



// Вариант 2 (с семинара через массив):

// Console.Write("Введите координаты точки 1: ");                                                                                       // запрос ввода координат точки А
// string[] sArr = Console.ReadLine().Split(' ');                                                                                       // прием координат в виде строки массива через пробел
// int num1 = Convert.ToInt32(sArr[0]);                                                                                                 // прием координаты точки А: x
// int num2 = Convert.ToInt32(sArr[1]);                                                                                                 // прием координаты точки А: y
// int num3 = Convert.ToInt32(sArr[2]);                                                                                                 // прием координаты точки А: z

// Console.Write("Введите координаты точки 2: ");                                                                                       // запрос ввода координат точки В
// string[] sArr2 = Console.ReadLine().Split(' ');                                                                                      // прием координат в виде строки массива через пробел
// int num4 = Convert.ToInt32(sArr2[0]);                                                                                                // прием координаты точки B: x
// int num5 = Convert.ToInt32(sArr2[1]);                                                                                                // прием координаты точки B: y
// int num6 = Convert.ToInt32(sArr2[2]);                                                                                                // прием координаты точки B: z

// double result = Math.Round(Math.Sqrt(Math.Pow((num1 - num4), 2) + Math.Pow((num2 - num5), 2) + Math.Pow((num3 - num6), 2)), 2);      // подсчет по формуле через библу Math
// Console.Write($"A ({num1},{num2},{num3}); B ({num4},{num5},{num6}) -> {result}");                                                                                                               // вывод на печать результата



// Вариант 3 (с семинара через рандом, без введения вручную):

// Random rand = new Random();                                                                       // ввели переменную rand, которая рандомно будет подставлять данные

// int x1 = rand.Next(-100, 101), y1 = rand.Next(-100, 101), z1 = rand.Next(-100, 101);              // запуск и присвоение поиска рандомом координат точки А
// int x2 = rand.Next(-100, 101), y2 = rand.Next(-100, 101), z2 = rand.Next(-100, 101);              // запуск и присвоение поиска рандомом координат точки B

// Console.WriteLine($"Point A  ({x1}, {y1}, {z1})");                                                // вывод на печать подобранных рандомом координат точки А
// Console.WriteLine($"Point B  ({x2}, {y2}, {z2})");                                                // вывод на печать подобранных рандомом координат точки В

// double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));    // подсчет по формуле через библу Math
// Console.WriteLine(Math.Round(length,2));                                                          // вывод на печать результата
