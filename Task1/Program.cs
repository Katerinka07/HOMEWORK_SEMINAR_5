/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100, 1000);
}
string PrintArray(int[] array)
{
    string res = String.Empty;
    res += "[ "; // Добавила при выводе массива на печать квадратные скобки и запятые.
    for (int i = 0; i < array.Length - 1; i++)
    {
        res += array[i] + ", ";
    }
    res += array[array.Length - 1] + " ]";
    return res;
}
int СountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}
int size = InputNum("Введите размер массива: ");
int[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
int res = СountEvenNumbers(myArray);
Console.WriteLine($"Количество чётных чисел в массиве: {res}");
