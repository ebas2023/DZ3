/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Write("Введите координату точки А, x: ");
int x1=int.Parse(Console.ReadLine ()!);
Console.Write("Введите координату точки А, y: ");
int y1=int.Parse(Console.ReadLine ()!);
Console.Write("Введите координату точки А, z: ");
int z1=int.Parse(Console.ReadLine ()!);

Console.Write("Введите координату точки B, x: ");
int x2=int.Parse(Console.ReadLine ()!);
Console.Write("Введите координату точки B, y: ");
int y2=int.Parse(Console.ReadLine ()!);
Console.Write("Введите координату точки B, z: ");
int z2=int.Parse(Console.ReadLine ()!);

double AB=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
Console .WriteLine ($"Расстояние между точками {AB:f2}");