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
    for( int i = 0; i < arr.GetLength(0); i++ )
      { 
        for( int j = 0; j < arr.GetLength(1); j++ )
          { 
             arr[i,j] = new Random().Next(1,10);
          }
      }
  }
// функция вывода двумерного массива  
void PrintArray( int[,] arr )
  { 
     Console.Write("[ ");
     for( int i = 0; i < arr.GetLength(0); i++ )
       { 
          for( int j = 0; j < arr.GetLength(1); j++ ) Console.Write($"{arr[i, j]} ");
          if( i < arr.GetLength(0)-1 ) Console.WriteLine();
      }
     Console.Write("]");
     Console.WriteLine("");
  }
void SortArray( int [,] arr )
  {
     int result = Int32.MaxValue;
     int id = 0;
     for( int i = 0; i < arr.GetLength(0); i++ )
       {
          int tmp = 0;
          for( int j = 0; j < arr.GetLength(1); j++ ) tmp = tmp + arr[i, j];        
          if( tmp < result )
            {
              result = tmp;
              id ++;
            }
       }
     Console.WriteLine( $"Строка с наименьшей суммой елементов под номером: {id}, с суммой елементов равной: {result}" );
  }  
int count = InputInt("Введите размер прямоугольного массива: ");
int[,] numbers = new int[count, count];
FillArray( numbers );
PrintArray( numbers );
SortArray( numbers );
