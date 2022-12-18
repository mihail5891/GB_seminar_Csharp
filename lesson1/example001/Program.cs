Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.Write("Число ");
    Console.Write(number1);
    Console.WriteLine(" больше");
}
else
{
    Console.Write("Число ");
    Console.Write(number2);
    Console.WriteLine(" больше");
}

