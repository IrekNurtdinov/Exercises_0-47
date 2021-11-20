// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// Status: htityj


int Quarter(int x, int y)
{
    int quarterNum = 1;
    if (x < 0 && y > 0 ) quarterNum = 2;
    else if (x < 0 && y < 0) quarterNum = 3;
    else if (x > 0 && y < 0) quarterNum = 4;
    return quarterNum;
}
 
System.Console.WriteLine($"Точка находится в плоскости №{Quarter(5,6)}");
System.Console.WriteLine($"Точка находится в плоскости №{Quarter(-5,6)}");
System.Console.WriteLine($"Точка находится в плоскости №{Quarter(-5,-6)}");
System.Console.WriteLine($"Точка находится в плоскости №{Quarter(5,-6)}");

