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
// функция наполнения массива рандомными числами  
void FillArray(double[,] arr )
  { 
    Random rnd = new Random();
    for( int i = 0; i < arr.GetLength(0); i++)
      { 
        for( int j = 0; j < arr.GetLength(1); j++)
          { 
             arr[i,j] = new Random().Next(-10,100);
          }
      }
  }
// функция вывода двумерного массива  
void PrintArray(double[,] arr)
  { 

    for (int i = 0; i < arr.GetLength(0); i++)
      { 
         for (int j = 0; j < arr.GetLength(1); j++) Console.Write($"{arr[i, j]} ");
         Console.WriteLine();
      }
  }
int m = InputInt("Задайте количество строк двумерного массива: ");
int n = InputInt("Задайте количество столбцов двумерного массива: ");
double[,] array = new double[m, n];
FillArray( array );
PrintArray(array);
