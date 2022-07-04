// Задача 64: Задайте значения M и N. Напишите программу, которая выведет
// произведение натуральных чисел в промежутке от M до N.
// M = 1; N = 5. ->120
// M = 4; N = 6. -> 120
using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine($"M = {m}; N = {n} -> {MultiFromMToN(m, n)}");

int MultiFromMToN (int m, int n) {
	if (m < 1 || n < 1) {
		WriteLine("ОШИБКА! m и n должны быть натуральными числами!");
		return 0;
	}
	return n == m ? n : n > m ? n * MultiFromMToN(m, n - 1) : m * MultiFromMToN(m - 1, n);
}
