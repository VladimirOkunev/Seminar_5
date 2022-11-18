// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.

double [] NewArray(int length) // create an array
{
    double [] array = new double[length];
    Console.Write("Array: ");
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
        array[i] = Math.Round(array[i], 2);
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
    return array;
}

void SumMaxMin(double [] array) // define sum of the minimal and maximal numbers in the array
{
    double max = array[0], min = array[0];
    foreach(double el in array)
    {
        if(el > max) max = el;
    }
    Console.WriteLine($"Maximal element in the array: {max}");

    foreach(double el in array)
    {
        if(el < min) min = el;
    }
    Console.WriteLine($"Minimal element in the array: {min}");

    Console.WriteLine($"Sum of the minimal and maximal numbers: {Math.Round(min+max, 2)}");
}

Console.Clear();

Console.Write("Enter length of an array: ");
int length = int.Parse(Console.ReadLine() ?? "0");

double [] arr = NewArray(length);

SumMaxMin(arr);