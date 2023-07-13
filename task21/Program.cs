// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void DistanceBetweenPlaces(int ax, int ay, int az, int bx, int by, int bz)
{
    double distance = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
    Console.WriteLine($"Растояние между точкой A и точкой B = {distance}");
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int ax = GetInput("Введите координату X точки A: ");
int ay = GetInput("Введите координату Y точки A: ");
int az = GetInput("Введите координату Z точки A: ");
int bx = GetInput("Введите координату X точки B: ");
int by = GetInput("Введите координату Y точки B: ");
int bz = GetInput("Введите координату Z точки A: ");
DistanceBetweenPlaces(ax, ay, az, bx, by, bz);
