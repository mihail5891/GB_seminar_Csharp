// функция создания масива и заполнение его случайными числами
int[] FillArray()
  {
     int[] arr = new int[8];
     for( int i = 0; i < arr.Length; i++ ) arr[i] = new Random().Next(1,9);
     return arr;      
  }
// функция вывода масива в консоль  
void PrintArray(int[] arr )
  {
    Console.Write( "[ " );
    int count = arr.Length -1;
    for( int i = 0; i <= count; i++ )
      {
         if( i == count ) Console.Write( arr[i] ); else Console.Write( arr[i] + ", " );
      }
    Console.Write( " ]" ); 
  }  
int[] array = FillArray();
PrintArray(array); 