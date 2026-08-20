namespace day14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "";// 输入的操作编号
            CarManger CM = new CarManger();// 实例化车辆管理对象
            UserManage UM = new UserManage();
            RentReturnclass RR = new RentReturnclass();
            while (num != "0")
            {

                Tips();  // 提示界面
                // 提示输入
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        // 车辆输入
                        Console.WriteLine("请输入车牌号：");
                        string Card = Console.ReadLine();
                        Console.WriteLine("请输入车类型：");
                        string Type = Console.ReadLine();
                        Console.WriteLine("请输入时租费：");
                        string Price = Console.ReadLine();
                        string resAdd = CM.Add(Card, Type, Price);
                        Console.WriteLine(resAdd);
                        break;
                    case "2":
                        Console.WriteLine("查看所有车辆信息");
                        string str = CM.Search();
                        Console.WriteLine(str);
                        break;
                    case "3":
                        Console.WriteLine("请输入车辆ID");
                        int id = int.Parse(Console.ReadLine());
                        string str1 = CM.Search(id);
                        Console.WriteLine(str1);
                        break;
                    case "4":
                        string str2 = CM.isFree();
                        Console.WriteLine(str2);
                        break;
                    case "5":
                        Console.WriteLine("请输入客户姓名：");
                        string userName = Console.ReadLine();
                        Console.WriteLine("请输入身份证号：");
                        string userCardId = Console.ReadLine();
                        Console.WriteLine("请输入性别：");
                        string gender = Console.ReadLine();
                        Console.WriteLine("请输入手机号：");
                        string telNum = Console.ReadLine();
                        Console.WriteLine("请输入座右铭：");
                        string motto = Console.ReadLine();
                        string str3 = UM.Add(userName,userCardId,gender,telNum,motto);
                        Console.WriteLine(str3);
                        break;
                    case "6":
                        string str4 = UM.Search();
                        Console.WriteLine(str4);
                        break;
                    case "7":
                        Console.WriteLine("请输入你的用户Id");
                        int uid = int.Parse(Console.ReadLine());
                        string str5 = UM.Search(uid);
                        Console.WriteLine(str5);
                        break;
                    case "8":
                        string str6 = RR.rent();
                        Console.WriteLine(str6);
                        break;
                    case "9":
                        Console.WriteLine("请输入你想要还的ID");
                        int ID = int.Parse(Console.ReadLine());
                        string str7 = RR.returnCar(ID);
                        Console.WriteLine(str7);
                        break;
                    case "10":
                        string str8 = RR.search();
                        Console.WriteLine(str8);
                        break;
                    case "0":
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
            Console.WriteLine("==欢迎来到神车系统==");
            Console.WriteLine("请选择操作编号：");
            Console.WriteLine("0：退出系统");
            Console.WriteLine("1：新增车辆");
            Console.WriteLine("2：查看所有车辆信息");
            Console.WriteLine("3：查看某辆车");
            Console.WriteLine("4：查看所有空闲车辆");
            Console.WriteLine("5：新增客户");
            Console.WriteLine("6：查看所有客户");
            Console.WriteLine("7：查看某个客户");
            Console.WriteLine("8：租车");
            Console.WriteLine("9：还车");
            Console.WriteLine("10：查询租车信息");
        }
    }
}

