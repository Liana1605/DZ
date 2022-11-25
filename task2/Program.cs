Console.WriteLine("Введите два числа: "); 
int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine()); 

if(a > b)
{
Console.Write("max = ");
Console.WriteLine(a);
Console.Write("min = ");
Console.WriteLine(b);
}
else
{
Console.Write("max = ");
Console.WriteLine(b);
Console.Write("min = ");
Console.WriteLine(a);
}
