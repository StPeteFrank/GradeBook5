﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook5
{
    public class Book
    {
        public Book(string name)        //Explicit Constructor. Has a constructor parameter of string name.
        {
            grades = new List<double>();
            this.name = name;                     //this is an impicit variable that accesses this memeber of the class.
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average /= grades.Count();               // or // result = grades.Average();

            return result;
        }

        private List<double> grades;
        private string name;
    }
}
