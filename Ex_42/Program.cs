// 42. Определить сколько чисел больше 0 введено с клавиатуры (числа будем вводить в одну строку через один пробел)

// Status:

string CutString(string text, int index)  // метод возвращает строку удалив из неё все символы которые находятся левее от text[index+1] (т.е. включая text[index])
{
    string shortText = string.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (i > index)
        {
            shortText += $"{text[i]}";
        }
    }
    return shortText;
}



// string num = string.Empty;
// int number = 0;
// for (int i = 0; i <= (text.Length-1); i++)
// {
//     if (text[i] == ' ')
//     {
//         for (int j = 0; j < i; j++)
//         {
//             num += $"{text[j]}";
//         }
//         number = Convert.ToInt32(num);
//         text = CutString(text, i);
//         i = 0;
//         System.Console.WriteLine(number);
//         num = String.Empty;
//     }
//     else if (i == (text.Length-1))
//     {
//         num = text;
//         number = Convert.ToInt32(num);
//         System.Console.WriteLine(number);
//     }
// }



int FindFirstNumber(string text, char delimiter)  // метод возвращает первое число из строки чисел text, которое находится до разделительного символа ( в нашем случае будет пробел ' ')
{

    string num = string.Empty;
    int number = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == delimiter)
        {
            for (int j = 0; j < i; j++)
            {
                num += $"{text[j]}";
            }
            number = Convert.ToInt32(num);
            break;
        }

    }
    return number;
}

int CountPositiveNum()
{
    System.Console.WriteLine("Введите любое количество отрицательных или положительных целых чисел в одну строку через пробел, затем нажмите Enter");
    string text = Console.ReadLine();
    System.Console.WriteLine(text.Length);
    int count = 0;
    for (int i = 0; i <= text.Length; i++)
    {
        if (FindFirstNumber(text, ' ') > 0)
        {
            count++;
            System.Console.WriteLine(count);
        }
        else if (i == text.Length)
        {
            string num = text;
            int number = Convert.ToInt32(num);
            if (number > 0)
            {
                count++;
            }
        }

        text = CutString(text, text.IndexOf(' '));
        System.Console.WriteLine(text);
    }

    return count;


}

System.Console.WriteLine(CountPositiveNum());