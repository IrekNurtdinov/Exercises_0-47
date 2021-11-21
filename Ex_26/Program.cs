// 26. Возведите число А в натуральную степень B используя цикл


// Status: решено


int Pow(int A, int B)
{
   int num = A;
  for (int i = 1; i < B; i++)
  {
    num *= A;
  }  
  return num;
}

System.Console.WriteLine(Pow(2,3));
System.Console.WriteLine(Pow(3,2));
System.Console.WriteLine(Pow(4,5));
