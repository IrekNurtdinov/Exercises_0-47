// Написать программу замену элементов массива на противоположные

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


void ChangePrintArr(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i] * -1;
        System.Console.Write(newArray[i] + " ");
    }

}

ChangePrintArr(FillPrintArr(12, -10, 10));
