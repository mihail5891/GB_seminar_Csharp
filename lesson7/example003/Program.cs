
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
void arithmeticMean( int[,] arr, int n )
  {
     for( int i = 0; i < arr.GetLength(1); i++ )
       {
          double result = 0;
          for( int j = 0; j < arr.GetLength(0); j++ ) result = ( result + arr[j, i]);
          result = result / n;
          Console.Write( result + "; " );
        }
     Console.WriteLine();
  }
int n = InputInt("Введите количество строк: ");
int m = InputInt("Введите количество столбцов: ");
int[,] numbers = new int[n, m];
FillArray( numbers );
Console.WriteLine("Массив: ");
PrintArray(numbers);
Console.Write("Среднее арифметическое элементов в каждом столбце массива: ");
arithmeticMean( numbers, n );
