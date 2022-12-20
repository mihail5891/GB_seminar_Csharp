int CheckPalindromic(int number)
  {
     if( number >= 10000 && number < 100000 )
       {
         int first_num = number / 10000;
         int last_num = number % 10;
         if( first_num == last_num )
           {
              number = number / 10;
              first_num = (number / 100) % 10;
              last_num = number % 10;
              if( first_num == last_num) return 1; else return 0; 
            }
         return 0;       
       }
     return -1;
}
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
int result = CheckPalindromic(number);
if( result == 1)
  {
     Console.Write("Число: ");
     Console.Write(number);
     Console.WriteLine(" является полиндромом");
  }
 else if( result == 0 )
  {
     Console.Write("Число: ");
     Console.Write(number);
     Console.WriteLine(" не является полиндромом");
  } 
 else
  {
     Console.Write("Число: ");
     Console.Write(number);
     Console.WriteLine(" не является пятизначным"); 
  }