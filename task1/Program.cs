// Напишите программу, которая принимает на вход два числа A и B и возводит число А в натуральную степень числа В

Console.Clear();

double Degree (int a, int b)
{
    double c = Math.Pow(a,b);   
    return c;
}

try
{
    Console.Write ("Введите число A. A = ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write ("Введите число B. B = ");
    int b = Convert.ToInt32(Console.ReadLine());

    double rez = Degree(a,b);
    Console.Write($"Число А в степени В будет равно {rez}");
}

catch
{
    Console.WriteLine("Вводить нужно было целые числа");
}
