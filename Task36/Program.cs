// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = RandArray();
PrintArray(array);
PrintSumNumbersOnEvenPosInArray(array);

void PrintSumNumbersOnEvenPosInArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine($"The sum of numbers on odd positions in this array is {sum}");
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
        yourArray[i] = new Random().Next(-99, 100);
    }
    return yourArray;
}

int EnterInteger()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number)
           || number < 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("This is not a positive integer, try again: ");
        Console.ResetColor();
    }
    return number;
}