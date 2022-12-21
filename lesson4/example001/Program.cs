
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
// Функция подсчета и вывода результата  
void OutResult(int a, int b)
  {
    int result = 1;
    for (int i = 1; i <= b; i++) result = result * a;
    Console.WriteLine(result);
  }
int numberA = InputInt("Введите число A: ");
int numberB = InputInt( "Введите число B: ");

OutResult(numberA,numberB);