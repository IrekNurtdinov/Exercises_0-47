//Даны два числа. Показать большее и меньшее число

// Status: решено

void FindMaxMin (int a, int b)
{
    if (a > b)
    {
        Console.WriteLine($" Большее число {a}, меньшее число {b}");
    }
    else 
    {
        Console.WriteLine($" Большее число {b}, меньшее число {a}");
    }
    
}

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

FindMaxMin(a, b);