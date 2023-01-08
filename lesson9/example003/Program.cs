// Функция ввода сообщения
int InputInt( string message )
  {
     Console.Write( message );
     string number = Console.ReadLine();
     if( number == "" )
       {
         Console.WriteLine("Вы не ввели число!");
         return InputInt( message );
       }
     return int.Parse( number );
  }
int FillAkkerman(int m, int n)
  {
     if( m == 0 ) return n ++;
     if( m > 0 && n == 0 )
       {
          return FillAkkerman(m - 1, 1 );
       }
      else
       {
          return FillAkkerman(m - 1, FillAkkerman( m, n - 1 ) );
       }
  }
Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
if( n < 0 )
  {
     Console.Write($"{n} не натуральное число");
     return;
  }
if( m < 0 )
  {
     Console.Write($"{m} не натуральное число");
     return;
  }
int result = FillAkkerman( m, n );
Console.WriteLine($"A({m}, {n}) = {result}");