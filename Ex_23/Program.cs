// 23. Показать таблицу квадратов чисел от 1 до N

// Status: решено


void Square(int N)
{
for (int i = 1; i <= N; i++)
{
    int a = i*i;
    System.Console.WriteLine($"{i,4}^2 = {a, 5}"); 
}

}

int num = 12;
Square(num);