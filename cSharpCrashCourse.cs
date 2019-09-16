//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");  //writing lines in C#

            var meaningOfLife = 42; //examples of varibale types and instatiation
            var smallPi = 3.14f;  //Best practice is to declare int, float, bool, etc but types can also be inferred by the processor
            var bigPi = 3.14159265359; //A double uses twice as much data to store as a float
            var vaporWare = "Half Life 3";
            const bool likesPizza = true; //can't change constants

            string[] writers = { "Anthony", "Brian", "Eric", "Sean" }; //Instantiates an array
            string[] editors = new string[5]; //Instantiates and empty array with 5 open elements
            Console.WriteLine(writers[2]); //writes the second element of the array

            writers[0] = "Ray"; //replaces first element in the array with new string
            if (likesPizza == false)
            {
                Console.WriteLine("You monster!");
            }
            bool isMonster = (likesPizza == true) ? false : true; //short hand of above if statement
            for (int i = 0; i < 10; i++) //loops 10 times incrementing by 1 each time
            {
                Console.WriteLine("C# Rocks!");
            }
            for (int i = 0; i < writers.Length; i++) //loops through the writers array and prints each element
            {
                string writer = writers[i];
                Console.WriteLine(writer);
            }
            foreach (string writer in writers) //does the same as above but in foreach format
            {
                Console.WriteLine(writer);
            }
            if (meaningOfLife == 42)  //example of variable scope.  inScope is only in scope inside the braces
            {
                bool inScope = true;
            }

            Point2D myPoint = new Point2D(); //creates new point from the struct below
            myPoint.X = 10; //changes the x and y properties of this new point 
            myPoint.Y = 20;

            Point2D anotherPoint = new Point2D(); //creates another point to add to myPoint in the below struct
            anotherPoint.X = 5;
            anotherPoint.Y = 15;

            myPoint.AddPoint(anotherPoint); //Calling the method inside of the struct to add the points
            Console.WriteLine(myPoint.X); //results of method
            Console.WriteLine(myPoint.Y);

            Point2D yetAnotherPoint = myPoint; //copied another instance of the struct
            yetAnotherPoint.X = 100;
            Console.WriteLine(myPoint.X);
            Console.WriteLine(yetAnotherPoint.X);

            Point2DRef pointRef = new Point2DRef(); //creates instance of point2DRef object
            pointRef.X = 20; //assigns x value
            Point2DRef anotherRef = pointRef; //copied to new instance
            anotherRef.X = 25; //x value is changed again
            //These are two references to the same object and therefore both now have 25 as the x value

            Console.WriteLine(pointRef.X);
            Console.WriteLine(anotherRef.X);

            pointRef = null; //object is still in memory and therefore still  accessible even though it is set to null
            anotherRef.X = 125;
            Console.WriteLine(anotherRef.X); //outputs 125
            anotherRef = null;

            RenFairePerson person = new RenFairePerson();//Creates new object of class person
            person.Name = "Igor the Ratcatcher"; //sets the name
            person.SayHello();
        }
    }
    struct Point2D //defines a struct (a template of an object)
    {
        public int X; //defines 2D point with x and y properties
        public int Y;//public so you can change the properties outside of the object
        public void AddPoint(Point2D anotherPoint) //defines the behavior of the object which is adding two points together
        {
            this.X = this.X + anotherPoint.X; 
            this.Y = this.Y + anotherPoint.Y;
        }
    }

    class Point2DRef //struct is a value type while a class is a reference type(longterm memory)
    {
        public int X;
        public int Y;

        public void AddPoint(Point2DRef anotherPoint)
        {
            this.X = this.X + anotherPoint.X;
            this.Y = this.Y + anotherPoint.Y;
        }
    }

    class Person //Inheritance example
    {
        public string Name;
        public virtual void SayHello() //virtual means a subclass can override the method
        {
            Console.WriteLine("Hello");
        }
    }

    class RenFairePerson : Person
    {
        public override void SayHello()
        {
            base.SayHello();
            Console.Write("Huzzah!");
        }
    }


}