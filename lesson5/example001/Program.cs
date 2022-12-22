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
// функция заполнения массива рандомными числами  
void FillArrayRandom(int[] arr )
  {
    for( int i = 0; i < arr.Length; i++ )
      {
         arr[i] = new Random().Next(100,1000);
      }
  }
// функция вывода массива в консоль  
void PrintArray(int[] arr)
  {
     int count = arr.Length -1;
     Console.WriteLine("массив: ");
     Console.Write("[ ");
     for(int i = 0; i < arr.Length; i++)
      {
         if( i == count ) Console.Write( arr[i] ); else Console.Write( arr[i] + ", " );
      }
    Console.Write(" ]");
    Console.WriteLine();
}
void CountEvenNum( int[] number )
  {
     int count = 0;
     for(int i = 0; i < number.Length; i++)
       {
          if (number[i] % 2 == 0) count++;
       }
     Console.WriteLine($"Всего {sizeArray} чисел, {count} из них чётные");
  }
int sizeArray = InputInt("Введите число: ");
int[] number = new int[sizeArray];
FillArrayRandom(number);
PrintArray(number);
CountEvenNum( number );

