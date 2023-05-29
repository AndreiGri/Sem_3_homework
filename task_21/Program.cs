//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double Messages(string num)
{
    Console.Write($"Введите координату {num}: ");
    double res = double.Parse(Console.ReadLine()!);
    return res;
}

double MaP(double i, double j)
{
    double num = Math.Pow((i - j), 2);
    return num;
}

double x1 = Messages("x1");
double y1 = Messages("y1");
double z1 = Messages("z1");

double x2 = Messages("x2");
double y2 = Messages("y2");
double z2 = Messages("z2");

double l = Math.Sqrt(MaP(x1, x2) + MaP(y1, y2) + MaP(z1, z2));

Console.Write($"Растояние между точками: {Math.Round(l, 2)}");
