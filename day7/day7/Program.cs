using System.Text.Json;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //解密
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "7-16-30-38-49-52-63-70";
            //string result = ""; // 最终获取到的情报
            //string[] num = salt.Split("-");
            //List<int> list = new List<int>();
            //foreach (string s in num) list.Add(int.Parse(s));
            //for (int i = 0; i < list.Count; i++) Console.Write(text[list[i]]);
            string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            string salt = "午夜渡口交换情报";
            //加密
            //List<int> list = new List<int>();
            //for (int i = 0; i < salt.Length; i++) list.Add(text.IndexOf(salt[i]));
            //string res = string.Join("-", list);
            //Console.WriteLine(res);//7-16-30-38-49-52-63-70
            /******************************************************/
            //加密为了更安全，生成密文的时候可以调整下标：（上一个字符）：
            //List<int> list = new List<int>();
            //for (int i = 0; i < salt.Length; i++) list.Add(text.IndexOf(salt[i]) - 1);
            //string res = string.Join("-", list);
            //Console.WriteLine(res);
            ////解密
            //string result = ""; // 最终获取到的情报
            //string[] num = res.Split("-");
            //List<int> list1 = new List<int>();
            //foreach (string s in num) list1.Add(int.Parse(s) + 1);
            //for (int i = 0; i < list.Count; i++) Console.Write(text[list1[i]]);//午夜渡口交换情报
            //List<int> list = new List<int>();
            //for (int i = 0; i < salt.Length; i++) list.Add(text.IndexOf(salt[i]) % 2 == 0 ? text.IndexOf(salt[i])+1: text.IndexOf(salt[i]) - 1);
            //string res = string.Join("-", list);
            //Console.WriteLine(res);//6-17-31-39-48-53-62-71
            ////解密
            //string result = ""; // 最终获取到的情报
            //string[] num = res.Split("-");
            //List<int> list1 = new List<int>();
            //foreach (string s in num) list1.Add(int.Parse(s)%2==0?int.Parse(s)+1:int.Parse(s)-1);
            //for (int i = 0; i < list.Count; i++) Console.Write(text[list1[i]]);//午夜渡口交换情报
            /********************************************************************/
            //int money = 100086;
            //string str = money.ToString();
            //// 创建汉字数组
            //string[] arr = new string[] {"零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"};
            //// 创建单位数组
            //string[] units = new string[] {"", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"};
            //string result = "";
            //for (int i = 0; i < str.Length; i++) {
            //    int index = str.Length - 1 - i;
            //    //Console.WriteLine(index);
            //    if (int.Parse(str[i].ToString()) != 0 || units[index] == "萬") result += (arr[int.Parse(str[i].ToString())] + units[index]);
            //    else result += arr[int.Parse(str[i].ToString())];
            //}
            //string reg1 = @"零+";
            //string reg2 = @"零萬";
            //result = Regex.Replace(result, reg1, "零");
            //result = Regex.Replace(result, reg2, "萬");
            //Console.WriteLine(result);
            /********************************************************************/
            //double d1 = 1234.5678;
            ////c/C带货币符号
            //Console.WriteLine(d1.ToString("C2"));//￥1,234.57带货币符号
            ////D/d 十进制类型只能是Int
            //int d2 = 1234;
            //Console.WriteLine(d2.ToString("D5"));//01234
            ////E/e科学计数法
            //Console.WriteLine(d1.ToString("e2"));//1.23e+003
            ////F/f定点格式
            //Console.WriteLine(d1.ToString("f3"));//1234.568
            ////N/n千分位分割
            //Console.WriteLine(d1.ToString("n3"));//1,234.568
            //// P/p百分比格式
            //Console.WriteLine(d1.ToString("p3"));//123,456.780%
            //// X/x十六进制格式 
            //int d3 = 16;
            //Console.WriteLine(d3.ToString("x"));//10
            //// 0零占位符
            //Console.WriteLine(d1.ToString("00000.0000000"));//01234.5678000
            //// #,#千分位  整数千分位分割
            //Console.WriteLine(d2.ToString("#,#"));//1,234
            //// %百分比站位符
            //Console.WriteLine(d1.ToString("0.0%"));//123456.8%
            /********************************************************************/
            //获取当前的时间对象
            //var date = DateTime.Now;
            //Console.WriteLine(date);//2026/8/11 18:55:52
            //var year = date.Year;
            //var month = date.Month;
            //var day = date.Day;
            //var dayOfWeek = date.DayOfWeek;
            //var hour = date.Hour;
            //var minute = date.Minute;
            //var second = date.Second;
            //var milliSecond = date.Millisecond;
            //Console.WriteLine($"年={year},月={month},日={day},周={dayOfWeek},时={hour},分={minute},秒={second},毫秒={milliSecond}");//年=2026,月=8,日=11,周=Tuesday,时=18,分=56,秒=56,毫秒=826                                                                               
            // 日期格式化
            //var date = DateTime.Now;
            //Console.WriteLine(date.ToString()); //2026/8/11 19:00:07
            //// 短日期
            //Console.WriteLine(date.ToString("d")); //2026/8/11            
            //// 长日期
            //Console.WriteLine(date.ToString("D")); //2026年8月11日
            //// 短时间
            //Console.WriteLine(date.ToString("t")); //19:00            
            //// 长时间
            //Console.WriteLine(date.ToString("T")); //19:00:07
            //// 完整日期时间（短时间）
            //Console.WriteLine(date.ToString("f")); //2026年8月11日 19:00            
            //// 完整日期时间（长时间）
            //Console.WriteLine(date.ToString("F")); //2026年8月11日 19:00:07
            //// 常规日期时间（短时间）
            //Console.WriteLine(date.ToString("g")); //2026/8/11 19:00           
            //// 常规日期时间（长时间）
            //Console.WriteLine(date.ToString("G")); //2026/8/11 19:00:07
            //// 月日格式
            //Console.WriteLine(date.ToString("M")); //8月11日            
            //// 年月格式
            //Console.WriteLine(date.ToString("Y")); //2026年8月
            ////通用完整格式（UTC格林威治）
            //Console.WriteLine(date.ToString("U")); //2026年8月11日 11:00:07
            ////RFC1123模式
            //Console.WriteLine(date.ToString("R"));  //Tue, 11 Aug 2026 19:00:07 GMT
            /********************************************************************/
            List<Dictionary<string, dynamic>> singerList = new ()
            {
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1001},
                    {"singerName", "周杰伦"},
                    {"genre", "流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1002},
                    {"singerName", "林俊杰"},
                    {"genre", "华语流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1003},
                    {"singerName", "邓紫棋"},
                    {"genre", "流行、摇滚"}
                }
            };
            //json序列化
            string json = JsonSerializer.Serialize(singerList);
            Console.WriteLine(json);
            //反序列化
            var res = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            foreach(var item in res) Console.WriteLine(item["singerName"]);
            // 将unicode编码汉字转成中文汉字
            string source = "\u6C11\u8C23\u725B\x42";
            // 将需要反序列化的数据前面加双引号和大括号
            string json1 = $"\"{source}\"";
            string result = JsonSerializer.Deserialize<string>(json1);
            Console.WriteLine(result); // 民谣牛B
        }
    }
}
