using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            Test sv = new Test();
            Console.WriteLine("MOI NHAP: ");
            int mssv = Convert.ToInt32(Console.ReadLine());
            sv.setMSSV(mssv);
            Console.WriteLine(sv.getMssv());
            Console.ReadKey();


        }
    }
}