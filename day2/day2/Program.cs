using System.Collections.Generic;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>()
            //{
            //    ["Name"] = "李四",
            //    ["age"] = 18,
            //    ["gener"] = 1,
            //    ["girl"] = new Dictionary<string, dynamic>()
            //    {
            //        ["Name"] = "翠花",
            //        ["age"] = 18,
            //        ["gener"] = 0,
            //    }
            //};
            //dict["name"] = "张三";
            //string name = dict["name"];
            //Console.WriteLine(name);
            //Console.WriteLine(dict.TryGetValue("age", out dynamic val));
            //dict.Remove("gender");
            //dict.claer
            //Console.WriteLine(dict.TryGetValue("age", out dynamic val));
            //int cnt = dict.Count
            //List<string> str = new List<string>() {"A", "B", "C" ,"D"};
            //str.Add("Z");
            //str.Insert(2, "X");
            //str.AddRange(["Q", "W", "E"]);
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(str);
            List<string> str2 = new List<string>() { "蒜头王八","杰尼龟","小火龙","皮卡丘","甲贺忍蛙"};
            Random r = new Random();
            Console.WriteLine($"就决定是你了：{str2[r.Next(str2.Count)]}");
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            //list.Add(100);
            //List<string> list = new List<string>() {"a","b","c" };
            //list.AddRange(["DD", "EE"]); // 参数必须 也是一个集合`
            //list.AddRange(new List<string>() { "FF", "GG" });
            //list.Insert(1, "a");
            //List<string> list = new List<string>() { "张三", "李四", "王五" ,"赵六","田七"};
            //list.RemoveRange(1, 3);
            //list.Remove("张三");
            //list.RemoveAt(0);
            //list.Clear();
            //bool b = list.Contains("李四");
            //Console.WriteLine(b);
            //List<string> list = new List<string>() { "a", "b", "c", "a", "b", "d", "f" };
            //int idx = list.IndexOf("a");
            //Console.WriteLine(idx);
            //int idx = list.LastIndexOf("a");
            //Console.WriteLine(idx);
            //var newList = list.GetRange(0, 2);
            //list.Reverse();
        }
    }
}
