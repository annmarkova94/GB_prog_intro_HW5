// Задайте массив заполненный случайными положительными трёхзначными числами
// Напишите программу, которая покажет количество чётных чисел в массиве
// [345, 897, 568, 234] -> 2

int[] array = RandArray();
PrintArray(array);
PrintCountEvenNumbersInArray(array);

void PrintCountEvenNumbersInArray(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        count += (item % 2 == 0) ? 1 : 0;
    }
    Console.WriteLine($"The number of even numbers in this array is {count}");
}

void PrintArray(int[] array)
{
    Console.WriteLine($"The array is [{string.Join(", ", array)}]");
}

int[] RandArray()
{
    Console.Write("Enter the length of an array that you want to be randomly generated: ");
    int array_length = EnterInteger();
    int[] yourArray = new int[array_length];
    for (int i = 0; i < array_length; i++)
    {
        yourArray[i] = new Random().Next(100, 1000);
    }
    return yourArray;
}

int EnterInteger()
{
    int number;
    //Console.Write("Enter a positive integer: ");
    while (!int.TryParse(Console.ReadLine(), out number)
           || number < 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("This is not a positive integer, try again: ");
        Console.ResetColor();
    }
    return number;
}