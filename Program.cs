using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using TallyAssignment2.Operations;

namespace TallyAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            while(exit)
            {
                Console.WriteLine("--------------------------------------Menu-------------------------------------");
                Console.WriteLine("1--Add    2--Delete    3--DisplayAll    4--DisplayById    5--Update    6--Exit");
                StudentOperations operations = new StudentOperations();
                Console.WriteLine("Enter the option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        operations.AddStudent();
                        break;

                    case 2:
                        Console.WriteLine("Enter the student id to delete");
                        string studIdCheck = Console.ReadLine();
                        int studId = Convert.ToInt32(CheckInteger(studIdCheck));
                        operations.DeleteStudent(studId);
                        break;

                    case 3:
                        operations.DisplayAll();
                        break;

                    case 4:
                        Console.WriteLine("Enter the student id to display");
                        string studId2Check = Console.ReadLine();
                        int studId2 = Convert.ToInt32(CheckInteger(studId2Check));  
                        operations.DisplayById(studId2);
                        break;

                    case 5:
                        Console.WriteLine("Enter the student id to Update");
                        string studId3Check = Console.ReadLine();
                        int studId3 = Convert.ToInt32(CheckInteger(studId3Check));  
                        operations.UpdateStudent(studId3);
                        break;

                    case 6:
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("Enter the valid option");
                        break;
                }
            }
            Console.ReadKey();       
        }
        public static string CheckInteger(string value)
        {
            int n;
            while (!int.TryParse(value, out n))
            {
                Console.WriteLine("Enter the integer value");
                value = Console.ReadLine();
            }
            return value;
        }
    }
}
