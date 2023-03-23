
using System;
using csharp_calcolatrice;

// INT
Console.WriteLine("Inserisci il primo numero:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il secondo numero:");
int num2 = int.Parse(Console.ReadLine());

int sum = CalcoliHelper.Sum(num1, num2);
int dif = CalcoliHelper.Difference(num1, num2);
int mul = CalcoliHelper.Multiplication(num1, num2);
int avi = CalcoliHelper.AbsoluteValue(num1);
int lea = CalcoliHelper.Least(num1, num2);
int max = CalcoliHelper.Maximum(num1, num2);
int pow = CalcoliHelper.GetExponentiationFunction(num1, num2);

Console.WriteLine($"La somma tra {num1} e {num2} è {sum}");
Console.WriteLine($"La differenza tra {num1} e {num2} è {dif}");
Console.WriteLine($"La moltiplicazione tra {num1} e {num2} è {mul}");
Console.WriteLine($"Il valore assoluto di {num1} è {avi}");
Console.WriteLine($"Il minimo tra due numeri interi {num1} e {num2} è {lea}");
Console.WriteLine($"Il massimo tra due numeri interi {num1} e {num2} è {max}");
Console.WriteLine($"La potenza di {num1} con esponente {num2} è {pow}");

Console.WriteLine();
// DOUBLE
double num3 = 4.8;
Console.WriteLine($"Il primo numero è {num3}");

double num4 = 3.6;
Console.WriteLine($"Il secondo numero è {num4}");

double sum2 = CalcoliHelper.Sum(num3, num4);
double dif2 = CalcoliHelper.Difference(num3, num4);
double mul2 = CalcoliHelper.Multiplication(num3, num4);
double avi2 = CalcoliHelper.AbsoluteValue(num3);
double lea2 = CalcoliHelper.Least(num3, num4);
double max2 = CalcoliHelper.Maximum(num3, num4);



Console.WriteLine($"La somma tra {num3} e {num4} è {sum2}");
Console.WriteLine($"La differenza tra {num3} e {num4} è {dif2}");
Console.WriteLine($"La moltiplicazione tra {num3} e {num4} è {mul2}");
Console.WriteLine($"Il valore assoluto di {num3} è {avi2}");
Console.WriteLine($"Il minimo tra due numeri double {num3} e {num4} è {lea2}");
Console.WriteLine($"Il massimo tra due numeri double {num3} e {num4} è {max2}");
Console.ReadLine();

//Il principio applicato è il polimorfismo-overload

