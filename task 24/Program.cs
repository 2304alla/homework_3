/ Задача 24: Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2. выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)// int num = a
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum += i; // sum = sum + i
    }

    return sum;
}

if (a > 0)
{
    int sumNumbers = SumNumbers(a);
    Console.WriteLine($"Сумма чисел от 1 до {a} = {sumNumbers}");
}
else Console.WriteLine("Введено некорректное число. Требуется целое положительное число.");

