// Задача 38: Задайте массив дробных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3,5 7,78 22 2,23 78, 25] -> 76,02


void FullArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());

    }
    Console.WriteLine("[" + string.Join("; ", array) + "]");
}

double MaxNumber(double[] array)
{
    double Max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > Max) Max = array[i];
    }
    return Max;
}

double MinNumber(double[] array)
{
    double Min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < Min) Min = array[i];
    }
    return Min;
}

double[] array = new double[5];
FullArray(array);
double a = MaxNumber(array) - MinNumber(array);
Console.WriteLine("Raznica: " + a);