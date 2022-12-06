// See https://aka.ms/new-console-template for more information

double Linia(int ax, int ay, int az, int bx, int by, int bz)
{
  return Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)),2);
  
}
Console.WriteLine(Linia(5, 1, 7, -4, 6, 8));