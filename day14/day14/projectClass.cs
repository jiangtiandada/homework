using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace day14
{
    internal class car
    {
        public long id { get; }
        public string num { get; }
        public string mark { get; set; }
        public bool isBorrow { get; set; } = true;
        public double price { get; set; }


        public car(long id, string num, string mark, bool isBorrow, double price)
        {
            this.id = id;
            this.num = num;
            this.mark = mark;
            this.isBorrow = isBorrow;
            this.price = price;
        }

    }
    internal class User
    {
        public int Id { get; }
        public string Name { get; set; }
        public string IdCard { get; }
        public string RegTime { get; }
        public string Gender { get; set; }
        public string PhoneNo { get; set; }
        public string Motto { get; set; }
        public User(int Id, string Name, string IdCard, string RegTime, string Gender, string PhoneNo, string Motto)
        {
            this.Id = Id;
            this.Name = Name;
            this.IdCard = IdCard;
            this.RegTime = RegTime;
            this.Gender = Gender;
            this.PhoneNo = PhoneNo;
            this.Motto = Motto;
        }
    }
    internal class RentReturn
    {
        public int Id { get;set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public string RentTime { get; set; }
        public string ReturnTime { get; set; }
        public double PayPrice { get; set; }
        public RentReturn(int Id, int CarId, int UserId, string RentTime, string ReturnTime, double PayPrice)
        {
            this.Id = Id;
            this.CarId = CarId;
            this.UserId = UserId;
            this.RentTime = RentTime;
            this.ReturnTime = ReturnTime;
            this.PayPrice = PayPrice;
        }
        public RentReturn() { }
    }
}
