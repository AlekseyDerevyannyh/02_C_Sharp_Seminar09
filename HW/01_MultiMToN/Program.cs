// Задача 64: Задайте значения M и N. Напишите программу, которая выведет
// произведение натуральных чисел в промежутке от M до N.
// M = 1; N = 5. ->120
// M = 4; N = 6. -> 120
using System;
using static System.Console;

Write("Введите M: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine($"M = {m}; N = {n} -> {MultiFromMToN(m, n)}");

// int MultiFromMToN (int m, int n) {
// 	if (n == m)		return n;
// 	else if (n > m)	return n * MultiFromMToN(m, n - 1);
// 	else 			return m * MultiFromMToN(m - 1, n);
// }

int MultiFromMToN (int m, int n) {
	return n == m ? n : n > m ? n * MultiFromMToN(m, n - 1) : m * MultiFromMToN(m - 1, n);
}
