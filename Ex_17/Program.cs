// 17. По двум заданным числам проверять является ли одно квадратом другого

// Status: решено

int a = 3;
int b = 10;

void SqrCheck(int d, int c)
{
    if (d == c * c) System.Console.WriteLine($"Число {d} является квадратом числа {c}");
    else if (c == d * d) System.Console.WriteLine($"Число {c} является квадратом числа {d}");
    else System.Console.WriteLine("Мы совершенно посторонние друг другу числа...");
}
SqrCheck(a, b);