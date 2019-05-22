using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        // <summary>
        /// 员工名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        public int DeptID { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DeptName { get; set; }

        /// <summary>
        /// 薪资
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// 入职时间
        /// </summary>
        public DateTime EntryTime { get; set; }

        public override string ToString()
        {
            return String.Format("{0}；{1}；薪资：{2}元；入职时间：{3}；", this.Name, this.DeptName, this.Salary, this.EntryTime.ToString("yyyy-MM-dd"));
        }
    }
}
