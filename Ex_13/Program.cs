// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// Status: решено

int a = new Random().Next(-1000, 1000);
Console.WriteLine($"Случайное число = {a}");
void Ost(int num)
{
    if (a % num == 0) Console.WriteLine($"Число {a} кратно {num}");
    else Console.WriteLine($"Число {a} не кратно {num}, остаток {a % num}");
}

Console.WriteLine("Введите число для проверки кратности:");
int b = int.Parse(Console.ReadLine());

Ost(b);