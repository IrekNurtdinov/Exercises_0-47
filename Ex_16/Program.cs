// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

//Status: решено


void Holiday(int num)
{
    if (num < 1 || num > 7) System.Console.WriteLine("Молодец! Попробуй еще раз.");
    else if (num > 5) System.Console.WriteLine("Выходной");
         else System.Console.WriteLine("Рабочий день");
}


System.Console.WriteLine("Введите число, обозначающее день недели:");
int a = Convert.ToInt32(Console.ReadLine());

Holiday(a);