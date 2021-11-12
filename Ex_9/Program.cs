//Показать последнюю цифру трёхзначного числа

//Status: решил, только без проверки на отрицательные трехзначные числа


char LastNum(int num)              // сделал метод, который возвращает последнюю цифру в ТРЕХЗНАЧНОМ числе
{
    string newNum = Convert.ToString(num);
    char last = newNum[2];
    return last;    
}

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)                           //проверка на трехзначность
{
  Console.Write($"Последняя цифра - {LastNum(number)}");  
}
else
{
Console.WriteLine("Вам же сказали трехзначное!");
}
