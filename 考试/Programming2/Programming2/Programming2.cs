using System.Text.RegularExpressions;

namespace Programming2
{
    internal class Programming2
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[5] { "    13213213121       ", "17321231123", "16123213123", "HelloWorld", "你好世界" };
            for (int i = 0; i < strArr.Length; i++)
            {
                strArr[i] = strArr[i].Trim();
                strArr[i] = strArr[i].ToLower();
            }
            string reg = @"^1[34578][0-9]{9}$";
            for (int i = 0; i < strArr.Length; i++) {
                if (Regex.IsMatch(strArr[i], reg))Console.WriteLine($"合法手机号：{strArr[i]}");
                else if (long.TryParse(strArr[i], out long l)) Console.WriteLine($"不合法手机号：{strArr[i]}");
                else Console.WriteLine($"普通文本：{strArr[i]}");
            }
        }
    }
}
