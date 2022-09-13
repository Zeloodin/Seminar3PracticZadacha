// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.Write("Введите целочисленное число: ");
try
{
    string inputString = Console.ReadLine();
    double numberN = Convert.ToDouble(inputString);
    double[] massivCubovChisel = new double[Convert.ToUInt64(numberN)];
    bool massivBool = false;

    for (int i = 0; i < numberN; i++)
    {
        massivCubovChisel[i] = Convert.ToDouble(Math.Pow(i,2));
        if (i >= numberN-1) massivBool = true;
    }
    
    if (massivBool)
    {
        Console.WriteLine(string.Join(", ", massivCubovChisel));

        // Console.WriteLine(String.Concat<double>(massivCubovChisel));

        // int lenghtMax = massivCubovChisel.Length;
        // for (int i = 0; i < lenghtMax; i++)
        // {
        //     Console.Write($"{massivCubovChisel[i]} ");
        // }
    }
    
}
catch
{
    Console.Write("Ошибка");
}
