// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number =  int.Parse(Console.ReadLine()!);
string Number= Convert.ToString(number);
Console.WriteLine (number);
int [] array= new int[Number.Length];
int i;
for (i=0; i<Number.Length; i++)
{
    array[i]= Convert.ToInt32(Number[i].ToString());
}
if (array[0]==array[4] && array[1]==array[3])
{
    Console.WriteLine ("да");
}
else
{
    Console.WriteLine ("нет");
}