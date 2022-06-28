// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Random rnd = new Random();
int number = rnd.Next(10, 999);
Console.WriteLine(number);
int A = number % 10;
int B = (number/ 10) % 10;
int C = number / 100;

Console.WriteLine("Полученное последнее число {0}", A + number>99 ? number.ToString()[2] : '-');
Console.ReadKey(true);