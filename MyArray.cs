﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Array;

namespace CollectionFramework
    
{
    
    internal class MyArray
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Program starts...");
            int enterSize;
            Console.WriteLine("Please enter the length/Size for the array : ");
            enterSize=int.Parse(Console.ReadLine());
            int[] a = new int[enterSize];   //creating integer array with user Input


            //int enterString;
            //Console.WriteLine("Please enter the length/Size for the String array : ");
            //enterString = ConvertTOInt.Parse(Console.ReadLine());
            String[] b = new String[5]; //creating String array with user Input
            
            /*b[0] = "kishan"; //assigning elements to String array with length 5
            b[1] = "Nihar";
            b[2] = "Gamani";
            b[3] = "Virat";
            b[4] = "DK";*/
            //int len = a.Length; //finding the length
            int ub1 = a.Length - 1; //finding Upperbound of integer array
            int ub2 = b.Length - 1; //finding Upperbound of String array
            int mb1 = ub1 / 2; //finding Middlebound of integer array
            int mb2 = ub2 / 2; //finding Middlebound of String array
            
            Console.WriteLine("Length of the integer array :" + a.Length);
            Console.WriteLine("Upper Bound of the integer array : " + ub1);
            Console.WriteLine("Middle Bound of the integer array : " + mb1);
            Console.WriteLine("=========================================================");
            Console.WriteLine("Length of the String array :" + a.Length);
            Console.WriteLine("Upper Bound of the String array : " + ub2);
            Console.WriteLine("Middle Bound of the String array : " + mb2);
            Console.WriteLine("=========================================================");
            Console.WriteLine("In the following design page you will notice various operations performed on the arrays!!");

            for(int i=0;i<a.Length;i++)
            {
                //a[i] = i + 100;
                
                Console.WriteLine("Enter number:");
                a[i] = int.Parse(Console.ReadLine()); //taking user Input
                Console.WriteLine("Original integer array elements are : {0} ", a[i]);
            }
            Console.WriteLine("===============After peroming Copy Operation to integer array=============");
            int [] a1 = new int[a.Length]; 
            Array.Copy(a, 0, a1, 0, a.Length);    
            foreach(int res in a1)
            {
                Console.WriteLine("The elements are copied to integer array named a1 : {0} ", res);
            }
            Console.WriteLine("=========================================================");





            for (int i=0;i<b.Length;i++)
            {
                Console.WriteLine("Enter String");
                b[i] = Console.ReadLine();   //taking user Input
                Console.WriteLine("Original String array elements are : {0} ",b[i]);
            }
            Console.WriteLine("===============After peroming Copy Operation to String array=============");
            String[] b2 = new String[b.Length];
            Array.Copy(b, 0, b2, 0, b.Length);
            foreach(String res1 in b2)
            {
                Console.WriteLine("The elements are copied to String array named b1 : {0} ",res1);
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Performing SORT operation on the arrays");
            Array.Sort(a);
            foreach(int res2 in a) //To sort an Array in ascending order we directly use Sort operation
            {
                Console.WriteLine("Ascending order : {0} ", res2);
            }
            Array.Reverse(a);   //To sort an array in descending order, we use Reverse operation
            foreach(int res3 in a)
            {
                Console.WriteLine("Desceding order:{0} ", res3);    
            }
            Array.Sort(b);
            foreach(String res4 in b)
            {
                Console.WriteLine("Asending order for String array : {0} ", res4);
            }
            Array.Reverse(b);
            foreach (String res5 in b)
            {
                Console.WriteLine("Descending order for String array : {0} ", res5);
            }
            Console.WriteLine("Performing Clear Operation on the array - it will clear all the elements and elements will be set to 0");
            Array.Clear(a1, 0, a.Length);   //it will clear all the elements from the array from THE GIVEN INDEX TO GIVEN LENGTH.
            foreach(int res6 in a1)
            {
                Console.WriteLine(res6);
            }

            Console.WriteLine("Program ends...");






        }
    }
}
