// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Status: решено


double[] Array = {1.2, 5.6, 8, 4.5, 9.6};

void PrintArray(double[] array)  // печатает массив вещественных чисел
{
    for (int i = 0; i < array.Length; i++)
    {
       System.Console.Write($"{array[i]}  "); 
       
    }
    System.Console.WriteLine();
}

void DifMaxMinInArr(double[] array)  // ищет максимальный и минимальный элементы в массиве и выводит их разницу
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    System.Console.WriteLine($"Максимальный элемент = {max}, \nМинимальный элемент = {min} \nРазница = {max - min}");
}


PrintArray(Array);
DifMaxMinInArr(Array);