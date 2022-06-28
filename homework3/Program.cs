// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели");
int day;

day=int.Parse(Console.ReadLine());

if(day<=5){

Console.WriteLine("рабочий");

}

else{

Console.WriteLine("выходной");

}

Console.ReadLine();