using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace day14
{
    internal class CarManger
    {
        string path { get; } = "./car.json";
        JsonSerializerOptions jsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        public  string Add(string num,string mark,string price)
        {
            List<car> list = new();
            string json = "";
            long id = 1;
            if (File.Exists(path))
            {
                json = File.ReadAllText(path);
                list = JsonSerializer.Deserialize<List<car>>(json);
                if (list.Exists(item => item.num == num)) return "这个车辆已经存在";
                id = list[list.Count - 1].id + 1;
            }
            car c = new(id,num,mark,true,double.Parse(price));
            list.Add(c);
            json = JsonSerializer.Serialize(list,jsonOpt);
            File.WriteAllText(path, json);
            return "添加成功";
        }
        //查询全部
        public string Search()
        {
            List<car> list = new();
            string json = "";
            if (!File.Exists(path)) return "还没有数据请添加";
            json = File.ReadAllText(path);
            list = JsonSerializer.Deserialize<List<car>>(json);
            foreach (var it in list)
            {     
                Console.WriteLine($"{it.id}--{it.num}--{it.mark}--{it.isBorrow}--{it.price}");
            }
            return "已经为您查询";
        }
        public string Search(long id)
        {
            List<car> list = new();
            string json = "";
            if (!File.Exists(path)) return "还没有数据请添加";
            json = File.ReadAllText(path);
            list = JsonSerializer.Deserialize<List<car>>(json);
            List<car> newlist = new();
            newlist = list.FindAll(item =>item.id == id);
            if (newlist.Count == 0) return "没有这个id";
            foreach (var it in newlist)
            {
                Console.WriteLine($"{it.id}--{it.num}--{it.mark}--{it.isBorrow}--{it.price}");
            }
            return "已经为您查询";
        }
        public string isFree()
        {
            List<car> list = new();
            string json = "";
            if (!File.Exists(path)) return "还没有数据请添加";
            json = File.ReadAllText(path);
            list = JsonSerializer.Deserialize<List<car>>(json);
            List<car> newlist = new();
            newlist = list.FindAll(item => item.isBorrow);
            if (newlist.Count == 0) return "没有空闲车辆";
            foreach (var it in newlist)
            {
                Console.WriteLine($"{it.id}--{it.num}--{it.mark}--{it.isBorrow}--{it.price}");
            }
            return "已经为您查询";
        }
        public (string,bool) Free(int id)
        {
            List<car> list = new();
            string json = "";
            if (!File.Exists(this.path)) return ("车辆还未录入", false);
            json = File.ReadAllText(path);
            list = JsonSerializer.Deserialize<List<car>>(json);
            if (!list.Exists(item => item.id == id)) return ("没有该Id车辆", false);
            car c = list.Find(item => item.id == id);
            if (c.isBorrow = false) return ("该车辆已经被租借", false);
            c.isBorrow = false;
            json = JsonSerializer.Serialize(list, jsonOpt);
            File.WriteAllText(path, json);
            return ("添加成功", true);
        }
        public double updateAndGetInfo(int id)
        {
            List<car> list = new();
            string json = "";
            json = File.ReadAllText(path);
            list = JsonSerializer.Deserialize<List<car>>(json);
            car c = list.Find(item => item.id == id);
            c.isBorrow = true;
            json = JsonSerializer.Serialize(list, jsonOpt);
            File.WriteAllText(path, json);
            return c.price;
        }
    }
}
