using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programming3
{
    internal class Employee
    {
        //私有字段：员工编号（int EmpId）、员工姓名（string EmpName）、所属部门（string Department）、员
        //工薪资（double Salary）
        //为所有私有字段编写对应的public公开属性（get、set）
        private int EmpId;
        private string EmpName;
        private string Department;
        private double Salary;
        public int _EmpId
        {
            get => this.EmpId;
            set
            {
                this.EmpId = value;
            }
        }
        public string _EmpName{

            get =>this.EmpName;
            set
            {
                this.EmpName = value;
            }
        }
        public string _Department
        {

            get => this.Department;
            set
            {
                this.Department = value;
            }
        }
        public double _Salary
        {

            get => this.Salary;
            set
            {
                this.Salary = value;
            }
        }
        public void ShowEmpInfo()
        {
            Console.WriteLine($"Id--{this.EmpId} 名字--{this.EmpName} 部门--{this.Department} 薪资--{this.Salary}");
        }
        public Employee(int EmpId,string EmpName,string Department,double Salary) {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.Department = Department;
            this.Salary = Salary;
        }
        public Employee() { }
    }
}
