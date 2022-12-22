// Функция ввода сообщения
string[] Input( string message )
  {
     Console.Write(message);
     string[] text = Console.ReadLine().Split();
     int count = text.Length;
     if( count == 0 )
       {
         Console.WriteLine("Вы не ввели число!");
         return Input( message );
       }
     return text;
  }
//функция подсчета чисел больше 0  
int CountNumber( string[] arr )
 {
    int count = 0;
    int[] num = Array.ConvertAll( arr, s => int.TryParse(s, out var x) ? x : -1 );
    int Length = num.Length;
    for (int i = 0; i < Length; i++)
      {
         if(  num[i] > 0) count++;
      }
      Console.WriteLine();
    return count;  
 }
string[] arr = Input("Введите числа (через пробел): "); 
int count = CountNumber( arr );
Console.WriteLine($"Кол-во элементов > 0: {count}");