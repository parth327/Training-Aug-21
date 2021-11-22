using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hospital Management System");
                Console.WriteLine("Select Any one Option");
                Console.WriteLine("\n 1.Insert Doctor " +
                                  "\n 2.Update Doctor " +
                                  "\n 3.Delete Doctor " +
                                  "\n 4.Exit");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Hospital.addNewDoctor();
                        break;
                    case 2:
                        Hospital.updateDoctor();
                        break;
                    case 3:
                        Hospital.DeleteDoctorDetail();
                        break;
                    case 8:
                        return;
                    default:
                        break;
                }
            }
            
        }
    }
}
