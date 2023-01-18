// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 

// int[] Array = GetArray(8); 
// Console.WriteLine($"[{String.Join(";", Array)}]"); 

// int[] GetArray (int size) 
// { 
//     int[] Array = new int[size]; 
//     for (int i = 0; i < size; i++) 
//     { 
//         Array[i] = new Random().Next(11); 
//     } 
//     return Array; 
// }

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 

// Console.Write("Введи число A: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Введи число B: ");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"The exponentiation {A} in {B} is {GetExponentiation(A, B)}");

// int GetExponentiation(int A, int B)
// {
//     int result = 1;
//     for (int i = 1; i <= B; i++)
//     {
//         result = result * A;
//     }
//     return result;
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введи число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"The sum of digits the number {N} is {GetSum(N)}");

int GetSum (int N)
{
    int digits = Convert.ToString(N).Length;
    int result1 = 0;
    int result2 = 0;

    for (int i = 0; i < digits; i++)
    {
        result1 = N - N % 10;
        result2 = result2 + (N - result1);
        N = N / 10;
    }
    return result2;
}

