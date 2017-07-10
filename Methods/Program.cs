using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods are tools fur us to creat reusable pieces of code.
            //Serice of instructions that can be call on when needed.
            //Always part of a class, they are CHILDREN of classes.
            //This means that a method will never be inside of another method or member of the class. 
            //However, methods are fequently called inside of another class or method.
            Console.WriteLine("Enter a nimber");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("AGAIN!");
            int numberTwo = int.Parse(Console.ReadLine());

            int answer = Add(numberOne, numberTwo);
            Console.WriteLine("Thats makes: " + answer + " A DUH"); 







        }
        //Method header
        public static int Add(int firstNumber, int secondNumber)
        {
            //Method body- complete method is called a method decloration

            int sum = firstNumber + secondNumber;

            return sum;
            // the return keyword takes whatever value is determined by using this method 
            //and sends that value back to where i call my method 
        }
        //If you have a method that does not have a return value, use the keyword static 
    }
}
