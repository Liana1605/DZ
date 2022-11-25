Console.WriteLine("Введите одно число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if(numberN > 1)
{
    int numberS = 2;
    while(numberS <= numberN)
    {
        Console.Write($"{numberS} ");
        numberS += 2;
    }
}
else if(numberN < 1)
{
   int numberS = 0;
   while(numberS >= numberN)
   {
        Console.Write($"numberS ");
        numberS -= 2;
   }
}
else
{
    Console.WriteLine("ошибка");
}