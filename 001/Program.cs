// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void fillarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i]= new Random().Next(100, 1000);
}

int search(int[] array)
{
int count = 0;
int i = 0;
while (i < array.Length)
    {
    if (array[i] % 2 < 1)
        count++;
    i++;
    }
    return count;
}

Console.WriteLine("Введите число значений в массиве");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
fillarray(array);
Console.WriteLine($"начальный массив = {string.Join(", ", array)}");

search(array);
Console.WriteLine($"Четных чисел = {search(array)}");
