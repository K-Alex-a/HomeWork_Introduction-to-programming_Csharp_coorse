// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длинна которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] stringArray = { "hello", "2", "world", ":)"};
//string[] stringArray = { "1234", "1567", "-2", "computer science" };
//string[] stringArray = { "Russia", "Denmark", "Kazan"};
Console.WriteLine(String.Join(" ", stringArray));

int n = 3;
int length = LengthArray(stringArray);
string[] newArr = new string[length];
Console.Write(String.Join(" ", NewArray(newArr, stringArray)));


int LengthArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= n) count++;
    }
    return count;
}

string[] NewArray(string[] arr1, string[] arr2)
{
    int j = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i].Length <= n)
        {
            arr1[j] = arr2[i]; 
            j++;
        }
    }
    return arr1;
}