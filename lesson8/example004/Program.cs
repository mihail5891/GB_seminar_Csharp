// Функция ввода сообщения
int InputInt( string message )
  {
     Console.Write( message );
     string number = Console.ReadLine();
     if( number == "" )
       {
         Console.WriteLine("Вы не ввели число!");
         return InputInt( message );
       }
     return int.Parse( number );
  }
int[,,] Create3DArray(int size1, int size2, int size3, int count)
  {
     int[,,] arr = new int[size1, size2, size3];
     int[] val = new int[count];
     int num = 10;
     for( int i = 0; i < val.Length; i++ )
       {
           val[i] = num
           ++;
       }
    for( int i = 0; i < val.Length; i++ )
      {
        int rnd = new Random().Next(0, val.Length);
        int temp = val[i];
        val[i] = val[rnd];
        val[rnd] = temp;
      }
    int valid = 0;
    for( int i = 0; i < arr.GetLength(0); i++ )
      {
         for( int j = 0; j < arr.GetLength(1); j++ )
           {
              for( int k = 0; k < arr.GetLength(2); k++ )
                {
                   arr[i, j, k] = val[valid++];
                }
           }
      }
    return arr;
  }
void Print3DArray( int [,,] arr )
  {
     for( int i = 0; i < arr.GetLength(0); i++ )
        {
           for( int j = 0; j < arr.GetLength(1); j++ )
             {
                for (int k = 0; k < arr.GetLength(2); k++)
                   {
                        Console.WriteLine($" {arr[i, j, k]} - [{i},{j},{k}]");
                   }
                Console.WriteLine();
             }
           Console.WriteLine();
        }
  }
int size1 = InputInt("Введите размерность 1: ");
int size2 = InputInt("Введите размерность 2: ");
int size3 = InputInt("Введите размерность 3: ");
int count = 89;
int[,,] result = Create3DArray( size1,  size2, size3, count );
Print3DArray( result );





