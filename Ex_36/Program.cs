// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// Status: решено

int[] FillPrintArr(int N, int min, int max)  // создает N-элементный массив и заполняет случайными числами из диапазона [min, max] и выводит на экран
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
    return array;
}

void EvenOddInArr(int[] array)
{
    int countEven = 0;
    int countOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) countEven++;
        else countOdd++;
    }
    System.Console.WriteLine($"Количество четных чисел в массиве = {countEven}");
    System.Console.WriteLine($"Количество нечетных чисел в массиве = {countOdd}");
}

EvenOddInArr(FillPrintArr(12, 100,999));