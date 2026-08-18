using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace day10
{
    internal class Book
    {
        public  JsonSerializerOptions DefaultOptions { get; }
        public string path { get;}
        public List<Dictionary<string, dynamic>> bookLists { get; set; }
        public void add(Dictionary<string, dynamic> bookDic){
            if (bookLists.Exists(item => item["name"].ToString() == bookDic["name"]))Console.WriteLine("书籍已经存在");
            else
            {
                bookLists.Add(bookDic);
                Console.WriteLine("书籍已加入");
            }
            File.WriteAllText(path, JsonSerializer.Serialize(bookLists, DefaultOptions));
        }
        public void upDate(string name, string[] strArr1, string[] strArr2)
        {
            bool isTure = false;
            for (int i = 0; i < bookLists.Count; i++)
            {
                if (bookLists[i]["name"].ToString() == name)
                {
                    isTure = true;
                    for (int j = 0; j < strArr1.Length; j++)
                    {
                        bool istrue1 = false;
                        foreach (var item in bookLists[i].Keys) { 
                            if(item == strArr1[j])
                            {
                                istrue1 = true;
                                bookLists[i][strArr1[j]] = strArr2 [j];
                            }
                        }
                        if(!istrue1) Console.WriteLine($"{strArr1[j]}输入错误无法更新该数值");
                    }
                    Console.WriteLine("更新成功");
                }
                if (!isTure)
                {
                    Console.WriteLine("没有这个书籍信息请您去添加");
                }
                File.WriteAllText(path, JsonSerializer.Serialize(bookLists, DefaultOptions));
            }
        }
        public void delete(string str)
        {
            int count = bookLists.RemoveAll(item => item["name"].ToString() == str);    
            if(count == 0) Console.WriteLine("未查到该书籍信息");
            else Console.WriteLine("已删除");
            File.WriteAllText(path, JsonSerializer.Serialize(bookLists, DefaultOptions));
        }
        public void SearchBook(string name)
        {
            bool isTrue = false;
            foreach (var item in bookLists) {
                if (item["name"].ToString() == name)
                {
                    isTrue = true;
                    foreach(var item2 in item)
                    {
                        Console.WriteLine(item2);
                    }
                } 
            }
            if (!isTrue) Console.WriteLine("书籍还未录入未找到");
        }
        public void SearchBook()
        {
            Console.WriteLine("帮您查询");
            foreach (var item in bookLists) foreach(var item2 in item) Console.WriteLine(item2);
             Console.WriteLine("书籍已全部找出");
        }
        public Book(string str)
        {
            path = str;
            DefaultOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                AllowTrailingCommas = true
            };
            if (!File.Exists(path))
            {
                Random r = new Random();
                bookLists = new List<Dictionary<string, dynamic>>() {

                new Dictionary<string, dynamic>()
                        {
                        ["name"] = "三国演义",
                        ["author"] = "罗贯中",
                        ["isBorrow"] = true, // false表示还在书库中，true表示外借
                        ["id"] = r.NextDouble(),
                        ["mark"] = "言情、武侠",
                        ["price"] = 56.09 // 价格
                        }
                };
                string str1 = JsonSerializer.Serialize(bookLists, DefaultOptions);
                File.WriteAllText(path, str1);
            }
            else
            {
                string str1 = File.ReadAllText(path);
                bookLists =  JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(str1);
            }
        }
    }
}
