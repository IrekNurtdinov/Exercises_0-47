// 46. Написать программу масштабирования фигуры


// Status: решено


int FindIndexOf(string text, char sign)   // метод возвращает индекс (int) первого сивола 'sign' (char) в строке text (string)
{
    int index = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == sign)
        {
            index = i;
            break;
        }
    }
    return index;
}

// string DeleteChar(string text, char sign)  // метод возвращает строку text удалив из нее все символы 'sign'
// {
//     string newText = String.Empty;
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] != sign)
//         {
//             newText += $"{text[i]}";
//         }
//     }
//     return newText;
// }

int NumBetweenSign(string text, char firstSign, char secondSign) // метод возвращает int число, которое находится между первыми символами firstSign и secondSign в строке text                                                               
{
    int count = FindIndexOf(text, secondSign) - FindIndexOf(text, firstSign) - 1;
    string num = string.Empty;
    for (int i = FindIndexOf(text, firstSign); i < (count + FindIndexOf(text, firstSign)); i++)
    {
        num += $"{text[i + 1]}";
    }

    int number = Convert.ToInt32(num);
    return number;
}

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

int[] NumFromStrToArr(string text)  // метод возвращает массив состоящий из двух первых чисел, находящихсяв строке text между символами '('  ','  ')'
{
    int[] Arr = new int[2];
    int i = 0;
    Arr[i] = NumBetweenSign(text, '(', ',');
    //System.Console.WriteLine(Arr[i]);
    Arr[i + 1] = NumBetweenSign(text, ',', ')');
    //System.Console.WriteLine(Arr[i + 1]);
    return Arr;

}


string Scaling(string text, int k) // метод возвращает строку text с координатами записанными в формате (x1, y1) умножая координаты на коэффициент k.
{
    string newText = string.Empty;
    while (text.Length > 0)
    {
        int[] Arr = NumFromStrToArr(text);
        newText += $"({Arr[0]* k},{Arr[1]*k}) ";
        text = CutString(text, FindIndexOf(text, ')'));
        
    }
    return newText;
}

string a = "(-5550,3) (44,12) (6,83) (712,9)";
int k = 2;


System.Console.WriteLine(Scaling(a,k));
