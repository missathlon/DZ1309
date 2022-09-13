// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int Number(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
        count += array[i];
    return count;
}
int[] array = new int[10];
FullArray(array);
Console.WriteLine("Summa: " + Number(array));