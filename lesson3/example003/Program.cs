// Функция ввода сообщения
int InputInt( string message )
  {
     Console.Write(message);
     string number = Console.ReadLine();
     if( number == "" )
       {
         Console.WriteLine("Вы не ввели число!");
         return InputInt( message );
       }
     return int.Parse( number );
  }
int number = InputInt("Введите число N: ");
for (int i = 1; i <= number; i++) Console.WriteLine( i*i*i );
