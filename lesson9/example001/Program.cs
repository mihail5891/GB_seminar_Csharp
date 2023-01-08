
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
int number = InputInt("Введите натуральное число больше 1: ");
if( number < 0 )
  {
     Console.Write($"{number} не натуральное число");
     return;
  } 
///Метод вывода натуральных чисел от N до 1:
void PrintNumber( int num )
  {
    if( num == 0 ) return;
    if( num == 1 ) Console.Write( num ); else Console.Write( num + ", ");
    PrintNumber(num - 1);
  }
Console.Write($"N = {number} -> ");
PrintNumber(number);