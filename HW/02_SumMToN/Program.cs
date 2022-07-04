// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine($"M = {m}; N = {n} -> {SumFromMToN(m, n)}");

int SumFromMToN (int m, int n) {
	if (m < 1 || n < 1) {
		WriteLine("ОШИБКА! m и n должны быть натуральными числами!");
		return 0;
	}
	return n == m ? n : n > m ? n + SumFromMToN(m, n - 1) : m + SumFromMToN(m - 1, n);
}
