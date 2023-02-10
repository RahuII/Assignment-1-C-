using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace EmployeeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your details........");
            Console.Write("ID no: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Department name: ");
            string depName = Console.ReadLine();

            Employee emp = new Employee(id, name, depName);

            emp.MethodCalled += Employee_MethodCalled;

            Console.WriteLine();
            //method calling.
            string empName = emp.GetName();
            int empID = emp.GetId();
            string empDep = emp.GetDepartmentName();


            //printing employee details
            Console.WriteLine();
            Console.WriteLine("Here is your details.......");
            Console.WriteLine("Employee ID :" + empID);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Department Name :" + empDep);
            Console.WriteLine();


            while (true)
            {
                Console.WriteLine("Do you want to update your details(y/n)");
                string userInput = Console.ReadLine();
                if (userInput.Equals("y") || userInput.Equals("Y"))
                {
                    Console.WriteLine("What you want to update: 1. ID, 2. Name, 3. Department");

                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Write("Enter your new ID no. ");
                            int newId = Convert.ToInt32(Console.ReadLine());
                            emp.Update(newId);                                   //using method overloading 
                            break;
                        case 2:
                            Console.Write("Enter your new Name: ");
                            String newName = Console.ReadLine();
                            emp.Update(newName);                                 //using method overloading 
                            break;
                        case 3:
                            Console.Write("Enter your new ID no.: ");
                            int newIdD = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter your new Department name: ");
                            string newDep = Console.ReadLine();
                            emp.Update(newIdD, newDep);                      //using method overloading 
                            break;
                        default:
                            Console.WriteLine("You entered invalid option.");
                            break;
                    }
                }
                else
                {
                    break;
                }

            }

        }
        private static void Employee_MethodCalled(string message)
        {
            Console.WriteLine(message);
        }
    }
}