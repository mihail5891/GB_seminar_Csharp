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
// функция наполнения массива рандомными числами  
void FillArray( int[,] arr )
  { 
    Random rnd = new Random();
    for( int i = 0; i < arr.GetLength(0); i++)
      { 
        for( int j = 0; j < arr.GetLength(1); j++)
          { 
             arr[i,j] = new Random().Next(10,100);
          }
      }
  }
  // функция вывода двумерного массива  
void PrintArray( int[,] arr)
  { 
     Console.Write("[ ");
     for (int i = 0; i < arr.GetLength(0); i++)
       { 
          for (int j = 0; j < arr.GetLength(1); j++) Console.Write($"{arr[i, j]} ");
          Console.WriteLine();
      }
     Console.Write("]");
     Console.WriteLine("");
  }
int n = InputInt("Введите номер строки: ");
int m = InputInt("Введите номер столбца: ");
int [,] numbers = new int [10,10];
FillArray( numbers );

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
  {
     Console.WriteLine("Такого элемента нет");
  }
 else
  {
     Console.WriteLine($"Значение {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
  }
PrintArray(numbers);

