// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine("Введите пятизначное число");
string? num = Console.ReadLine();

void PalNum(string num)
{
  if (num[0]==num[4] || num[1]==num[3])
  {
    Console.WriteLine($"число {num} - палиндром");
  }
  else Console.WriteLine($"число {num} - не палиндром");
}
PalNum(num);
