using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace day14
{
    internal class RentReturnclass
    {
        private string Path { get; } = "./rentreturn.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        public string rent()
        {
            List<RentReturn> list = new();
            string json = "";
            CarManger CM = new();
            UserManage UM = new();
            int id = 1;
            Console.WriteLine("请输入车辆Id");
            int CarID = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入用户Id");
            int UserID = int.Parse(Console.ReadLine());
            if (!UM.Free(UserID)) return "该用户不存在";
            var (resStr, isFree) = CM.Free(CarID);
            if (!isFree) return resStr;
            if (File.Exists(Path))
            {
                json = File.ReadAllText(Path);
                list = JsonSerializer.Deserialize<List<RentReturn>>(json);
                id = list[list.Count - 1].Id + 1;
            }
            RentReturn rr = new(id, CarID, UserID, DateTime.Now.ToString(),"", 0);
            list.Add(rr);
            json = JsonSerializer.Serialize(list,JsonOpt);
            File.WriteAllText(Path, json);
            return "添加成功";
        }
        public string returnCar(int id)
        {
            List<RentReturn> list = new();
            string json = "";
            CarManger CM = new();
            UserManage UM = new();
            //判断文件是否存在 
            //存在 ---》反序列化-》list-》查carID -》获得price修改状态 UserID -->修改时间和价格-》写入
            if (!File.Exists(Path)) return "还没有租车记录";
            json = File.ReadAllText(Path);
            list = JsonSerializer.Deserialize < List<RentReturn>>(json);
            if (!list.Exists(item => item.Id == id)) return "没有这个租车记录";
            if (list.Find(item => item.Id == id).ReturnTime != "") return "该车已经归还";
            RentReturn rr = list.Find(item => item.Id == id);
            rr.ReturnTime = DateTime.Now.ToString();
            rr.PayPrice = (double)(DateTime.Now-DateTime.Parse(rr.RentTime)).TotalHours * CM.updateAndGetInfo(rr.CarId);
            json = JsonSerializer.Serialize (list,JsonOpt);
            File.WriteAllText(Path, json);
            return "还车成功";
        }
        public string search()
        {
            List<RentReturn> list = new();
            string json = "";
            if (!File.Exists(Path)) return "还没有数据请添加";
            json = File.ReadAllText(this.Path);
            list = JsonSerializer.Deserialize<List<RentReturn>>(json);
            foreach (var it in list)
            {
                Console.WriteLine($"{it.Id}--{it.CarId}--{it.UserId}--{it.RentTime}--{it.ReturnTime}--{it.PayPrice}");
            }
            return "已经为您查询";
        }
    }
}
