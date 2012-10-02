using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DifferentStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil[] p = new Pupil[4];
            p[0] = new Pupil(4, 4, "0404", "sjs", 10, 'w', "NULL", "Yes");
            Console.WriteLine(p[0].Answer());

            MiddleSchoolStudent student2 = new MiddleSchoolStudent(9, 2, "090810111", "njj", 12, 'm', "NULL", "Yes");
            Console.WriteLine(student2.Answer());
        }
    }
}
