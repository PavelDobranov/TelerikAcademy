using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            var first = new Point3D(-7, -4, 3);
            var second = new Point3D(17, 6, 2.5);
            var third = new Point3D(33, 12, 18);
            var fourth = new Point3D(44, 12, 6);

            var path = new Path();

            path.AddPoint(first);
            path.AddPoint(second);

            string pathFile = @"..\..\points.txt";


            PathSorage.SavePath(path, pathFile);
        }
    }
}
