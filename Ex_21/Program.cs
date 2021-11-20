// 21. Программа проверяет пятизначное число на палиндромом.

// Status: решено

int a = 28582;
int b = 32155;

bool Palindrom(int num)
{
    return (num / 10000 == num % 10) && (num/1000%10 == num/10%10);
}

System.Console.WriteLine($"Является ли число {a} палиндромом? Ответ: {Palindrom(a)}");
System.Console.WriteLine($"Является ли число {b} палиндромом? Ответ: {Palindrom(b)}");
