// 31. Задать массив из 8 элементов и вывести их на экран 

// Status: решено

int[] A = new int[8];
int[] B = {2,45,6,4,87,98,1,5};

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       System.Console.Write($"{array[i]} "); 
    }
}

PrintArray(A);
System.Console.WriteLine();
PrintArray(B);


