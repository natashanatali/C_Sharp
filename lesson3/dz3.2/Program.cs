// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Linia(int ax, int ay, int az, int bx, int by, int bz)
{
  return Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)),2);
  
}
Console.WriteLine(Linia(3, 6, 8, 2, 1, -7));