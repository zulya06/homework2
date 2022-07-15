//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Seconddigit (int num1)
{
int twodid = num1/10;
int result = twodid % 10;
Console.WriteLine("Seconddigit is" + result);

}

Console.WriteLine(" Input there digit num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Seconddigit(num1);