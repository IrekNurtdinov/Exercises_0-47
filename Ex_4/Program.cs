//Найти максимальное из трех чисел

// Status: решено


int FindMax(int a, int b, int c)
{
int max = a;
if (b > max) max = b;
if (c > max) max = c;
return max;
}
Console.WriteLine("Insert first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert second number:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert third number:");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Maximum number is {FindMax(a,b,c)}");

