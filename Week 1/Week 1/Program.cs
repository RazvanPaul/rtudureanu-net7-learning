using System.Runtime.InteropServices;

Console.WriteLine("Ce suma doriti sa retrageti?");
string input = Console.ReadLine();
double suma = Convert.ToInt32(input);
double procent = 5;
//double taxa = (double)((suma * procent) / 100);
if ((double) suma <= 20)
{
    Console.WriteLine("Taxa dumneavoasta este 1$");
}
else if ((double) suma > 20)
{
    double taxa = (double)((suma * procent) / 100);
    Console.WriteLine("Taxa dumneavoastra este: " + taxa + "$");
}
   


