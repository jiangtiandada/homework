using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programming3
{
    internal class EmployeeManager
    {
        private string Path { get; } = "./emp.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        public string Add(int id, string name, string department, double salary)
        {
            List<Employee> list = new();
            string json = null;
            if (File.Exists(Path))
            {
                //json = File.ReadAllText(Path);
                //list = JsonSerializer.Deserialize<List<Employee>>(json);
                (json, list) = tool();
                if (list.Exists(item => item._EmpId == id)) return "这个用户已经存在";
            }
            Employee c = new(id, name, department, salary);
            list.Add(c);
            json = JsonSerializer.Serialize(list, JsonOpt);
            File.WriteAllText(Path, json);
            return "添加成功";
        }
        public string Search()
        {
            if (!File.Exists(Path)) return "暂无员工数据";
            var(json,list) = tool();
            foreach (var it in list)
            {
                it.ShowEmpInfo();
            }
            return "";
        }
        public string Search(double salary)
        {
            if (!File.Exists(Path)) return "暂无员工数据";
            var (json, list) = tool();
            List<Employee> newList = list.FindAll(item => item._Salary > salary);
            if (newList.Count == 0) return "无对应薪资条件的员工";
            foreach (var it in newList)
            {
                it.ShowEmpInfo();
            }
            return "";
        }
        public string UpdateSalary(int id)
        {
            if (!File.Exists(Path)) return "暂无员工数据";
            var (json, list) = tool();
            Employee emp = list.Find(item => item._EmpId == id);
            if (emp == null) return "未查询到该编号的员工";
            Console.WriteLine("输入新薪资：");
            double salary = double.Parse(Console.ReadLine());
            emp._Salary = salary;
            json = JsonSerializer.Serialize(list, JsonOpt);
            File.WriteAllText(Path, json);
            return "修改成功";
        }
        public string DeleteId(int id)
        {
            
            if (!File.Exists(Path)) return "暂无员工数据";
            var (json, list) = tool();
            Employee emp = list.Find(item => item._EmpId == id);
            if (emp == null) return "未查询到该编号的员工，删除失败";
            list.Remove(emp);
            json = JsonSerializer.Serialize(list, JsonOpt);
            File.WriteAllText(Path, json);
            return "删除成功";
        }
        public (string,List<Employee>) tool()
        {
            List<Employee> list = new();
            string json = "";
            json = File.ReadAllText(Path);
            list = JsonSerializer.Deserialize<List<Employee>>(json);
            return (json, list);
        }
        public (bool,int) isLaw()
        {
            bool isright;
            int empId;
            isright = int.TryParse(Console.ReadLine(), out empId);
            if (!isright)Console.WriteLine("员工编号输入错误");
            return (isright, empId);
        }
        public (bool, double) isLawSalary()
        {
            bool isright;
            double salary;
            isright = double.TryParse(Console.ReadLine(), out salary);
            if (!isright) Console.WriteLine("员工编号输入错误");
            return (isright, salary);
        }
    }
}
