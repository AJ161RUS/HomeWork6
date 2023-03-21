/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/*


int Number;
int n = 0;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out Number);
Sum(Number, n);

int Sum(int figure, int result)
{
    while (figure > 0)
 {
     result = result + figure % 10;
     figure = figure / 10;
 }
 return n = result;
}
Console.WriteLine($"{Number} -> {n}");