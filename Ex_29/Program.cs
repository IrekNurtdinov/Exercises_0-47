// 29. Написать программу вычисления произведения чисел от 1 до N

// Status: решено


int Prod(int N)
{
    int prod = 1;
    for (int i = 1; i <= N; i++)
    {
        prod*= i;
    }
    return prod;
}

System.Console.WriteLine(Prod(5));
System.Console.WriteLine(Prod(3));
System.Console.WriteLine(Prod(6));
System.Console.WriteLine(Prod(8));


