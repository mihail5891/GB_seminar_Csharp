
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
int numberA = InputInt("Введите число A: ");
int numberB = InputInt( "Введите число B: ");
int result = 1;
for (int i = 1; i <= numberB; i++) result = result * numberA;
Console.WriteLine(result);