/* Задача 25: Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

int A, B;
int sum = 1;
Console.Write("Введите число A: ");
int.TryParse(Console.ReadLine()!, out A);
Console.Write("Введите число B: ");
int.TryParse(Console.ReadLine()!, out B);

for (int i = 0; i < B; i++)
{
    sum = A * sum;
    
}
Console.WriteLine($"{sum}");