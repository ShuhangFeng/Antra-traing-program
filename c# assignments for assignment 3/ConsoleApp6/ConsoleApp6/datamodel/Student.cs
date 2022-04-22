using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.inter;

namespace ConsoleApp6.datamodel
{
    public class Student: IStudentService
    {
        public List<Course> Courses { get; set; }

        public double CalculateGPA()
        { int CourseNum = this.Courses.Count;
            int totalGrade = 0;
            for(int i = 0; i < CourseNum; i++)
            {
                Grade grade = this.Courses[i].Grade;
                int gradeNum = 0;
                if (grade == Grade.A)
                {
                    gradeNum = 4;
                }
                if (grade == Grade.B)
                {
                    gradeNum = 3;
                }
                if (grade == Grade.C)
                {
                    gradeNum = 2;
                }
                if (grade == Grade.D)
                {
                    gradeNum = 1;
                if (grade == Grade.F)
                {
                    gradeNum = 0;
                }
                }
                totalGrade += gradeNum;
            }
            double result = totalGrade / CourseNum;
            return result;
        }
    }
}
