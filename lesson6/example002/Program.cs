// Функция ввода сообщения
double InputInt( string message )
  {
     Console.Write(message);
     string number = Console.ReadLine();
     if( number == "" )
       {
         Console.WriteLine("Вы не ввели число!");
         return InputInt( message );
       }
     return Convert.ToDouble( number );
  }
 // Функция подсчета и вывода результата в консоль 
void OutResult( double b1, double b2, double k1, double k2)
  {
     double x = -(b1 - b2) / (k1 - k2);//double
     double y = k1 * x + b1;
     x = Math.Round(x, 3);
     y = Math.Round(y, 3);
     Console.WriteLine($"Пересечение в точке: ( {x}; {y})");
  }
double b1 = InputInt("Введите b1: ");
double b2 = InputInt("Введите b2: ");
double k1 = InputInt("Введите k1: ");
double k2 = InputInt("Введите k2: ");
OutResult(b1,b2,k1,k2);


