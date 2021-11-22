// 46. Написать программу масштабирования фигуры




string a = "1(-555,0) (2,0) (2,2) (0,2)";
// int k = 2;




int FindIndexOf(string text, char sign)   // метод возвращает индекс (int) первого знака 'sign' (char) в строке text (string)
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

string DeleteChar(string text, char sign)  // метод возвращает строку string text удалив из нее все знаки char 'sign'
{
  string newText = String.Empty;
  for (int i = 0; i < text.Length; i++)
  {
    if (text[i] != sign)
    {
        newText += $"{text[i]}";
    }
  }
  return newText;
}

int NumBetweenSign(string text, char firstSign, char secondSign) // метод возвращает int число, которое находится между символами firstSign и secondSign в строке text                                                               
{
  int count = FindIndexOf(text, secondSign) - FindIndexOf(text, firstSign)-1;
  string num = string.Empty;
  for (int i = FindIndexOf(text, firstSign); i <= count; i++)
  {
      num += $"{text[i+1]}";
  }
  int number = Convert.ToInt32(num);
   return number;
}


Console.Write(NumBetweenSign(a,'(',','));

//System.Console.WriteLine(FindIndexOf(a,','));

// string b = DeleteChar(a,'"');
// string c = DeleteChar(b,'(');
// string d = DeleteChar(c,')');

// System.Console.WriteLine(d);

