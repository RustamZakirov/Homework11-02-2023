// Задайте массив вещественных(дробных) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.1, 7.23, 22.57, 2.45, 78.78] -> 76.33

void fillarray(double[] array)
{
    
    for(int i = 0; i < array.Length; i++)
        array[i] = Math.Round((new Random().Next(-99,100) + new Random().NextDouble()), 2);
}

double mincount(double[] array)
{
    int i = 0;
    double min = array[0];
    while (i < (array.Length-1))
    {
        if (array[i + 1] < min)
            min = array[i + 1];
        i++;
    }
    return min;
}
double maxcount(double[] array)
{
    int i = 0;
    double max = array[0];
    while (i < (array.Length-1))
    {
        if (array[i + 1] > max)
            max = array[i+1];
        i++;
    }
    return max;
}


Console.Clear();
Console.WriteLine("Введите число цифр в массиве");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
fillarray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
mincount(array);
Console.WriteLine($"Минимальное значение: {mincount(array)}");
maxcount(array);
Console.WriteLine($"Максимальное значение: {maxcount(array)}");
Console.WriteLine($"Разница между минимальным и максимальным: {maxcount(array) - mincount(array)}");