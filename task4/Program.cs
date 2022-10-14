// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.

Console.Clear();

void FillArray (int N, int array)
{
    for (int i=0; i<N; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
}

try
{

}