
using System;
using csharp_calcolatrice;

//SOMMA INTERI
Console.WriteLine("Inserisci il primo numero:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il secondo numero:");
int num2 = int.Parse(Console.ReadLine());

int sum = (int)CalcoliHelper.SumOfTwoIntegers(num1, num2);

Console.WriteLine($"La somma tra {num1} e {num2} è {sum}");