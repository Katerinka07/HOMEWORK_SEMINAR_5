/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и
минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
double[] CreateArray(int size)
{
    return new double[size];
}
void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(rnd.NextDouble() + rnd.Next(-99, 100), 2);
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine();
}
double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    return Math.Round(max - min, 2);
}

int size = InputNum("Введите размер массива: ");
double[] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
double difference = DiffMaxMin(myArray);
Console.WriteLine(
    $"Разница между максимальным и минимальным элементом массива равна: {difference}"
);
