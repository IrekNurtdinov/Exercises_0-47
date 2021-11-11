//Даны два числа. Показать большее и меньшее число


// if (a > b)
// {
//     Console.WriteLine($" Большее число {a}, меньшее число {b}");
// }
// else 
// {
//     Console.WriteLine($" Большее число {b}, меньшее число {a}");
// }
// int a = 43;
// int b = 16;


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