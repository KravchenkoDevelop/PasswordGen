// See https://aka.ms/new-console-template for more information

using PasswordGen;

Console.WriteLine("get password length:");
var passLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("random char pass: " + Randomiser.GetPassworRndCharacters(passLength));
Console.ReadKey();

