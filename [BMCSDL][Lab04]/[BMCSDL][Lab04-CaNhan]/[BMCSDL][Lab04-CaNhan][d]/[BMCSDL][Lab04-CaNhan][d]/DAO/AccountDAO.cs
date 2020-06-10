using _BMCSDL__Lab04_CaNhan__d_.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _BMCSDL__Lab04_CaNhan__d_.DAO {
    public class AccountDAO {
        private static AccountDAO instance;

        public static AccountDAO Instance {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        static string getMd5Hash(string input) {
            using (MD5 md5Hash = MD5.Create()) {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++) {
                    stringBuilder.Append(data[i].ToString("X2"));
                }

                return stringBuilder.ToString();
            }
        }

        static string getSha1Hash(string input) {
            using (SHA1Managed sha1Hash = new SHA1Managed()) {
                byte[] hash = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder stringBuilder = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash) {
                    stringBuilder.Append(b.ToString("X2"));
                }

                return stringBuilder.ToString();
            }
        }

        public int Login(string username, string password) {
            string md5Pwd = getMd5Hash(password);
            string sha1Pwd = getSha1Hash(password);

            string query = "SP_SEL_USER @username, @md5Pwd, @sha1Pwd";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, md5Pwd, sha1Pwd });
            return result;
        }

        public AccountDTO GetAccountByUsername(string username) {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.NHANVIEN WHERE TENDN = '" + username + "'");
            
            foreach (DataRow item in data.Rows) {
                return new AccountDTO(item);
            }

            return null;
        }
    }
}
