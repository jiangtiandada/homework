using System.Text.Json;
delegate int myStlye(int a, int b);
namespace day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var dayin = () =>
            //{
            //    Console.WriteLine("/**************************************************/");
            //};
            //dayin();
            //void dayin1()
            //{
            //    Console.WriteLine("/**************************************************/");
            //}
            //dayin1();
            //var d1 = DateTime.Now;
            //var d2 = DateTime.Parse("2026-10-1");
            //var diff = d2 - d1;
            //Console.WriteLine(diff.Days);
            //Console.WriteLine(diff.TotalDays);
            //var str = "\u4e00\u4e01\u4e02";
            //var r = $"\"{str}\"";
            //Console.WriteLine(JsonSerializer.Deserialize<string>(r));
            /**********************************************************************/
            //装修房间：参数1，圆的半径，计算圆的面积，每平方米收费200元，返回装修总价。计算这个半径的圆装修一半需要多少钱？
            //double price(double r)
            //{
            //    double area = Math.PI * r * r;
            //    return area * 200;
            //}
            //Console.WriteLine("请输入圆的半径");
            //double r = double.Parse(Console.ReadLine());
            //Console.WriteLine($"装修一半需要{(price(r) / 2):F2}");
            /**********************************************************************/
            //计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回
            //int charCount(string str,char s)
            //{
            //    int count = 0;
            //    foreach (char c in str) {
            //        if (c == s) count++;
            //    }
            //    return count;
            //}
            //string str = Console.ReadLine();
            //char s = char.Parse(Console.ReadLine());
            //Console.WriteLine($"{s}在{str}中出现了{charCount(str,s)}次");
            /**********************************************************************/
            //计算一个整型数组中，最小值第一次出现的下标。
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0,1, 2, 3, 4, 5, 6 };
            //int returnmin(int[] arr)
            //{
            //    int min = 10000000;
            //    int minXia = 0;
            //    for(int i = 0; i < arr.Length; i++)
            //    {
            //        if (min > arr[i])
            //        {
            //            min = arr[i];
            //            minXia = i;
            //        }
            //    }
            //    return minXia;
            //}
            //Console.WriteLine($"下标是：{returnmin(arr)}");
            /**********************************************************************/
            //判断一个字符串是否为回文，返回布尔值类型。
            //bool isHuiwen(string str)
            //{
            //    int l = 0, r = str.Length - 1;
            //    while (l < r)
            //    {
            //        if (str[l] == str[r])
            //        {
            //            l++;
            //            r--;
            //        }
            //        else return false;
            //    }
            //    return true;
            //}
            //Console.WriteLine("请输入你要判断的字符串：");
            //string str = Console.ReadLine();
            //if(isHuiwen(str)) Console.WriteLine("你的字符串是回文串");
            //else Console.WriteLine("你的字符串不是回文串");
            //用函数封装一个猜数字的小游戏，函数中生成一个随机整数（0-100）作为目标数字，不停的让用户输入数字，距离目标数字偏大，就提示用户偏大，距离目标数字偏小就输出偏小，用户有5次输入的机会，5次没有猜对，输出GAME OVER，猜对了就输出WIN！
            void caishuzi()
            {
                Random n1 = new Random();
                int n2 = n1.Next(101);
                int count = 0;
                while (count < 5)
                {
                    Console.WriteLine("请输入：");
                    int n3 = int.Parse(Console.ReadLine());
                    if (n3 > n2) Console.WriteLine("偏大");
                    else if (n3 < n2) Console.WriteLine("偏小");
                    else
                    {
                        Console.WriteLine("WIN");
                        break;
                    }
                    //Console.WriteLine(n2);
                    count++;
                }
                //Console.WriteLine(count);
                if (count == 5) Console.WriteLine("GAME OVER");
            }
            caishuzi();
            /**********************************************************************/
            //var n = 10;
            //void foundn(int m)
            //{
            //    m = 20;
            //    n = 30;
            //}
            //foundn(n);
            //Console.WriteLine(n);
            /**********************************************************************/
            //myStlye add = (int a, int b) =>
            //{
            //    return a+b;
            //};
            //Console.WriteLine(add(10,20));
            /**********************************************************************/
            //bool issu(int n)
            //{
            //    for(int i = 2; i < n; i++)
            //    {
            //        if (n % i == 0) return false;
            //    }
            //    return true;
            //}
            //Console.WriteLine(issu(23));
            
        }
    }
}
