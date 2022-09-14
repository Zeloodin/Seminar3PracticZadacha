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

Console.Clear();

int points = 2;
int coorNum = 3;

int[,] coordinates = new int [points, coorNum];
for (int k = 0; k < points; k++)
{
    string txt = k == 0 ? "Точка A" : "Точка B";
    Console.WriteLine(txt);
    for (int m = 0; m < coorNum; m++)
    {
        Console.WriteLine($"Введите значение {m + 1}-й координаты");
        coordinates[k, m] = int.Parse(Console.ReadLine());
    }
}

Console.Clear();
Console.Write($"Point1 X:{coordinates[0,0]} Y:{coordinates[0,1]} Z:{coordinates[0,2]}\n");
Console.Write($"Point2 X:{coordinates[1,0]} Y:{coordinates[1,1]} Z:{coordinates[1,2]}\n");

double coordinats_X2_X1 = coordinates[1,0] - coordinates[0,0];
double coordinats_Y2_Y1 = coordinates[1,1] - coordinates[0,1];
double coordinats_Z2_Z1 = coordinates[1,2] - coordinates[0,2];
double sqrt_PowX2_PowY2_PowZ2 = Math.Sqrt(Math.Pow(coordinats_X2_X1,2)+Math.Pow(coordinats_Y2_Y1,2)+Math.Pow(coordinats_Z2_Z1,2));
sqrt_PowX2_PowY2_PowZ2 =  Math.Round(sqrt_PowX2_PowY2_PowZ2, 2);

Console.WriteLine($"Расстояние между Ponit1 и Point2: {sqrt_PowX2_PowY2_PowZ2}");