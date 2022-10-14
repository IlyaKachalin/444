// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int Sum(int a)
{
   int sum = 0;
   for (int i = 0; i<a; i++)
   {
  sum = sum + a%10;
  a=a/10;
   }
   return sum;

}

try
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());

    int rez = Sum(a);
    Console.WriteLine (rez);

}

catch
{
    Console.WriteLine("Вводить нужно было целое число");
}
