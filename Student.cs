using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
#region Student
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public string Graduated;
        public byte Point;

        public Student(string name, string surname, string group, string graduated, byte point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Graduated = graduated;
            Point = point;

        }
        public void Pointt()

        {
            if (Point > 80) ;
            {
                Console.WriteLine("Imtahana icaze verilir");

            }

            if (Point < 80) ;
            {
                Console.WriteLine("Imtahana icaze verilmir");
            }


        }














    }
}
#endregion 