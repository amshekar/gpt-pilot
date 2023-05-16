//create a .net core project which named as Employee
//create a class Employee with properties EmpId, EmpName, EmpSalary, EmpDesignation
//create a class EmployeeDAL with methods AddEmployee, DeleteEmployee, UpdateEmployee, GetEmployee
//create a class EmployeeBAL with methods AddEmployee, DeleteEmployee, UpdateEmployee, GetEmployee
//create a class EmployeePL with methods AddEmployee, DeleteEmployee, UpdateEmployee, GetEmployee
//create a class Program with Main method
//create a menu for the user to select the operation
//call the respective methods based on the user selection
//use try catch block to handle the exceptions
//use appropriate exception handling methods to handle the exceptions
//use appropriate exception handling methods to handle the exceptions


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
public class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public string EmpDesignation { get; set; }
}
public class EmployeeDAL
{
    public static List<Employee> employees = new List<Employee>();
    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }
    public void DeleteEmployee(int empId)
    {
        Employee employee = employees.Find(id => id.EmpId == empId);
        employees.Remove(employee);
    }
    public void UpdateEmployee(Employee employee)
    {
        Employee employee1 = employees.Find(id => id.EmpId == employee.EmpId);
        employee1.EmpName = employee.EmpName;
        employee1.EmpSalary = employee.EmpSalary;
        employee1.EmpDesignation = employee.EmpDesignation;
    }
    public Employee GetEmployee(int empId)
    {
        Employee employee = employees.Find(id => id.EmpId == empId);
        return employee;
    }
}

public class EmployeeBAL
{
    EmployeeDAL employeeDAL = new EmployeeDAL();
    public void AddEmployee(Employee employee)
    {
        try
        {
            employeeDAL.AddEmployee(employee);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
   public void DeleteEmployee(int empId)
{
    try
    {
        // Call the data access layer to delete the employee
        employeeDAL.DeleteEmployee(empId);
    }
    catch (Exception ex)
    {
        // If an error occurs, rethrow the exception to the calling method
        throw ex;
    }
}
    public void UpdateEmployee(Employee employee)
    {
        try
        {
            employeeDAL.UpdateEmployee(employee);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public Employee GetEmployee(int empId)
    {
        try
        {
            return employeeDAL.GetEmployee(empId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

public class EmployeePL
{
    EmployeeBAL employeeBAL = new EmployeeBAL();
    public void AddEmployee()
    {
        try
        {
            Employee employee = new Employee();
            GetEmployeeData(employee);
            employeeBAL.AddEmployee(employee);
        }

       private void GetEmployeeData(Employee employee)
        {
            Console.WriteLine("Enter Employee Id");
            employee.EmpId = Convert.ToInt32(Console.ReadLine());
            GetEmployeeName(employee);
            GetEmployeeSalary(employee);
            GetEmployeeDesignation(employee);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void DeleteEmployee()
    {
        try
        {
            Console.WriteLine("Enter Employee Id");
            int empId = Convert.ToInt32(Console.ReadLine());
            employeeBAL.DeleteEmployee(empId);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
   public void UpdateEmployee()
    {
        log("Doing something");
        doSomething();
        log("Doing something else");
        doSomethingElse();
        log("Doing something more");
        doSomethingMore();
        {
            Employee employee = new Employee();

            // Prompt the user for the employee's information.
            Console.WriteLine("Enter Employee Id");
            employee.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            employee.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            employee.EmpSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Employee Designation");
            employee.EmpDesignation = Console.ReadLine();

            // Update the employee's information.
            employeeBAL.UpdateEmployee(employee);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void UpdateEmployee()
    {
        try
        {
            Employee employee = new Employee();

            // Prompt the user for the employee's information.
            Console.WriteLine("Enter Employee Id");
            employee.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            employee.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            employee.EmpSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Employee Designation");
            employee.EmpDesignation = Console.ReadLine();

            // Update the employee's information.
            employeeBAL.UpdateEmployee(employee);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }try
        {
            EmployeePL employeePL = new EmployeePL();
            int choice = 0;
            do
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Delete Employee");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Get Employee");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employeePL.AddEmployee();
                        break;
                    case 2:
                        employeePL.DeleteEmployee();
                        break;
                    case 3:
                        employeePL.UpdateEmployee();
                        break;
                    case 4:
                        employeePL.GetEmployee();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 5);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

//write test cases for above program
//use nunit testing framework
//use appropriate attributes
//use appropriate assertions
//use appropriate test fixtures
//use appropriate test runners
//use appropriate test cases
//use appropriate test suites
//use appropriate test categories
//use appropriate test setup and teardown
//use appropriate test execution order
//use appropriate test results
//use appropriate test reports
//use appropriate test data
//use appropriate test naming conventions
//use appropriate test code refactoring
//use appropriate test code debugging
//use appropriate test code logging
//use appropriate test code exception handling
//use appropriate test code comments
//use appropriate test code documentation
//use appropriate test code version control
//use appropriate test code build automation
//use appropriate test code deployment automation
//use appropriate test code continuous integration
//use appropriate test code continuous delivery

//write test cases for above program




//use nunit testing framework








