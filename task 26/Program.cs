// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int CountDigit( int num)
{
    int count = 0;
    while (num!=0)
    {
        count++;
        num/=10;
    }
    return count;
}



Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());

int countDigit = CountDigit(number);
Console.WriteLine($"В числе {number} - {countDigit}  цифр  ");