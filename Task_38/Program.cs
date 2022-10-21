//                         Задача 38:

//  Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    var array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double rndNum = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(rndNum, 1);
    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void GetSumPositiveNegativeElem(double[] array)
{
    double maxArr = array[0];
    double minArr = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxArr) maxArr = array[i];
        if (array[i] < minArr) minArr = array[i];
    }
    Console.WriteLine($"Максимальное значение = {maxArr}, минимальное значение = {minArr}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {maxArr - minArr}");
}
double[] arr = CreateArrayRndDouble(5, 100, 1);
PrintArrayDouble(arr);
GetSumPositiveNegativeElem(arr);