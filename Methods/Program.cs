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
            //Console.WriteLine("Enter a nimber");
            //int numberOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("AGAIN!");
            //int numberTwo = int.Parse(Console.ReadLine());

            //int answer = Add(numberOne, numberTwo);
            //Console.WriteLine("Thats makes: " + answer + " A DUH"); 


            //string myBirthMonth = "September";
            //string freindBirhtMonth = "Febuary";
            //string myVehicle = Vehicle(myBirthMonth);
            //string freindVehicle = Vehicle(freindBirhtMonth);

            //Console.WriteLine("Mine {0), theres {1}", myVehicle, freindVehicle);
            //FavoriteFood();

            //Console.WriteLine("When will you retire?\n Enter your age.");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("You have {0} years to go.", RetirementCalculator(age));

            //double hoursWorked = 42.3d;
            //double myWage = 12.50;

            //Console.WriteLine("Your monthly wage: {0}",WageCalculator(hoursWorked, myWage));
            Console.WriteLine("Tell me your name and I'll assigne you a color.");
            string name = Console.ReadLine();
            int number = name.Length;
            string asighnedColor ="";
            Console.WriteLine("Hi {0}, you color is {1}.",name, WhatColor(number, asighnedColor));
        }
        //Method header
        // public static int Add(int firstNumber, int secondNumber)
        //  {
        //Method body- complete method is called a method decloration

        // the return keyword takes whatever value is determined by using this method 
        //and sends that value back to where i call my method 
        //  }
        //If you have a method that does not have a return value, use the keyword static
        // public static void RobotWarning(string name)
        //{
        //    Console.WriteLine("Danger " + name);
        //} 
        // public static void Useless()
        // {
        //    Console.WriteLine("Bla bla bla ");
        //}
        //public static string Vehicle(string birthMonth)
        //{
        //    string vehicleOfFortune;
        //    if(birthMonth.ToUpper() == "SEPTEMBER" || birthMonth.ToUpper() == "OCTOBER")
        //    {
        //        vehicleOfFortune = "Hoverboard";
        //    }
        //    else
        //    {
        //        vehicleOfFortune = "SUV";
        //    }
        //    return vehicleOfFortune;
        //}

        //public static void FavoriteFood()
        //{
        //    string name = "Shawn";
        //    string food = "pizza";
        //    Console.WriteLine("Hi {0}, I have some {1}.", name, food);
        //    return;

        //}
        //public static int RetirementCalculator(int age)
        //{
        //    age = 65 - age;
        //    return age;
        //}
        //public static double WageCalculator (double hoursWorkedWeekly, double hourlyWage)
        //{
        //    double monthlyWage = (hoursWorkedWeekly * 52 * hourlyWage) / 12;
        //    return monthlyWage; 
        //}

        public static string WhatColor(int number, string color)
        {
            if (number % 2 == 0)
            {
                color = "Green";
            }
            else
            {
                color = "Red";
            }
            return color;
        }
    }
}
