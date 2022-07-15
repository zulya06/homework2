// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void Thirddigit (string num)
{
    if (num.Length >= 3)
    {
       char thirdChar = num [2];
       Console.WriteLine("Third digit is " + thirdChar);
    }
    
    else
    {
        if (num.Length == 2 || num.Length == 1)
        {
            Console.WriteLine("This num has no third digit");
        }
    }
    
}

string num1;
Console.Write("Input your num: ");
num1 = Console.ReadLine();
Thirddigit (num1);
