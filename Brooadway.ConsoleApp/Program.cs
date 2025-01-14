﻿using System;
using Broadway;
using Brooadway.ConsoleApp.Abstract;
using Brooadway.ConsoleApp.CustomStack;
using Brooadway.ConsoleApp.Delegates;
using Brooadway.ConsoleApp.Inheritance;
using interfaces = Brooadway.ConsoleApp.Interface;

namespace Brooadway.ConsoleApp
{
    internal class Program
    {
        private static Student s; // is null

        private static readonly Deleg d = new Deleg();
        public Human human = new Human();

        private static void Main(string[] args)
        {
            var result = "y";
            do
            {
                //Console.BackgroundColor = ConsoleColor.Cyan;
                //Console.Title = "Broadway 4:30";
                //Console.Write("Write called");
                //Console.ForegroundColor = ConsoleColor.Black;
                //Console.WriteLine("Writeline called");

                //EvenOddExample();

                //ResultCalculationExampleUsingIfElse();

                //WeekDaysExample();

                //TableGenerate();

                //StudentExample();

                //ConstructorOverloadingExample();

                //StaticAndNonStaticExample();

                //this function contains code where inheritance is properly explained
                //InheritanceExample();


                //OperatorOverloadingExample();

                //PolymorphismExample();

                //FactoryInterfaceExample();

                //AbstractExample();

                //FactoryAbstractExample();

                //ArrayExample();

                //StackTypeGenericExample();

                //StackType1Implementation();

                //ErrorHandlingExample();

                //ErrorHandling2();

                //PassByExample();

                DelegateExample();

                //CallDeleg();

                Console.WriteLine("Want to try more (y/n)?");
                result = Console.ReadLine();
            } while (result == "y" || result == "Y");

            Console.ReadLine();
        }

        private static void DelegateExample()
        {
            var dg = new Deleg();
            dg.OnClick += D_OnClick;
            dg.OnClick += D_OnClick1;

            d.OnClick += D_OnClick;
            d.OnClick += D_OnClick;
            d.OnClick += D_OnClick1;
            d.OnClick += D_OnClick1;


            var str = Console.ReadLine();
            dg.Call(str);

            Console.WriteLine("");
            d.Call(str);
        }

        private static void CallDeleg()
        {
            d.OnClick -= D_OnClick;
            d.Call("Sailesh");
        }

        private static void D_OnClick1(string str)
        {
            Console.WriteLine("Someone called with str => " + str);
        }

        private static void D_OnClick(string strs)
        {
            Console.WriteLine(nameof(D_OnClick) + " called with str => " + strs);
        }

        private static void PassByExample()
        {
            var val = 20;
            var a = new Arithmetic();
            var b = new Arithmetic();
            Console.WriteLine("Pass by value");
            Console.WriteLine("From a");
            a.Addby1(val);
            a.Addby1(val);
            a.Addby1(val);
            a.Addby1(val);
            Console.WriteLine("From b");
            b.Addby1(val);

            Console.WriteLine("Pass by Reference");
            Console.WriteLine("From a");
            a.Addby1Ref(ref val);
            a.Addby1Ref(ref val);
            a.Addby1Ref(ref val);
            a.Addby1Ref(ref val);
            Console.WriteLine("From b");
            b.Addby1Ref(ref val);


            var age = 30;
            var str = a.SomeFunction(val, out age);

            Console.WriteLine("Str => " + str);
            Console.WriteLine("age => " + age);
        }

