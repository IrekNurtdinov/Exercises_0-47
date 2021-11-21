// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// Status:

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

void PairNumProd(int[] array)  // выводит произведение пар чисел 
{
    int length = array.Length - 1;
    int prod = 0;
    for (int i = 0; i < array.Length/2; i++)
    {
      prod = array[i] * array[length];
      System.Console.WriteLine(prod);
      length--;
    }
}

PairNumProd(FillPrintArr(11,1,5));