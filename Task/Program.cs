/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/


Console.Clear();
string[] arr1 = {"Hello","2","word",":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"}; 

int WordLength = 3;
string[] GetShortWordsArray(string[]array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;
    for(int i = 0; i< length; i++)
    {
        if(array[i].Length<=WordLength)
        {
            result[count]= array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}
void PrintArray(string[] array)
{
    if (array.Length==0)
    {
        Console.WriteLine("[] ");
    }
    else
    {
        Console.Write("[ ");
        Array.ForEach(array,(str)=> Console.Write($" {str},"));
        Console.Write("]");
        Console.WriteLine();   
    }  
}
void PrintTask(string[]array)
{
    Console.Write("Первоначальный массив:  ");
    PrintArray(array);
    string[] shortArray = GetShortWordsArray(array);
    Console.Write("Результат:  ");
    PrintArray(shortArray);
    Console.WriteLine();
}
PrintTask(arr1);
PrintTask(arr2);
PrintTask(arr3);