// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

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

int SumNumInArr(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum+= array[i];
    }
    return sum;
}
System.Console.WriteLine(SumNumInArr(FillPrintArr(10,1,10)));

