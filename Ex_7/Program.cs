//Показать числа от -N до N

void Numbers(int N)
{
    for (int i = -N; i <= N; i++)
    {
        Console.Write(i +" ");
    }
}

Numbers(6);