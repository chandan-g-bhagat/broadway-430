﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway
{
    public class Human
    {
        private string name;
        public const string Type = "Homo Sapiens";
        public readonly string LastName = "";
        public Human()
        {
           // Type = "";
            LastName = "Thapa";
            this.name = "Babu";
        }
        public Human(string name, string LastName)
        {
            this.name = name;
            this.LastName = LastName;
        }

        public Human(string LastName)
        {
            this.LastName = LastName;
        }
        public Human(string FirstName, int age)
        {
            this.name = FirstName;
        }
        public void DisplayName()
        {
            Console.WriteLine("My Name is " + this.name);
            
            this.name = "John";
           
        }

        public void IncreaseJby1()
        {
            j++;
        }
       
        public void ValueOfJ()
        {
            Console.WriteLine("Value of J : " + j);
        }

        public static int j = 10;

        public class NewClass
        {

        }
        //access modifier : public, private, protected, internal protected
    }

    public static class StaticClass
    {
        public static int i;
        public static void Function1()
        {

        }
    }


    public class StudentExams
    {
        private int Fullmarks = 20;
        private int PassMarks = 8;
        private int MinMarks = 0;

        private double englishMarks;
        public double EnglishMarks { get {
                return englishMarks;
            } 
            set {
                var val = value;
                if (val<MinMarks || val>Fullmarks)
                {
                    Console.WriteLine("Invalid marks");
                }
                else
                {
                    englishMarks = val;
                }
            }
        }

        private double mathMarks;
        public double MathMarks
        {
            get
            {
                return mathMarks;
            }
            set
            {
                var val = value;
                if (val < MinMarks || val > Fullmarks)
                {
                    Console.WriteLine("Invalid marks");
                }
                else
                {
                    mathMarks = val;
                }
            }
        }

        public double TotalMarks
        {
            get
            {
                return EnglishMarks + MathMarks;
            }
        }

        public double Percentage
        {
            get
            {
                return (TotalMarks / (2 * Fullmarks)) * 100;
            }
        }

        public string Division
        {
            get
            {
                if (Percentage>80)
                {
                    return "Distinction";
                }
                else if (Percentage>60)
                {
                    return "First Division";
                }
                else if (Percentage>45)
                {
                    return "Second Division";
                }
                else if(Percentage>32)
                {
                    return "Theird Division";
                }
                else
                {
                    return "Failed";
                }
            }
        }

        //access modifer, return type, Function name and parameters
        public string Display(string name, int id, double amount, int studentid)
        {
            Console.WriteLine(name);
            return name;
        }

        public void Display()
        {

        }
        public int Display(string name)
        {
            return 1;
        }

        public string Name { get; set; }

    }
}
