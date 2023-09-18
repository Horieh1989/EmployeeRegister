using System;
using System.Collections.Generic;

// Define a class to represent an employee with name and salary.
class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
}

class Program
{   // main set up the menu and handel the inputs:
    static void Main()
    {
        // Create a list to store Employee objects.
        List<Employee> employees = new List<Employee>();

        // Create a while loop to show the options to users.
        while (true)
        {
            Console.WriteLine("Restaurant Employee Register");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display Employees");
            Console.WriteLine("3. Exit");
            Console.Write("Please select an option (1/2/3): ");

            //we read the user choice from the options and baised on their choice choose the right method.
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEmployee(employees);
                    break;
                case "2":
                    DisplayEmployees(employees);
                    break;
                case "3":
                    // Exit the program if employee chose case 3.
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
    // this method take employee name and salary if input is correct add it to the list.
    static void AddEmployee(List<Employee> employees)
    {
        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();

        Console.Write("Enter employee salary: ");
        if (double.TryParse(Console.ReadLine(), out double salary))
        {
            // Create a new Employee object and add it to the list.
            employees.Add(new Employee { Name = name, Salary = salary });
            Console.WriteLine("Employee added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid salary input. Please enter a valid number.");
        }
    }
    // this method gather employee name and salary and show it in the console 
    static void DisplayEmployees(List<Employee> employees)
    {
        Console.WriteLine("Employee List:");
        foreach (var employee in employees)
        {
            // show in the console name and salary.
            Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary:C}");
        }
    }
}