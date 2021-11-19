//1.Get employee details from employees object whose employee name is “John” (note restrict operator)

//2.Get FIRSTNAME,LASTNAMe from employees object(note project operator)

//3.Select FirstName, IncentiveAmount from employees and incentives object for those employees who have incentives.(join operator)

//4.Get department wise maximum salary from employee table order by salary ascending (note group by)

//5.Select department, total salary with respect to a department from employees object where total salary greater than 800000 order by TotalSalary descending(group by having)



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Ass
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Deparment { get; set; }
    }
    class Incentive
    {
        public int ID { get; set; }
        public double IncentiveAmount { get; set; }
        public DateTime IncentiveDate { get; set; }
    }
    class Assignment
    {
        static void Main(string[] args)
            {
                List<Employee> employees = new List<Employee>()
            {
                new Employee(){ID=1,FirstName="John",LastName="Abraham",Salary=1000000,JoiningDate=new DateTime(2013,1,1),Deparment="Banking"},
                new Employee(){ID=2,FirstName="Michael",LastName="Clarke",Salary=800000,JoiningDate=new DateTime(),Deparment="Insurance" },
                new Employee(){ID=3,FirstName="oy",LastName="Thomas",Salary=700000,JoiningDate=new DateTime() ,Deparment="Insurance"},
                new Employee(){ID=4,FirstName="Tom",LastName="Jose",Salary=600000,JoiningDate=new DateTime() ,Deparment="Banking"},
                new Employee(){ID=4,FirstName="TestName2",LastName="Lname%",Salary=600000,JoiningDate=new DateTime(2013,1,1) ,Deparment="Services"}
            };
                List<Incentive> incentives = new List<Incentive>()
            {
                new Incentive(){ ID=1,IncentiveAmount=5000,IncentiveDate=new DateTime(2013,02,02)},
                new Incentive(){ID=2,IncentiveAmount=10000,IncentiveDate=new DateTime(2013,02,4)},
                new Incentive(){ID=1,IncentiveAmount=6000,IncentiveDate=new DateTime(2012,01,5)},
                new Incentive(){ID=2,IncentiveAmount=3000,IncentiveDate=new DateTime(2012,01,5)}

            };

            //Query 1


            //var mquery1 = employees.Where(e => e.FirstName == "John");

            //foreach (var e in mquery1)
            //{
            //    Console.WriteLine($"EmployeeId : {e.ID}, EmployeeName : {e.FirstName} {e.LastName}, Salary : {e.Salary}, Join Date : {e.JoiningDate}, Department : {e.Deparment}");
            //}

            //Query 2

            //var mquery2 = employees.Select(e => new
            //{
            //    e.FirstName,
            //    e.LastName
            //});

            //foreach (var e in mquery2)
            //{
            //    Console.WriteLine($"Employee FirstName :{e.FirstName},Employee LastName:{e.LastName}");
            //}

            //Query 3

            //var mquery3 = employees.Join(incentives, e => e.ID, i => i.ID, (e, i) => new
            //{
            //    EmpID = e.ID,
            //    EmpName = e.FirstName + "" + e.LastName,
            //    EmpSalary = e.Salary,
            //    IncAmount = i.IncentiveAmount,
            //    IncDate = i.IncentiveDate
            //});

            //foreach (var e in mquery3)
            //{
            //    Console.WriteLine($"Employee id: { e.EmpID}, EmployeeName: { e.EmpName}, Salary: { e.EmpSalary}, IncentiveAmount: { e.IncAmount}, IncentiveDate: { e.IncDate}");
            //}

            //Query 4

            //var mquery4 = from e in employees
            //              group e by e.Deparment into eg
            //              let maxSalary = (from e1 in eg select e1.Salary).Max()
            //              orderby maxSalary
            //              select new
            //              {
            //                  department = eg.Key,
            //                  maxSalary
            //              };

            //foreach (var i in mquery4)
            //{
            //    Console.WriteLine($"Department : {i.department} , MaximunSalary : {i.maxSalary}");
            //}

            //Query 5

            var mquery5 = from e in employees
                          group e by e.Deparment into eg
                          let totalSalary = (from e1 in eg
                                             select e1.Salary).Sum()
                          where totalSalary > 800000
                          orderby totalSalary descending
                          select new
                          {
                              department = eg.Key,
                              totalSalary
                          };
            foreach (var i in mquery5)
            {
                Console.WriteLine($"Department : {i.department} , Max.Salary : {i.totalSalary}");
            }
        Console.ReadKey();
        }
    }
}
