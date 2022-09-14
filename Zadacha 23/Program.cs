// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.Write("Введите целочисленное число: ");
try
{
    string inputString = Console.ReadLine();
    double numberN = Convert.ToDouble(inputString);
    double[] massivCubovChisel = new double[Convert.ToUInt64(numberN)];

    for (int i = 0; i < numberN; i++)
    {
        massivCubovChisel[i] = Convert.ToDouble(Math.Pow(i+1,3));
    }
    Console.WriteLine(string.Join(", ", massivCubovChisel));
}
catch
{
    Console.Write("Ошибка");
}
