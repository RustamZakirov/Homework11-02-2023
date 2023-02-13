// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void createarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i]= new Random().Next(-99, 100);
}

int summa(int[] array)
{
    int i = 1;
    int summ = 0;
    while (i < array.Length)
    {
        summ = summ + array[i];
        i = i +2;
    }
    return summ;
}

Console.Clear();
Console.WriteLine("Введите число цифр в массиве");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
createarray(array);
Console.WriteLine($"Начальный массив: {string.Join(", ", array)}");
summa(array);
Console.WriteLine($"Сумма нечетных6 {summa(array)}");