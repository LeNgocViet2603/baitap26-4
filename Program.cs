
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
        int max_168=a[0];
        int min_168=a[0];
        for (var j = 0; j < n; j++)
        {
            if(a[i]>max_168){
                max=a[i];
            }                
            if(a[i]<min_168){
                min_168 = a[i];
            }
        }
    
        
    }
}