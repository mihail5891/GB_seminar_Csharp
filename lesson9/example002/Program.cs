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
int CountSum( int m, int n )
  {
     if( m == n ) return n;
     return n + CountSum( m, n - 1 );
  }
int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
int result = CountSum( m, n );
Console.WriteLine($"Сумма элементов от {m} до {n} = {result}");





