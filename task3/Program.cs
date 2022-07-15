// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void fineday (int num)

{
if (num >=5)
{
    Console.WriteLine( "this is not weeknd");
}
if (num ==6  || num ==7 )
{
  Console.WriteLine (" this is weeknd");
}

}

Console.WriteLine("input num");
  int num = Convert.ToInt32 (Console.ReadLine()); 
fineday (num);

