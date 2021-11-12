//Показать вторую цифру трёхзначного числа

//Status: решил, так же как 9 задачу

char SecondNum(int num)              // сделал метод, который возвращает вторую цифру в ТРЕХЗНАЧНОМ числе
{
    string newNum = Convert.ToString(num);
    char second = newNum[1];
    return second;    
}

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)                           //проверка на трехзначность
{
  Console.Write($"Вторая цифра - {SecondNum(number)}");  
}
else
{
Console.WriteLine("Вам же сказали трехзначное!");
}
