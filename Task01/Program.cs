// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
using System;
using static System.Console;

Write(Sum(45));

int Sum (int n) {
	if (n < 10) {
		return n;
	}
	else {
		return n%10 + Sum(n/10);
	}
}
