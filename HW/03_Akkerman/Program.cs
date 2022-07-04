// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
using System;
using static System.Console;

Clear();
Write("Введите m: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите n: ");
int n = Convert.ToInt32(ReadLine());
WriteLine($"m = {m}; n = {n} -> A(m, n) = {Akkerman(m, n)}");

int Akkerman (int m, int n) {
	if (m < 0 || n < 0) {
		WriteLine("ОШИБКА! m и n должны быть >= 0!");
		return 0;
	}
	return m == 0 ? n + 1 : m > 0 && n == 0 ? Akkerman(m - 1, 1) : Akkerman(m - 1, Akkerman(m, n - 1));
}
