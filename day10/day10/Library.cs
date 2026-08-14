using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace day10
{
    internal class Library
    {
        public string path;
        public List<Dictionary<string, dynamic>> bookLists = new ();
        public void add(Dictionary<string, dynamic> bookList){
            Random r = new Random();
            bookList["id"] = r.NextDouble();
            bookLists.Add(bookList);
            File.AppendAllText(path, JsonSerializer.Serialize(bookList));
        }
        public void upDate(Dictionary<string, dynamic> newbookList){
            for (int i = 0; i < bookLists.Count; i++) {
                if (bookLists[i]["id"] == newbookList["id"] || bookLists[i]["name"] == newbookList["name"])
                {
                    foreach (dynamic item in bookLists[i])
                    {
                        item[item.key] = newbookList[item.key];
                    }
                }
            }
            File.WriteAllText(path, JsonSerializer.Serialize(bookLists));
        }
        public void delete(string str)
        {
            foreach (var item in bookLists) {
                if (item["id"] == str)bookLists.Remove(item);
                else if(item["name"] == str)bookLists.Remove(item);
            }
            File.WriteAllText(path,JsonSerializer.Serialize(bookLists));
        }
        public void queryName()
        {
            Console.WriteLine("请输入你想要查询名字");
            string name = Console.ReadLine();
            foreach (var item in bookLists) {
                if (item["name"] == name)
                {
                    foreach(var item2 in item)
                    {
                        Console.WriteLine(item2);
                    }
                }
            }
        }
        public void queryId()
        {
            Console.WriteLine("请输入你想要查询的id");
            double id = double.Parse(Console.ReadLine());
            foreach (var item in bookLists)
            {
                if (item["id"] == id)
                {
                    foreach(var item2 in item) Console.WriteLine(item2);
                }
            }
        }
        public void book(string str)
        {
            path = str;
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
            string str1 = JsonSerializer.Serialize(bookLists);
            if (!File.Exists(str1)) File.WriteAllText(path, str1);

        }
    }
}
