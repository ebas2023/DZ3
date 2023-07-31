/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое == последнему, второе == предпоследнему).
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите 5-е число");
int num = int.Parse(Console.ReadLine()!);
string five = num.ToString();
if (five.Length == 5)
{
    if (five[0] == five[4] && five[1] == five[3])
            {
        Console.WriteLine("Число полнидром");
    }
    else
    {
        Console.WriteLine("Число не полнидром");
    }
  
}
else
{
    Console.WriteLine("Введите корректное число");
}
