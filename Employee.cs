using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBook
{
    class Employee
    {
        private int id;
        private string name;
        private string department;

        public delegate void MethodCalledEventHandler(string message);
        public event MethodCalledEventHandler MethodCalled;

        //Creating constructor of Employee class 
        public Employee(int empId, string empName, string empDep)
        {
            id = empId;
            name = empName;
            department = empDep;
        }
        public int GetId()
        {
            OnMethodCalled("GetId() method called");
            return id;
        }
        public string GetName()
        {
            OnMethodCalled("GetName() method called");
            return name;

        }
        public string GetDepartmentName()
        {
            OnMethodCalled("GetDepartmentName() method called");
            return department;
        }



        // Updating employee id using Update method
        public void Update(int empId)
        {
            OnMethodCalled("Your Employee id is updated...");
            id = empId;
        }

        // Updating employee Name using Update method
        public void Update(string empName)
        {
            OnMethodCalled("Your Employee Name is updated...");
            name = empName;
        }

        // Updating employee id using Update method
        public void Update(int empId, string empDepartment)
        {
            OnMethodCalled("Your Employee id is updated...");
            id = empId;
            department = empDepartment;
        }
        protected void OnMethodCalled(string message)
        {
            MethodCalled?.Invoke(message);
        }
    }
}
