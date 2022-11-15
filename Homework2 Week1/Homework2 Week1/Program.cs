//Exercise 1
//Console.WriteLine("Introduceti primul numar");
//string input1 = Console.ReadLine();
//double numar1 = Convert.ToDouble(input1);
//Console.WriteLine("Introduceti al doilea numar");
//string input2 = Console.ReadLine();
//double numar2 = Convert.ToDouble(input2);
//double rezultatAdunare = numar1 + numar2;
//double rezultatScadere = numar1 - numar2;
//double rezultatInmultire = numar1 * numar2;
//double rezultatImpartire = numar1 / numar2;
//Console.WriteLine("Adunare: " + rezultatAdunare);
//Console.WriteLine("Scadere: " + rezultatScadere);
//Console.WriteLine("Inmultire: " + rezultatInmultire);
//Console.WriteLine("Impartire: " + rezultatImpartire);

//Exercise 2

//using System;

//Console.WriteLine("Introduceti primul numar");
//string input1 = Console.ReadLine();
//int numar1 = Convert.ToInt32(input1);
//Console.WriteLine("Introduceti al doilea numar");
//string input2 = Console.ReadLine();
//int numar2 = Convert.ToInt32(input2);
//Console.WriteLine("Introduceti al treilea numar");
//string input3 = Console.ReadLine();
//int numar3 = Convert.ToInt32(input3);
//int[] arr = new int[3] { numar1, numar2, numar3 };
//int i, max, min, n;

//n = 3;

//max = arr[0];
//min = arr[0];

//for (i = 1; i < n; i++)
//{
//  if (arr[i] > max)
//  {
//      max = arr[i];
//   }
//   if (arr[i] < min)
//  {
//      min = arr[i];
//  }
//}
//Console.Write("Maximum element = {0}\n", max);
//Console.Write("Minimum element = {0}\n\n", min);

//Exercise 3
Console.WriteLine("Introduceti numarul de zile");
string input1 = Console.ReadLine();
int zileTotale = Convert.ToInt32(input1);
int ani = zileTotale / 365; int restAni = zileTotale % 365;
int luni = restAni / 30; int restLuni = restAni % 30;
int saptamani = restLuni / 7; int restSaptamani = restLuni % 7;
int zile = restSaptamani / 1; 
if (ani == 0)
{
    Console.WriteLine("");
}
else if (ani == 1)
{
    Console.WriteLine(ani + " an");
}
else
{
    Console.WriteLine(ani + " ani");
}
if (luni == 0)
{
    Console.WriteLine("");
}
else if (luni == 1)
{
    Console.WriteLine(luni + " luna");
}
else
{
    Console.WriteLine(luni + " luni");
}
if (saptamani == 0)
{
    Console.WriteLine("");
}
else if (saptamani == 1)
{
    Console.WriteLine(saptamani + " saptamana");
}
else
{
    Console.WriteLine(saptamani + " saptamani");
}
if (zile == 0)
{
    Console.WriteLine("");
}
else if (zile == 1)
{
    Console.WriteLine(zile + " zi");
}
else
{
    Console.WriteLine(zile + " zile");
}