// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
FindNatural(N, M);
Console.WriteLine($"Сумма чисел от {N} до {M} = " + FindNatural(N, M));
int FindNatural(int N, int M, int sum = 0)
{
    if (N <= M)
    {
        sum = sum + N;
        N = N + 1;
    }
    else
        return sum;
    return FindNatural(N, M, sum);
}