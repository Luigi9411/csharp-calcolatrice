
using System;
using csharp_calcolatrice;

// INT
Console.WriteLine("Inserisci il primo numero:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il secondo numero:");
int num2 = int.Parse(Console.ReadLine());

int sum = CalcoliHelper.SumOfTwoIntegers(num1, num2);
int dif = CalcoliHelper.DifferenceBetweenTwoIntegers(num1, num2);
int mul = CalcoliHelper.MultiplicationOfTwoIntegers(num1, num2);
int avi = CalcoliHelper.AbsoluteValueOfAnInteger(num1);
int lea = CalcoliHelper.LeastOfTwoIntegers(num1, num2);
int max = CalcoliHelper.MaximumOfTwoIntegers(num1, num2);

Console.WriteLine($"La somma tra {num1} e {num2} è {sum}");
Console.WriteLine($"La differenza tra {num1} e {num2} è {dif}");
Console.WriteLine($"La moltiplicazione tra {num1} e {num2} è {mul}");
Console.WriteLine($"Il valore assoluto di {num1} è {avi}");
Console.WriteLine($"Il minimo tra due numeri interi {num1} e {num2} è {lea}");
Console.WriteLine($"Il massimo tra due numeri interi {num1} e {num2} è {max}");

// DOUBLE
double num3 = 4.8;
Console.WriteLine($"Il primo numero è {num3}");

double num4 = 3.6;
Console.WriteLine($"Il secondo numero è {num4}");

double sum2 = CalcoliHelper.SumOfTwoDoubleNumbers(num3, num4);
double dif2 = CalcoliHelper.DifferenceBetweenTwoDoubleNumbers(num3, num4);
double mul2 = CalcoliHelper.MultiplicationOfTwoDoubleNumbers(num3, num4);
double avi2 = CalcoliHelper.AbsoluteValueOfADoubleNumber(num3);
double lea2 = CalcoliHelper.LeastOfTwoIntegers(num3, num4);
double max2 = CalcoliHelper.MaximumOfTwoDoubleNumbers(num3, num4);

Console.WriteLine($"La somma tra {num3} e {num4} è {sum2}");
Console.WriteLine($"La differenza tra {num3} e {num4} è {dif2}");
Console.WriteLine($"La moltiplicazione tra {num3} e {num4} è {mul2}");
Console.WriteLine($"Il valore assoluto di {num3} è {avi2}");
Console.WriteLine($"Il minimo tra due numeri double {num3} e {num4} è {lea2}");
Console.WriteLine($"Il massimo tra due numeri double {num3} e {num4} è {max2}");
Console.ReadLine();

