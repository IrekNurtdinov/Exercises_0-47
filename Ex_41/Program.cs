// 41. Выяснить являются ли три числа сторонами треугольника 

// Status: решено

int a = 3;
int b = 2;
int c = 2;

// если сумма любых двух сторон больше третьей


bool IsTriangle(int a,int b,int c)
{
    return (a + b) > c && (b + c) > a && (c + a) > b;
}


System.Console.WriteLine(IsTriangle(a,b,c));