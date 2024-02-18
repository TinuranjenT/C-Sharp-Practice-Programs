using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_details_Project
{
    public static class StudentDataSeeds
    {
        public static Student[] GetData()
        {
            int id = 0;
            Student[] students =
            {
                new Student()
                {
                    Id = id++,
                    Name = "A",
                    Department = "CSE"
                },
                new Student()
                {
                    Id = id++,
                    Name = "B",
                    Department = "IT"
                },
                new Student()
                {
                    Id = id++,
                    Name = "C",
                    Department = "CSE"
                },
                new Student()
                {
                    Id = id ++,
                    Name = "D",
                    Department = "CSE"
                },
                new Student()
                {
                    Id = id++,
                    Name= "E",
                    Department = "EE"
                }
            };


            return students;
        }

    }
}
