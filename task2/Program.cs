Console.WriteLine("Введите два числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
Console.Write("max =  ");
Console.WriteLine(numberA);
Console.Write("min =  ");
Console.WriteLine(numberB);
}
else
{
Console.Write("max =  ");
Console.WriteLine(numberB);
Console.Write("min =  ");
Console.WriteLine(numberA);   
}

