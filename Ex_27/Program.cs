// 27. Определить количество цифр в числе

// Status: решено

int DigitQuant(int number)
{
    int count = 1;
    for (int i = number; i/10 > 0; i/=10)
    {
      count++;  
    }
    return count;
}

System.Console.WriteLine(DigitQuant(6548));
System.Console.WriteLine(DigitQuant(1));
System.Console.WriteLine(DigitQuant(64));
System.Console.WriteLine(DigitQuant(123464));
