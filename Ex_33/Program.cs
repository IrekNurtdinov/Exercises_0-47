// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

// Stattus: решено


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

void SumPlusMinusArr(int[] array)
{
    int sumPlus = 0;
    int sumMinus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPlus+= array[i];
        else  sumMinus+= array[i];
        
    }
    System.Console.WriteLine($"Сумма положительных элементов массива = {sumPlus} \nСумма отрицательных элементов массива = {sumMinus}");
}

SumPlusMinusArr(FillPrintArr(12, -9, 9));
