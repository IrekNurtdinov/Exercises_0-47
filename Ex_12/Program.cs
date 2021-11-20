// Удалить вторую цифру трёхзначного числа

// Status: решено

int DelSecond(int number)
{
int newNum = number/100*10 + number%10;
return newNum;
}

int a = 653;

Console.Write(DelSecond(a));