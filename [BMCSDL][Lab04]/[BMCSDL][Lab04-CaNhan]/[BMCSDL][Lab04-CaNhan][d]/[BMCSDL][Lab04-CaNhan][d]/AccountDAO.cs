using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _BMCSDL__Lab04_CaNhan__d_ {
    public class AccountDAO {
        private static AccountDAO instance;
        public static AccountDAO Instance { 
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public static QLSVEntities db = new QLSVEntities();

        //public static string username;
        //public static string md5Pwd;
        //public static string sha1Pwd;
        static List<AccountDTO> listInsertNhanVien = new List<AccountDTO>();
        static List<string> listDeleteNhanVien = new List<string>();
        static List<AccountDTO> listEditNhanVien = new List<AccountDTO>();

        //public AccountDAO getLoginAccountByUsername(string _username) {
        //    string account;
        //    account = db.NHANVIEN.Find(_username).TENDN;
        //    return null;
        //}

        public List<AccountDTO> getListAccount() {
            List<AccountDTO> listAccount = new List<AccountDTO>();
            foreach (var item in db.SP_SEL_ENCRYPT_NHANVIEN()) {
                AccountDTO acc = new AccountDTO(
                    item.MANV,
                    item.HOTEN,
                    item.EMAIL,
                    item.LUONG);

                listAccount.Add(acc);
            }
            return listAccount;
        }

        public bool getChangeStatus() {
            if (
                (listInsertNhanVien.Count() != listDeleteNhanVien.Count()) ||
                (listDeleteNhanVien.Count() != listEditNhanVien.Count()) ||
                (listEditNhanVien.Count() != listInsertNhanVien.Count()) ||
                (listInsertNhanVien.Count() != 0)
                ) {
                return true;
            }
            return false;
        }

        public void insertNhanVien(string _manv, string _hoten, string _email, string _luong, string _tendn, string _matkhau) {
            AccountDTO account = new AccountDTO(_manv, _hoten, _email, _luong, _tendn, _matkhau);

            listInsertNhanVien.Add(account);
        }

        public void deleteNhanVien(string _manv) {
            listDeleteNhanVien.Add(_manv);
        }

        public void editNhanVien(string _manv, string _hoten, string _email, string _luong) {
            AccountDTO account = new AccountDTO(_manv, _hoten, _email, _luong);

            listEditNhanVien.Add(account);
        }

        public void saveChangeNhanVien() {
            if (listInsertNhanVien.Count != 0) {
                foreach (AccountDTO item in listInsertNhanVien) {
                    db.SP_INS_ENCRYPT_NHANVIEN(
                        item.MANV,
                        item.HOTEN,
                        item.EMAIL,
                        item.LUONG,
                        item.TENDN,
                        item.MATKHAU
                        );
                }
                listInsertNhanVien.Clear();
            }

            if (listEditNhanVien.Count != 0) {
                foreach (AccountDTO item in listEditNhanVien) {
                    db.SP_UPD_ENCRYPT_NHANVIEN(
                        item.MANV,
                        item.HOTEN,
                        item.EMAIL,
                        item.LUONG);
                }
                listEditNhanVien.Clear();
            }

            if (listDeleteNhanVien.Count != 0) {
                foreach (string item in listDeleteNhanVien) {
                    NHANVIEN deleteNhanVien = new NHANVIEN();
                    deleteNhanVien.MANV = item;

                    db.NHANVIEN.Attach(deleteNhanVien);
                    db.NHANVIEN.Remove(deleteNhanVien);
                }
                listDeleteNhanVien.Clear();
            }

            db.SaveChanges();
        }
    }
}