// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// Status: решено


bool Method(bool x, bool y)
{
return !(x | y) == (!x & !y);
}

System.Console.WriteLine(Method(true, true));
System.Console.WriteLine(Method(true, false));
System.Console.WriteLine(Method(false, false));
System.Console.WriteLine(Method(false, true));