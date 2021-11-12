//Показать четные числа от 1 до N

//Status: solved

void FindEven(int N)
{
    for (int i = 1; i <= N; i++)
    {
       if (i % 2 == 0) Console.Write(i + " ");
    }
}

FindEven(10);