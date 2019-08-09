using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book() //Added Constructor
        {
            grades = new List<double>();
        }


        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        List<double> grades;
    }
}