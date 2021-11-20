// 20. Ввести номер четверти, показать диапазоны для возможных координат


// Status: решено

void Range(int num)
{
    if (num == 1) System.Console.WriteLine("Дипапзоны х - от 0 до +бесконечности; у от 0 до +бесконечности"); 
    else if (num == 2) System.Console.WriteLine("Дипапзоны х - от 0 до -бесконечности; у от 0 до +бесконечности"); 
    else if (num == 3) System.Console.WriteLine("Дипапзоны х - от 0 до -бесконечности; у от 0 до -бесконечности"); 
    else if (num == 4) System.Console.WriteLine("Дипапзоны х - от 0 до +бесконечности; у от 0 до -бесконечности"); 
    else System.Console.WriteLine("Попробуйте ещё раз");
}

System.Console.WriteLine("Введите номер четверти:");
int quarterNum = Convert.ToInt32(Console.ReadLine());
Range(quarterNum);