
using Internal;
using System;
public class diemdanh
{
   
    public static void Main(string[] args)
    {
        int n=10;
        int[] a= new int[10];
        for (var i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap so thu {0}",i+1);
            a[i]=Console.ReadLine();
        }

    }
}