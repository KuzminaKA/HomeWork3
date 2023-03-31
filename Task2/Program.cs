﻿//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int Read(string coordinate) 

{     
    System.Console.WriteLine($"Введите 3 координаты двух точек {coordinate}:");
    int x = int.Parse(Console.ReadLine());     
    return x; 
}  

int x1 = Read("x1"); 
int y1 = Read("y1"); 
int x2 = Read("x2"); 
int y2 = Read("y2");  
int z1 = Read("z1");
int z2 =Read ("z2");

double Lenght (int x1, int y1, int z1, int x2, int y2, int z2)  
{    
    return Math.Round(Math.Sqrt (Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)),2);  
}  
System.Console.WriteLine($"Расстояние между двумя точками - {Lenght(x1, y1, z1, x2, y2, z2)}");