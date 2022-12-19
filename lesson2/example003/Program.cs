Console.WriteLine("Введите число дня недели");
int number = int.Parse(Console.ReadLine());
if( number >=1 && number <= 5 )
 {
    Console.WriteLine("Этот день не является выходным");
 }
else if(number >=6 && number <= 7)
 {
    if( number == 6)
      {
         Console.WriteLine("Суббота - выходной");
      }
     else
      {
         Console.WriteLine("Воскресенье - выходной");
      } 
 } 
else
 {
    Console.WriteLine("Такого дня недели не бывает!");
 }  