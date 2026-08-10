using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

namespace day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Length获取字符串长度 属性
            //string str = "sadfsda";
            //Console.WriteLine(str.Length);
            /**************************************************/
            //注意是string
            //-string.IsNullOrEmpty：判断字符串是否为空或null
            //string str = null;
            //Console.WriteLine(string.IsNullOrEmpty);
            //- string.IsNullOrWhiteSpace：判断字符串是否为null或空格
            //Console.WriteLine(string.IsNullOrWhiteSpace);
            /**************************************************/
            //Substring：截取字符串
            //string str = "asdfghjkl";
            //Console.WriteLine(str.Substring(1));//从1开始截取后面所有的sdfghjkl
            //Console.WriteLine(str.Substring(1,2));//从1开始截取后面2个sd
            /**************************************************/
            //Contains：判断字符串中是否包含小字符串（子串）
            //string str = "asdfghjkl";
            //Console.WriteLine(str.Contains("asd"));//True
            /**************************************************/
            //-StartsWith：判断字符串是否用某个子串开头
            //string str = "asdfghjkl";
            //Console.WriteLine(str.StartsWith("asd"));//True
            //- EndsWith：判断字符串是否以某个子串结尾
            //Console.WriteLine(str.EndsWith("jkl"));//True
            /**************************************************/
            //string str = "asdafghljkl";
            //IndexOf：在字符串中找某个子串第一次出现的下标，找到得到下标，找不到得到 - 1
            // 字符串.IndexOf(子串)  查找子串第一次出现的下标
            // 字符串.IndexOf(子串,开始下标)  从开始下标查找子串第一次出现的下标   
            //Console.WriteLine(str.IndexOf("a"));//0
            //Console.WriteLine(str.IndexOf("a",2));//3
            //LastIndexOf：在字符串中找某个子串最后一次出现的下标，找到得到下标，找不到得到 - 1
            //Console.WriteLine(str.LastIndexOf("l"));//10
            //Console.WriteLine(str.LastIndexOf("l",5));//-1
            /**************************************************/
            //-ToUpper：将字符串中的小写字母转成大写字母
            //- 只有字母区分大小写，其他字符没有大小写区分
            //- ToLower：将字符串中的大写字母转成小写字母
            //string str = "asdAfghLjkl";
            //Console.WriteLine(str.ToLower());//asdafghljkl
            //Console.WriteLine(str.ToUpper());//ASDAFGHLJKL
            /**************************************************/
            //Trim：去除字符串首尾两端的空格
            //补充：类型中还有一种类型char类型，字符类型，单个字符(字符串)
            //TrimStart：去除开头的空格
            //TrimEnd：去除结尾的空格
            //string str = "    abc     ";
            //Console.WriteLine($"*{str}*");
            //Console.WriteLine($"*{str.Trim()}*");//*abc*
            //Console.WriteLine($"*{str.TrimEnd()}*");//*    abc*
            //Console.WriteLine($"*{str.TrimStart()}*");//*abc     *
            /**************************************************/
            //Replace：将字符串中指定的子串都替换成的新的子串
            //string str = "生活总会有大麻烦, 黑夜总会过去";
            //// 假设list存储敏感词
            //List<string> mgc = ["大麻", "夜总会"];
            //for (int i = 0; i < mgc.Count; i++)
            //{
            //    string str1 = "";
            //    for (int j = 0; j < mgc[i].Length; j++) str1 += "*";
            //    str = str.Replace(mgc[i], str1);
            //    //str = str.Replace(mgc[i], new string('*', mgc[i].Length));
            //}
            //Console.WriteLine(str);
            /***************************************************************/
            //分割字符串 Split
            //string oldstr = "you love i";
            //string[] strArr = oldstr.Split();
            //List<string> strList = new ();
            //foreach (var item in strArr) strList.Add(item);
            //strList.Reverse();
            //string newstr = "";
            //foreach(var item in strList)
            //{
            //    string str1 = item.Substring(0,1).ToUpper();
            //    string str2 = item.Substring(1).ToLower();
            //    newstr = newstr + str1 + str2 + " ";
            //}
            //Console.WriteLine(newstr.Substring(0,newstr.Length-1));
            /***************************************************************/
            //string.Concat：将多个字符串拼接成一个大字符串
            //string str1 = "aa";
            //string str2 = "bb";
            //string str3 = "cc";
            //string[] strArr = ["qq", "ww", "EE"];
            //string res1 = string.Concat(str1, str2, str3);
            //string res2 = string.Concat(strArr);
            //Console.WriteLine(res1); // aabbcc
            //Console.WriteLine(res2); // qqwwEE
            /***************************************************************/
            //string.Join：将数组或List中的所有元素使用指定的连接符拼接成一个字符串
            //string[] strArr = ["qq", "ww", "EE"];
            //Console.WriteLine(string.Join("-", strArr)); // qq-ww-EE
            /***************************************************************/
            //-PadLeft：给字符串左边填充指定的符号填满指定的长度
            //string str = "aa";
            // 字符串.PadLeft(数字,填充字符) // 数字表示填充后的长度
            //Console.WriteLine(str.PadLeft(2, '*')); // aa
            //Console.WriteLine(str.PadLeft(1, '*')); // aa
            //Console.WriteLine(str.PadLeft(4, '*')); // **aa
            //- PadRight：给字符串右边填充指定的符号填满指定的长度
            //Console.WriteLine(str.padRight(4,'*'));//aa**
            /***************************************************************/
            //Remove：删除字符串中的一段
            // 字符串.Remove(开始下标)// 从开始下标往最后的全删除
            // 字符串.Remove(开始下标,个数)// 从开始下标根据个数删除
            // 返回的是删除后的字符串
            //string str = "asdafghljkl";
            //Console.WriteLine(str.Remove(3));//asd
            //Console.WriteLine(str.Remove(0,3));//afghljkl
            /***************************************************************/
            //string reg = @"^1[1-9]\d{9}$";
            //Console.WriteLine("请输入你的手机号码");
            //string num = Console.ReadLine();
            //bool res = Regex.IsMatch(num, reg);
            //if (res) Console.WriteLine("你输入的手机号是正确的");
            //else Console.WriteLine("你输入的手机号是错误的");
            /************************************************************/
            //string reg = @"^[1-9]\d{4,9}$";
            //Console.WriteLine("输入你的QQ号");
            //string num = Console.ReadLine();
            //if (Regex.IsMatch(num, reg)) Console.WriteLine("你的QQ号输入无误");
            //else Console.WriteLine("你的QQ号输入错误");
            /**************************************************/
            //string reg = @"^[1-9]\d{4,9}@qq\.com$";
            //Console.WriteLine("请输入你的邮箱");
            //string num = Console.ReadLine();
            //if (Regex.IsMatch(num, reg))Console.WriteLine("你的邮箱无误");
            //else Console.WriteLine("邮箱错误");
            /**************************************************/
            //var str = "你的工资是: 10000 我的工资是:3000,小明的工资是: 20000";
            //var reg4 = @"[1-9]\d{3,}";
            //var res = Regex.Matches(str, reg4);
            //foreach (var item in res) Console.WriteLine($"工资是：{item}");
            /**************************************************/
            //提取一句话中所有的中文姓名
            //string str = "hello, I am 刘德华,your name is 黎明?";
            //string reg = @"[\u4e00-\u9fa5]{1,4}";
            //var res = Regex.Matches(str, reg);
            //foreach (var match in res) Console.WriteLine(match);
            /**************************************************/
            //替换所有多余空格
            //string str = "abc  dd  ee  ff  gg  HH  h j k";
            //string reg = @"\s*";
            //string res = Regex.Replace(str, reg,"");
            //Console.WriteLine(res);
            /**************************************************/
            //身份证号码书写正则, 找到字符串中的身份证号及 出生年, 月, 日
            //string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            //string reg = @"(?:[1-9]\d{5})(\d{4})(\d{2})(\d{2})(d{3}[1-9X])";
            //string reg = @"[1-9]\d{16}[1-9X]";
            //var res = Regex.Matches(str, reg);
            //foreach (var match in res)
            //{
            //    Console.WriteLine($"你的身份证号是：{match} 你出生的年份：{match.ToString().Substring(6,4)}月份：{match.ToString().Substring(10, 2)}日：{match.ToString().Substring(12, 2)}");
            //}
            /**************************************************/
            //密码强度检测：强中弱（字母、数字、特殊符号）
            //Console.WriteLine("请输入密码（字母、数字、特殊符号）");
            //string password = Console.ReadLine();
            //string reg1 = @".{5,8}";
            //string reg2 = @"\d";
            //string reg3 = @"[A-Za-z]";
            //string reg4 = @"\W|_";
            //if (Regex.IsMatch(password, reg1)) {
            //    int count = 0;
            //    if (Regex.IsMatch(password, reg2))count++;
            //    if(Regex.IsMatch(password, reg3))count++;
            //    if (Regex.IsMatch(password, reg4)) count++;
            //    if(count == 1) Console.WriteLine("弱");
            //    else if(count == 2) Console.WriteLine("中");
            //    else if(count == 3) Console.WriteLine("强");
            //}else Console.WriteLine("密码长度有误");
        }
    }
}
