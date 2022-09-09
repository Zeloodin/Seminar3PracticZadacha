// Задача 21: Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

double[] listXYZ1, listXYZ2;

listXYZ1 = new double[3];
listXYZ2 = new double[3];

Console.Write("Введите координату X для первой точки: ");
listXYZ1[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y для первой точки: ");
listXYZ1[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z для первой точки: ");
listXYZ1[2] = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X для второй точки: ");
listXYZ2[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y для второй точки: ");
listXYZ2[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z для второй точки: ");
listXYZ2[2] = Convert.ToDouble(Console.ReadLine());


double coordinats_X2_X1 = listXYZ2[0] - listXYZ1[0];
double coordinats_Y2_Y1 = listXYZ2[1] - listXYZ1[1];
double coordinats_Z2_Z1 = listXYZ2[2] - listXYZ1[2];
double sqrt_PowX2_PowY2_PowZ2 = Math.Sqrt(Math.Pow(coordinats_X2_X1,2)+Math.Pow(coordinats_Y2_Y1,2)+Math.Pow(coordinats_Z2_Z1,2));


Console.WriteLine(sqrt_PowX2_PowY2_PowZ2);

// listXYZ1[1] = 3;
// listXYZ1[0] = 10.3;

// listXYZ1[2] = 33;

// int iner = (listXYZ1).Length;

// double numberA = listXYZ1[0] + listXYZ1[1] + listXYZ1[2];

// Console.WriteLine(listXYZ1[1]);

// Console.ReadLine();






