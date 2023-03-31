//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.Write("Введите число: ");
int N= int.Parse(Console.ReadLine());

void Cube(int N)
{
for(int n=1; n<=N; n++)

    {
      int result= n*n*n;
      System.Console.WriteLine(result);
    }

  }

Cube(N);