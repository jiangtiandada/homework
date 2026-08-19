using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace day14
{
    internal class car
    {
        public string path { get; }
        public JsonSerializerOptions jsonOpt { get; }
        public long id { get; }
        public string num { get; }

        //增加车辆
        public string Add(Dictionary<string, dynamic> AddDic){
            
            List<Dictionary<string,dynamic>> list = new();
            string json = File.ReadAllText(path);
            if (File.Exists(path)) { 
                list = JsonSerializer.Deserialize<List<Dictionary<string,dynamic>>>(json);
                int index = list.FindIndex(item => item["id"].GetInt64() == AddDic["id"]);
                if (index != -1) return "这个车辆已经存在";
            }
            list.Add(AddDic);
            json = JsonSerializer.Serialize(list);
            File.WriteAllText(path, json);
            return "添加成功";
        }
        //查询全部
        public string Search()
        {
            List<Dictionary<string, dynamic>> list = new();
            string json = File.ReadAllText(path);
            if (!File.Exists(path)) return "还没有数据请添加";
            list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            foreach(var it in list)
            {
                Console.WriteLine($"{it["id"]}--{it["num"]}--{it["mark"]}--{it["isBorrow"]}--{it["price"]}");
            }
            return "已经为您查询";
        }
        public string Search(long id)
        {
            List<Dictionary<string, dynamic>> list = new();
            string json = File.ReadAllText(path);
            if (!File.Exists(path)) return "还没有数据请添加";
            list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            List<Dictionary<string, dynamic>> newlist = new();
            newlist = list.FindAll(item => item["id"].GetInt64 == id);
            foreach (var it in newlist)
            {
                Console.WriteLine($"{it["id"]}--{it["num"]}--{it["mark"]}--{it["isBorrow"]}--{it["price"]}");
            }
            return "已经为您查询";
        }
        public string isFree(bool isBorrow)
        {
            List<Dictionary<string, dynamic>> list = new();
            string json = File.ReadAllText(path);
            if (!File.Exists(path)) return "还没有数据请添加";
            list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            List<Dictionary<string, dynamic>> newlist = new();
            newlist = list.FindAll(item => item["isBorrow"].GetBoolen == isBorrow);
            foreach (var it in newlist)
            {
                Console.WriteLine($"{it["id"]}--{it["num"]}--{it["mark"]}--{it["isBorrow"]}--{it["price"]}");
            }
            return "已经为您查询";
        }


        public car(string path,JsonSerializerOptions jsonOpt) {
            this.path = path;
            this.jsonOpt = jsonOpt;
        }

    }
}
