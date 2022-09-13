// Задача 21: Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

string what_coordinate(int coordinate) // Координаты X=1 Y=2 Z=3 4......N
{
    switch(coordinate)
    {
        case 0: return "X";
        case 1: return "Y";
        case 2: return "Z";
        default: return Convert.ToString(coordinate);
    }
};

double[] coordinats1Point = new double[3];
double[] coordinats2Point = new double[3];

Console.Clear();

for (int iCountPoint=0; iCountPoint<2; iCountPoint++)      // Колличество точек     = iCountPoint
{
    double coordinateXYZ;
    for (int jCountCoor=0; jCountCoor<3; jCountCoor++) // Колличество координат = jCountCoor
    {
        Console.Write($"Введите координату {what_coordinate(coordinate:jCountCoor)} для точки Point{iCountPoint+1}: ");
        switch(iCountPoint)
        {
            case 0:
            {
                coordinats1Point[jCountCoor] = double.Parse(Console.ReadLine());
                Console.Write($"Point{iCountPoint+1} X:{coordinats1Point[0]} Y:{coordinats1Point[1]} Z:{coordinats1Point[2]}\n");
                break;
            }
            
            case 1:
            {
                coordinats2Point[jCountCoor] = double.Parse(Console.ReadLine());
                Console.Write($"Point{iCountPoint+1} X:{coordinats2Point[0]} Y:{coordinats2Point[1]} Z:{coordinats2Point[2]}\n");
                break;
            }

            default:
                break;
        }
    }
}

Console.Clear();
Console.Write($"Point1 X:{coordinats1Point[0]} Y:{coordinats1Point[1]} Z:{coordinats1Point[2]}\n");
Console.Write($"Point2 X:{coordinats2Point[0]} Y:{coordinats2Point[1]} Z:{coordinats2Point[2]}\n");

double coordinats_X2_X1 = coordinats2Point[0] - coordinats1Point[0];
double coordinats_Y2_Y1 = coordinats2Point[1] - coordinats1Point[1];
double coordinats_Z2_Z1 = coordinats2Point[2] - coordinats1Point[2];
double sqrt_PowX2_PowY2_PowZ2 = Math.Sqrt(Math.Pow(coordinats_X2_X1,2)+Math.Pow(coordinats_Y2_Y1,2)+Math.Pow(coordinats_Z2_Z1,2));


Console.WriteLine($"Расстояние между Ponit1 и Point2: {sqrt_PowX2_PowY2_PowZ2}");
