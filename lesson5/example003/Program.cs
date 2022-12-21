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
         arr[i] = new Random().Next(10,100);
      }
  }
// функция вывода массива в консоль 
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
// Функция подсчета минимального и максимального числа и разница этих чисел в массиве
int[] OutMinMaxResult(int[] arg )
  {
     int min = Int32.MaxValue;
     int max = Int32.MinValue;
     for (int i = 0; i < arg.Length; i++)
       {
          if( arg[i] > max ) max = arg[i];
          if( arg[i] < min ) min = arg[i];
       }
     int difference = max - min;
     int[] result = {min, max, difference}; 
     return result;
  }
int sizeArray = InputInt("Введите число: ");
int[] number = new int[sizeArray];

FillArrayRandom(number);
Console.Write("массив: ");
PrintArray(number);
int[] result = OutMinMaxResult(number);
Console.WriteLine($"Всего {sizeArray} чисел. Максимальное значение = {result[1]}, минимальное значение = {result[0]}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {result[2]}");