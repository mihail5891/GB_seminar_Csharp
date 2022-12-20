
int[] arr = new int[8];
Console.Write( "[ " );
int count = arr.Length -1;
for( int i = 0; i <= count; i++ )
  {
    arr[i] = new Random().Next(1,9);
    if( i == count ) Console.Write( arr[i] ); else Console.Write( arr[i] + ", " );
  }
 Console.Write( " ]" ); 