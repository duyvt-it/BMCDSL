using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BMCSDL__Lab04_CaNhan__d_ {
    public class AccountDTO {
        public AccountDTO() { }
        public AccountDTO(string _manv, string _hoten, string _email, string _luong, string _tendn = null, string _matkhau = null) {
            this.MANV = _manv;
            this.HOTEN = _hoten;
            this.EMAIL = _email;
            this.LUONG = _luong;
            this.TENDN = _tendn;
            this.MATKHAU = _matkhau;
        }

        private string manv = "";
        private string hoten = "";
        private string email = "";
        private string luong = "";
        private string tendn = "";
        private string matkhau = "";

        public string MANV { get => manv; set => manv = value; }
        public string HOTEN { get => hoten; set => hoten = value; }
        public string EMAIL { get => email; set => email = value; }
        public string LUONG { get => luong; set => luong = value; }
        public string TENDN { get => tendn; set => tendn = value; }
        public string MATKHAU { get => matkhau; set => matkhau = value; }
    }
}
