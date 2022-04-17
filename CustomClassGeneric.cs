using System;
//using System,Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericClassMyStack
{
    public class CustomGenericClassMyStack<String>  //creating custom generic class
    {
        public string Name { get; set; }    
        static readonly int MAX2 = 500;  //size of the array
        int top2;                        //integer var to store top position
        String[] str = new String[MAX2]; //String array
        

       

        public void Push(String data)  //performing push operation
        {
            if(top2 > MAX2)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                str[top2++]=data;
                Console.WriteLine("Persons who contest UNGA elections next week are added to Stack : " + data);
            }
        }
        public void Pop()  //performing pop operation
        {
            if(top2 < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                String value = str[top2--];
                Console.WriteLine(value);
                Console.WriteLine("Persons who withdrawn from UNGA Elections are Popped from the stack are : " + value);
            }
        }
    }
    internal class CustomClassGeneric
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starts...");
            CustomGenericClassMyStack<String> cg = new CustomGenericClassMyStack<String>();           
            cg.Push("Narendra Modi");  //adding names to stack
            cg.Push("Barack Obama");
            cg.Push("Joseph Biden");
            cg.Push("Emanuel Macron");
            cg.Push("Boris Johnson");

            cg.Pop();  //it removes all names from the custom generic class myStack
            Console.WriteLine("Program ends...");
        }
    }
}
