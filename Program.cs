// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using HRAdministrationAPI;
using System.Linq;


namespace SchoolHRAdministration
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();

            SeedData(employees);

            /* foreach (IEmployee employee in employees)
             {
                 totalSalaries += employee.Salary;
             };
             Console.WriteLine($"Total Annual Salaries + bonus is: {totalSalaries}" );
             Console.ReadKey();*/

            Console.WriteLine($"Total annula salaries + bonus is: {employees.Sum(e => e.Salary)}");
            Console.ReadKey();
        }
        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Alice",
                LastName = "Bob",
                Salary = 40000
            };
            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "Charity",
                LastName = "Davids",
                Salary = 40000
            };
            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                FirstName = "Emma",
                LastName = "Frank",
                Salary = 50000
            };
            employees.Add(headOfDepartment);

            IEmployee deputyHeadTeacher = new DeputyHeadMaster
            {
                Id = 4,
                FirstName = "Gianna",
                LastName = "Hudson",
                Salary = 60000
            };
            employees.Add(deputyHeadTeacher);

            IEmployee headTeacher = new HeadMaster
            {
                Id = 2,
                FirstName = "Ivan",
                LastName = "Joel",
                Salary = 70000
            };
            employees.Add(headTeacher);
        }
    }
    public class Teacher: EmployeeBase
    {
        public override decimal Salary { get => base.Salary + base.Salary * 0.02m; }
    }
    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + base.Salary * 0.03m; }
    }
    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + base.Salary * 0.04m; }
    }
    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + base.Salary * 0.05m; }
    }

}
