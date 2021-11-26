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

string text = "25 -123 54 -15 2 32 -5 0 65";

string num = string.Empty;
for (int i = 0; i < text.Length; i++)
{
    if (text[i] == ' ')
    {
        for (int j = 0; j < i; j++)
        {
            num += $"{text[j]}";
        }
        text = CutString(text, i);
    }
}
    
System.Console.WriteLine(num);