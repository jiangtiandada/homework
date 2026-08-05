using System.Collections.Concurrent;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //小明的择偶要求
            //int money = int.Parse(Console.ReadLine());
            //double yz = double.Parse(Console.ReadLine());
            //if (money > 300 || yz > 9.5)
            //{
            //    Console.WriteLine("条件满足,就是你了");
            //}
            //else { 
            //    Console.WriteLine("条件不满足,继续找");
            //}
            //bool res = money > 300 || yz > 9.5;
            //Console.WriteLine(res);

            //Console.WriteLine("请输入你的成绩：");
            //int score = int.Parse(Console.ReadLine());
            //if (score < 60)
            //{
            //    Console.WriteLine("成绩不及格");
            //}
            //else if (score >= 60 && score < 80)
            //{
            //    Console.WriteLine("成绩及格");
            //}
            //else if (score >= 80 && score < 90)
            //{
            //    Console.WriteLine("成绩良好");

            //}
            //else if (score >= 90 && score < 100)
            //{
            //    Console.WriteLine("成绩优秀");
            //}
            //else {
            //    Console.WriteLine("满分");
            //}
            //Console.WriteLine("请输入你想要查询的年份");
            //int year = int.Parse(Console.ReadLine());
            //if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            //{
            //    Console.WriteLine($"{year}是闰年");
            //}
            //else
            //{
            //    Console.WriteLine($"{year}不是闰年");
            //}
            //Console.WriteLine("请输入数字（1~7）");
            //int day = int.Parse(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("星期一");
            //        break;
            //    case 2:
            //        Console.WriteLine("星期二");
            //        break;
            //    case 3:
            //        Console.WriteLine("星期三");
            //        break;
            //    case 4:
            //        Console.WriteLine("星期四");
            //        break;
            //    case 5:
            //        Console.WriteLine("星期五");
            //        break;
            //    case 6:
            //        Console.WriteLine("星期六");
            //        break;
            //    case 7:
            //        Console.WriteLine("星期日");
            //        break;
            //    default:
            //        Console.WriteLine("输入错误");
            //        break;
            //}
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("星期一");
            //        break;
            //    case 2:
            //        Console.WriteLine("星期二");
            //        break;
            //    case 3:
            //        Console.WriteLine("星期三");
            //        break;
            //    case 4:
            //        Console.WriteLine("星期四");
            //        break;
            //    case 5:
            //        Console.WriteLine("星期五");
            //        break;
            //    case 6:

            //    case 7:
            //        Console.WriteLine("周末");
            //        break;
            //    default:
            //        Console.WriteLine("输入错误");
            //        break;
            //}
            //Console.WriteLine("请输入你的分数：");
            //int score1 = int.Parse(Console.ReadLine());
            //switch (score1 / 10)
            //{
            //    case 0:
            //        Console.WriteLine($"{score1}分数是F等级");
            //        break;
            //    case 1:
            //        Console.WriteLine($"{score1}分数是F等级");
            //        break;
            //    case 2:
            //        Console.WriteLine($"{score1}分数是F等级");
            //        break;
            //    case 3:
            //        Console.WriteLine($"{score1}分数是F等级");
            //        break;
            //    case 4:
            //        Console.WriteLine($"{score1}分数是F等级");
            //        break;
            //    case 5:
            //        Console.WriteLine($"{score1}分数是F等级");
            //        break;
            //    case 6:
            //        Console.WriteLine($"{score1}分数是D等级");
            //        break;
            //    case 7:
            //        Console.WriteLine($"{score1}分数是C等级");
            //        break;
            //    case 8:
            //        Console.WriteLine($"{score1}分数是B等级");
            //        break;
            //    case 9:
            //        Console.WriteLine($"{score1}分数是A等级");
            //        break;
            //    case 10:
            //        Console.WriteLine($"{score1}分数是A等级");
            //        break;
            //    default:
            //        Console.WriteLine("分数不合法");
            //        break;
            //}
            //if (score1 > 0 && score1 <= 100)
            //{
            //    string res = score1 switch
            //    {
            //        >= 90 => "A等级",
            //        >= 80 => "B等级",
            //        >= 70 => "C等级",
            //        >= 60 => "D等级",
            //        _ => "F等级"
            //    };
            //    Console.WriteLine($"{score1}分数是{res}");
            //}
            //else {
            //    Console.WriteLine("分数不合法");
            //}
            //Console.WriteLine("请输入年龄：");
            //int age = int.Parse(Console.ReadLine());
            ////string res1 = age>18 ? "成年" : "未成年";
            ////Console.WriteLine(res1);
            //Console.WriteLine($"{(age > 18 ? "成年" : "未成年")}");
            //Console.WriteLine("请输入年份");
            //int year = int.Parse(Console.ReadLine());
            ////string res2 = (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) ? "闰年" : "平年";
            ////Console.WriteLine($"{year}是{res2}");
            //Console.WriteLine($"{year}是{(year % 4 == 0 && year % 100 != 0 || year % 400 == 0 ? "闰年" : "平年")}");
            //Console.WriteLine("请输入一个数字");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{num}是{(num % 2 == 0 ? "偶数" : "奇数")}");
            //int n = 1;
            //Console.WriteLine(n == 1?"在线":"离线");
            //Console.WriteLine("请输入文件大小：");
            //int fileSize = int.Parse(Console.ReadLine());
            //Console.WriteLine($"文件大小是{(fileSize > 1024 ? fileSize / 1024 + "MB":fileSize+"KB") }");
            //Console.WriteLine("请输入两个文字和一个运算符");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //string op = Console.ReadLine();
            //if (op == "+")
            //{
            //    Console.WriteLine($"{num1 + num2}");
            //}
            //else if (op == "-")
            //{
            //    Console.WriteLine($"{num1 - num2}");
            //}
            //else if (op == "*")
            //{
            //    Console.WriteLine($"{num1 * num2}");
            //}
            //else if (op == "/" && num2 != 0)
            //{
            //    Console.WriteLine($"{num1 / num2}");
            //}
            //else if (op == "/" && num2 == 0)
            //{
            //    Console.WriteLine("除数不能为0");
            //}
            //else
            //{
            //    Console.WriteLine("运算符不合法");
            //}
            //Console.WriteLine("请输入你的血型");
            //string bloodType = Console.ReadLine();
            //string personality = bloodType switch
            //{
            //    "A" => "细心稳重",
            //    "B" => "乐观自由",
            //    "AB" => "思维多变",
            //    "O" => "热情外向",
            //    _ => "暂时无法判断你的性格"
            //};
            //Console.WriteLine(personality);
            //if (bloodType == "A")
            //{
            //    Console.WriteLine("细心稳重");
            //}
            //else if (bloodType == "B")
            //{
            //    Console.WriteLine("乐观自由");
            //}
            //else if (bloodType == "AB")
            //{
            //    Console.WriteLine("思维多变");
            //}
            //else if (bloodType == "O")
            //{
            //    Console.WriteLine("热情外向");
            //}
            //else
            //{
            //    Console.WriteLine("暂时无法判断你的性格");
            //}
            //作业1
            //Console.WriteLine("请输入账号：");
            //string account = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //int password = int.Parse(Console.ReadLine());
            //if (account != "admin")
            //{
            //    Console.WriteLine("账号不存在");
            //}
            //if (password != 123456)
            //{
            //    Console.WriteLine("密码错误");
            //}
            //if(account == "admin" && password == 123456) { 
            //    Console.WriteLine("登录成功");
            //}
            //作业2
            //Console.WriteLine("用户请选择操作：（add/edit/del）");
            //string operation = Console.ReadLine();
            //switch(operation)
            //{
            //    case "add":
            //        Console.WriteLine("添加操作");
            //        break;
            //    case "edit":
            //        Console.WriteLine("编辑操作");
            //        break;
            //    case "del":
            //        Console.WriteLine("删除操作");
            //        break;
            //    default:
            //        Console.WriteLine("无效操作");
            //        break;
            //}
            //作业3
            //Console.WriteLine("请输入你的用户等级：（VIP/USER）");
            //string userLevel = Console.ReadLine();
            //if (userLevel == "VIP")
            //{
            //    double num = double.Parse(Console.ReadLine());
            //    if (num >= 1000)
            //    {
            //        num *= 0.9;
            //        Console.WriteLine($"尊贵的VIP您只需要支付：{num}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"你需要支付：{num}");
            //    }
            //}
            //else if(userLevel == "USER"){ 
            //    double num = double.Parse(Console.ReadLine());
            //    if (num >= 2000)
            //    {
            //        num *= 0.95;
            //        Console.WriteLine($"你需要支付：{num}");
            //    }
            //    else {
            //        Console.WriteLine($"你需要支付：{num}");
            //    }
            //}
            //作业4
            //Console.WriteLine("请输入月份：");
            //int month = int.Parse(Console.ReadLine());
            //switch (month) {
            //    case 1:
            //    case 11:
            //    case 12:
            //        Console.WriteLine("冬季");
            //        break;
            //    case 2:
            //    case 3:
            //    case 4:
            //        Console.WriteLine("春季");
            //        break;
            //    case 5:
            //    case 6:
            //    case 7:
            //        Console.WriteLine("夏季");
            //        break;
            //    case 8:
            //    case 9:
            //    case 10:
            //        Console.WriteLine("秋季");
            //        break;
            //}
            //作业5
            //Console.WriteLine("请输入你的包裹重量：");
            //double weight = double.Parse(Console.ReadLine());
            //if (weight < 1)
            //{
            //    Console.WriteLine("你应该支付10元");
            //}
            //else if (weight >= 1 && weight < 5)
            //{
            //    Console.WriteLine("你应该支付20元");
            //}
            //else {
            //    Console.WriteLine("你应该支付50元");
            //}
            //作业6
            //Console.WriteLine("请输入你的会员等级");
            //int level = int.Parse(Console.ReadLine());
            //if (level == 5)
            //{
            //    Console.WriteLine("终身免运费");
            //}
            //else if (level == 4)
            //{
            //    Console.WriteLine("每月可以领取优惠卷");
            //}
            //else if (level == 3) {
            //    Console.WriteLine("购物可以打九折");
            //}
            //else
            //{
            //    Console.WriteLine("没有优惠");
            //}
            //作业7
            //Console.WriteLine("请输入商品编号：");
            //int productId = int.Parse(Console.ReadLine());
            //if(productId == 1)
            //{
            //    Console.WriteLine("已购买可乐");
            //}
            //else if(productId == 2)
            //{
            //    Console.WriteLine("已购买雪碧");
            //}
            //else if(productId == 3)
            //{
            //    Console.WriteLine("已购买矿泉水");
            //}
            //else
            //{
            //    Console.WriteLine("商品不存在");
            //}
            //作业8
            //Console.WriteLine("请输入速度：");
            //int speed = int.Parse(Console.ReadLine());
            //if(speed >0 && speed < 30)
            //{
            //    Console.WriteLine("低速通过");
            //}else if(speed >= 30 && speed < 60)
            //{
            //    Console.WriteLine("中速通过");
            //}
            //else if(speed >= 60 && speed < 100)
            //{
            //    Console.WriteLine("高速通过");
            //}
            //else if(speed >= 100 && speed <=120)
            //{
            //    Console.WriteLine("超速行驶");
            //}
            //加一行注释测试编码问题
        }
    }
}
