﻿//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Введите значение точки A: ");
int y1 = ReadInt("Введите значение точки A: ");
int v1 = ReadInt("Введите значение точки A: ");
int x2 = ReadInt("Введите значение точки B: ");
int y2 = ReadInt("Введите значение точки B: ");
int v2 = ReadInt("Введите значение точки B: ");

double distance = Math.Sqrt(Math.Pow((x2-x1), 2) +  Math.Pow((y2-y1), 2) + Math.Pow((v2-v1), 2));
Console.WriteLine(distance);

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}