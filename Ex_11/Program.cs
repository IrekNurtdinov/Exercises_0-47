//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

//Status: не решено

int num = new Random().Next(10,100);
Console.WriteLine(num);
void FindMax(int number)
{
    for (int i = number; i > 9; i--)
    {
        int a = 0;
        int b = 0;
        if (i % 10 == 0) 
        {
            a = i/10;
            b = number - i;
            break;
        }
        if (a > b)
        {
        Console.WriteLine($"Наибольшая цифра {a}");   
        }
        else
        {
        Console.WriteLine($"Наибольшая цифра {b}");   
        }
          

    }
}
FindMax(num);