// Задача 27: 
// Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumDigit(int num)
{
int sum= 0;

while (num!=0)
{
     num/=10;
     sum+=num;
     num/=10;
}
return sum;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(number);
Console.WriteLine($"Сумма чисел = {sumDigit}");