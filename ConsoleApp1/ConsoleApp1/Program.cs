namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ////作业1
            //double a1 = double.Parse(Console.ReadLine()), b1 = double.Parse(Console.ReadLine());
            //Console.WriteLine(a1 + b1);
            ////作业2
            //double a2 = 80, b2;
            //b2 = 5 / 9.0 * (a2 - 32);
            //b2 = Math.Round(b2, 3);
            //Console.WriteLine("摄氏度： " + b2 + "℃");
            //Console.WriteLine("华氏度： " + a2 + "℉");
            ////作业3
            //int a3 = int.Parse(Console.ReadLine()), b3 = int.Parse(Console.ReadLine());
            //int c3;
            //c3 = a3;
            //a3 = b3;
            //b3 = c3;
            //Console.WriteLine("a3= " + a3 + " " + "b3= " + b3);
            //Console.WriteLine("a3 = {a3},b3 = {b3}");
            ////作业4
            //int a4 = 89, day, hour;
            //day = a4 / 24;
            //hour = a4 % 24;
            //Console.WriteLine("天数为：" + day);
            //Console.WriteLine("小时数为：" + hour);
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>()
            {
                ["name"] = "张三",
                ["age"] = 20,
                ["isMan"] = true,
                ["wife"] = new Dictionary<string, dynamic>()
                {
                    ["name"] = "翠花",
                    ["age"] = 21,
                    ["isMan"] = false
                }
            };
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine(Math.Floor(-1.4));
            
        }
    }
}
