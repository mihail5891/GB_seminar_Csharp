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
//Функция нахожденияпроизведения двух матриц  
int[,] productTwoMatrix( int[,] a, int[,] b, int[,] c )
  {
     for( int i = 0; i < a.GetLength(0); i++ )
       {
          for( int j = 0; j < a.GetLength(0); j++ )
            {
              for(int k = 0; k < a.GetLength(0); k++)
                 {
                    c[i, j] = c[i, j] + ( a[i, k] * b[k, j]);
                 }
            }
        }
      return c;  
  }
int size = InputInt("Размерность матриц: ");
int[,] a = new int[size, size];
int[,] b = new int[size, size];
int[,] c = new int[size, size];
FillArray( a );
FillArray( b );

Console.WriteLine( "Матрица - А: " );
PrintArray( a );
Console.WriteLine();

Console.WriteLine( "Матрица - В: " );
PrintArray( b );
Console.WriteLine();

Console.WriteLine( "Произведение матриц А*В: " );
int[,]result = productTwoMatrix(a,b,c);
PrintArray( result );