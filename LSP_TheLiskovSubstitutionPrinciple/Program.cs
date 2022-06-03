using System;
using System.Collections.Generic;

namespace LSP_TheLiskovSubstitutionPrinciple
{
    public interface IEmployee
    {
        string GetEmployeeDetails(int employeeId);
    }

    public interface IWork : IEmployee
    {
        string GetWorkDetails(int employeeId);
    }

    public class SeniorEmployee : IWork
    {
        public string GetWorkDetails( int employeeId)
        {
            return "Senior Work";
        }

        public string GetEmployeeDetails(int employeeId)
        {
            return "Senior Employee";
        }
    }

    public class JuniorEmployee : IEmployee
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return "Junior Employee";
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<IEmployee> list = new List<IEmployee>();

            list.Add(new JuniorEmployee());
            list.Add(new SeniorEmployee());
            
             
            foreach (var emp in list)
            {
                Console.WriteLine((emp as JuniorEmployee)?.GetEmployeeDetails(789));

                Console.WriteLine((emp as SeniorEmployee)?.GetWorkDetails(798));
                Console.WriteLine((emp as SeniorEmployee)?.GetEmployeeDetails(798));
                
            }

            Console.ReadKey();
        }
    }
}