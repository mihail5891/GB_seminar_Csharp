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
// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortArray( int[,] arr )
  {
     for( int i = 0; i < arr.GetLength(0); i++ )
       {
          for( int j = 0; j < arr.GetLength(1); j++ )
            {
              for( int k = 0; k < arr.GetLength(1) - 1; k++ )
                {
                   if( arr[i, k] < arr[i, k + 1] )
                     {
                        int tmp = arr[i, k + 1];
                         arr[i, k + 1] = arr[i, k];
                         arr[i, k] = tmp;
                     }
                }
            }
        }
  }

int[,] array = new int[3, 4];
FillArray( array );
PrintArray( array );
SortArray( array );
Console.WriteLine();
PrintArray( array );