        private static void ErrorHandling2()
        {
            try
            {
                Console.WriteLine("Enter a number");
                var number = Convert.ToInt32(Console.ReadLine());
                SomeClass.Function1(number);
            }
            catch (CustomException ce)
            {
                Console.WriteLine("I have caught custom exception, I can do here whatever I like");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ErrorHandlingExample()
        {
            try
            {
                s = new Student();
                Console.WriteLine("Before Error");
                s.Id = 10;
                Console.WriteLine("Successfully completed");
            }
            catch (Exception e)
            {
                Console.WriteLine("la exception aayo hai");
            }

            Console.WriteLine("Function Completed");
        }

        private static void FunctionTemplatingExample()
        {
            Console.WriteLine(FunctionTemplating.Equals(1, 1));
            Console.WriteLine(FunctionTemplating.Equals("abc", "xyz"));
            var dog = new Dog();
            var cat = new Cat();
            var horse = new Horse();
            var rose = new Rose();
            Console.WriteLine(FunctionTemplating.Equals(dog, dog));

            FunctionTemplating.SomeFunction(dog, dog, cat);
        }

        private static void StackTypeGenericExample()
        {
            var stackInt = new StackTypeGeneric<int>();
            var stackString = new StackTypeGeneric<string>();
            var stackChar = new StackTypeGeneric<char>();
            var stackStudent = new StackTypeGeneric<Student>();

            var dogStack = new LivingThingStack<Dog>();
            var catStack = new LivingThingStack<Cat>();
            var horseStack = new LivingThingStack<Horse>();
            var roseStack = new LivingThingStack<Rose>();

            // var plantlivingThingStack = new LivingThingStack<Dog, Rose>();
        }

        private static void StackType1Implementation()
        {
            var stack = new StackType1();

            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Display();

            stack.Pop();
            stack.Display();

            stack.Push(5);
            stack.Push(7);
            stack.Display();

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Display();

            var stack2 = new StackType1(15);
        }

        private static void ArrayExample()
        {
            var arrayInt = new int[2]; //element 1 and element 2
            //element 1 - item number 1, index 0
            //element 2 -> item number 2, index 1
            // if i try to add new element then index out of bound exception

            arrayInt[0] = 10;
            arrayInt[1] = 20;

            //copy array
            var newArr = new int[3];
            //looping 2 times with i=0 and i=1
            for (var i = 0; i < arrayInt.Length; i++)
                newArr[i] = arrayInt[i];
            //in first loop 
            //newArr[0]=arrayInt[0] => when i=0
            //newArr[1]=arrayInt[1] => when i=1

            arrayInt = newArr;

            Array.Resize(ref arrayInt, arrayInt.Length + 1);

            var length = arrayInt.Length;

            Array.Reverse(arrayInt);
            Array.Resize(ref arrayInt, arrayInt.Length - 1);
        }

        public static void AbstractExample()
        {
            // DrawingAbstract daAbstract = new DrawingAbstract();
            DrawingAbstract circleAbs = new CircleAbs();
            circleAbs.TakeInput();
            Console.WriteLine("Area = > " + circleAbs.Area());
            circleAbs.Display();
        }

        public static void FactoryAbstractExample()
        {
            Console.WriteLine("1. Circle\n2. Square");
            var choice = Convert.ToInt32(Console.ReadLine());
            DrawingAbstract drawingObj;

            switch (choice)
            {
                case 1:
                    drawingObj = new CircleAbs();
                    break;
                case 2:
                    drawingObj = new SquareAbs();
                    break;
                default:
                    return;
                    break;
            }

            drawingObj.TakeInput();
            Console.WriteLine("Area = >" + drawingObj.Area());
            drawingObj.Display();
        }


        public static void FactoryInterfaceExample()
        {
            Console.WriteLine("1. Circle\n2. Square\n3. Rectangle");
            var choice = Convert.ToInt32(Console.ReadLine());
            interfaces.IDrawing drawingObj;

            switch (choice)
            {
                case 1:
                    drawingObj = new interfaces.Cirle();
                    break;
                case 2:
                    drawingObj = new interfaces.Square();
                    break;
                case 3:
                    drawingObj = new interfaces.Rectangle();
                    break;
                //case 4:
                //    drawingObj = new Triangle();
                //    break;
                default:
                    return;
                    break;
            }

            drawingObj.TakeInput();
            Console.WriteLine("Area = >" + drawingObj.Area());
            Console.WriteLine("Perimeter = >" + drawingObj.Perimeter());
        }

        public static void InterfaceExplained()
        {
            var squareObj = new interfaces.Square();
            interfaces.IArea areaInt = squareObj;

            var circleObj = new interfaces.Cirle();
            //circleObj.Add();
            areaInt = circleObj;


            interfaces.IPerimeter perimeterInt = circleObj;
            perimeterInt = squareObj;

            interfaces.IDrawing drawingInt = squareObj;
        }

        private static void PolymorphismExample()
        {
            Drawing circle = new Circle();

            Console.WriteLine("Area :" + circle.Area());

            Drawing square = new Square();

            Console.WriteLine("Area :" + square.Area());

            Drawing rectangle = new Rectangle();
            Console.WriteLine("Area :" + rectangle.Area());
        }


        private static void OperatorOverloadingExample()
        {
            var a1 = new Animal();
            a1.Name = "Dog";
            a1.LastName = "Gates";
            var a2 = new Animal();
            a2.Name = "Cat";
            a2.LastName = "Gates";
            var str = a1 + a2;

            Console.WriteLine("final firstname => " + str.Name);
            Console.WriteLine("final lastname => " + str.LastName);

            if (a1 == a2) Console.WriteLine("both are equal");
            else Console.WriteLine("Both are not equal");
        }


        private static void InheritanceExample()
        {
            var animal = new Animal();
            var name = animal.Name;
            var AnimalTwo = new Animal("HOmo Sapiens");

            var mammals = new Mammals();
            Console.WriteLine(mammals.Name);
        }

        private static void TypeConversion()
        {
            //implicit conversion
            var i = 10;
            double j = i;


            //explicit conversion
            var x = 20.09;
            var y = (int) x;


            //Type Conversion Method
            var p = 21.20;
            var q = Convert.ToInt32(p);
        }

        private static void ArithmeticOperatorsExample()
        {
            var i = 10;
            var j = 20;
            var k = i + j;
            var l = i - j;
            var m = i * j;
            var n = i / j;


            var x = 1;
            var y = "test";
            var z = 'c';

            x = 20;

            object a = 1;
            object b = "object";
            object c = 'a';

            a = "";

            var p = x == 3 && y == "test";
        }

        private static void IfElseExample()
        {
            var x = 0;
            var y = 1;
            if (x == 0)
                Console.WriteLine("X is 0");
            else
                Console.WriteLine("x is not 0");
        }

        private static void EvenOddExample()
        {
            Console.WriteLine("Enter a number");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number / 2 == 0)
                Console.WriteLine("Number is even");
            else
                Console.WriteLine("Number is Odd");
        }


        private static void ResultCalculationExampleUsingIfElse()
        {
            Console.WriteLine("Enter the percentage");
            var input = Console.ReadLine();
            var percentage = Convert.ToDouble(input);

            if (percentage > 100 || percentage < 0)
                Console.WriteLine("Invalid percentage");
            else if (percentage > 80)
                Console.WriteLine("Distinction");
            else if (percentage > 60)
                Console.WriteLine("First Division");
            else if (percentage > 45)
                Console.WriteLine("Second Division");
            else if (percentage > 32)
                Console.WriteLine("Third Division");
            else
                Console.WriteLine("Fail");
        }

        private static void WeekDaysExample()
        {
            Console.WriteLine("Enter the DayofWeek");
            var input = Console.ReadLine();
            var dayOfWeek = Convert.ToInt32(input);

            Console.WriteLine("Using Switch Case");
            switch (dayOfWeek)
            {
                case 1:
                case 7:
                    Console.WriteLine("Its Weekend");
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Its Weekdays");
                    break;
                default:
                    Console.WriteLine("Invalid days");
                    break;
            }


            Console.WriteLine("Using If Else");

            if (dayOfWeek == 1 || dayOfWeek == 7)
                Console.WriteLine("Its weekend");
            else if (dayOfWeek == 2 || dayOfWeek == 3 || dayOfWeek == 4 || dayOfWeek == 5 || dayOfWeek == 6)
                Console.WriteLine("Its weekdays");
            else
                Console.WriteLine("Invalid days");
        }

        private static void TableGenerate()
        {
            Console.WriteLine("Enter the Number of which you want to generate the table");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            for (var i = 1; i <= 10; i++) Console.WriteLine(number + " x " + i + " = " + number * i);
        }

        /// <summary>
        ///     We have implemented the properties and variable stuffs
        /// </summary>
        private static void StudentExample()
        {
            Console.WriteLine("Student s1");
            var s1 = new StudentExams();
            s1.EnglishMarks = 21;
            s1.MathMarks = 30;
            Console.WriteLine("Total => " + s1.TotalMarks);
            Console.WriteLine("Percentage => " + s1.Percentage);
            Console.WriteLine("Division => " + s1.Division);


            Console.WriteLine("Student s2");
            var s2 = new StudentExams();
            s2.EnglishMarks = 19;
            s2.MathMarks = 3;
            Console.WriteLine("Total => " + s2.TotalMarks);
            Console.WriteLine("Percentage => " + s2.Percentage);
            Console.WriteLine("Division => " + s2.Division);

            s1.Display();
        }

        private static void ConstructorOverloadingExample()
        {
            var h1 = new Human();
            var h3 = new Human();
            var h2 = new Human("Amit");

            //h1.DisplayName();
            //h2.DisplayName();


            h1.IncreaseJby1(); // this will be 11
            h1.ValueOfJ();
            h2.IncreaseJby1(); //12
            h2.ValueOfJ();
            h3.IncreaseJby1(); //13
            h3.ValueOfJ();
            h3.DisplayName();
        }

        private static void SubClassExample()
        {
            var newclass = new Human.NewClass();
        }

        private static void StaticAndNonStaticExample()
        {
            NSAS.NumberOne = 50;
            var objA = new NSAS();
            objA.NumberTwo = 100;
            objA.FunctionTwo();

            //NSAS.NumberOne = 20;
            var objB = new NSAS();
            objB.NumberTwo = 200;
            objB.FunctionTwo();

            //var numberOne=NSAS.NumberOne;
            //NSAS.FunctionOne();
        }
    }
}