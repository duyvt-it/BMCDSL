using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _BMCSDL__Lab04_CaNhan__d_.DTO {
    public class AccountDTO {
        public AccountDTO(string MANV, string HOTEN, string EMAIL, string LUONG, string TENDN, string MATKHAU) {
            this.Manv = MANV;
            this.Hoten = HOTEN;
            this.Email = EMAIL;
            this.Luong = LUONG;
            this.Tendn = TENDN;
            this.Matkhau = MATKHAU;
        }

        public AccountDTO(DataRow row) {
            this.Manv = row["MANV"].ToString();
            this.Hoten = row["HOTEN"].ToString();
            this.Email = row["EMAIL"].ToString();
            this.Luong = row["LUONG"].ToString();
            this.Tendn = row["TENDN"].ToString();
            this.Matkhau = row["MATKHAU"].ToString();
        }

        private string manv;
        private string hoten;
        private string email;
        private string luong;
        private string tendn;
        private string matkhau;

        public string Manv { get => manv; set => manv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Email { get => email; set => email = value; }
        public string Luong { get => luong; set => luong = value; }
        public string Tendn { get => tendn; set => tendn = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
