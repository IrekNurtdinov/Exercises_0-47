// Определить, присутствует ли в заданном массиве, некоторое число 

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

void FindNumInArr(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            System.Console.WriteLine($"В массиве есть число {num}");
            break;
        }
    }
}

FindNumInArr(FillPrintArr(12, -10, 10), 5);

int[] A = { 5, 5, 5, 4, 3 };
FindNumInArr(A, 5);
