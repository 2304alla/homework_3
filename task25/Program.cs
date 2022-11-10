// Задача 25: Напишите цикл,
// который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Degree(int a, int b)
{
    int count = b;
    int res = 1;
    for (int i = 1; i <= count; i++)
    {
        res *= a;
    }
    return res;
}



Console.Write("Введите натуральное число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());


if(num2<=0) Console.WriteLine ("Введите натурильное число");
else
{
int degree = Degree(num1, num2);

Console.WriteLine($"{num1} в степени {num2} = {degree}");
}