// Задача 43: 
// Напишите программу, которая 
// найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Please input below data:");
Console.Write("b1: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1: ");
int numk1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2: ");
int numk2 = Convert.ToInt32(Console.ReadLine());


double pointX = Math.Round(IntesectionPointX(numb1, numk1, numb2, numk2), 1, MidpointRounding.ToZero);
double pointY = Math.Round(IntesectionPointY(numb1, numk1, numb2, numk2), 1, MidpointRounding.ToZero);
Console.WriteLine($"b1 = {numb1}, k1 = {numk1}, b2 = {numb2}, k2 = {numk2} -> ( {pointX} ; {pointY} )");


double IntesectionPointX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double IntesectionPointY(double b1, double k1, double b2, double k2)
{
    double y = (k1 * b2 - k2 * b1) / (k1 - k2);
    return y;
}
