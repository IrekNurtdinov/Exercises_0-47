//Показать последнюю цифру трёхзначного числа

//Status: решил

char LastNum(int num)              // сделал метод, который возвращает последнюю цифру в ТРЕХЗНАЧНОМ числе
{
    string newNum = Convert.ToString(num);
    char last = ' ';
    if (num < 1000 && num > 99)
    {
        last = newNum[2];
    }
    else if (num > -1000 && num < -99)
    {
        last = newNum[3];
    }
    else Console.WriteLine("Вам же сказали ТРЁХЗНАЧНОЕ число!");
    return last;
}

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Последняя цифра - {LastNum(number)}");
