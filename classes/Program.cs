using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Company si = new Company("Stark Industries", DateTime.Now);    
            

            Sales tim = new Sales("Tim", "Director of Sales");
            Sales jim = new Sales("Jim", "Traveling Salesman");
            Accounting john = new Accounting("John", "Auditor");
            Accounting kelsey = new Accounting("Kelsey", "VP of Accounting");

             
            si.addEmployee(tim);
            si.addEmployee(jim);
            si.addEmployee(john);
            si.addEmployee(kelsey);

        //    foreach(Employee person in si.employees)
        //    {
        //        Console.WriteLine($"{person.Name} works for {si.Name} and is a {person.JobTitle}");
        //    }

            si.ListEmployees();

        }
    }    
    

    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employee> employees = new List<Employee>();
        public List<Sales> salesDpt = new List<Sales>();
        public List<Accounting> accountingDpt = new List<Accounting>();
        
        // Create a method that allows external code to add an employee
        public void addEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        // public void addEmployee(Sales salesEmployee)
        // {
        //     salesDpt.Add(salesEmployee);
        // }
        // public void addEmployee(Accounting accountingEmployee)
        // {
        //     employees.Add(accountingEmployee);
        // }

        // Create a method that allows external code to remove an employee
        public void removeEmployee(Employee employeeName)
        {
            employees.Remove(employeeName);
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime DateCreated)
        {
            this.Name = name;
            this.CreatedOn = DateCreated;
        }
        public Company()
        {

        }

        /*
	  Method to 
        */
        public void ListEmployees()
        {
            foreach (Employee e in employees)
            {
                Console.WriteLine($"{e.Name}");
            }
        }
    }
 

    public class Employee
    {
        public string Name {get;set;}
        public string JobTitle {get;set;}

    }

    public class Accounting : Employee
    {
        public Accounting(string name, string job)
        {
            this.Name = name;
            this.JobTitle = job;
        }
    }
        public class Sales : Employee
    {
        public Sales(string name, string job)
        {
            this.Name = name;
            this.JobTitle = job;
        }
    }
}
