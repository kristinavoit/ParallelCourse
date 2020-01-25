using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCourseWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Values.calculate();
            (new ConsistentImplementation()).calculate();
            Error computationalError = new Error();
            Console.WriteLine("Computational error: " + computationalError.computeError(ConsistentImplementation.matrix) + "%");
        }
    }
}
