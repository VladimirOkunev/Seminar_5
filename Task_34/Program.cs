// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int [] NewArray(int length) // create an array
{
    int [] array = new int[length];
    Console.Write("Array: ");
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int TreatArray(int [] array) //define count of even numbers
{
    int count = 0;
    foreach(int el in array)
    {
        if(el % 2 == 0) count++;
    }
    return count;
}

Console.Clear();

Console.Write("Enter length of an array: ");
int length = int.Parse(Console.ReadLine() ?? "0");

int [] arr = NewArray(length);

int countEven = TreatArray(arr);

Console.WriteLine($"Count of even numbers in the array: {countEven}");