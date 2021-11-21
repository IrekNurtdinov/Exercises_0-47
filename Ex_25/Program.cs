// 25. Найти сумму чисел от 1 до А

// Status: решено


int Sum(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i;
    }
    return sum;
}

int num = 6;
System.Console.WriteLine($"Сумма чисел от 1 до {num} = {Sum(num)}");