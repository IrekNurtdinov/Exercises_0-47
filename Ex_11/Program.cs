//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

//Status: решено

int num = new Random().Next(10,100);
Console.WriteLine(num);
void FindMax(int number)
{
    int a = number / 10;
    int b = number % 10;
        if (a > b)
        {
        Console.WriteLine($"Наибольшая цифра {a}");   
        }
        else if (b > a)
        {
        Console.WriteLine($"Наибольшая цифра {b}");   
        }
        else Console.WriteLine($"Цифры равны");
}
FindMax(num);