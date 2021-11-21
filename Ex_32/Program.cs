// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

// Status: решено

void FillPrintArr(int N, int min, int max)
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        System.Console.Write(array[i] + " ");
    }

}

FillPrintArr(8,0,1);