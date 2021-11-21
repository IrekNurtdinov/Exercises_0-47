// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

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

void FindNumInArr(int[] array)
{
    int count = 0;
       for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
    System.Console.WriteLine($"Количество элементов из отрезка [10,99] в массиве = {count}");
}



FindNumInArr(FillPrintArr(123,0,200));