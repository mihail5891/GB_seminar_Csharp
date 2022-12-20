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
// Функция подсчета цифр в числе
int CountNum( int num )
  {
    int i = 0;
    while( num > 0)
      {
        num /= 10;
        i++;
      }
    return i;
  }
// Функция вывода суммы цифр в числе
int Sum( int number, int count)
  {
     int sum = 0;
     for (int i = 1; i <= count; i++)
       {
          sum += number % 10;
          number /= 10;
       }
     return sum;
  }
int number = InputInt("Введите число: ");
int count = CountNum(number);
int result = Sum( number, count );
Console.WriteLine( result );