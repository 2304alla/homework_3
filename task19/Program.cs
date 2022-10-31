// Задача 19

// Напишите программу, 
// которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


int Palindrome(int number)
{
    int number5 = number % 10;
    int number1 = number / 10000;
    int number2 = number / 1000 % 10;
    int number4 = number / 10 % 10;


    if (number1 == number5 && number2 == number4) return number;

    return 0;



}

Console.Write("Ведите пятизначное  число:  ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99999 || num < 10000) Console.WriteLine("Не верное значение");
else
{
    int palindrome = Palindrome(num);
    string result = palindrome == 0 ? "Не является палиндромом" : "Является палиндромом";

    Console.WriteLine(result);
}