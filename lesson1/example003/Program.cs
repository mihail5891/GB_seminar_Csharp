Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

if( number % 2 == 1 )
  {
    Console.Write("Число ");
    Console.Write(number);
    Console.WriteLine(" является не четным");
  }
 else
  {
    Console.Write("Число ");
    Console.Write(number);
    Console.WriteLine(" является четным");
  }