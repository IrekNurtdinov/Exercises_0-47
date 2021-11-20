// 14. Найти третью цифру числа или сообщить, что её нет

// Status: решено


int a = new Random().Next(-10000,10000);
System.Console.WriteLine($"Случайная цифра = {a}");

void Third(int num)
{
string b = Convert.ToString(num);
if (num < 99 && num > -99) Console.WriteLine("Третьей цифры нет");
else if (a < 0) 
{
        Console.WriteLine($"Третья цифра числа {num} - {b[3]}");
}
else Console.WriteLine($"Третья цифра числа {num} - {b[2]}");
}

Third(a);