//По заданному номеру дня недели вывести его название


void PrintDay(int userNumber)
{
string[] a = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};

if (userNumber == 1)
 {
     Console.WriteLine(a[0]);
 }
 if (userNumber == 2)
 {
     Console.WriteLine(a[1]);
 }
if (userNumber == 3)
 {
     Console.WriteLine(a[2]);
 }
 if (userNumber == 4)
 {
     Console.WriteLine(a[3]);
 }
 if (userNumber == 5)
 {
     Console.WriteLine(a[4]);
 }
if (userNumber == 6)
 {
     Console.WriteLine(a[5]);
 }
 if (userNumber == 7)
 {
     Console.WriteLine(a[6]);
 }
 if (userNumber > 7)
 {
     Console.WriteLine("Вы - сверхчеловек!!");
 }
}

Console.WriteLine("Введите номер дня:");
int userNumber = Convert.ToInt32(Console.ReadLine());
PrintDay(userNumber);