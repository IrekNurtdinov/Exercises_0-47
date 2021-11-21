// 28. Подсчитать сумму цифр в числе


// Status: решено


int SumNum(int number)
{
    int sum = 0;
    for (int i = Math.Abs(number); i > 0; i /= 10)
    {
    sum += i % 10;
    }
    return sum;
}

System.Console.WriteLine(SumNum(123));
System.Console.WriteLine(SumNum(-2));
System.Console.WriteLine(SumNum(123456));
System.Console.WriteLine(SumNum(-32));
System.Console.WriteLine(SumNum(1234));
