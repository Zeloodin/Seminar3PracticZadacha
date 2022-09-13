// Задача 19: Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.

bool IsNumberPalindrom(int number)
{
    int numberPalindrom = number;
    int lenghtNumber = Find_the_lenght_of_an_integer(numberPalindrom);
    string numberPalindromString = Convert.ToString(numberPalindrom);
    for (int i = 2; i > 0; i--)
    {
        if(numberPalindromString[i] == numberPalindromString[lenghtNumber-i]) // Проверяет первые два числа на палиндром
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine(IsNumberPalindrom(12321));

int Terminal_input_out_integer(string input_string)
{
    while(true) // Всегда работает
    {
        try
        {   
            Console.Clear();
            Console.Write("Введите целое пятизначное число, которое является палиндромом: ");
            // if (input_string == "")
            // {
                input_string = Console.ReadLine(); // Присваивает переменную из консоли
            // }
            int num5 = Convert.ToInt16(input_string);
            if (Find_the_lenght_of_an_integer(num5) == 5) return num5;
            
        }
        catch(System.FormatException) // Входная строка имела неправильный формат.
        {   
            Console.Clear();
            Console.Write("Ошибка. Не является целочисленным.\nВведите целое пятизначное число, которое является палиндромом: ");
            // input_string = Console.ReadLine(); // Присваивает переменную из консоли
        }
        catch(System.OverflowException) // Значение было либо слишком большим, либо слишком маленьким.
        {
            Console.Clear();
            Console.Write("Ошибка. Значение было, или очень большим, или очень маленьким.\nВведите целое пятизначное число число, которое является палиндромом: ");
            // input_string = Console.ReadLine(); // Присваивает переменную из консоли
        }
    }
}

int Find_the_lenght_of_an_integer(int number)
{
    int lenNum = 1;
    while(true)
    {
        number = number / 10;
        if (number == 0) break;
        else lenNum++;
    }
    return lenNum;
}

Console.Clear();
Console.Write($"Введите целое пятизначное число, которое является палиндромом \n"
+              "Пример: 19491, 83038, 35353, 13531, 02920. Введите число: ");

int numberPalindrom = Terminal_input_out_integer("Console.ReadLine()");
// int lenghtNumber = Find_the_lenght_of_an_integer(numberPalindrom);

// Console.WriteLine(Convert.ToString(numberPalindrom));
// Console.WriteLine(Convert.ToString(lenghtNumber));


Console.WriteLine(IsNumberPalindrom(numberPalindrom));
