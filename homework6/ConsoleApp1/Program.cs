using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取员工列表
            List<Employee> empList = GetEmployeeList();

            //打印排序前列表
            System.Console.WriteLine("排序前：");
            empList.ForEach(a => System.Console.WriteLine(a.ToString()));

            //使用LINQ执行排序
            empList = empList.OrderBy(a => a.DeptID).ThenByDescending(a => a.Salary).ThenBy(a => a.EntryTime).ToList();

            //打印排序后列表
            System.Console.WriteLine("");
            System.Console.WriteLine("排序后：");
            empList.ForEach(a => System.Console.WriteLine(a.ToString()));
            System.Console.ReadLine();
        }

        private static List<Employee> GetEmployeeList()
        {
            List<Employee> result = new List<Employee>();
            result.Add(new Employee() { Name = "张伟伟", DeptID = 3, DeptName = "市场部", Salary = 1500, EntryTime = DateTime.Parse("2016-05-12") });
            result.Add(new Employee() { Name = "李涛涛", DeptID = 2, DeptName = "财务部", Salary = 1600, EntryTime = DateTime.Parse("2017-02-16") });
            result.Add(new Employee() { Name = "王亮亮", DeptID = 1, DeptName = "研发部", Salary = 1900, EntryTime = DateTime.Parse("2018-10-25") });
            result.Add(new Employee() { Name = "孙红红", DeptID = 1, DeptName = "研发部", Salary = 1900, EntryTime = DateTime.Parse("2018-08-03") });
            result.Add(new Employee() { Name = "黄苗苗", DeptID = 3, DeptName = "市场部", Salary = 2200, EntryTime = DateTime.Parse("2016-09-06") });
            result.Add(new Employee() { Name = "蔡明明", DeptID = 1, DeptName = "研发部", Salary = 3500, EntryTime = DateTime.Parse("2012-11-25") });
            result.Add(new Employee() { Name = "吴慧慧", DeptID = 2, DeptName = "财务部", Salary = 1800, EntryTime = DateTime.Parse("2018-07-26") });
            result.Add(new Employee() { Name = "杨梅梅", DeptID = 3, DeptName = "市场部", Salary = 2200, EntryTime = DateTime.Parse("2017-02-15") });
            return result;
        }
    }
}

