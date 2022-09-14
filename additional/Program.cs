// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность 
// (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, 
// если отрицательное.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны
//  N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

// В выходной файл OUTPUT.TXT выведите полученную последовательность.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
}

void Sdvig(int[] array, int K)
{
    int[] ResultArray = new int[array.Length];

    if (K > 0)
    {
        for (int i = 0; i < K; i++)
            ResultArray[i] = array[array.Length - K + i];
        for (int i = 0; i < array.Length - K; i++)
            ResultArray[K + i] = array[i];
    }
    else
    {
        int N = Math.Abs(K);
        for (int i = 0; i < array.Length - N; i++)
            ResultArray[i] = array[N + i];
        for (int i = 0; i < N; i++)
            ResultArray[array.Length - 1 - i] = array[N - 1 - i];
    }
    Console.WriteLine("Result: [" + string.Join(", ", ResultArray) + "]");
}

int[] array = new int[10];
InputArray(array);
Console.WriteLine("Ishodnyj massiv: [" + string.Join(", ", array) + "]");
Console.Write("Vvedite chislo K = ");
int K = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(K)>array.Length)
{
    Console.WriteLine("Vvedite chislo |K| <= " + array.Length);
    K = Convert.ToInt32(Console.ReadLine());
}
Sdvig(array, K);