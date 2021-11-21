// 24. Найти кубы чисел от 1 до N

// Status: решено


void Cube(int N)
{
    for (int i = 1; i <= N; i++)
    {
      int a = i*i*i;
      System.Console.WriteLine($"{i,4}^3 = {a, 4}");  
    }
}

int num = 12;
Cube(num);