﻿Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int i = 2;

while (i <= number) {
    Console.Write($"{i}, ");
    i+=2;
}