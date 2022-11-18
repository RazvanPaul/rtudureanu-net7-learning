//                           Exercise 1

/*Console.WriteLine("Introduceti primul numar");
string input1 = Console.ReadLine();
double numar1 = Convert.ToDouble(input1);
Console.WriteLine("Introduceti al doilea numar");
string input2 = Console.ReadLine();
double numar2 = Convert.ToDouble(input2);
double rezultatAdunare = numar1 + numar2;
double rezultatScadere = numar1 - numar2;
double rezultatInmultire = numar1 * numar2;
double rezultatImpartire = numar1 / numar2;
Console.WriteLine("Adunare: " + rezultatAdunare);
Console.WriteLine("Scadere: " + rezultatScadere);
Console.WriteLine("Inmultire: " + rezultatInmultire);
Console.WriteLine("Impartire: " + rezultatImpartire);*/

//                            Exercise 2

/*using System;

Console.WriteLine("Introduceti primul numar");
string input1 = Console.ReadLine();
int numar1 = Convert.ToInt32(input1);
Console.WriteLine("Introduceti al doilea numar");
string input2 = Console.ReadLine();
int numar2 = Convert.ToInt32(input2);
Console.WriteLine("Introduceti al treilea numar");
string input3 = Console.ReadLine();
int numar3 = Convert.ToInt32(input3);
int[] arr = new int[3] { numar1, numar2, numar3 };
int i, max, min, n;

n = 3;

max = arr[0];
min = arr[0];

for (i = 1; i < n; i++)
{
  if (arr[i] > max)
  {
     max = arr[i];
    }
   if (arr[i] < min)
  {
      min = arr[i];
  }
}
Console.Write("Maximum element = {0}\n", max);
Console.Write("Minimum element = {0}\n\n", min);*/

//                                 Exercise 3

/*Console.WriteLine("Introduceti numarul de zile");
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
}*/

//                          Exercise 4

/*Console.WriteLine("Introduceti primul numar");
string input1 = Console.ReadLine();
int Numar1 = Convert.ToInt32(input1);
Console.WriteLine("Introduceti al doilea numar");
string input2 = Console.ReadLine();
int Numar2 = Convert.ToInt32(input2);
Console.WriteLine("Introduceti al treilea numar");
string input3 = Console.ReadLine();
int Numar3 = Convert.ToInt32(input3);
int RezultatMax = (Numar1 > Numar2 ? Numar1 : Numar2) > Numar3 ? (Numar1 > Numar2 ? Numar1 : Numar2) : Numar3;
int RezultatMin = (Numar1 < Numar2 ? Numar1 : Numar2) < Numar3 ? (Numar1 < Numar2 ? Numar1 : Numar2) : Numar3;
Console.WriteLine("Numarul cel mai mare este: " + RezultatMax);
Console.WriteLine("Numarul cel mai mic este: " + RezultatMin);*/

//                            Exercise 5

/*using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Introduceti punctajul obtinut la Fizica");
string input1 = Console.ReadLine();
int notaFizica = Convert.ToInt32(input1);
Console.WriteLine("Introduceti punctajul obtinut la Chimie");
string input2 = Console.ReadLine();
int notaChimie = Convert.ToInt32(input2);
Console.WriteLine("Introduceti punctajul obtinut la Biologie");
string input3 = Console.ReadLine();
int notaBiologie = Convert.ToInt32(input3);
Console.WriteLine("Introduceti punctajul obtinut la Matematica");
string input4 = Console.ReadLine();
int notaMatematica = Convert.ToInt32(input4);
Console.WriteLine("Introduceti punctajul obtinut la TIC");
string input5 = Console.ReadLine();
int notaTIC = Convert.ToInt32(input5);
int[] note = new int[5] { notaFizica, notaChimie, notaBiologie, notaMatematica, notaTIC };
int medie = (int)note.Average();
if (medie >= 90)
{
    string nota = "A";
    Console.WriteLine("Felicitari, media dumneavoastra este: " + medie + ", iar nota dumneavoastra este: " + nota);
}
else if (medie >= 80)
{
    string nota = "B";
    Console.WriteLine("Felicitari, media dumneavoastra este: " + medie + ", iar nota dumneavoastra este: " + nota);
}
else if (medie >= 70)
{
    string nota = "C";
    Console.WriteLine("Felicitari, media dumneavoastra este: " + medie + ", iar nota dumneavoastra este: " + nota);
}
else if (medie >= 60)
{
    string nota = "D";
    Console.WriteLine("Felicitari, media dumneavoastra este: " + medie + ", iar nota dumneavoastra este: " + nota);
}
else if (medie >= 40)
{
    string nota = "E";
    Console.WriteLine("Felicitari, media dumneavoastra este: " + medie + ", iar nota dumneavoastra este: " + nota);
}
else
{
    string nota = "F";
    Console.WriteLine("Felicitari, media dumneavoastra este: " + medie + ", iar nota dumneavoastra este: " + nota);
}*/

//                         Exercise 6

/*string nota;
char grade;
Console.Write("Please type in your grade :");
grade = Convert.ToChar(Console.ReadLine().ToUpper());

switch (grade)
{
    case 'E':
        nota = " Excellent";
        break;
    case 'V':
        nota = " Very Good";
        break;
    case 'G':
        nota = " Good ";
        break;
    case 'A':
        nota = " Average";
        break;
    case 'F':
        nota = " Fails";
        break;
    default:
        nota = "Invalid Grade Found.";
        break;
}
Console.Write("Your grade is  : {0}\n", nota);
*/

//                         Exercise 7

/*Console.WriteLine("Introduceti numarul lunii");
string input = Console.ReadLine();
int numar = Convert.ToInt32(input);
string luna;
switch (numar)
{
    case 1:
        Console.Write("Ianuarie");
        break;
        
    case 2:
        Console.Write("Februarie");
        break;

    case 3:
        Console.Write("Martie");
        break;
    
    case 4:
        Console.Write("Aprilie");
        break;

    case 5:
        Console.Write("Mai");
        break;

    case 6:
        Console.Write("Iunie");
        break;

    case 7:
        Console.Write("Iulie");
        break;

    case 8:
        Console.Write("August");
        break;

    case 9:
        Console.Write("Septembrie");
        break;

    case 10:
        Console.Write("Octombrie");
        break;

    case 11:
        Console.Write("Noiembrie");
        break;

    case 12:
        Console.Write("Decembrie");
        break;
}
*/

//                  Exercise 8

/*Console.WriteLine("Introduceti temperatura in grade celsius");
var input = Console.ReadLine();
int temp = Convert.ToInt32(input);
if (temp < 0)
{
    Console.WriteLine("Inghet");
}
else if (temp > 0 && temp <= 10)
{
    Console.WriteLine("Foarte frig");
}
else if (temp >10 && temp <= 20)
{
    Console.WriteLine("Frig");
}
else if (temp >20 && temp <=30)
{
    Console.WriteLine("Temperatura normala");
}
else if (temp > 30 && temp <= 40)
{
    Console.WriteLine("Cald");
}
else if (temp > 40)
{
    Console.WriteLine("Foarte cald");
}
*/

//               Exercise 9
/* A=10 B=20
+   A+B= 30      Console.WriteLine("Numarul ales este: " + A)
-   A-B= -10
*   A*B= 200
/   B/A= 2
%   B%A= 0
++  B++= 21
--  B--= 19
+= A+=B este A=A+B
-= A-=B este A=A-B 