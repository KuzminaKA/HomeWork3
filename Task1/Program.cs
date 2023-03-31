//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine());

int i1=N/10000;
int i2=N%10;
int i3=N/1000%10;
int i4=N%100/10;

bool Palindrome(int i1, int i2, int i3, int i4)
{
    return i1==i2 && i3==i4;
}

if (Palindrome(i1, i2, i3, i4))
{
    System.Console.WriteLine("Это палиндром");
}
else
{
    System.Console.WriteLine("Это НЕ палиндром");
}