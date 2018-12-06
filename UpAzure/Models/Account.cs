using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UpAzure.Models
{
    public class Account
    {

        [Key]
        public long _id { get; set; }
        public string _name { get; set; }
        public string _email { get; set; }
        public string _user { get; set; }
        public string _pass { get; set; }
        public string _sail { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime CreateAt { get; set; }
        public CheckStatus Status { get; set; }
        public Account() 
        {
            this.CreateAt = DateTime.Now;
            this.UpdateAt = DateTime.Now;
            this.Status = CheckStatus.Active;
        }
        public void GenerateSail()// Tạo Muối 
        {
            this._sail = Guid.NewGuid().ToString();
        }
        public void EncryptPass() // phương thức mã hóa
        {
            this._pass += this._sail; // pass mới kèm muối
            var aglorithe = MD5.Create(); // bộ mã hóa MD5
            var HashPass = aglorithe.ComputeHash(Encoding.UTF8.GetBytes(this._pass));
            this._pass = Convert.ToBase64String(HashPass);
        }
    }
        public enum CheckStatus
        {
            Active = 1,
            DeActive =0
        }
    
}
