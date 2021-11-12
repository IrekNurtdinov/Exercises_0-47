//Показать последнюю цифру трёхзначного числа

//Status: сделать проверку на трехзначность


char LastNum(int num)
{
    string newNum = Convert.ToString(num);
    char last = newNum[2];
    return last;
}

Console.Write(LastNum(526));
