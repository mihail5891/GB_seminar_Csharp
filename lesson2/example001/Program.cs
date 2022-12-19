Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
if( number > 99 && number <= 999 )
  {
     int result = ((number / 10) % 10);
     Console.Write("Вторая цифра вашего числа: ");
     Console.WriteLine( result );
  }
 else
  {
      Console.WriteLine("Вы ввели не трехзначное число!");
  }