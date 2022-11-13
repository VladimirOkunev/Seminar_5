// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int [] NewArray(int length) // create an array
{
    int [] array = new int[length];
    Console.Write("Array: ");
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 101);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int SumOddPos(int [] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Clear();

Console.Write("Enter length of an array: ");
int length = int.Parse(Console.ReadLine() ?? "0");

int [] arr = NewArray(length);

int sum = SumOddPos(arr);

Console.WriteLine($"Sum of the numbers of odd positions in the array: {sum}");