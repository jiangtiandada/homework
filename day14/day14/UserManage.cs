using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace day14
{
    internal class UserManage
    {
        private string Path { get; } = "./user.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        // 新增客户方法
        public string Add(string Name,string IdCard,string Gender,string PhoneNo,string Motto)
        {

            List<User> list = new();
            string json = "";
            int id = 1;
            if (File.Exists(Path))
            {
                json = File.ReadAllText(Path);
                list = JsonSerializer.Deserialize<List<User>>(json);
                if (list.Exists(item => item.IdCard == IdCard)) return "这个用户已经存在";
                id = list[list.Count - 1].Id + 1;
            }
            var DTO =  DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            User c = new(id, Name, IdCard, DTO.ToString() ,Gender, PhoneNo, Motto);
            list.Add(c);
            json = JsonSerializer.Serialize(list, JsonOpt);
            File.WriteAllText(Path, json);
            return "添加成功";
        }
        // 查看所有客户方法
        public string Search()
        {
            List<User> list = new();
            string json = "";
            if (!File.Exists(Path)) return "还没有数据请添加";
            json = File.ReadAllText(Path);
            list = JsonSerializer.Deserialize<List<User>>(json);
            foreach (var it in list)
            {
                Console.WriteLine($"{it.Id}--{it.Name}--{it.RegTime}--{it.Gender}--{it.Motto}");
            }
            return "已经为您查询";
        }
        // 查看某个客户方法
        public string Search(int id)
        {
            List<User> list = new();
            string json = "";
            if (!File.Exists(Path)) return "还没有数据请添加";
            json = File.ReadAllText(Path);
            list = JsonSerializer.Deserialize<List<User>>(json);
            var newList = new List<User>();
            newList = list.FindAll(item => item.Id == id);
            if (newList.Count == 0) return "没有这个Id";
            foreach (var it in newList)
            {
                Console.WriteLine($"{it.Id}--{it.Name}--{it.RegTime}--{it.Gender}--{it.Motto}");
            }
            return "已经为您查询";
        }
        public bool Free(int id)
        {
            List<User> list = new();
            string json = "";
            if (!File.Exists(this.Path)) return  false;
            json = File.ReadAllText(Path);
            list = JsonSerializer.Deserialize<List<User>>(json);
            if (!list.Exists(item => item.Id == id)) return  false;
            return true;
        }
    }
}
