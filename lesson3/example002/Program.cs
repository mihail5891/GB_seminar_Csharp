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
void OutResult(int a, int b, int c)
  {
    double length = Math.Sqrt(a * a + b * b + c * c);
    Console.Write( $"Длинна отрезка: {length}" );
  }
int x1 = InputInt("Введите координату X первой точки: ");
int x2 = InputInt("Введите координату X второй точки: ");

int y1 = InputInt("Введите координату Y первой точки: ");
int y2 = InputInt("Введите координату Y второй точки: ");

int z1 = InputInt("Введите координату Z первой точки: ");
int z2 = InputInt("Введите координату Z второй точки: ");

OutResult( x2 - x1, y2 - y1, z1 - z2 );
