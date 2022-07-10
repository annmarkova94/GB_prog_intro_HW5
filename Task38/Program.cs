// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

FontGreen();
double[] array = RandArray();
PrintArray(array);
PrintDifferenceMaxMinInArray(array);
Console.ResetColor();

void PrintDifferenceMaxMinInArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    Console.WriteLine($"The difference between the max and min number in this array is {max - min}");
}

void PrintArray(double[] array)
{
    Console.WriteLine($"The array is [{string.Join(", ", array)}]");
}

double[] RandArray()
{
    Console.Write("Enter the length of an array that you want to be randomly generated: ");
    int array_length = EnterPositiveInteger();
    double[] yourArray = new double[array_length];
    for (int i = 0; i < array_length; i++)
    {
        yourArray[i] = Math.Round(new Random().NextDouble() *
                                 new Random().Next(-99, 100), 2);
    }
    return yourArray;
}

int EnterPositiveInteger()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number)
           || number < 1)
    {
        FontRed();
        Console.Write("This is not a positive integer, try again: ");
        FontGreen();
    }
    return number;
}

void FontRed()
{
    Console.ForegroundColor = ConsoleColor.Red;
}
void FontGreen()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
}

