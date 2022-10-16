// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо 
// равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] ArrayLessThan3Characters(string[] array)
{
    string[] newArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

string[] array = new string[7] { "55", "kkkk", "ooo", "546", "r", "88547", "11" };
string[] newArray = ArrayLessThan3Characters(array);
PrintArray(newArray);
