int i = 1;
bool found = false;
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + number );
while (i <= number)
  {
     if( i % 2 != 1 )
       {
         if( i == number )
           {
              Console.WriteLine( i );
           }
          else 
           {
              Console.Write( i + ", " );
           } 
         found = true;
       }
     i++;
  }
if( !found )
  {
     Console.WriteLine("Чётных чисел нет!");
  } 