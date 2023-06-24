/*
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(min, max + 1);
}
string PrintArray(int[] array)
{
    string res = String.Empty;
    res += "[ ";
    for (int i = 0; i < array.Length - 1; i++)
    {
        res += array[i] + ", ";
    }
    res += array[array.Length - 1] + " ]";
    return res;
}
int SumOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");
int[] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
int pos = SumOddPositions(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {pos}");
