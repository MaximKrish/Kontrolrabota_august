// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Введите кол-во элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во символов элемента массива:");
int m = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
string[] newarray = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите элемент массива:");
    array[i] = Console.ReadLine();
}
Console.WriteLine("Массив получился:");
Console.Write("[" + string.Join(", ", array) + "]");
for (int i = 0; i < n; i++)
{
    
    if (array[i].Length <= m)
    { 
        newarray[i] = array[i];
    }   
}
Console.WriteLine();
Console.WriteLine("Конечный массив:");
Console.Write("[" + string.Join(", ", newarray) + "]");