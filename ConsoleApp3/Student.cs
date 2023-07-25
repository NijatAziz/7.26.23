using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public byte Point { get; set; }
        public bool IsGraduated { get; set; }


        public Student(string name,string surname, string group,byte point,bool IsGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            this.IsGraduated = IsGraduated;
        }

        public void GetFullName() 
        {
            Console.WriteLine(string.Concat(Name," ",Surname));

        }
        public void GetStudent() 
        {
            string graduated;
            if (IsGraduated == true)
            {
                graduated = "Mezun olub";
            }
            else
            {
                graduated = "Mezun olmayib";
            }
            Console.WriteLine(Name," ",Surname," ",Group," ",Point," ",graduated);
           
        }
        public void GetPoint()
        {
            if (Point > 80)
            {
                Console.WriteLine("Novbeti imtahana buraxildiniz");
            }
            else
            {
                Console.WriteLine("Novbeti imtahana buraxilmadiniz");
            }
        }
    }


}
