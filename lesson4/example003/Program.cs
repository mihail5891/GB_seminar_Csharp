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
int len = InputInt("Введите длинну массива: ");
int[] arr = new int[len];
for( int i = 0; i < arr.Length; i++ )
  {
    arr[i] = new Random().Next(1,9);
    Console.WriteLine( arr[i] );
  }