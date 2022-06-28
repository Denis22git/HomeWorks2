// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Random rnd = new Random();
int number = rnd.Next(100, 1000);
Console.WriteLine(number);
int A = number % 10;
int B = (number / 10) % 10;
int C = number/ 100;
Console.WriteLine("Полученное число {0}", B);
