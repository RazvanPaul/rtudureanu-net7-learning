using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
//                  Exercise 1
/*int x=0;
int[] numere = new int[5] {1,2,3,4,5};
for (int i = 1; i <= numere.Length; i++)
{
    
    if(i%2==0)
    {
        x += i;
       
    }
    
}
Console.WriteLine("Suma numerelor pare este: " + x);*/

//                  Exercise 2
/*int i = 0;
int j = 0;
int[] numere2 = new int[5] { 1, 6, 2, 3, 1 };
for (i = 0; i < numere2.Length; i++)
{
    for(j = i+1 ; j < numere2.Length; j++)
    {
        if (numere2[i] == numere2[j])
        {

            Console.WriteLine("Cele doua numere identice sunt: " + numere2[i] + " si " + numere2[j]);
        }
    }
}*/
//               Exercise 3
/*List<string> litere = new List<string>() { "a", "b", "c","d","b","e","e"};
List<string> duplicate = new List<string>();
List<string> singure = new List<string>();
foreach(string s in litere)
{
    if(!singure.Contains(s))
    {
        singure.Add(s);
    }
    else if(singure.Contains(s))
    {
        duplicate.Add(s);
    }
    
    
}
foreach(string b in duplicate) 
{
    if(singure.Contains(b))
    {
        singure.Remove(b);
        
    }
}
foreach(string c in singure)
{
    Console.WriteLine(c);
}*/
//               Exercise 4
/*int[] array = new int[100];
int[] array2 = new int[100];
int n, i, j, ctr;
Console.Write("How many elements do you want the array to have?");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input {0} elements in the array :\n", n);
for (i = 0; i < n; i++)
{
    Console.Write("element - {0} : ", i);
    array[i] = Convert.ToInt32(Console.ReadLine());
    array2[i] = -1;
}
for (i = 0; i < n; i++)
{
    ctr = 1;
    for (j = i + 1; j < n; j++)
    {
        if (array[i] == array[j])
        {
            ctr++;
            array2[j] = 0;
        }
    }

    if (array2[i] != 0)
    {
        array2[i] = ctr;
    }
}
Console.Write("\nThe frequency of all elements of the array : \n");
for (i = 0; i < n; i++)
{
    if (array2[i] != 0)
    {
        Console.Write("{0} occurs {1} times\n", array[i], array2[i]);
    }
}*/
//                Exercise 5

/*int i, n, j=0, k=0;
int[] array= new int[10];
int[] array2= new int[10];
int[] array3 = new int[10];
Console.Write("How many elements do you want the array to have?");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input {0} elements in the array :\n", n);
for (i = 0; i < n; i++)
{
    Console.Write("element - {0} : ", i);
    array[i] = Convert.ToInt32(Console.ReadLine());
    
}
for (i = 0; i < n; i++)
{
        if (array[i] % 2 ==0)
        {
            array2[j]=array[i];
            j++;
            
        }
        else
        {
            array3[k]=array[i];
            k++;

        }
}
Console.WriteLine("The odd elements are:");
for(i = 0; i < k; i++)
{
    Console.WriteLine(array3[i]);
}
Console.Write("The even elements are:");
for (i = 0; i < j; i++)
{
    Console.WriteLine(array2[i]);
}*/


//                      Exercise 6- Algorithms
/*int n=10;
int[] array = new int[n];
int i = 0, j = 0, swap=0;
Console.Write("How many elements do you want the array to have?");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input {0} elements in the array :\n", n);
for (i = 0; i < n; i++)
{
    Console.Write("element - {0} : ", i);
    array[i] = Convert.ToInt32(Console.ReadLine());

}

for(i = 0; i < n-1; i++)
{
    for(j = 0; j < n-i-1; j++)
    {
        if (array[j] > array[j]+1)
        {
            swap=array[j];
            array[j] = array[j+1];
            array[j+1] = swap;
        }
    }
    
}

    for (i = 0; i < n; i++)
{
    Console.WriteLine(array[i]);
}*/
int[] arr = new int[10] { 23, 9, 85, 2, 99, 34, 60, 15, 100, 1 };
int n = 10, i, j, val, cond;
Console.WriteLine("Insertion Sort");
Console.Write("Initial array is: ");
for (i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
for (i = 1; i < n; i++)
{
    val = arr[i];
    cond = 0;
    for (j = i - 1; j >= 0 && cond != 1;)
    {
        if (val < arr[j])
        {
            arr[j + 1] = arr[j];
            j--;
            arr[j + 1] = val;
        }
        else cond = 1;
    }
}
Console.Write("Sorted Array is: ");
for (i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}