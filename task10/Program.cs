// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.WriteLine("Ведите трехзначное число");
int number = int.Parse(Console.ReadLine());

int desatki = number / 10 ;
int sotni = desatki % 10 ;

Console.WriteLine ($"Вторая цифра числа {sotni}");
