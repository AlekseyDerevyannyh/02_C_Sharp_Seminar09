// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using System;
using static System.Console;

Clear();

Integers(3, 10);

void Integers (int m, int n) {
	if (n == m) {
		Write($"{m} ");
		return;
	}
	else {
		Integers(m, n - 1);
		Write($"{n} ");
	}
}

string GetNumbers(int start, int end) {
	if (start == end)	return start.ToString();
	if (start < end)	return $"{start} {GetNumbers(start + 1, end)}";
	else				return $"{end} {GetNumbers(end + 1, start)}";
}

string GetNumbersTern(int start,int end)
{
    return start==end
    ?start.ToString()
    :start<end
        ?$"{start} {GetNumbersTern(start+1,end)}"
        :$"{end} {GetNumbersTern(end+1,start)}";
}
