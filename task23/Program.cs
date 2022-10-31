// Задача 23

// Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void Quarter(int number)
{
    int i = 1;
    while (i <= number)
    {
        Console.WriteLine($"{i,4}   {i * i * i,4}");
        i++;
    }
}


Console.Write("Ведите натуральное число:  ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


if (num > 0) Quarter(num);
else Console.WriteLine("Введите число,которое больше 0");