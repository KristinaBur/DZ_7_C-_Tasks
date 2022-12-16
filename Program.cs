/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/


/*Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);

if(a>b)
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else if (b>a)
{
    Console.WriteLine($"Число {b} больше числа {a}");
}*/


/*Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Введите первое число ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите третье число ");
double c = Convert.ToDouble(Console.ReadLine());

var max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;   
}

Console.WriteLine($"Максимальное число равно {max}");