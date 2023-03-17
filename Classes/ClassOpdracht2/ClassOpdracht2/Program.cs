using System;
using System.IO;

namespace ClassOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //maak hier een variable aan met type ShopGreeter
            string ShopGreeter = "hello world";
        //roep de function greetcustomer aan'
        ShopGreeter greetcostomer = new ShopGreeter();
        greetcostomer.GreetCustomer();
        }
    }
}