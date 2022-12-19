Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if( number >= 100 )
  {
     while( number > 999 ) number = number / 10;
     int result = number % 10;
     Console.Write("Третья цифра вашего числа: ");
     Console.WriteLine( result );
  }
 else
  {
    Console.WriteLine("Третьей цифры нет");
  } 