using System.Runtime.CompilerServices;

namespace day9
{
    using day8;
    internal class Program
    {
        static void Main(string[] args)
        {
            //var item = new FileName();
            //void add1(Action<int,int> n,int a,int b)
            //{
            //    n(a,b);
            //    item.add(a,b);
            //}
            //add1(item.add,4,5);
            //List<Dictionary<string, dynamic>> list = new() {
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "zs",
            //        ["age"] = 29,
            //        ["isMan"] = true,
            //        ["isSingle"] = true,
            //        ["salary"] = 4200
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "ls",
            //        ["age"] = 20,
            //        ["isMan"] = false,
            //        ["isSingle"] = true,
            //        ["salary"] = 3400
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "ww",
            //        ["age"] = 19,
            //        ["isMan"] = true,
            //        ["isSingle"] = false,
            //        ["salary"] = 6000
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "zl",
            //        ["age"] = 14,
            //        ["isMan"] = false,
            //        ["isSingle"] = true,
            //        ["salary"] = 2000
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "sq",
            //        ["age"] = 35,
            //        ["isMan"] = true,
            //        ["isSingle"] = false,
            //        ["salary"] = 7000
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "zb",
            //        ["age"] = 27,
            //        ["isMan"] = false,
            //        ["isSingle"] = true,
            //        ["salary"] = 2900
            //    },
            //};
            //// 作业1
            //// Find: 要求查找年龄小于20的
            //Dictionary<string, dynamic> age20 = list.Find(item => item["age"] < 20);
            //Console.WriteLine(age20["name"]);
            //// FindLast: 要求查找年龄大于25的
            //Dictionary<string, dynamic> age25 = list.FindLast(item => item["age"] > 25);
            //Console.WriteLine(age25["name"]);
            //// FindAll: 找出性别男的
            //List<Dictionary<string, dynamic>> manList = list.FindAll(item => item["isMan"] == true);
            //foreach (var item in manList) Console.WriteLine(item["name"]);
            //// FindIndex: 找出薪水大于5000
            //int fristsalary = list.FindIndex(item => item["salary"] > 5000);
            //Console.WriteLine(fristsalary);
            //// FindLastIndex: 找出薪水小于3000
            //int lastsalary = list.FindLastIndex(item => item["salary"] < 3000);
            //Console.WriteLine(lastsalary);
            //// Exists: 判断是否有薪水大于5000
            //bool is5000 = list.Exists(item => item["salary"] > 5000);
            //Console.WriteLine(is5000);
            //// ForEach: 输出每个的 名字-年龄-薪水
            //list.ForEach(item => Console.WriteLine($"{item["name"]}-{item["age"]}-{item["salary"]}"));
            //// ConvertAll: 映射得到一个所以薪水的list
            //List<int> salaryList = list.ConvertAll(item => (int)item["salary"]);
            //foreach (int item in salaryList) Console.WriteLine(item);
            ////TrueForAll: 判断是否都成年
            //bool isChengnian = list.TrueForAll(item => item["age"] >= 18);
            //Console.WriteLine(isChengnian);
            // IndexOf

            // LastIndexOf
            // 作业2:  封装一个函数 接收一个字符串; 返回一个字典,键是字符串的每个字符,键值是这个字符在字符串中出现的次数
            //void count(string str, ref Dictionary<char, int> charCount)
            //{
            //    foreach (char s in str)
            //    {
            //        if (charCount.ContainsKey(s)) charCount[s]++;
            //        else charCount.Add(s, 1);
            //    }
            //}
            //Dictionary<char, int> charCount = new Dictionary<char, int>();
            //Console.WriteLine("请输入一个字符串：");
            //string str = Console.ReadLine();
            //count(str, ref charCount);
            //foreach (var item in charCount) Console.WriteLine(item);
        }
    }
}
