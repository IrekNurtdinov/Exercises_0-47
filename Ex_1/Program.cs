// По двум заданным числам проверять является ли первое квадратом второго



bool IfSquare (int a, int b)
{
    return a == b * b;
}

Console.WriteLine(IfSquare(26, 5));
Console.WriteLine(IfSquare(9, 3));
Console.WriteLine(IfSquare(48, 6));
Console.WriteLine(IfSquare(81, 9));

