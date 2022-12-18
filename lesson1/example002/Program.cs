
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

if((number2 < number1) && (number1 > number3))
  {
    Console.Write("Число ");
    Console.Write(number1);
    Console.WriteLine(" больше");
  }
 else if ((number1 < number2) && (number2 > number3))
  {
    Console.Write("Число ");
    Console.Write(number2);
    Console.WriteLine(" больше");}
 else
  {
    Console.Write("Число ");
    Console.Write(number3);
    Console.WriteLine(" больше");
  }