// 15. Дано число. Проверить кратно ли оно 7 и 23

// Status: решено


int num = 161; //new Random().Next(-10000,10000);
Console.WriteLine(num);

bool Method(int a, int b, int c)
{
return (a % b == 0 && a % c == 0);
}


System.Console.WriteLine(Method(num, 7, 23));