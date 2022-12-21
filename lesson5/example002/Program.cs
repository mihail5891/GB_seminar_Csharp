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
void FillArrayRandom(int[] arr )
  {
    for( int i = 0; i < arr.Length; i++ )
      {
         arr[i] = new Random().Next(1,10);
      }
  }
void PrintArray(int[] arr)
  {
     int count = arr.Length -1;
     Console.Write("[ ");
     for(int i = 0; i < arr.Length; i++)
      {
         if( i == count ) Console.Write( arr[i] ); else Console.Write( arr[i] + ", " );
      }
    Console.Write(" ]");
    Console.WriteLine();
}
int sizeArray = InputInt("Введите число: ");
int[] number = new int[sizeArray];

FillArrayRandom(number);
Console.Write("массив: ");
PrintArray(number);
int sum = 0;

for( int i = 0; i < number.Length; i++ )
   {
     if(i % 2 != 0) sum += number[i];
   }

Console.WriteLine($"всего {sizeArray} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");