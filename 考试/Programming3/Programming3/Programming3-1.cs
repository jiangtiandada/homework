namespace Programming3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "";
            int empId = 0;
            double salary = 0;
            bool isright;
            bool isrights;
            EmployeeManager emp = new ();
            while (num != "6")
            {

                Tips();  // 提示界面
                // 提示输入
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        // 输入车辆信息提示
                        Console.WriteLine("请输入员工编号：");
                        (isright, empId) = emp.isLaw();
                        if (!isright) break;
                        Console.WriteLine("请输入员工姓名：");
                        string empName = Console.ReadLine();
                        Console.WriteLine("请输入员工部门：");
                        string department = Console.ReadLine();
                        Console.WriteLine("请输入员工薪资：");
                        (isrights, salary) = emp.isLawSalary();
                        if (!isrights) break;
                        string str1 = emp.Add(empId,empName,department,salary);
                        Console.WriteLine(str1);
                        break;
                    case "2":
                        string str2 = emp.Search();
                        break;
                    case "3":
                        Console.WriteLine("请输入员工编号");
                        (isright,empId) = emp.isLaw();
                        if (!isright) break;
                        string str3 = emp.UpdateSalary(empId);
                        Console.WriteLine(str3);
                        break;
                    case "4":
                        Console.WriteLine("请输入员工编号");
                        (isright, empId) = emp.isLaw();
                        if (!isright) break;
                        string str4 = emp.DeleteId(empId);
                        Console.WriteLine(str4);
                        break;
                    case "5":
                        Console.WriteLine("请输入员工薪资：");
                        (isrights, salary) = emp.isLawSalary();
                        if (!isrights) break;
                        string str5 = emp.Search(salary);
                        Console.WriteLine(str5);
                        break;
                    case "6":
                        Console.WriteLine("退出系统");
                        break;
                    default:
                        Console.WriteLine("输入编号有误，请重新输入！！！");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void Tips()
        {
            // 提示界面
            Console.WriteLine("==欢迎来到员工管理系统==");
            Console.WriteLine("请选择操作编号：");
            Console.WriteLine("1：新增员工");
            Console.WriteLine("2：查看全部员工");
            Console.WriteLine("3：根据编号调整工资");
            Console.WriteLine("4：根据编号删除员工");
            Console.WriteLine("5：按薪资条件筛选员工");
            Console.WriteLine("6：退出系统");
        }
    }
}
